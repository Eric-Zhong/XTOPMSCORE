//
//  TradeManager.cs
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
using System.Collections.Generic;
using Abp.AutoMapper;
using Abp.BackgroundJobs;
using Abp.Domain.Services;
using com.alibaba.openapi.client;
using com.alibaba.openapi.client.policy;
using com.alibaba.trade.param;
using XTOPMS.Alibaba.Dto;
using XTOPMS.DataSyncServices;
using XTOPMS.EntityFrameworkCore.Repositories;

namespace XTOPMS.Alibaba
{

    public interface ITradeManager
        : IDomainService
    {
        IList<AlibabaOpenplatformTradeModelTradeInfo> GetModificationTradeInfos(IAccessToken token, DateTime modifyStart, DateTime modifyEnd);
        IList<AlibabaOpenplatformTradeModelTradeInfo> GetYesterdayModificationTradeInfos(IAccessToken token);
        bool SaveTradeInfos(IList<AlibabaOpenplatformTradeModelTradeInfo> tradeInfos);
        AlibabaOpenplatformTradeModelTradeInfo GetTradeInfor(string appKey, string memberId, long orderId);
        void CallbackMessageTrigger();
    }

    public class TradeManager
        : DomainService, ITradeManager
    {

        IBackgroundJobManager backgroundJobManager;
        IAccessTokenManager accessTokenManager;
        IAccessTokenRepository accessTokenRepository;
        IAlibabaMessageRepository alibabaMessageRepository;

        public TradeManager(
            IBackgroundJobManager _backgroundJobManager,
            IAccessTokenManager _accessTokenManager,
            IAccessTokenRepository _accessTokenRepository,
            IAlibabaMessageRepository _alibabaMessageRepository
            )
        {
            backgroundJobManager = _backgroundJobManager;
            accessTokenManager = _accessTokenManager;
            accessTokenRepository = _accessTokenRepository;
            alibabaMessageRepository = _alibabaMessageRepository;
        }

        /// <summary>
        /// 获取前一天有更新的Trade Information
        /// </summary>
        /// <returns>The yesterday modification trade infos.</returns>
        public IList<AlibabaOpenplatformTradeModelTradeInfo> GetYesterdayModificationTradeInfos(IAccessToken token)
        {
            string yesteday = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");

            /*
            return GetModificationTradeInfos(
                token,
                DateTime.Parse(yesteday + " 00:00:00"),
                DateTime.Parse(yesteday + " 23:59:59"));
            */

            string start = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
            string end = DateTime.Now.AddDays(0).ToString("yyyy-MM-dd");
            return GetModificationTradeInfos(
                token,
                DateTime.Parse(start + " 00:00:00"),
                DateTime.Parse(end + " 23:59:59"));

        }

        // Testing Method
        public void GetSellerTradeView()
        {
            SyncAPIClient client = new SyncAPIClient("3259943", "t6MpyARzzv");
            AlibabaTradeGetSellerOrderListParam param = new AlibabaTradeGetSellerOrderListParam();

            string accessToken = "aa200987-fcec-48d9-9521-967d3ce2eea2";

            RequestPolicy oauthPolicy = new RequestPolicy();
            oauthPolicy.UseHttps = true;

            AlibabaTradeGetSellerOrderListResult result =
                client.execute<AlibabaTradeGetSellerOrderListResult>(param, accessToken);

            Console.Write(result.getTotalRecord());
        }

        // Save trade
        public bool SaveTradeInfos(IList<AlibabaOpenplatformTradeModelTradeInfo> tradeInfos)
        {
            return true;
        }

        public IList<AlibabaOpenplatformTradeModelTradeInfo> GetModificationTradeInfos(
            long tokenId,
            DateTime modifyStart,
            DateTime modifyEnd)
        {
            IAccessToken token = accessTokenRepository.Get(tokenId);
            return GetModificationTradeInfos(token, modifyStart, modifyEnd);
        }

        public IList<AlibabaOpenplatformTradeModelTradeInfo> GetModificationTradeInfos(
            IAccessToken token, 
            DateTime modifyStart, 
            DateTime modifyEnd)
        {
            string accessToken = token.Access_Token;
            SyncAPIClient client = new SyncAPIClient(token.App_Key, token.App_Secret);
            int maxPageSize = 20;   // Alibaba only support 20
            int currentPage = 1;
            long totalCount = 0;
            // Save all trade into this collection.
            IList<AlibabaOpenplatformTradeModelTradeInfo> data
                = new List<AlibabaOpenplatformTradeModelTradeInfo>();
            // 先计算一次，拿到总数后，再做循环处理
            do
            {
                Console.WriteLine("Page " + currentPage.ToString());
                AlibabaTradeGetSellerOrderListParam param
                    = new AlibabaTradeGetSellerOrderListParam();
                // 设置查询条件，查询前一在的数据
                param.setModifyStartTime(modifyStart);
                param.setModifyEndTime(modifyEnd);
                // 分页计算
                param.setPageSize(maxPageSize);
                param.setPage(currentPage);
                RequestPolicy oauthPolicy = new RequestPolicy();
                oauthPolicy.UseHttps = true;
                AlibabaTradeGetSellerOrderListResult result =
                    client.execute<AlibabaTradeGetSellerOrderListResult>(param, accessToken);
                totalCount = result.getTotalRecord().Value;
                AlibabaOpenplatformTradeModelTradeInfo[] orders = result.getResult();
                foreach (var ord in orders)
                {
                    data.Add(ord);
                }
                currentPage++;
            }
            while (currentPage * 1.0 <= (totalCount * 1.0 / maxPageSize)); // 没有超出分页，继续执行

            Console.WriteLine("Alibaba Order Count : " + data.Count);
            Console.WriteLine("Pull Order Count : " + data.Count);
            return data;
        }


        public AlibabaOpenplatformTradeModelTradeInfo GetTradeInfor(string appKey, string memberId, long orderId)
        {
            // var token = accessTokenRepository.Single(t => t.App_Key == appKey && t.MemberId == memberId && t.IsActive == true && t.IsDeleted == false);

            // SyncAPIClient client = new SyncAPIClient(token.App_Key, token.App_Secret);
            SyncAPIClient client = new SyncAPIClient("3259943", "t6MpyARzzv");

            AlibabaTradeGetSellerViewParam param
                = new AlibabaTradeGetSellerViewParam();
            RequestPolicy oauthPolicy = new RequestPolicy();
            oauthPolicy.UseHttps = true;

            param.setOrderId(orderId);

            // AlibabaTradeGetSellerViewResult response = client.execute<AlibabaTradeGetSellerViewResult>(param, token.Access_Token);
            AlibabaTradeGetSellerViewResult response = client.execute<AlibabaTradeGetSellerViewResult>(param, "30ef3548-9ebb-4730-9c48-a8bfe6fea683");

            return response.getResult();
        }

        public List<Message> GetMessageNeetToTrigger()
        {
            // Get newest message from storage.
            var messages = alibabaMessageRepository.GetAllMessageNeedToTrigger();
            return messages;
        }

        /// <summary>
        /// Get the Alibaba callback message and start the processing background job.
        /// </summary>
        public void CallbackMessageTrigger()
        {
            // Step 1: Get the message need to process.
            var messages = this.GetMessageNeetToTrigger();
            Console.WriteLine("There are " + messages.Count + " messages need to process.");

            // Generate background job for processing them.
            foreach (var msg in messages)
            {
                // Init message
                msg.Status = (int)CallbackMessageStatus.Inprocess;              // set message's status as 'inprocess'
                var arg = msg.MapTo<MessageDto>();

                switch (msg.Type)
                {
                    case "ORDER_PAY":
                        backgroundJobManager.Enqueue<AlibabaCallbackOnOrderPayJob, MessageDto>(arg, BackgroundJobPriority.Low, null);
                        Console.WriteLine("Background job created. Message Id is " + msg.Id.ToString());
                        break;
                    default:
                        msg.Status = (int)CallbackMessageStatus.Ignored;        // Status set to 'ignored' when none job to trigger.
                        break;
                }
            }
        }
    }
}
