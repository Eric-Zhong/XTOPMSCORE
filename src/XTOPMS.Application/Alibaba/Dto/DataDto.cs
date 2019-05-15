//
//  DataDto.cs
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

namespace XTOPMS.Alibaba.Dto
{

    public interface IDataDto
    {
        string OrderId { get; set; }
        string BizType { get; set; }
        string CurrentStatus { get; set; }
        string MsgSendTime { get; set; }
        string BuyerMemberId { get; set; }
        string SellerMemberId { get; set; }
        string RefundAction { get; set; }
        string Operator { get; set; }
        string BuyOfferId { get; set; }
        string PrId { get; set; }
        string SubUserId { get; set; }
        string SupplierMemberId { get; set; }
        string SourceBuyOfferId { get; set; }
        List<DataItemDto> Items { get; set; }
        string QuotationId { get; set; }
        string Title { get; set; }
        string CreateLoginId { get; set; }
        string RequisitionNo { get; set; }
        string RequisitionId { get; set; }
        string Id { get; set; }
        string GmtCreate { get; set; }
        string FrameworkAgreementNum { get; set; }
        string Status { get; set; }
    }


    /// <summary>
    /// Callback.Message.Data 的结构定义 (/XTOPMS.Alibaba.Subscription_Event.xlsx)
    /// </summary>
    [Serializable]
    public class DataDto : IDataDto
    {
        /// <summary>
        /// 买家中文站会员ID
        /// </summary>
        public string BuyerMemberId { get; set; }
        /// <summary>
        /// 询价单ID
        /// </summary>
        public string BuyOfferId { get; set; }
        public string BizType { get; set; }
        /// <summary>
        /// 提交请购人子账号
        /// </summary>
        public string CreateLoginId { get; set; }
        /// <summary>
        /// 当前订单状态，状态值为waitbuyerpay
        /// </summary>
        public string CurrentStatus { get; set; }
        /// <summary>
        /// 框架协议编号
        /// </summary>
        public string FrameworkAgreementNum { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string GmtCreate { get; set; }
        /// <summary>
        /// 框架协议主键ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<DataItemDto> Items { get; set; }
        /// <summary>
        /// 消息发送时间
        /// </summary>
        public string MsgSendTime { get; set; }
        /// <summary>
        /// 操作的发起人，buyer(买家)，seller(卖家)，system(系统)
        /// </summary>
        public string Operator { get; set; }
        /// <summary>
        /// 订单ID
        /// </summary>
        public string OrderId { get; set; }
        /// <summary>
        /// 接入商的PR ID
        /// </summary>
        public string PrId { get; set; }
        /// <summary>
        /// 报价单ID
        /// </summary>
        public string QuotationId { get; set; }
        /// <summary>
        /// 退款操作，具体状态为：BUYER_APPLY_REFUND(买家申请退款)、BUYER_RECEIVE_CLOSE(买家确认收货关闭)、SELLER_SEND_GOODS_CLOSE(卖家发货关闭)、BUYER_UPLOAD_BILL(买家上传凭证)、SELLER_UPLOAD_BILL(卖家上传凭证)、SELLER_REJECT_REFUND(卖家拒绝退款)、SELLER_AGREE_REFUND(卖家同意退款)、SELLER_RECEIVE_GOODS(卖家确认收货)、BUYER_SEND_GOODS(买家声明发货)、BUYER_APPLY_SUPPORT(买家申请客服介入)、SELLER_APPLY_SUPPORT(卖家申请客服介入)、SYSTEM_AGREE_REFUND(系统超时同意退款协议)、SYSTEM_RECEIVE_GOODS(系统超时确认收货)、SYSTEM_SEND_GOODS(系统超时退货)、BUYER_MODIFY_REFUND_PROTOCOL(买家修改退款协议)、SELLER_AGREE_REFUND_PROCOTOL(卖家同意退款协议)、SELLER_REJECT_REFUND_PROCOTOL(卖家拒绝退款协议)、SYSTEM_MODIFY_REFUND_PROTOCOL(系统超时修改协议)
        /// </summary>
        public string RefundAction { get; set; }
        /// <summary>
        /// 请购单Id
        /// </summary>
        public string RequisitionId { get; set; }
        /// <summary>
        /// 请购单号
        /// </summary>
        public string RequisitionNo { get; set; }
        /// <summary>
        /// 卖家中文站会员ID
        /// </summary>
        public string SellerMemberId { get; set; }
        /// <summary>
        /// 修改前询价单ID
        /// </summary>
        public string SourceBuyOfferId { get; set; }
        /// <summary>
        /// 协议状态，包括wait_approval：审批中，approved：审批通过未生效，effective：已生效，dismissed：已驳回，freezing：已冻结，expired：已到期，completed：已完成，terminated：终止，deleted：删除
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 发布询价的操作人子账号ID
        /// </summary>
        public string SubUserId { get; set; }
        /// <summary>
        /// 供应商在1688的会员ID
        /// </summary>
        public string SupplierMemberId { get; set; }
        /// <summary>
        /// 请购单标题
        /// </summary>
        public string Title { get; set; }

        public DataDto()
        {
            this.Items = new List<DataItemDto>();
        }
    }


    [Serializable]
    public class DataItemDto
    {
        public string OrderItemId { get; set; }
        public string PrItemId { get; set; }
        public string ProductCode { get; set; }
        public string ProductId { get; set; }
        public string ProductQuoteId { get; set; }
        public string SupplyNoteItemId { get; set; }
    }

    /*
        "Items": [{
            "productCode": "MMA00152",
            "productId": 2227112,
            "orderItemId": 152539133487786140,
            "productQuoteId": 569969887292
        }],
    */
}
