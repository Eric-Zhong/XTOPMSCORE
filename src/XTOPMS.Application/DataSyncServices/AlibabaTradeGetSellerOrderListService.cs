//
//  AlibabaTradeGetSellerOrderListService.cs
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
using com.alibaba.trade.param;
using XTOPMS.Alibaba;

namespace XTOPMS.DataSyncServices
{
    public class AlibabaTradeGetSellerOrderListService: IService
    {
        private readonly IAccessToken accessToken;
        private readonly ITradeManager tradeManager;

        public AlibabaTradeGetSellerOrderListService(
            IAccessToken a0,
            ITradeManager a1
            )
        {
            accessToken = a0;
            tradeManager = a1;
        }

        public void Execute()
        {
            IList<AlibabaOpenplatformTradeModelTradeInfo> tradeInfos = tradeManager.GetYesterdayModificationTradeInfos(accessToken);
            Console.WriteLine(string.Format("There are {0} trade need to sync.", tradeInfos.Count));

            foreach (var trade in tradeInfos)
            {
                AlibabaOpenplatformTradeModelOrderBaseInfo baseInfo = trade.getBaseInfo();
                AlibabaTradeCustoms customs = trade.getCustoms();
                AlibabaOpenplatformTradeModelGuaranteeTermsInfo guaranteeTermsInfo = trade.getGuaranteesTerms();
                AlibabaOpenplatformTradeModelInternationalLogisticsInfo internationalLogistics = trade.getInternationalLogistics();
                AlibabaOpenplatformTradeModelNativeLogisticsInfo nativeLogistics = trade.getNativeLogistics();
                AlibabaOrderBizInfo orderBizInfo = trade.getOrderBizInfo();
                AlibabaInvoiceOrderInvoiceModel orderInvoiceInfo = trade.getOrderInvoiceInfo();
                AlibabaTradeOrderRateInfo orderRateInfo = trade.getOrderRateInfo();
                AlibabaTradeOverseasExtraAddress overseasExtraAddress = trade.getOverseasExtraAddress();
                AlibabaOpenplatformTradeModelProductItemInfo[] productItems = trade.getProductItems();
                AlibabaOrderDetailCaigouQuoteInfo[] quoteList = trade.getQuoteList();
                AlibabaOpenplatformTradeModelTradeTermsInfo[] tradeTerms = trade.getTradeTerms();
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(trade);
                Console.WriteLine(json);
            }
        }
    }
}
