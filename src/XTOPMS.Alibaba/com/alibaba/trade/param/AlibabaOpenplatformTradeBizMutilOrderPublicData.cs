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
public class AlibabaOpenplatformTradeBizMutilOrderPublicData {

       [DataMember(Order = 1)]
    private string bizType;
    
        /**
       * @return 页面级别的业务场景. 比如: 零售通(完整独立的订购页面)
    */
        public string getBizType() {
               	return bizType;
            }
    
    /**
     * 设置页面级别的业务场景. 比如: 零售通(完整独立的订购页面)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBizType(string bizType) {
     	         	    this.bizType = bizType;
     	        }
    
        [DataMember(Order = 2)]
    private long? freeCarriageMinProductAmount;
    
        /**
       * @return 零售通全场满包邮产品总金额
    */
        public long? getFreeCarriageMinProductAmount() {
               	return freeCarriageMinProductAmount;
            }
    
    /**
     * 设置零售通全场满包邮产品总金额     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFreeCarriageMinProductAmount(long freeCarriageMinProductAmount) {
     	         	    this.freeCarriageMinProductAmount = freeCarriageMinProductAmount;
     	        }
    
        [DataMember(Order = 3)]
    private long? sumPaymentLimitMin;
    
        /**
       * @return 页面级别的显示条件, 所有订单总金额之和的最小值。单位：分
    */
        public long? getSumPaymentLimitMin() {
               	return sumPaymentLimitMin;
            }
    
    /**
     * 设置页面级别的显示条件, 所有订单总金额之和的最小值。单位：分     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSumPaymentLimitMin(long sumPaymentLimitMin) {
     	         	    this.sumPaymentLimitMin = sumPaymentLimitMin;
     	        }
    
        [DataMember(Order = 4)]
    private bool? supportFreeCarriage;
    
        /**
       * @return 是否支持零售通全场满包邮
    */
        public bool? getSupportFreeCarriage() {
               	return supportFreeCarriage;
            }
    
    /**
     * 设置是否支持零售通全场满包邮     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSupportFreeCarriage(bool supportFreeCarriage) {
     	         	    this.supportFreeCarriage = supportFreeCarriage;
     	        }
    
        [DataMember(Order = 5)]
    private bool? supportInvoice;
    
        /**
       * @return 当页面所有的订单都支持发票时=true，页面中有一个订单块不支持发票 = false
    */
        public bool? getSupportInvoice() {
               	return supportInvoice;
            }
    
    /**
     * 设置当页面所有的订单都支持发票时=true，页面中有一个订单块不支持发票 = false     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSupportInvoice(bool supportInvoice) {
     	         	    this.supportInvoice = supportInvoice;
     	        }
    
    
  }
}