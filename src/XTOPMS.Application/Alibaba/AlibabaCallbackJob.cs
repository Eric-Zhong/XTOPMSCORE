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

        public AlibabaCallbackJob(
            ICallbackMessageRepository _callbackMessageRepository,
            IAlibabaMessageRepository _alibabaMessageRepository)
        {
            callbackMessageRepository = _callbackMessageRepository;
            alibabaMessageRepository = _alibabaMessageRepository;
        }

        public override void Execute(CallbackDto args)
        {
            // Init callback message entity
            CallbackMessage cbm = new CallbackMessage()
            {
                Body = args.Message,
                Status = CallbackMessageStatus.New
            };

            // Save callback message
            var cbmId = callbackMessageRepository.InsertAndGetId(cbm);
            Console.WriteLine("Callback saved. (ID: " + cbmId + ")");

            // Generate object from JSON
            var msg = JsonConvert.DeserializeObject<MessageDto>(args.Message);

            var msgEntity = msg.MapTo<Message>();

            // Save alibaba message
            var msgId = alibabaMessageRepository.InsertAndGetId(msgEntity);

            Console.WriteLine("Message saved. (ID: " + msgId + ")");
        }
    }
}
