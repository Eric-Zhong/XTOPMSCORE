//
//  PushMessageData.cs
//
//  Author:
//       Eric-Zhong Xu <zhong.xu@biztalkgroup.com>
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
using System.Runtime.Serialization;

namespace cn.alibaba.open.param
{
    [DataContract(Namespace = "com.alibaba.openapi.client")]
    public class PushMessageData
    {
        [DataMember()]
        public string buyerMemberId { get; set; }
        /// <summary>
        /// 询价单ID
        /// </summary>
        [DataMember()]
        public string buyOfferId { get; set; }
        [DataMember()]
        public string bizType { get; set; }
        /// <summary>
        /// 提交请购人子账号
        /// </summary>
        [DataMember()]
        public string createLoginId { get; set; }
        /// <summary>
        /// 当前订单状态，状态值为waitbuyerpay
        /// </summary>
        [DataMember()]
        public string currentStatus { get; set; }
        /// <summary>
        /// 框架协议编号
        /// </summary>
        [DataMember()]
        public string frameworkAgreementNum { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DataMember()]
        public string gmtCreate { get; set; }
        /// <summary>
        /// 框架协议主键ID
        /// </summary>
        [DataMember()]
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember()]
        public List<DataItemDto> items { get; set; }
        /// <summary>
        /// 消息发送时间
        /// </summary>
        [DataMember()]
        public string msgSendTime { get; set; }
        /// <summary>
        /// 操作的发起人，buyer(买家)，seller(卖家)，system(系统)
        /// </summary>
        [DataMember()]
        public string Operator { get; set; }
        /// <summary>
        /// 订单ID
        /// </summary>
        [DataMember()]
        public string orderId { get; set; }
        /// <summary>
        /// 接入商的PR ID
        /// </summary>
        [DataMember()]
        public string prId { get; set; }
        /// <summary>
        /// 报价单ID
        /// </summary>
        [DataMember()]
        public string quotationId { get; set; }
        /// <summary>
        /// 退款操作，具体状态为：BUYER_APPLY_REFUND(买家申请退款)、BUYER_RECEIVE_CLOSE(买家确认收货关闭)、SELLER_SEND_GOODS_CLOSE(卖家发货关闭)、BUYER_UPLOAD_BILL(买家上传凭证)、SELLER_UPLOAD_BILL(卖家上传凭证)、SELLER_REJECT_REFUND(卖家拒绝退款)、SELLER_AGREE_REFUND(卖家同意退款)、SELLER_RECEIVE_GOODS(卖家确认收货)、BUYER_SEND_GOODS(买家声明发货)、BUYER_APPLY_SUPPORT(买家申请客服介入)、SELLER_APPLY_SUPPORT(卖家申请客服介入)、SYSTEM_AGREE_REFUND(系统超时同意退款协议)、SYSTEM_RECEIVE_GOODS(系统超时确认收货)、SYSTEM_SEND_GOODS(系统超时退货)、BUYER_MODIFY_REFUND_PROTOCOL(买家修改退款协议)、SELLER_AGREE_REFUND_PROCOTOL(卖家同意退款协议)、SELLER_REJECT_REFUND_PROCOTOL(卖家拒绝退款协议)、SYSTEM_MODIFY_REFUND_PROTOCOL(系统超时修改协议)
        /// </summary>
        [DataMember()]
        public string refundAction { get; set; }
        /// <summary>
        /// 请购单Id
        /// </summary>
        [DataMember()]
        public string requisitionId { get; set; }
        /// <summary>
        /// 请购单号
        /// </summary>
        [DataMember()]
        public string requisitionNo { get; set; }
        /// <summary>
        /// 卖家中文站会员ID
        /// </summary>
        [DataMember()]
        public string sellerMemberId { get; set; }
        /// <summary>
        /// 修改前询价单ID
        /// </summary>
        [DataMember()]
        public string sourceBuyOfferId { get; set; }
        /// <summary>
        /// 协议状态，包括wait_approval：审批中，approved：审批通过未生效，effective：已生效，dismissed：已驳回，freezing：已冻结，expired：已到期，completed：已完成，terminated：终止，deleted：删除
        /// </summary>
        [DataMember()]
        public string status { get; set; }
        /// <summary>
        /// 发布询价的操作人子账号ID
        /// </summary>
        [DataMember()]
        public string subUserId { get; set; }
        /// <summary>
        /// 供应商在1688的会员ID
        /// </summary>
        [DataMember()]
        public string supplierMemberId { get; set; }
        /// <summary>
        /// 请购单标题
        /// </summary>
        [DataMember()]
        public string title { get; set; }
    }

    [DataContract(Namespace = "com.alibaba.openapi.client")]
    public class DataItemDto
    {
        [DataMember()]
        public string orderItemId { get; set; }
        [DataMember()]
        public string prItemId { get; set; }
        [DataMember()]
        public string productCode { get; set; }
        [DataMember()]
        public string productId { get; set; }
        [DataMember()]
        public string productQuoteId { get; set; }
        [DataMember()]
        public string supplyNoteItemId { get; set; }
    }

}
