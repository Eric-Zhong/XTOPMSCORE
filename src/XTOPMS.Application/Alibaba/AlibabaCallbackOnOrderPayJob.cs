﻿//
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
using System.Linq;
using Abp.Linq;
using Castle.Core.Logging;
using Abp.BackgroundJobs;
using XTOPMS.Alibaba.Dto;
using XTOPMS.EntityFrameworkCore.Repositories;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Abp.AutoMapper;
using com.alibaba.trade.param;
using XTOPMS.DataSyncServices;
using Abp.Domain.Entities;
using XTOPMS.Henkel.Salesforce;
using Abp.Domain.Uow;
using System.Collections.Generic;

namespace XTOPMS.Alibaba
{
    public class AlibabaCallbackOnOrderPayJob
        : BackgroundJob<MessageDto>
    {
        readonly ICallbackMessageRepository callbackMessageRepository;
        readonly IAlibabaMessageRepository alibabaMessageRepository;
        readonly IAccessTokenRepository accessTokenRepository;
        readonly IDataSyncServiceRepository dataSyncServiceRepository;
        readonly ITradeManager tradeManager;
        readonly IOrderManager orderManager;
        readonly IUnitOfWorkManager unitOfWorkManager;

        public AlibabaCallbackOnOrderPayJob(
            ICallbackMessageRepository _callbackMessageRepository,
            IAlibabaMessageRepository _alibabaMessageRepository,
            IAccessTokenRepository _accessTokenRepository,
            IDataSyncServiceRepository _dataSyncServiceRepository,
            ITradeManager _tradeManager,
            IOrderManager _orderManager,
            IUnitOfWorkManager _unitOfWorkManager)
        {
            callbackMessageRepository = _callbackMessageRepository;
            alibabaMessageRepository = _alibabaMessageRepository;
            accessTokenRepository = _accessTokenRepository;
            dataSyncServiceRepository = _dataSyncServiceRepository;
            tradeManager = _tradeManager;
            orderManager = _orderManager;
            unitOfWorkManager = _unitOfWorkManager;
        }

        /// <summary>
        /// Background job will execute this method for process the event when order pay.
        /// </summary>
        /// <param name="args">Arguments.</param>
        public override void Execute(MessageDto args)
        {
            long msgId = args.Id;
            string memberId = args.UserInfo;
            string serviceCode = "ALIBABA_ORDER_PAY";
            long orderId = long.Parse(args.Data.OrderId);

            var msgEntity = alibabaMessageRepository.Get(msgId);
            msgEntity.Status = (int)CallbackMessageStatus.Inprocess;
            alibabaMessageRepository.Update(msgEntity);

            try
            {
                DataSyncService dataSyncService;

                //using (unitOfWorkManager.Current.SetTenantId(1))
                //{
                //}

                //var query = dataSyncServiceRepository.GetAllIncluding(t => t.AccessTokenInfo);
                //List<DataSyncService> ds = query.ToList();

                //var q = from t in ds
                //where t.ErpId == serivceCode && t.AccessTokenInfo.MemberId == memberId
                //select t;

                // dataSyncService = q.First();

                dataSyncService = dataSyncServiceRepository.GetDataServiceInforByCodeAndMemberId(serviceCode, memberId).Result;

                //query = query.Where(t => t.IsActive == true && t.ErpId == serivceCode && t.AccessTokenInfo.MemberId == memberId);
                //dataSyncService = query.First();

                // Step 1: get the order from alibaba.
                AlibabaOpenplatformTradeModelTradeInfo tradeInfo;

                // Step 2: Save trade info to callback message business data field.
                if (msgEntity.Data == null)
                {
                    tradeInfo = tradeManager.GetTradeInfor(dataSyncService.AccessTokenInfo.App_Key, memberId, orderId);
                    msgEntity.Data = JsonConvert.SerializeObject(tradeInfo);            // Save as JSON
                    alibabaMessageRepository.Update(msgEntity);
                    Console.WriteLine("Got order from alibaba.");
                    Console.WriteLine(msgEntity.Data);
                }
                else
                {
                    // TODO: 这个转换可能不行
                    tradeInfo = JsonConvert.DeserializeObject<AlibabaOpenplatformTradeModelTradeInfo>(msgEntity.Data);
                }

                // Step 3: Check the product filter.
                bool isMatched = false;

                foreach (var prd in tradeInfo.getProductItems())
                {
                    if (prd.getProductCargoNumber() == "")
                    {
                        isMatched = true;
                        break;
                    }
                    isMatched = true;
                    break;
                }

                // Step 4: If matched then send it to salesforce.
                if (isMatched)
                {
                    try
                    {
                        string salesforceUri = dataSyncService.GetData<string>("SalesforceUri");
                        if (string.IsNullOrEmpty(salesforceUri))
                        {
                            throw new ArgumentException("Data sync service config error. 'SalesforceUri' field not found.", "SalesforceUri");
                        }

                        // Step 5: Generate the JSON that will post to salesforce.
                        OrderDto order = new OrderDto(tradeInfo);
                        string orderJson = JsonConvert.SerializeObject(order);
                        Console.WriteLine("Generate salesforce order:");
                        Console.WriteLine(orderJson);

                        string resp = orderManager.Create(salesforceUri, order);    // Call API and cretae order in salesforce.

                        if (string.IsNullOrEmpty(resp))
                        {
                            msgEntity.Status = (int)CallbackMessageStatus.Success;  // Set status as success
                            msgEntity.Comment = orderJson;
                            Console.WriteLine("Salesforce interface return success: (HTTP 200)");
                        }
                        else
                        {
                            // Salesforce interface throw error.
                            msgEntity.Comment = resp;                               // Write response for error detail info.
                            msgEntity.Status = (int)CallbackMessageStatus.InterfaceThrowError;      // Salesforce throw error
                            Console.WriteLine("Salesforce interface return error: " + resp);
                        }
                    }
                    catch (Exception err)
                    {
                        msgEntity.Status = (int)CallbackMessageStatus.Failed;      // Set status as failed.
                        msgEntity.RetryCount++;

                        // Get error message
                        Console.WriteLine(err.ToString());
                        this.Logger.Error(err.Message, err);
                        msgEntity.Comment = err.ToString();
                    }
                }
                else
                {
                    Console.WriteLine("Ignored");
                    msgEntity.Status = (int)CallbackMessageStatus.Ignored;
                }
            }
            catch (Exception ex)
            {
                this.Logger.Error(ex.Message, ex);
                Console.WriteLine(ex.ToString());
                msgEntity.Status = (int)CallbackMessageStatus.Failed;
                msgEntity.Comment = ex.ToString();
            }
            // Update message status as last.
            alibabaMessageRepository.Update(msgEntity);
        }
    }
}
