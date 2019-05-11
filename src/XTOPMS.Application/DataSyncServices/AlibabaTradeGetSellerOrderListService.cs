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
    public class AlibabaTradeGetSellerOrderListService : IService
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
            Console.WriteLine("Service job executing. - XTOPMS.DataSyncServices.AlibabaTradeGetSellerOrderListService.Execute");
            IList<AlibabaOpenplatformTradeModelTradeInfo> tradeInfos = tradeManager.GetYesterdayModificationTradeInfos(accessToken);
            Console.WriteLine(string.Format("There are {0} trade need to sync.", tradeInfos.Count));

            Console.WriteLine();
            string header = "{0,20}\t{14,20}\t{1,10}\t{2,10}\t{3,20}\t{4,10}\t{5,10}\t{6,10}\t{7,10}\t{8,20}\t{9,20}\t{10,20}\t{11,20}\t{12,20}\t{13,20}";
            string item = "{0,20}\t{1,20}\t{2,20}\t{4,20}\t{5,20}\t{6,20}\t{7,20}\t{8,10}\t{3}";

            Console.WriteLine("Trade Header Information");
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine(
                header, 
                "ID", 
                "Amount", 
                "Discount", 
                "BuyerID", 
                "Buyer Name", 
                "Buyer Memo", 
                "Seller Name", 
                "Seller Memo", 
                "Create Time", 
                "Modify Time", 
                "Completed Time", 
                "Confirmed Time", 
                "Remark", 
                "ID",
                "Status");

            foreach (var trade in tradeInfos)
            {

                AlibabaOpenplatformTradeModelOrderBaseInfo baseInfo = trade.getBaseInfo();

                Console.WriteLine(
                    header,
                    baseInfo.getId(),
                    baseInfo.getTotalAmount(),
                    baseInfo.getDiscount(),
                    baseInfo.getBuyerID(),
                    baseInfo.getBuyerContact().getName(),
                    baseInfo.getBuyerMemo(),
                    baseInfo.getSellerContact().getName(),
                    baseInfo.getSellerMemo(),
                    baseInfo.getCreateTime(),
                    baseInfo.getModifyTime(),
                    baseInfo.getCompleteTime(),
                    baseInfo.getConfirmedTime(),
                    baseInfo.getRemark(),
                    baseInfo.getIdOfStr(),
                    baseInfo.getStatus()
                    );

                // string json = Newtonsoft.Json.JsonConvert.SerializeObject(trade);

                /*
                Console.Write(baseInfo.getId() + "\t");
                Console.Write(baseInfo.getTotalAmount() + "\t");
                Console.Write(baseInfo.getDiscount() + "\t");
                Console.Write(baseInfo.getBuyerID() + "\t");
                Console.Write(baseInfo.getBuyerContact().getName() + "\t");
                Console.Write(baseInfo.getBuyerMemo() + "\t");
                Console.Write(baseInfo.getSellerContact().getName() + "\t");
                Console.Write(baseInfo.getSellerMemo() + "\t");
                Console.Write(baseInfo.getCreateTime() + "\t");
                Console.Write(baseInfo.getModifyTime() + "\t");
                Console.Write(baseInfo.getCompleteTime() + "\t");
                Console.Write(baseInfo.getConfirmedTime() + "\t");
                Console.Write(baseInfo.getRemark() + "\t");
                Console.Write(baseInfo.getIdOfStr() + "\t");
                Console.WriteLine();
                */

                AlibabaTradeCustoms customs = trade.getCustoms();
                AlibabaOpenplatformTradeModelGuaranteeTermsInfo guaranteeTermsInfo = trade.getGuaranteesTerms();
                AlibabaOpenplatformTradeModelInternationalLogisticsInfo internationalLogistics = trade.getInternationalLogistics();
                AlibabaOpenplatformTradeModelNativeLogisticsInfo nativeLogistics = trade.getNativeLogistics();
                AlibabaOrderBizInfo orderBizInfo = trade.getOrderBizInfo();
                AlibabaInvoiceOrderInvoiceModel orderInvoiceInfo = trade.getOrderInvoiceInfo();
                AlibabaTradeOrderRateInfo orderRateInfo = trade.getOrderRateInfo();
                AlibabaTradeOverseasExtraAddress overseasExtraAddress = trade.getOverseasExtraAddress();
                AlibabaOrderDetailCaigouQuoteInfo[] quoteList = trade.getQuoteList();
                AlibabaOpenplatformTradeModelTradeTermsInfo[] tradeTerms = trade.getTradeTerms();

                AlibabaOpenplatformTradeModelProductItemInfo[] productItems = trade.getProductItems();

            }

            Console.WriteLine("Trade Item Information");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(item,
                "ID",
                "Product ID",
                "SKU ID",
                "Name",
                "Quantity",
                "Unit",
                "Price",
                "Amount",
                "Description"
                );

            foreach (var trade in tradeInfos)
            {
                AlibabaOpenplatformTradeModelOrderBaseInfo baseInfo = trade.getBaseInfo();
                AlibabaOpenplatformTradeModelProductItemInfo[] productItems = trade.getProductItems();

                foreach (var prd in productItems)
                {
                    Console.WriteLine(item,
                        baseInfo.getId(),
                        prd.getProductID(),
                        prd.getSkuID(),
                        prd.getName(),
                        prd.getQuantity(),
                        prd.getUnit(),
                        prd.getPrice(),
                        prd.getItemAmount(),
                        prd.getDescription()
                        );

                    /*
                    Console.Write(prd.getProductID() + "\t");
                    Console.Write(prd.getSkuID() + "\t");
                    Console.Write(prd.getName() + "\t");
                    Console.Write(prd.getQuantity() + "\t");
                    Console.Write(prd.getUnit() + "\t");
                    Console.Write(prd.getPrice() + "\t");
                    Console.Write(prd.getItemAmount() + "\t");
                    Console.WriteLine();
                    */
                }
            }
        }
    }
}
