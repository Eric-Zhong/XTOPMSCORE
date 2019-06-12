//
//  OrderDto.cs
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

namespace XTOPMS.Henkel.Salesforce
{
    public class OrderDto
    {

        public string OrderNumber { get; set; }
        public string Source { get; set; }
        public string OrderDate { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public List<ProductDto> ProductDetails { get; set; }

        public OrderDto()
        {
            Source = "汉高阿里巴巴旗舰店";
        }

        public OrderDto(AlibabaOpenplatformTradeModelTradeInfo trade): this()
        {
            // Order information
            this.OrderNumber = trade.getBaseInfo().getIdOfStr();
            this.OrderDate = trade.getBaseInfo().getPayTime().Value.ToString("yyyy/MM/dd");

            // Customer information
            // 20190612 Change there logic for fix the buyer's mobile is empty, it will make salesforce can not process.
            /*
                @Eric – as per alignment today, please update with the below logic. Please re-push the orders once update is done so we can compare the data again.                 
                If there is a mobile number for the purchaser (采购人), use the purchaser’s details for Salesforce push
                If the purchaser doesn’t have a mobile number, use the recipient’s (收件人) details instead
            */
            var buyer = trade.getBaseInfo().getBuyerContact();
            var receiver = trade.getBaseInfo().getReceiverInfo();

            if (false == string.IsNullOrEmpty(buyer.getMobile()))
            {
                this.Name = buyer.getName();
                this.Mobile = buyer.getMobile();
            }
            else
            {
                this.Name = receiver.getToFullName();
                this.Mobile = receiver.getToMobile();
            }

            // Logistic information
            this.Province = trade.getNativeLogistics().getProvince();
            this.City = trade.getNativeLogistics().getCity();
            this.Address = trade.getNativeLogistics().getAddress();

            // Product detail information
            this.ProductDetails = new List<ProductDto>();

            foreach(var p in trade.getProductItems())
            {
                this.ProductDetails.Add(new ProductDto
                {
                    IDH = p.getProductCargoNumber(),
                    ProductName = p.getName(),
                    Quantity = p.getQuantity().Value,
                    OrderValue = p.getItemAmount().Value
                });
            }
        }
    }
}
