//
//  BackgroundService.cs
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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XTOPMS.Alibaba
{
    [Table("Alibaba_DataSyncService")]
    public class DataSyncService: XTOPMSEntity
    {

        /// <summary>
        /// Gets or sets the access token identifier.
        /// </summary>
        /// <value>The access token identifier.</value>
        public long AccessTokenId { get; set; }

        public DateTime LatestRunTime { get; set; }

        [StringLength(4000)]
        public string LatestResult { get; set; }

        public DataSyncService()
        {
        }
    }



    /// <summary>
    /// 定义 Service 的唯一标识，这个值会保存在 DataSyncService 中的 Code 字段上。
    /// </summary>
    public enum DataSyncServiceCode: int
    {
        // https://open.1688.com/api/apidocdetail.htm?aopApiCategory=trade_new&id=com.alibaba.trade%3Aalibaba.trade.getSellerOrderList-1
        // 订单列表查看(卖家视角)
        // com.alibaba.trade:alibaba.trade.getSellerOrderList-1
        com_alibaba_trade_alibaba_trade_getSellerOrderList_1 = 2000001,
        // https://open.1688.com/api/apidocdetail.htm?aopApiCategory=trade_new&id=com.alibaba.trade%3Aalibaba.trade.get.sellerView-1
        // 订单详情查看(卖家视角)
        // com.alibaba.trade:alibaba.trade.get.sellerView-1
        com_alibaba_trade_alibaba_trade_get_sellerView_1 = 2000002,
    }
}
