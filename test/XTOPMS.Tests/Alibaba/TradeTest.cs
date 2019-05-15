//
//  TradeTest.cs
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using XTOPMS.Alibaba;
using XTOPMS.Alibaba.Dto;
using XTOPMS.EntityFrameworkCore.Repositories;
using Xunit;

namespace XTOPMS.Tests.Alibaba
{
    public class TradeTest: XTOPMSTestBase
    {

        IAccessTokenRepository accessTokenRepository;
        ITradeManager tradeManager;

        public TradeTest()
        {
            accessTokenRepository = Resolve<IAccessTokenRepository>();
            tradeManager = Resolve<ITradeManager>();
        }

        [Fact]
        public void GetYesterdaySellerOrderListTest()
        {
            var token = accessTokenRepository.Get(1);
            tradeManager.GetYesterdayModificationTradeInfos(token);
        }

        [Fact]
        public void Json()
        {
            string msg = @"{
        ""supplierMemberId"": ""b2b-3081850159d0afc"",
        ""bizType"": ""mall"",
        ""orderId"": 152539133487786140,
        ""Items"": [{
            ""productCode"": ""MMA00152"",
            ""productId"": 2227112,
            ""orderItemId"": 152539133487786140,
            ""productQuoteId"": 569969887292
        },{
            ""productCode"": ""MMA00152"",
            ""productId"": 2227112,
            ""orderItemId"": 152539133487786140,
            ""productQuoteId"": 569969887292
        }],
        ""subUserId"": 2999689623
    }";

            var data = JsonConvert.DeserializeObject<DataDto>(msg);
            Console.WriteLine(JsonConvert.SerializeObject(data));

            JObject obj = (JObject)JsonConvert.DeserializeObject(msg);
            Console.WriteLine(obj["bizType"]);

            string product = @"{
      ""productCode"": ""MMA00152"",
      ""productId"": 2227112,
      ""orderItemId"": 152539133487786140,
      ""productQuoteId"": 569969887292
    }";

            DataItemDto prd = JsonConvert.DeserializeObject<DataItemDto>(product);
            Console.WriteLine(prd.OrderItemId);

            Assert.NotNull(data);
        }
    }
}
