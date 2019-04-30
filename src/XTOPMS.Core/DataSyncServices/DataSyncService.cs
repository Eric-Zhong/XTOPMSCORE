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
    public class DataSyncService: XTOPMSEntity, IDataSyncService
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
    public enum DataSyncServiceCode: long
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
