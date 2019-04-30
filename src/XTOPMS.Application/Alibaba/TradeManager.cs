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
using Abp.Domain.Services;
using com.alibaba.openapi.client;
using com.alibaba.openapi.client.policy;
using com.alibaba.trade.param;
using XTOPMS.DataSyncServices;

namespace XTOPMS.Alibaba
{

    public interface ITradeManager
        : IDomainService
    {
        IList<AlibabaOpenplatformTradeModelTradeInfo> GetYesterdayModificationTradeInfos(IAccessToken token);
    }

    public class TradeManager
        : DomainService, ITradeManager
    {

        public TradeManager()
        {
        }

        /// <summary>
        /// 获取前一天有更新的Trade Information
        /// </summary>
        /// <returns>The yesterday modification trade infos.</returns>
        public IList<AlibabaOpenplatformTradeModelTradeInfo> GetYesterdayModificationTradeInfos(IAccessToken token)
        {
            // string accessToken = "aa200987-fcec-48d9-9521-967d3ce2eea2";
            // SyncAPIClient client = new SyncAPIClient("3259943", "t6MpyARzzv");

            string accessToken = token.Access_Token;
            SyncAPIClient client = new SyncAPIClient(token.App_Key, token.App_Secret);

            int maxPageSize = 20;   // Alibaba only support 20
            int currentPage = 1;
            long totalCount = 0;

            string yesteday = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");

            IList<AlibabaOpenplatformTradeModelTradeInfo> data = new List<AlibabaOpenplatformTradeModelTradeInfo>();

            // 先计算一次，拿到总数后，再做循环处理
            do
            {
                AlibabaTradeGetSellerOrderListParam param
                    = new AlibabaTradeGetSellerOrderListParam();
                param.setModifyStartTime(DateTime.Parse(yesteday + " 00:00:00"));
                param.setModifyEndTime(DateTime.Parse(yesteday + " 23:59:59"));

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
            while ((currentPage * maxPageSize) < totalCount);

            Console.WriteLine("Get trade order from alibaba: " + data.Count);

            return data;

        }

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

    }
}
