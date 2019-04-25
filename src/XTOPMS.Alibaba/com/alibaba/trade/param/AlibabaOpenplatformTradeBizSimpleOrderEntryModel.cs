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
public class AlibabaOpenplatformTradeBizSimpleOrderEntryModel {

       [DataMember(Order = 1)]
    private string buyerAlipayId;
    
        /**
       * @return 
    */
        public string getBuyerAlipayId() {
               	return buyerAlipayId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerAlipayId(string buyerAlipayId) {
     	         	    this.buyerAlipayId = buyerAlipayId;
     	        }
    
        [DataMember(Order = 2)]
    private string buyerLoginId;
    
        /**
       * @return 
    */
        public string getBuyerLoginId() {
               	return buyerLoginId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerLoginId(string buyerLoginId) {
     	         	    this.buyerLoginId = buyerLoginId;
     	        }
    
        [DataMember(Order = 3)]
    private string buyerMemberId;
    
        /**
       * @return 
    */
        public string getBuyerMemberId() {
               	return buyerMemberId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerMemberId(string buyerMemberId) {
     	         	    this.buyerMemberId = buyerMemberId;
     	        }
    
        [DataMember(Order = 4)]
    private long? buyerUserId;
    
        /**
       * @return 
    */
        public long? getBuyerUserId() {
               	return buyerUserId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerUserId(long buyerUserId) {
     	         	    this.buyerUserId = buyerUserId;
     	        }
    
        [DataMember(Order = 5)]
    private long? id;
    
        /**
       * @return 
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置     *
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
       * @return 
    */
        public string getSellerAlipayId() {
               	return sellerAlipayId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerAlipayId(string sellerAlipayId) {
     	         	    this.sellerAlipayId = sellerAlipayId;
     	        }
    
        [DataMember(Order = 8)]
    private string sellerLoginId;
    
        /**
       * @return 
    */
        public string getSellerLoginId() {
               	return sellerLoginId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerLoginId(string sellerLoginId) {
     	         	    this.sellerLoginId = sellerLoginId;
     	        }
    
        [DataMember(Order = 9)]
    private string sellerMemberId;
    
        /**
       * @return 
    */
        public string getSellerMemberId() {
               	return sellerMemberId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerMemberId(string sellerMemberId) {
     	         	    this.sellerMemberId = sellerMemberId;
     	        }
    
        [DataMember(Order = 10)]
    private long? sellerUserId;
    
        /**
       * @return 
    */
        public long? getSellerUserId() {
               	return sellerUserId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerUserId(long sellerUserId) {
     	         	    this.sellerUserId = sellerUserId;
     	        }
    
        [DataMember(Order = 11)]
    private long? subBuyerUserId;
    
        /**
       * @return 
    */
        public long? getSubBuyerUserId() {
               	return subBuyerUserId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubBuyerUserId(long subBuyerUserId) {
     	         	    this.subBuyerUserId = subBuyerUserId;
     	        }
    
        [DataMember(Order = 12)]
    private long? succSumPayment;
    
        /**
       * @return 
    */
        public long? getSuccSumPayment() {
               	return succSumPayment;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSuccSumPayment(long succSumPayment) {
     	         	    this.succSumPayment = succSumPayment;
     	        }
    
        [DataMember(Order = 13)]
    private long? tbId;
    
        /**
       * @return 
    */
        public long? getTbId() {
               	return tbId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTbId(long tbId) {
     	         	    this.tbId = tbId;
     	        }
    
        [DataMember(Order = 14)]
    private string tradeTypeStr;
    
        /**
       * @return 
    */
        public string getTradeTypeStr() {
               	return tradeTypeStr;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTradeTypeStr(string tradeTypeStr) {
     	         	    this.tradeTypeStr = tradeTypeStr;
     	        }
    
    
  }
}