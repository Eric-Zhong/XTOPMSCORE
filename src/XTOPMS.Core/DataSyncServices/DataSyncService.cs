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
using Abp.Domain.Entities;
using XTOPMS.Alibaba;

namespace XTOPMS.DataSyncServices
{

    public interface IDataSyncService
    {
        AccessToken AccessTokenInfo { get; set; }
        long AccessTokenId { get; set; }
        DateTime LastRunTime { get; set; }
        DateTime NextRunTime { get; set; }
        double Interval { get; set; }
        int RetryCount { get; set; }
        string LastResult { get; set; }
        string Code { get; set; }
    }


    [Table("Alibaba_DataSyncService")]
    public class DataSyncService 
        : XTOPMSEntity
        , IXTOPMSEntity
        , IDataSyncService
        , IExtendableObject
    {

        [ForeignKey("AccessTokenId")]
        public AccessToken AccessTokenInfo { get; set; }

        /// <summary>
        /// Gets or sets the access token identifier.
        /// </summary>
        /// <value>The access token identifier.</value>
        public long AccessTokenId { get; set; }

        /// <summary>
        /// 上次运行的时间
        /// </summary>
        /// <value>The latest run time.</value>
        public DateTime LastRunTime { get; set; }

        /// <summary>
        /// 下次运行的时间
        /// </summary>
        /// <value>The next run time.</value>
        public DateTime NextRunTime { get; set; }

        /// <summary>
        /// 延时周期（单位：分钟）
        /// </summary>
        /// <value>The indivadue.</value>
        public double Interval { get; set; }

        /// <summary>
        /// 重试次数
        /// </summary>
        /// <value>The retry count.</value>
        public int RetryCount { get; set; }

        [StringLength(4000)]
        public string LastResult { get; set; }

    }

    /// <summary>
    /// 定义 Service 的唯一标识，这个值会保存在 DataSyncService 中的 Code 字段上。
    /// </summary>
    public enum DataSyncServiceCode : long
    {
        // https://open.1688.com/api/apidocdetail.htm?aopApiCategory=trade_new&id=com.alibaba.trade%3Aalibaba.trade.getSellerOrderList-1
        // 订单列表查看(卖家视角)
        // com.alibaba.trade:alibaba.trade.getSellerOrderList-1
        com_alibaba_trade_alibaba_trade_getSellerOrderList_1 = 2000001,
        // https://open.1688.com/api/apidocdetail.htm?aopApiCategory=trade_new&id=com.alibaba.trade%3Aalibaba.trade.get.sellerView-1
        // 订单详情查看(卖家视角)
        // com.alibaba.trade:alibaba.trade.get.sellerView-1
        com_alibaba_trade_alibaba_trade_get_sellerView_1 = 2000002,

        /// <summary>
        /// 1688订单发货（卖家视角）/// </summary>
        ORDER_ANNOUNCE_SENDGOODS = 3000001,
        /// <summary>
        /// 1688创建订单（卖家视角）/// </summary>
        ORDER_BUYER_MAKE = 3000002,
        /// <summary>
        /// 1688订单发货（买家视角）/// </summary>
        ORDER_BUYER_VIEW_ANNOUNCE_SENDGOODS = 3000003,
        /// <summary>
        /// 1688创建订单（买家视角）/// </summary>
        ORDER_BUYER_VIEW_BUYER_MAKE = 3000004,
        /// <summary>
        /// 1688订单备注修改（买家视角）/// </summary>
        ORDER_BUYER_VIEW_MODIFY_MEMO = 3000005,
        /// <summary>
        /// 1688运营后台关闭订单（买家视角）/// </summary>
        ORDER_BUYER_VIEW_ORDER_BOPS_CLOSE = 3000006,
        /// <summary>
        /// 1688买家关闭订单（买家视角）/// </summary>
        ORDER_BUYER_VIEW_ORDER_BUYER_CLOSE = 3000007,
        /// <summary>
        /// 1688订单售中退款（买家视角）/// </summary>
        ORDER_BUYER_VIEW_ORDER_BUYER_REFUND_IN_SALES = 3000008,
        /// <summary>
        /// 1688订单确认收货（买家视角）/// </summary>
        ORDER_BUYER_VIEW_ORDER_COMFIRM_RECEIVEGOODS = 3000009,
        /// <summary>
        /// 1688交易付款（买家视角）/// </summary>
        ORDER_BUYER_VIEW_ORDER_PAY = 3000010,
        /// <summary>
        /// 1688修改订单价格（买家视角）/// </summary>
        ORDER_BUYER_VIEW_ORDER_PRICE_MODIFY = 3000011,
        /// <summary>
        /// 1688订单售后退款（买家视角）/// </summary>
        ORDER_BUYER_VIEW_ORDER_REFUND_AFTER_SALES = 3000012,
        /// <summary>
        /// 1688卖家关闭订单（买家视角）/// </summary>
        ORDER_BUYER_VIEW_ORDER_SELLER_CLOSE = 3000013,
        /// <summary>
        /// 1688订单阶段付款（买家视角）/// </summary>
        ORDER_BUYER_VIEW_ORDER_STEP_PAY = 3000014,
        /// <summary>
        /// 1688交易成功（买家视角）/// </summary>
        ORDER_BUYER_VIEW_ORDER_SUCCESS = 3000015,
        /// <summary>
        /// 1688订单部分发货（买家视角）/// </summary>
        ORDER_BUYER_VIEW_PART_PART_SENDGOODS = 3000016,
        /// <summary>
        /// 1688订单备注修改（卖家视角）/// </summary>
        ORDER_MODIFY_MEMO = 3000017,
        /// <summary>
        /// 1688运营后台关闭订单（卖家视角）/// </summary>
        ORDER_ORDER_BOPS_CLOSE = 3000018,
        /// <summary>
        /// 1688买家关闭订单（卖家视角）/// </summary>
        ORDER_ORDER_BUYER_CLOSE = 3000019,
        /// <summary>
        /// 1688订单售中退款（卖家视角）/// </summary>
        ORDER_ORDER_BUYER_REFUND_IN_SALES = 3000020,
        /// <summary>
        /// 1688订单确认收货（卖家视角）/// </summary>
        ORDER_ORDER_COMFIRM_RECEIVEGOODS = 3000021,
        /// <summary>
        /// 1688修改订单价格（卖家视角）/// </summary>
        ORDER_ORDER_PRICE_MODIFY = 3000022,
        /// <summary>
        /// 1688订单售后退款（卖家视角）/// </summary>
        ORDER_ORDER_REFUND_AFTER_SALES = 3000023,
        /// <summary>
        /// 1688卖家关闭订单（卖家视角）/// </summary>
        ORDER_ORDER_SELLER_CLOSE = 3000024,
        /// <summary>
        /// 1688订单阶段付款（卖家视角）/// </summary>
        ORDER_ORDER_STEP_PAY = 3000025,
        /// <summary>
        /// 1688交易成功（卖家视角）/// </summary>
        ORDER_ORDER_SUCCESS = 3000026,
        /// <summary>
        /// 1688订单部分发货（卖家视角）/// </summary>
        ORDER_PART_PART_SENDGOODS = 3000027,
        /// <summary>
        /// 1688交易付款（卖家视角）/// </summary>
        ORDER_PAY = 3000028
    }
}
