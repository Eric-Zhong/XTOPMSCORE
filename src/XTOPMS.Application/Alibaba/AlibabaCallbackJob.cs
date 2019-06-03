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
using XTOPMS.Email;
using Abp.Domain.Uow;

namespace XTOPMS.Alibaba
{
    public class AlibabaCallbackJob
        : BackgroundJob<CallbackDto>
    {
        IUnitOfWorkManager unitOfWorkManager;
        IAccessTokenManager accessTokenManager;
        ICallbackMessageRepository callbackMessageRepository;
        IAlibabaMessageRepository alibabaMessageRepository;
        IAccessTokenRepository accessTokenRepository;
        IEmailManager emailManager;

        public AlibabaCallbackJob(
            IUnitOfWorkManager _unitOfWorkManager,
            IAccessTokenManager _accessTokenManager,
            ICallbackMessageRepository _callbackMessageRepository,
            IAlibabaMessageRepository _alibabaMessageRepository,
            IAccessTokenRepository _accessTokenRepository,
            IEmailManager _emailManager)
            : base()
        {
            unitOfWorkManager = _unitOfWorkManager;
            accessTokenManager = _accessTokenManager;
            callbackMessageRepository = _callbackMessageRepository;
            alibabaMessageRepository = _alibabaMessageRepository;
            accessTokenRepository = _accessTokenRepository;
            emailManager = _emailManager;

            this.UnitOfWorkManager = _unitOfWorkManager;
        }


        public override void Execute(CallbackDto args)
        {
            Logger.Info("Alibaba callbak message received. Message: " + args.Message);

            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                // Background job for all tenant service.
                UnitOfWorkManager.Current.DisableFilter(
                    AbpDataFilters.MayHaveTenant,
                    AbpDataFilters.MustHaveTenant);

                CallbackMessage cbm = new CallbackMessage()                         // cbm: Callback Message
                {
                    Body = args.Message,
                    Status = CallbackMessageStatus.New
                };

                // Save callback message
                try
                {
                    var cbmEntity = callbackMessageRepository.Insert(cbm);
                    Console.WriteLine("Callback saved. (ID: " + cbmEntity.Id + ")");
                    // Generate object from JSON
                    try
                    {
                        var msg = JsonConvert.DeserializeObject<MessageDto>(args.Message);

                        // Caculate tenantid
                        AccessToken accessToken;

                        // accessToken = accessTokenManager.GetByMemberId(msg.UserInfo);
                        accessToken = accessTokenRepository.FirstOrDefault(t => t.MemberId == msg.UserInfo);


                        if (accessToken == null)
                        {
                            // It's mean not found the alibaba account info by memberId. Maybe it's only a test member.
                            this.Logger.Error("The member (Id='" + msg.UserInfo + "') not found.");
                            cbmEntity.Status = CallbackMessageStatus.NotFoundMember;   // Set status as not found member.
                            this.callbackMessageRepository.Update(cbmEntity);       // Save the satatus.
                        }
                        else
                        {
                            // Found member, and continue to process the message.
                            var tenantId = accessToken.TenantId;                    // Need to know this member's tenantId.

                            try
                            {
                                var msgEntity = msg.MapTo<Message>();               // Dto map to Entity.

                                msgEntity.TenantId = tenantId;                      // Set entitie's tenantid.
                                                                                    // msgEntity.ExtensionData = msgEntity.Data;        // Copy data to extensionData field.
                                msgEntity.Status = (int)CallbackMessageStatus.New;  // Set status to new (0).
                                                                                    // Save alibaba message

                                var msgId = alibabaMessageRepository.InsertAndGetId(msgEntity);         // Save
                                this.Logger.Info("Alibaba message (ID = '" + msgId + "') saved.");      // Log
                                Console.WriteLine("Message saved. (ID: " + msgId + ")");
                                // After save this message, create an other schedule job for process there message.
                            }
                            catch (Exception err2)
                            {
                                this.Logger.Error("Get alibaba message entity throw error" + err2.Message, err2);
                                cbmEntity.Status = CallbackMessageStatus.ParseError;   // Set status as not found member.
                                this.callbackMessageRepository.Update(cbmEntity);   // Save the satatus.

                                // 这里已经标记CallbackMessage状态为 ParseError 了，后面需要运维人员排查具体原因。
                                // 所以这里不需要再抛出异常。抛出、重试也没用。
                                // throw err2;

                                // here is error, need notice admin to followe.
                                // Error Code : 100
                                emailManager.SendMail("[XTOPMS] 处理Alibaba返回的消息时出现异常 (AlibabaCallbackJob 100)", err2.ToString(), false);
                            }
                        }
                    }
                    catch (Exception err0)
                    {
                        this.Logger.Error("Process alibaba message throw error. " + err0.Message, err0);
                        cbmEntity.Status = CallbackMessageStatus.Failed;
                        // Error Code : 110
                        emailManager.SendMail("[XTOPMS] 处理Alibaba返回的消息时出现异常 (AlibabaCallbackJob 110)", err0.ToString(), false);
                        throw err0;
                    }
                }
                catch (Exception exc)
                {
                    this.Logger.Error("Process alibaba callback message throw error. " + args.Message, exc);
                    Console.WriteLine(exc.ToString());
                    // Error Code : 120
                    emailManager.SendMail("[XTOPMS] 处理Alibaba返回的消息时出现异常 (AlibabaCallbackJob 120)", exc.ToString(), false);
                    throw exc;
                }

                unitOfWork.Complete();
            }
        }
    }
}
