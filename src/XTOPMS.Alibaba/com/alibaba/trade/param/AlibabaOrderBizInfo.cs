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
public class AlibabaOrderBizInfo {

       [DataMember(Order = 1)]
    private bool? odsCyd;
    
        /**
       * @return 是否采源宝订单
    */
        public bool? getOdsCyd() {
               	return odsCyd;
            }
    
    /**
     * 设置是否采源宝订单     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setOdsCyd(bool odsCyd) {
     	         	    this.odsCyd = odsCyd;
     	        }
    
        [DataMember(Order = 2)]
    private string accountPeriodTime;
    
        /**
       * @return 账期交易订单的到账时间
    */
        public string getAccountPeriodTime() {
               	return accountPeriodTime;
            }
    
    /**
     * 设置账期交易订单的到账时间     *
     * 参数示例：<pre>yyyy-MM-dd HH:mm:ss</pre>     
             * 此参数必填
          */
    public void setAccountPeriodTime(string accountPeriodTime) {
     	         	    this.accountPeriodTime = accountPeriodTime;
     	        }
    
        [DataMember(Order = 3)]
    private bool? creditOrder;
    
        /**
       * @return 为true，表示下单时选择了诚e赊交易方式。注意不等同于“诚e赊支付”，支付时有可能是支付宝付款，具体支付方式查询tradeTerms.payWay
    */
        public bool? getCreditOrder() {
               	return creditOrder;
            }
    
    /**
     * 设置为true，表示下单时选择了诚e赊交易方式。注意不等同于“诚e赊支付”，支付时有可能是支付宝付款，具体支付方式查询tradeTerms.payWay     *
     * 参数示例：<pre>false</pre>     
             * 此参数必填
          */
    public void setCreditOrder(bool creditOrder) {
     	         	    this.creditOrder = creditOrder;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaCreditOrderForDetail creditOrderDetail;
    
        /**
       * @return 诚e赊支付详情，只有使用诚e赊付款时返回
    */
        public AlibabaCreditOrderForDetail getCreditOrderDetail() {
               	return creditOrderDetail;
            }
    
    /**
     * 设置诚e赊支付详情，只有使用诚e赊付款时返回     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCreditOrderDetail(AlibabaCreditOrderForDetail creditOrderDetail) {
     	         	    this.creditOrderDetail = creditOrderDetail;
     	        }
    
        [DataMember(Order = 5)]
    private AlibabaOrderPreOrderForRead preOrderInfo;
    
        /**
       * @return 预订单信息
    */
        public AlibabaOrderPreOrderForRead getPreOrderInfo() {
               	return preOrderInfo;
            }
    
    /**
     * 设置预订单信息     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setPreOrderInfo(AlibabaOrderPreOrderForRead preOrderInfo) {
     	         	    this.preOrderInfo = preOrderInfo;
     	        }
    
        [DataMember(Order = 6)]
    private AlibabaLstTradeInfo lstOrderInfo;
    
        /**
       * @return 零售通订单信息
    */
        public AlibabaLstTradeInfo getLstOrderInfo() {
               	return lstOrderInfo;
            }
    
    /**
     * 设置零售通订单信息     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setLstOrderInfo(AlibabaLstTradeInfo lstOrderInfo) {
     	         	    this.lstOrderInfo = lstOrderInfo;
     	        }
    
    
  }
}