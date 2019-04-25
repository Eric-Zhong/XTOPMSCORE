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
public class AlibabaTradeCrossResult {

       [DataMember(Order = 1)]
    private long? totalSuccessAmount;
    
        /**
       * @return 订单总金额（单位分），一次创建多个订单时，该字段为空
    */
        public long? getTotalSuccessAmount() {
               	return totalSuccessAmount;
            }
    
    /**
     * 设置订单总金额（单位分），一次创建多个订单时，该字段为空     *
     * 参数示例：<pre>100</pre>     
             * 此参数必填
          */
    public void setTotalSuccessAmount(long totalSuccessAmount) {
     	         	    this.totalSuccessAmount = totalSuccessAmount;
     	        }
    
        [DataMember(Order = 2)]
    private string orderId;
    
        /**
       * @return 订单ID，一次创建多个订单时，该字段为空
    */
        public string getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置订单ID，一次创建多个订单时，该字段为空     *
     * 参数示例：<pre>111111111</pre>     
             * 此参数必填
          */
    public void setOrderId(string orderId) {
     	         	    this.orderId = orderId;
     	        }
    
        [DataMember(Order = 3)]
    private bool? success;
    
        /**
       * @return 是否成功
    */
        public bool? getSuccess() {
               	return success;
            }
    
    /**
     * 设置是否成功     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setSuccess(bool success) {
     	         	    this.success = success;
     	        }
    
        [DataMember(Order = 4)]
    private string code;
    
        /**
       * @return 错误码
    */
        public string getCode() {
               	return code;
            }
    
    /**
     * 设置错误码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCode(string code) {
     	         	    this.code = code;
     	        }
    
        [DataMember(Order = 5)]
    private string message;
    
        /**
       * @return 错误信息
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置错误信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
        [DataMember(Order = 6)]
    private AlibabaTradeCrossPeriod accountPeriod;
    
        /**
       * @return 账期信息，非账期支付订单返回空
    */
        public AlibabaTradeCrossPeriod getAccountPeriod() {
               	return accountPeriod;
            }
    
    /**
     * 设置账期信息，非账期支付订单返回空     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAccountPeriod(AlibabaTradeCrossPeriod accountPeriod) {
     	         	    this.accountPeriod = accountPeriod;
     	        }
    
        [DataMember(Order = 7)]
    private AlibabaTradeFastOffer[] failedOfferList;
    
        /**
       * @return 失败商品信息
    */
        public AlibabaTradeFastOffer[] getFailedOfferList() {
               	return failedOfferList;
            }
    
    /**
     * 设置失败商品信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFailedOfferList(AlibabaTradeFastOffer[] failedOfferList) {
     	         	    this.failedOfferList = failedOfferList;
     	        }
    
        [DataMember(Order = 8)]
    private long? postFee;
    
        /**
       * @return 运费，单位：分，一次创建多个订单时，该字段为空
    */
        public long? getPostFee() {
               	return postFee;
            }
    
    /**
     * 设置运费，单位：分，一次创建多个订单时，该字段为空     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPostFee(long postFee) {
     	         	    this.postFee = postFee;
     	        }
    
    
  }
}