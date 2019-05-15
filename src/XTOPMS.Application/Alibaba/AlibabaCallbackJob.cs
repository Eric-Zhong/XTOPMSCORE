//
//  AlibabaCallbackJob.cs
//
//  Author:
//       Eric-Zhong Xu <xu.zhong@hotmail.com>
//
//  Copyright (c) 2019 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using Castle.Core.Logging;
using Abp.BackgroundJobs;
using XTOPMS.Alibaba.Dto;
using XTOPMS.EntityFrameworkCore.Repositories;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Abp.AutoMapper;

namespace XTOPMS.Alibaba
{
    public class AlibabaCallbackJob
        : BackgroundJob<CallbackDto>
    {
        ICallbackMessageRepository callbackMessageRepository;
        IAlibabaMessageRepository alibabaMessageRepository;
        IAccessTokenRepository accessTokenRepository;

        public AlibabaCallbackJob(
            ICallbackMessageRepository _callbackMessageRepository,
            IAlibabaMessageRepository _alibabaMessageRepository,
            IAccessTokenRepository _accessTokenRepository)
        {
            callbackMessageRepository = _callbackMessageRepository;
            alibabaMessageRepository = _alibabaMessageRepository;
            accessTokenRepository = _accessTokenRepository;
        }

        public override void Execute(CallbackDto args)
        {
            this.Logger.Info("Alibaba callbak message received. Message: " + args.Message);
            // Init callback message entity
            CallbackMessage cbm = new CallbackMessage()                         // cbm: Callback Message
            {
                Body = args.Message,
                Status = CallbackMessageStatus.New
            };

            // Save callback message
            try {
                var cbmEntity = callbackMessageRepository.Insert(cbm);          
                Console.WriteLine("Callback saved. (ID: " + cbmEntity.Id + ")");                
                // Generate object from JSON
                try
                {
                    var msg = JsonConvert.DeserializeObject<MessageDto>(args.Message);

                    // Caculate tenantid
                    var accessToken = accessTokenRepository.FirstOrDefault(t => t.MemberId == msg.UserInfo);

                    if(accessToken == null)
                    {
                        // It's mean not found the alibaba account info by memberId. Maybe it's only a test member.
                        this.Logger.Error("The member (Id='" + msg.UserInfo + "') not found.");
                        cbmEntity.Status = CallbackMessageStatus.NotFoundMember;   // Set status as not found member.
                        this.callbackMessageRepository.Update(cbmEntity);   // Save the satatus.
                    }
                    else
                    {

                        // Found member, and continue to process the message.
                        var tenantId = accessToken.TenantId;                // Need to know this member's tenantId.

                        try
                        {
                            var msgEntity = msg.MapTo<Message>();           // Dto map to Entity.
                            msgEntity.TenantId = tenantId;                  // Set entitie's tenantid.
                            // msgEntity.ExtensionData = msgEntity.Data;       // Copy data to extensionData field.
                            msgEntity.Status = (int)CallbackMessageStatus.New;   // Set status to new (0).
                            // Save alibaba message
                            var msgId = alibabaMessageRepository.InsertAndGetId(msgEntity);         // Save
                            this.Logger.Info("Alibaba message (ID = '" + msgId + "') saved.");      // Log
                            Console.WriteLine("Message saved. (ID: " + msgId + ")");
                        }
                        catch (Exception err2)
                        {
                            this.Logger.Error("Get alibaba message entity throw error" + err2.Message, err2);
                            cbmEntity.Status = CallbackMessageStatus.ParseError;   // Set status as not found member.
                            this.callbackMessageRepository.Update(cbmEntity);   // Save the satatus.
                            // throw err2;
                        }
                    }
                }
                catch (Exception err0)
                {
                    this.Logger.Error("Process alibaba message throw error. " + err0.Message, err0);
                    cbmEntity.Status = CallbackMessageStatus.Failed;
                    throw err0;
                }
            }
            catch (Exception exc)
            {
                this.Logger.Error("Process alibaba callback message throw error. " + args.Message, exc);
                Console.WriteLine(exc.ToString());
                throw exc;
            }
        }
    }
}
