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
public class AlibabaOceanOpenplatformBizTradeResultTradePayTypeResult {

       [DataMember(Order = 1)]
    private AlibabaOceanOpenplatformBizTradeResultPayTypeInfo[] channels;
    
        /**
       * @return 可用支付渠道列表
    */
        public AlibabaOceanOpenplatformBizTradeResultPayTypeInfo[] getChannels() {
               	return channels;
            }
    
    /**
     * 设置可用支付渠道列表     *
     * 参数示例：<pre>[]</pre>     
             * 此参数必填
          */
    public void setChannels(AlibabaOceanOpenplatformBizTradeResultPayTypeInfo[] channels) {
     	         	    this.channels = channels;
     	        }
    
        [DataMember(Order = 2)]
    private string orderId;
    
        /**
       * @return 订单号
    */
        public string getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置订单号     *
     * 参数示例：<pre>1231231211</pre>     
             * 此参数必填
          */
    public void setOrderId(string orderId) {
     	         	    this.orderId = orderId;
     	        }
    
        [DataMember(Order = 3)]
    private long? payFee;
    
        /**
       * @return 支付金额，单位分
    */
        public long? getPayFee() {
               	return payFee;
            }
    
    /**
     * 设置支付金额，单位分     *
     * 参数示例：<pre>100</pre>     
             * 此参数必填
          */
    public void setPayFee(long payFee) {
     	         	    this.payFee = payFee;
     	        }
    
        [DataMember(Order = 4)]
    private string timeout;
    
        /**
       * @return 最晚支付时间
    */
        public string getTimeout() {
               	return timeout;
            }
    
    /**
     * 设置最晚支付时间     *
     * 参数示例：<pre>2018-10-01 00:00:00</pre>     
             * 此参数必填
          */
    public void setTimeout(string timeout) {
     	         	    this.timeout = timeout;
     	        }
    
    
  }
}