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
using Abp.Domain.Services;
using com.alibaba.openapi.client;
using com.alibaba.openapi.client.policy;
using com.alibaba.trade.param;

namespace XTOPMS.Alibaba
{

    public interface ITradeManager
        : IDomainService
    {
        void GetYesterdayOrder();
    }

    public class TradeManager
        : DomainService, ITradeManager
    {

        private readonly IAccessTokenManager accessTokenManager;

        public TradeManager(
            IAccessTokenManager _accessTokenManager
            )
        {
            accessTokenManager = _accessTokenManager;
        }

        public void GetYesterdayOrder()
        {
            string accessToken = "aa200987-fcec-48d9-9521-967d3ce2eea2";
            SyncAPIClient client = new SyncAPIClient("3259943", "t6MpyARzzv");
            AlibabaTradeGetSellerOrderListParam param 
                = new AlibabaTradeGetSellerOrderListParam();

            string yesteday = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");

            param.setModifyStartTime(DateTime.Parse(yesteday + " 00:00:00"));
            param.setModifyEndTime(DateTime.Parse(yesteday + " 23:59:59"));

            RequestPolicy oauthPolicy = new RequestPolicy();
            oauthPolicy.UseHttps = true;

            AlibabaTradeGetSellerOrderListResult result = 
                client.execute<AlibabaTradeGetSellerOrderListResult>(param, accessToken);

            Console.Write(result.getTotalRecord());
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
