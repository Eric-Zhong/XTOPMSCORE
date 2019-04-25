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
public class AlibabaOpenplatformTradeBizSimpleOrderModel {

       [DataMember(Order = 1)]
    private string buyerAlipayId;
    
        /**
       * @return 买家支付宝id
    */
        public string getBuyerAlipayId() {
               	return buyerAlipayId;
            }
    
    /**
     * 设置买家支付宝id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerAlipayId(string buyerAlipayId) {
     	         	    this.buyerAlipayId = buyerAlipayId;
     	        }
    
        [DataMember(Order = 2)]
    private string buyerLoginId;
    
        /**
       * @return 买家中文站会员登录ID
    */
        public string getBuyerLoginId() {
               	return buyerLoginId;
            }
    
    /**
     * 设置买家中文站会员登录ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerLoginId(string buyerLoginId) {
     	         	    this.buyerLoginId = buyerLoginId;
     	        }
    
        [DataMember(Order = 3)]
    private string buyerMemberId;
    
        /**
       * @return 买家中文站会员ID
    */
        public string getBuyerMemberId() {
               	return buyerMemberId;
            }
    
    /**
     * 设置买家中文站会员ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerMemberId(string buyerMemberId) {
     	         	    this.buyerMemberId = buyerMemberId;
     	        }
    
        [DataMember(Order = 4)]
    private long? buyerUserId;
    
        /**
       * @return 买家阿里帐号ID(包括淘宝帐号Id)
    */
        public long? getBuyerUserId() {
               	return buyerUserId;
            }
    
    /**
     * 设置买家阿里帐号ID(包括淘宝帐号Id)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerUserId(long buyerUserId) {
     	         	    this.buyerUserId = buyerUserId;
     	        }
    
        [DataMember(Order = 5)]
    private long? id;
    
        /**
       * @return 订单主键ID
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置订单主键ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setId(long id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 6)]
    private string outOrderId;
    
        /**
       * @return 
    */
        public string getOutOrderId() {
               	return outOrderId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOutOrderId(string outOrderId) {
     	         	    this.outOrderId = outOrderId;
     	        }
    
        [DataMember(Order = 7)]
    private string sellerAlipayId;
    
        /**
       * @return 卖家支付宝id
    */
        public string getSellerAlipayId() {
               	return sellerAlipayId;
            }
    
    /**
     * 设置卖家支付宝id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerAlipayId(string sellerAlipayId) {
     	         	    this.sellerAlipayId = sellerAlipayId;
     	        }
    
        [DataMember(Order = 8)]
    private string sellerLoginId;
    
        /**
       * @return 卖家中文站会员登录ID
    */
        public string getSellerLoginId() {
               	return sellerLoginId;
            }
    
    /**
     * 设置卖家中文站会员登录ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerLoginId(string sellerLoginId) {
     	         	    this.sellerLoginId = sellerLoginId;
     	        }
    
        [DataMember(Order = 9)]
    private string sellerMemberId;
    
        /**
       * @return 卖家中文站会员ID
    */
        public string getSellerMemberId() {
               	return sellerMemberId;
            }
    
    /**
     * 设置卖家中文站会员ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerMemberId(string sellerMemberId) {
     	         	    this.sellerMemberId = sellerMemberId;
     	        }
    
        [DataMember(Order = 10)]
    private long? sellerUserId;
    
        /**
       * @return 卖家阿里帐号ID(包括淘宝帐号Id)
    */
        public long? getSellerUserId() {
               	return sellerUserId;
            }
    
    /**
     * 设置卖家阿里帐号ID(包括淘宝帐号Id)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerUserId(long sellerUserId) {
     	         	    this.sellerUserId = sellerUserId;
     	        }
    
        [DataMember(Order = 11)]
    private long? subBuyerUserId;
    
        /**
       * @return 买家子帐号ID
    */
        public long? getSubBuyerUserId() {
               	return subBuyerUserId;
            }
    
    /**
     * 设置买家子帐号ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubBuyerUserId(long subBuyerUserId) {
     	         	    this.subBuyerUserId = subBuyerUserId;
     	        }
    
        [DataMember(Order = 12)]
    private long? succSumPayment;
    
        /**
       * @return 应付款金额
    */
        public long? getSuccSumPayment() {
               	return succSumPayment;
            }
    
    /**
     * 设置应付款金额     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSuccSumPayment(long succSumPayment) {
     	         	    this.succSumPayment = succSumPayment;
     	        }
    
        [DataMember(Order = 13)]
    private long? tbId;
    
        /**
       * @return 淘宝订单主键ID
    */
        public long? getTbId() {
               	return tbId;
            }
    
    /**
     * 设置淘宝订单主键ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTbId(long tbId) {
     	         	    this.tbId = tbId;
     	        }
    
        [DataMember(Order = 14)]
    private string tradeTypeStr;
    
        /**
       * @return 交易类型
    */
        public string getTradeTypeStr() {
               	return tradeTypeStr;
            }
    
    /**
     * 设置交易类型     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTradeTypeStr(string tradeTypeStr) {
     	         	    this.tradeTypeStr = tradeTypeStr;
     	        }
    
        [DataMember(Order = 15)]
    private AlibabaOpenplatformTradeBizSimpleOrderEntryModel[] orderEntryModel;
    
        /**
       * @return 子订单明细,简易的子订单模型
    */
        public AlibabaOpenplatformTradeBizSimpleOrderEntryModel[] getOrderEntryModel() {
               	return orderEntryModel;
            }
    
    /**
     * 设置子订单明细,简易的子订单模型     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderEntryModel(AlibabaOpenplatformTradeBizSimpleOrderEntryModel[] orderEntryModel) {
     	         	    this.orderEntryModel = orderEntryModel;
     	        }
    
    
  }
}