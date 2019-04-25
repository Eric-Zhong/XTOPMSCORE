using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.trade.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaOpenplatformTradeModelOrderBaseInfo {

       [DataMember(Order = 1)]
    private string allDeliveredTime;
    
        /**
       * @return 完全发货时间
    */
        public DateTime? getAllDeliveredTime() {
                 if (allDeliveredTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(allDeliveredTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置完全发货时间     *
     * 参数示例：<pre>20180614101942000+0800</pre>     
             * 此参数必填
          */
    public void setAllDeliveredTime(DateTime allDeliveredTime) {
     	         	    this.allDeliveredTime = DateUtil.format(allDeliveredTime);
     	        }
    
        [DataMember(Order = 2)]
    private string businessType;
    
        /**
       * @return 业务类型。国际站：ta(信保),wholesale(在线批发)。
中文站：普通订单类型 = "cn";
大额批发订单类型 = "ws";
普通拿样订单类型 = "yp";
一分钱拿样订单类型 = "yf";
倒批(限时折扣)订单类型 = "fs";
加工定制订单类型 = "cz";
协议采购订单类型 = "ag";
伙拼订单类型 = "hp";
供销订单类型 = "supply";
淘工厂订单 = "factory";
快订下单  = "quick";
享拼订单  = "xiangpin";
当面付 = "f2f";
存样服务 = "cyfw";
代销订单 = "sp";
微供订单 = "wg";零售通 = "lst";跨境='cb';分销='distribution';采源宝='cab';加工定制="manufact"
    */
        public string getBusinessType() {
               	return businessType;
            }
    
    /**
     * 设置业务类型。国际站：ta(信保),wholesale(在线批发)。
中文站：普通订单类型 = "cn";
大额批发订单类型 = "ws";
普通拿样订单类型 = "yp";
一分钱拿样订单类型 = "yf";
倒批(限时折扣)订单类型 = "fs";
加工定制订单类型 = "cz";
协议采购订单类型 = "ag";
伙拼订单类型 = "hp";
供销订单类型 = "supply";
淘工厂订单 = "factory";
快订下单  = "quick";
享拼订单  = "xiangpin";
当面付 = "f2f";
存样服务 = "cyfw";
代销订单 = "sp";
微供订单 = "wg";零售通 = "lst";跨境='cb';分销='distribution';采源宝='cab';加工定制="manufact"     *
     * 参数示例：<pre>cn</pre>     
             * 此参数必填
          */
    public void setBusinessType(string businessType) {
     	         	    this.businessType = businessType;
     	        }
    
        [DataMember(Order = 3)]
    private string buyerID;
    
        /**
       * @return 买家主账号id
    */
        public string getBuyerID() {
               	return buyerID;
            }
    
    /**
     * 设置买家主账号id     *
     * 参数示例：<pre>1234531</pre>     
             * 此参数必填
          */
    public void setBuyerID(string buyerID) {
     	         	    this.buyerID = buyerID;
     	        }
    
        [DataMember(Order = 4)]
    private string buyerMemo;
    
        /**
       * @return 买家备忘信息
    */
        public string getBuyerMemo() {
               	return buyerMemo;
            }
    
    /**
     * 设置买家备忘信息     *
     * 参数示例：<pre>备忘</pre>     
             * 此参数必填
          */
    public void setBuyerMemo(string buyerMemo) {
     	         	    this.buyerMemo = buyerMemo;
     	        }
    
        [DataMember(Order = 5)]
    private string completeTime;
    
        /**
       * @return 完成时间
    */
        public DateTime? getCompleteTime() {
                 if (completeTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(completeTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置完成时间     *
     * 参数示例：<pre>20180614101942000+0800</pre>     
             * 此参数必填
          */
    public void setCompleteTime(DateTime completeTime) {
     	         	    this.completeTime = DateUtil.format(completeTime);
     	        }
    
        [DataMember(Order = 6)]
    private string createTime;
    
        /**
       * @return 创建时间
    */
        public DateTime? getCreateTime() {
                 if (createTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(createTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置创建时间     *
     * 参数示例：<pre>20180614101942000+0800</pre>     
             * 此参数必填
          */
    public void setCreateTime(DateTime createTime) {
     	         	    this.createTime = DateUtil.format(createTime);
     	        }
    
        [DataMember(Order = 7)]
    private string currency;
    
        /**
       * @return 币种，币种，整个交易单使用同一个币种。值范围：USD,RMB,HKD,GBP,CAD,AUD,JPY,KRW,EUR
    */
        public string getCurrency() {
               	return currency;
            }
    
    /**
     * 设置币种，币种，整个交易单使用同一个币种。值范围：USD,RMB,HKD,GBP,CAD,AUD,JPY,KRW,EUR     *
     * 参数示例：<pre>EUR</pre>     
             * 此参数必填
          */
    public void setCurrency(string currency) {
     	         	    this.currency = currency;
     	        }
    
        [DataMember(Order = 8)]
    private long? id;
    
        /**
       * @return 交易id
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置交易id     *
     * 参数示例：<pre>1231231231111</pre>     
             * 此参数必填
          */
    public void setId(long id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 9)]
    private string modifyTime;
    
        /**
       * @return 修改时间
    */
        public DateTime? getModifyTime() {
                 if (modifyTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(modifyTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置修改时间     *
     * 参数示例：<pre>20180614101942000+0800</pre>     
             * 此参数必填
          */
    public void setModifyTime(DateTime modifyTime) {
     	         	    this.modifyTime = DateUtil.format(modifyTime);
     	        }
    
        [DataMember(Order = 10)]
    private string payTime;
    
        /**
       * @return 付款时间，如果有多次付款，这里返回的是首次付款时间
    */
        public DateTime? getPayTime() {
                 if (payTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(payTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置付款时间，如果有多次付款，这里返回的是首次付款时间     *
     * 参数示例：<pre>20180614101942000+0800</pre>     
             * 此参数必填
          */
    public void setPayTime(DateTime payTime) {
     	         	    this.payTime = DateUtil.format(payTime);
     	        }
    
        [DataMember(Order = 11)]
    private string receivingTime;
    
        /**
       * @return 收货时间，这里返回的是完全收货时间
    */
        public DateTime? getReceivingTime() {
                 if (receivingTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(receivingTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置收货时间，这里返回的是完全收货时间     *
     * 参数示例：<pre>20180614101942000+0800</pre>     
             * 此参数必填
          */
    public void setReceivingTime(DateTime receivingTime) {
     	         	    this.receivingTime = DateUtil.format(receivingTime);
     	        }
    
        [DataMember(Order = 12)]
    private decimal? refund;
    
        /**
       * @return 退款金额，单位为元
    */
        public decimal? getRefund() {
               	return refund;
            }
    
    /**
     * 设置退款金额，单位为元     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setRefund(decimal refund) {
     	         	    this.refund = refund;
     	        }
    
        [DataMember(Order = 13)]
    private string remark;
    
        /**
       * @return 备注，1688指下单时的备注
    */
        public string getRemark() {
               	return remark;
            }
    
    /**
     * 设置备注，1688指下单时的备注     *
     * 参数示例：<pre>备注</pre>     
             * 此参数必填
          */
    public void setRemark(string remark) {
     	         	    this.remark = remark;
     	        }
    
        [DataMember(Order = 14)]
    private string sellerID;
    
        /**
       * @return 卖家主账号id
    */
        public string getSellerID() {
               	return sellerID;
            }
    
    /**
     * 设置卖家主账号id     *
     * 参数示例：<pre>123123123123</pre>     
             * 此参数必填
          */
    public void setSellerID(string sellerID) {
     	         	    this.sellerID = sellerID;
     	        }
    
        [DataMember(Order = 15)]
    private string sellerMemo;
    
        /**
       * @return 卖家备忘信息
    */
        public string getSellerMemo() {
               	return sellerMemo;
            }
    
    /**
     * 设置卖家备忘信息     *
     * 参数示例：<pre>备忘</pre>     
             * 此参数必填
          */
    public void setSellerMemo(string sellerMemo) {
     	         	    this.sellerMemo = sellerMemo;
     	        }
    
        [DataMember(Order = 16)]
    private decimal? shippingFee;
    
        /**
       * @return 运费，单位为元
    */
        public decimal? getShippingFee() {
               	return shippingFee;
            }
    
    /**
     * 设置运费，单位为元     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setShippingFee(decimal shippingFee) {
     	         	    this.shippingFee = shippingFee;
     	        }
    
        [DataMember(Order = 17)]
    private string status;
    
        /**
       * @return 交易状态，waitbuyerpay:等待买家付款;waitsellersend:等待卖家发货;waitlogisticstakein:等待物流公司揽件;waitbuyerreceive:等待买家收货;waitbuyersign:等待买家签收;signinsuccess:买家已签收;confirm_goods:已收货;success:交易成功;cancel:交易取消;terminated:交易终止;未枚举:其他状态
    */
        public string getStatus() {
               	return status;
            }
    
    /**
     * 设置交易状态，waitbuyerpay:等待买家付款;waitsellersend:等待卖家发货;waitlogisticstakein:等待物流公司揽件;waitbuyerreceive:等待买家收货;waitbuyersign:等待买家签收;signinsuccess:买家已签收;confirm_goods:已收货;success:交易成功;cancel:交易取消;terminated:交易终止;未枚举:其他状态     *
     * 参数示例：<pre>waitbuyerpay</pre>     
             * 此参数必填
          */
    public void setStatus(string status) {
     	         	    this.status = status;
     	        }
    
        [DataMember(Order = 18)]
    private decimal? totalAmount;
    
        /**
       * @return 应付款总金额，totalAmount = ∑itemAmount + shippingFee，单位为元
    */
        public decimal? getTotalAmount() {
               	return totalAmount;
            }
    
    /**
     * 设置应付款总金额，totalAmount = ∑itemAmount + shippingFee，单位为元     *
     * 参数示例：<pre>1000</pre>     
             * 此参数必填
          */
    public void setTotalAmount(decimal totalAmount) {
     	         	    this.totalAmount = totalAmount;
     	        }
    
        [DataMember(Order = 19)]
    private string buyerRemarkIcon;
    
        /**
       * @return 买家备忘标志
    */
        public string getBuyerRemarkIcon() {
               	return buyerRemarkIcon;
            }
    
    /**
     * 设置买家备忘标志     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setBuyerRemarkIcon(string buyerRemarkIcon) {
     	         	    this.buyerRemarkIcon = buyerRemarkIcon;
     	        }
    
        [DataMember(Order = 20)]
    private string sellerRemarkIcon;
    
        /**
       * @return 卖家备忘标志
    */
        public string getSellerRemarkIcon() {
               	return sellerRemarkIcon;
            }
    
    /**
     * 设置卖家备忘标志     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setSellerRemarkIcon(string sellerRemarkIcon) {
     	         	    this.sellerRemarkIcon = sellerRemarkIcon;
     	        }
    
        [DataMember(Order = 21)]
    private long? discount;
    
        /**
       * @return 折扣信息，单位分
    */
        public long? getDiscount() {
               	return discount;
            }
    
    /**
     * 设置折扣信息，单位分     *
     * 参数示例：<pre>11</pre>     
             * 此参数必填
          */
    public void setDiscount(long discount) {
     	         	    this.discount = discount;
     	        }
    
        [DataMember(Order = 22)]
    private AlibabaTradeTradeContact buyerContact;
    
        /**
       * @return 买家联系人
    */
        public AlibabaTradeTradeContact getBuyerContact() {
               	return buyerContact;
            }
    
    /**
     * 设置买家联系人     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setBuyerContact(AlibabaTradeTradeContact buyerContact) {
     	         	    this.buyerContact = buyerContact;
     	        }
    
        [DataMember(Order = 23)]
    private string tradeType;
    
        /**
       * @return 1:担保交易
2:预存款交易
3:ETC境外收单交易
4:即时到帐交易
5:保障金安全交易
6:统一交易流程
7:分阶段付款
8.货到付款交易
9.信用凭证支付交易
10.账期支付交易，50060 交易4.0
    */
        public string getTradeType() {
               	return tradeType;
            }
    
    /**
     * 设置1:担保交易
2:预存款交易
3:ETC境外收单交易
4:即时到帐交易
5:保障金安全交易
6:统一交易流程
7:分阶段付款
8.货到付款交易
9.信用凭证支付交易
10.账期支付交易，50060 交易4.0     *
     * 参数示例：<pre>50060</pre>     
             * 此参数必填
          */
    public void setTradeType(string tradeType) {
     	         	    this.tradeType = tradeType;
     	        }
    
        [DataMember(Order = 24)]
    private string refundStatus;
    
        /**
       * @return 订单的售中退款状态，等待卖家同意：waitselleragree ，待买家修改：waitbuyermodify，等待买家退货：waitbuyersend，等待卖家确认收货：waitsellerreceive，退款成功：refundsuccess，退款失败：refundclose
    */
        public string getRefundStatus() {
               	return refundStatus;
            }
    
    /**
     * 设置订单的售中退款状态，等待卖家同意：waitselleragree ，待买家修改：waitbuyermodify，等待买家退货：waitbuyersend，等待卖家确认收货：waitsellerreceive，退款成功：refundsuccess，退款失败：refundclose     *
     * 参数示例：<pre>refundclose</pre>     
             * 此参数必填
          */
    public void setRefundStatus(string refundStatus) {
     	         	    this.refundStatus = refundStatus;
     	        }
    
        [DataMember(Order = 25)]
    private string refundStatusForAs;
    
        /**
       * @return 订单的售后退款状态
    */
        public string getRefundStatusForAs() {
               	return refundStatusForAs;
            }
    
    /**
     * 设置订单的售后退款状态     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRefundStatusForAs(string refundStatusForAs) {
     	         	    this.refundStatusForAs = refundStatusForAs;
     	        }
    
        [DataMember(Order = 26)]
    private long? refundPayment;
    
        /**
       * @return 退款金额
    */
        public long? getRefundPayment() {
               	return refundPayment;
            }
    
    /**
     * 设置退款金额     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setRefundPayment(long refundPayment) {
     	         	    this.refundPayment = refundPayment;
     	        }
    
        [DataMember(Order = 27)]
    private string idOfStr;
    
        /**
       * @return 交易id(字符串格式)
    */
        public string getIdOfStr() {
               	return idOfStr;
            }
    
    /**
     * 设置交易id(字符串格式)     *
     * 参数示例：<pre>123121212123</pre>     
             * 此参数必填
          */
    public void setIdOfStr(string idOfStr) {
     	         	    this.idOfStr = idOfStr;
     	        }
    
        [DataMember(Order = 28)]
    private string alipayTradeId;
    
        /**
       * @return 外部支付交易Id
    */
        public string getAlipayTradeId() {
               	return alipayTradeId;
            }
    
    /**
     * 设置外部支付交易Id     *
     * 参数示例：<pre>123123121111</pre>     
             * 此参数必填
          */
    public void setAlipayTradeId(string alipayTradeId) {
     	         	    this.alipayTradeId = alipayTradeId;
     	        }
    
        [DataMember(Order = 29)]
    private AlibabaTradeOrderReceiverInfo receiverInfo;
    
        /**
       * @return 收件人信息
    */
        public AlibabaTradeOrderReceiverInfo getReceiverInfo() {
               	return receiverInfo;
            }
    
    /**
     * 设置收件人信息     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setReceiverInfo(AlibabaTradeOrderReceiverInfo receiverInfo) {
     	         	    this.receiverInfo = receiverInfo;
     	        }
    
        [DataMember(Order = 30)]
    private string buyerLoginId;
    
        /**
       * @return 买家loginId，旺旺Id
    */
        public string getBuyerLoginId() {
               	return buyerLoginId;
            }
    
    /**
     * 设置买家loginId，旺旺Id     *
     * 参数示例：<pre>alitestforusv01</pre>     
             * 此参数必填
          */
    public void setBuyerLoginId(string buyerLoginId) {
     	         	    this.buyerLoginId = buyerLoginId;
     	        }
    
        [DataMember(Order = 31)]
    private string sellerLoginId;
    
        /**
       * @return 卖家oginId，旺旺Id
    */
        public string getSellerLoginId() {
               	return sellerLoginId;
            }
    
    /**
     * 设置卖家oginId，旺旺Id     *
     * 参数示例：<pre>alitestforusv02</pre>     
             * 此参数必填
          */
    public void setSellerLoginId(string sellerLoginId) {
     	         	    this.sellerLoginId = sellerLoginId;
     	        }
    
        [DataMember(Order = 32)]
    private long? buyerUserId;
    
        /**
       * @return 买家数字id
    */
        public long? getBuyerUserId() {
               	return buyerUserId;
            }
    
    /**
     * 设置买家数字id     *
     * 参数示例：<pre>12314144</pre>     
             * 此参数必填
          */
    public void setBuyerUserId(long buyerUserId) {
     	         	    this.buyerUserId = buyerUserId;
     	        }
    
        [DataMember(Order = 33)]
    private long? sellerUserId;
    
        /**
       * @return 卖家数字id
    */
        public long? getSellerUserId() {
               	return sellerUserId;
            }
    
    /**
     * 设置卖家数字id     *
     * 参数示例：<pre>12312422</pre>     
             * 此参数必填
          */
    public void setSellerUserId(long sellerUserId) {
     	         	    this.sellerUserId = sellerUserId;
     	        }
    
        [DataMember(Order = 34)]
    private string buyerAlipayId;
    
        /**
       * @return 买家支付宝id
    */
        public string getBuyerAlipayId() {
               	return buyerAlipayId;
            }
    
    /**
     * 设置买家支付宝id     *
     * 参数示例：<pre>12312311233</pre>     
             * 此参数必填
          */
    public void setBuyerAlipayId(string buyerAlipayId) {
     	         	    this.buyerAlipayId = buyerAlipayId;
     	        }
    
        [DataMember(Order = 35)]
    private string sellerAlipayId;
    
        /**
       * @return 卖家支付宝id
    */
        public string getSellerAlipayId() {
               	return sellerAlipayId;
            }
    
    /**
     * 设置卖家支付宝id     *
     * 参数示例：<pre>12312311111</pre>     
             * 此参数必填
          */
    public void setSellerAlipayId(string sellerAlipayId) {
     	         	    this.sellerAlipayId = sellerAlipayId;
     	        }
    
        [DataMember(Order = 36)]
    private string confirmedTime;
    
        /**
       * @return 确认时间
    */
        public DateTime? getConfirmedTime() {
                 if (confirmedTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(confirmedTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置确认时间     *
     * 参数示例：<pre>20180614101942000+0800</pre>     
             * 此参数必填
          */
    public void setConfirmedTime(DateTime confirmedTime) {
     	         	    this.confirmedTime = DateUtil.format(confirmedTime);
     	        }
    
        [DataMember(Order = 37)]
    private string closeReason;
    
        /**
       * @return 关闭原因。buyerCancel:买家取消订单，sellerGoodsLack:卖家库存不足，other:其它
    */
        public string getCloseReason() {
               	return closeReason;
            }
    
    /**
     * 设置关闭原因。buyerCancel:买家取消订单，sellerGoodsLack:卖家库存不足，other:其它     *
     * 参数示例：<pre>buyerCancel</pre>     
             * 此参数必填
          */
    public void setCloseReason(string closeReason) {
     	         	    this.closeReason = closeReason;
     	        }
    
        [DataMember(Order = 38)]
    private decimal? sumProductPayment;
    
        /**
       * @return 产品总金额(该订单产品明细表中的产品金额的和)，单位元
    */
        public decimal? getSumProductPayment() {
               	return sumProductPayment;
            }
    
    /**
     * 设置产品总金额(该订单产品明细表中的产品金额的和)，单位元     *
     * 参数示例：<pre>1212</pre>     
             * 此参数必填
          */
    public void setSumProductPayment(decimal sumProductPayment) {
     	         	    this.sumProductPayment = sumProductPayment;
     	        }
    
        [DataMember(Order = 39)]
    private AlibabaTradeStepOrderModel[] stepOrderList;
    
        /**
       * @return [交易3.0]分阶段交易，分阶段订单list
    */
        public AlibabaTradeStepOrderModel[] getStepOrderList() {
               	return stepOrderList;
            }
    
    /**
     * 设置[交易3.0]分阶段交易，分阶段订单list     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStepOrderList(AlibabaTradeStepOrderModel[] stepOrderList) {
     	         	    this.stepOrderList = stepOrderList;
     	        }
    
        [DataMember(Order = 40)]
    private string stepAgreementPath;
    
        /**
       * @return 分阶段法务协议地址
    */
        public string getStepAgreementPath() {
               	return stepAgreementPath;
            }
    
    /**
     * 设置分阶段法务协议地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStepAgreementPath(string stepAgreementPath) {
     	         	    this.stepAgreementPath = stepAgreementPath;
     	        }
    
        [DataMember(Order = 41)]
    private bool? stepPayAll;
    
        /**
       * @return 是否一次性付款
    */
        public bool? getStepPayAll() {
               	return stepPayAll;
            }
    
    /**
     * 设置是否一次性付款     *
     * 参数示例：<pre>false</pre>     
             * 此参数必填
          */
    public void setStepPayAll(bool stepPayAll) {
     	         	    this.stepPayAll = stepPayAll;
     	        }
    
        [DataMember(Order = 42)]
    private string buyerFeedback;
    
        /**
       * @return 买家留言，不超过500字
    */
        public string getBuyerFeedback() {
               	return buyerFeedback;
            }
    
    /**
     * 设置买家留言，不超过500字     *
     * 参数示例：<pre>留言</pre>     
             * 此参数必填
          */
    public void setBuyerFeedback(string buyerFeedback) {
     	         	    this.buyerFeedback = buyerFeedback;
     	        }
    
        [DataMember(Order = 43)]
    private bool? overSeaOrder;
    
        /**
       * @return 是否海外代发订单，是：true
    */
        public bool? getOverSeaOrder() {
               	return overSeaOrder;
            }
    
    /**
     * 设置是否海外代发订单，是：true     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setOverSeaOrder(bool overSeaOrder) {
     	         	    this.overSeaOrder = overSeaOrder;
     	        }
    
        [DataMember(Order = 44)]
    private string subBuyerLoginId;
    
        /**
       * @return 买家子账号
    */
        public string getSubBuyerLoginId() {
               	return subBuyerLoginId;
            }
    
    /**
     * 设置买家子账号     *
     * 参数示例：<pre>alitestforusv02:temp</pre>     
             * 此参数必填
          */
    public void setSubBuyerLoginId(string subBuyerLoginId) {
     	         	    this.subBuyerLoginId = subBuyerLoginId;
     	        }
    
        [DataMember(Order = 45)]
    private bool? sellerOrder;
    
        /**
       * @return 是否自主订单（邀约订单）
    */
        public bool? getSellerOrder() {
               	return sellerOrder;
            }
    
    /**
     * 设置是否自主订单（邀约订单）     *
     * 参数示例：<pre>false</pre>     
             * 此参数必填
          */
    public void setSellerOrder(bool sellerOrder) {
     	         	    this.sellerOrder = sellerOrder;
     	        }
    
        [DataMember(Order = 46)]
    private long? preOrderId;
    
        /**
       * @return 预订单ID
    */
        public long? getPreOrderId() {
               	return preOrderId;
            }
    
    /**
     * 设置预订单ID     *
     * 参数示例：<pre>123123</pre>     
             * 此参数必填
          */
    public void setPreOrderId(long preOrderId) {
     	         	    this.preOrderId = preOrderId;
     	        }
    
        [DataMember(Order = 47)]
    private string refundId;
    
        /**
       * @return 退款单ID
    */
        public string getRefundId() {
               	return refundId;
            }
    
    /**
     * 设置退款单ID     *
     * 参数示例：<pre>TQ4562212313</pre>     
             * 此参数必填
          */
    public void setRefundId(string refundId) {
     	         	    this.refundId = refundId;
     	        }
    
        [DataMember(Order = 48)]
    private string flowTemplateCode;
    
        /**
       * @return 4.0交易流程模板code
    */
        public string getFlowTemplateCode() {
               	return flowTemplateCode;
            }
    
    /**
     * 设置4.0交易流程模板code     *
     * 参数示例：<pre>flow</pre>     
             * 此参数必填
          */
    public void setFlowTemplateCode(string flowTemplateCode) {
     	         	    this.flowTemplateCode = flowTemplateCode;
     	        }
    
        [DataMember(Order = 49)]
    private string buyerLevel;
    
        /**
       * @return 买家等级
    */
        public string getBuyerLevel() {
               	return buyerLevel;
            }
    
    /**
     * 设置买家等级     *
     * 参数示例：<pre>L1</pre>     
             * 此参数必填
          */
    public void setBuyerLevel(string buyerLevel) {
     	         	    this.buyerLevel = buyerLevel;
     	        }
    
        [DataMember(Order = 50)]
    private string sellerCreditLevel;
    
        /**
       * @return 卖家诚信等级
    */
        public string getSellerCreditLevel() {
               	return sellerCreditLevel;
            }
    
    /**
     * 设置卖家诚信等级     *
     * 参数示例：<pre>L1</pre>     
             * 此参数必填
          */
    public void setSellerCreditLevel(string sellerCreditLevel) {
     	         	    this.sellerCreditLevel = sellerCreditLevel;
     	        }
    
        [DataMember(Order = 51)]
    private AlibabaTradeTradeSellerContact sellerContact;
    
        /**
       * @return 卖家联系人信息
    */
        public AlibabaTradeTradeSellerContact getSellerContact() {
               	return sellerContact;
            }
    
    /**
     * 设置卖家联系人信息     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setSellerContact(AlibabaTradeTradeSellerContact sellerContact) {
     	         	    this.sellerContact = sellerContact;
     	        }
    
        [DataMember(Order = 52)]
    private AlibabaTradeBizNewStepOrderModel[] newStepOrderList;
    
        /**
       * @return [交易4.0]分阶段交易，分阶段订单list
    */
        public AlibabaTradeBizNewStepOrderModel[] getNewStepOrderList() {
               	return newStepOrderList;
            }
    
    /**
     * 设置[交易4.0]分阶段交易，分阶段订单list     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setNewStepOrderList(AlibabaTradeBizNewStepOrderModel[] newStepOrderList) {
     	         	    this.newStepOrderList = newStepOrderList;
     	        }
    
        [DataMember(Order = 53)]
    private string closeRemark;
    
        /**
       * @return 关闭订单备注
    */
        public string getCloseRemark() {
               	return closeRemark;
            }
    
    /**
     * 设置关闭订单备注     *
     * 参数示例：<pre>备注</pre>     
             * 此参数必填
          */
    public void setCloseRemark(string closeRemark) {
     	         	    this.closeRemark = closeRemark;
     	        }
    
        [DataMember(Order = 54)]
    private string closeOperateType;
    
        /**
       * @return 关闭订单操作类型。CLOSE_TRADE_BY_SELLER:卖家关闭交易,CLOSE_TRADE_BY_BOPS:BOPS后台关闭交易,CLOSE_TRADE_BY_SYSTEM:系统（超时）关闭交易,CLOSE_TRADE_BY_BUYER:买家关闭交易,CLOSE_TRADE_BY_CREADIT:诚信保障投诉关闭
    */
        public string getCloseOperateType() {
               	return closeOperateType;
            }
    
    /**
     * 设置关闭订单操作类型。CLOSE_TRADE_BY_SELLER:卖家关闭交易,CLOSE_TRADE_BY_BOPS:BOPS后台关闭交易,CLOSE_TRADE_BY_SYSTEM:系统（超时）关闭交易,CLOSE_TRADE_BY_BUYER:买家关闭交易,CLOSE_TRADE_BY_CREADIT:诚信保障投诉关闭     *
     * 参数示例：<pre>CLOSE_TRADE_BY_SELLER</pre>     
             * 此参数必填
          */
    public void setCloseOperateType(string closeOperateType) {
     	         	    this.closeOperateType = closeOperateType;
     	        }
    
        [DataMember(Order = 55)]
    private decimal? couponFee;
    
        /**
       * @return 红包金额，实付金额（totalAmount）已经计算过红包金额
    */
        public decimal? getCouponFee() {
               	return couponFee;
            }
    
    /**
     * 设置红包金额，实付金额（totalAmount）已经计算过红包金额     *
     * 参数示例：<pre>7.5</pre>     
             * 此参数必填
          */
    public void setCouponFee(decimal couponFee) {
     	         	    this.couponFee = couponFee;
     	        }
    
        [DataMember(Order = 56)]
    private string tradeTypeDesc;
    
        /**
       * @return 下单时指定的交易方式
    */
        public string getTradeTypeDesc() {
               	return tradeTypeDesc;
            }
    
    /**
     * 设置下单时指定的交易方式     *
     * 参数示例：<pre>担保交易</pre>     
             * 此参数必填
          */
    public void setTradeTypeDesc(string tradeTypeDesc) {
     	         	    this.tradeTypeDesc = tradeTypeDesc;
     	        }
    
        [DataMember(Order = 57)]
    private string[] payChannelList;
    
        /**
       * @return 支付渠道名称列表。一笔订单可能存在多种支付渠道。枚举值：支付宝,网商银行信任付,诚e赊,对公转账,赊销宝,账期支付,合并支付渠道,支付平台,声明付款,网商电子银行承兑汇票,银行转账,跨境宝,红包,其它
    */
        public string[] getPayChannelList() {
               	return payChannelList;
            }
    
    /**
     * 设置支付渠道名称列表。一笔订单可能存在多种支付渠道。枚举值：支付宝,网商银行信任付,诚e赊,对公转账,赊销宝,账期支付,合并支付渠道,支付平台,声明付款,网商电子银行承兑汇票,银行转账,跨境宝,红包,其它     *
     * 参数示例：<pre>["支付宝","跨境宝","银行转账"]</pre>     
             * 此参数必填
          */
    public void setPayChannelList(string[] payChannelList) {
     	         	    this.payChannelList = payChannelList;
     	        }
    
        [DataMember(Order = 58)]
    private string tradeTypeCode;
    
        /**
       * @return 下单时指定的交易方式tradeType
    */
        public string getTradeTypeCode() {
               	return tradeTypeCode;
            }
    
    /**
     * 设置下单时指定的交易方式tradeType     *
     * 参数示例：<pre>assureTrade</pre>     
             * 此参数必填
          */
    public void setTradeTypeCode(string tradeTypeCode) {
     	         	    this.tradeTypeCode = tradeTypeCode;
     	        }
    
    
  }
}