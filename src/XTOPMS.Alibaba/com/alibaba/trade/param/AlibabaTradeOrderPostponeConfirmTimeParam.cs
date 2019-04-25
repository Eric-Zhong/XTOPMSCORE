using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.trade.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaTradeOrderPostponeConfirmTimeParam : GatewayAPIRequest {

    public AlibabaTradeOrderPostponeConfirmTimeParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.order.PostponeConfirmTime",1);
	}
	
       [DataMember(Order = 1)]
    private long? orderId;
    
        /**
       * @return 订单ID
    */
        public long? getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置订单ID     *
     * 参数示例：<pre>198263322216969811</pre>     
             * 此参数必填
          */
    public void setOrderId(long orderId) {
     	         	    this.orderId = orderId;
     	        }
    
        [DataMember(Order = 2)]
    private long? subPayOrderId;
    
        /**
       * @return 子支付单号，如果传递，该值必须是真实的subPayOrderId
    */
        public long? getSubPayOrderId() {
               	return subPayOrderId;
            }
    
    /**
     * 设置子支付单号，如果传递，该值必须是真实的subPayOrderId     *
     * 参数示例：<pre>1357925445454</pre>     
             * 此参数必填
          */
    public void setSubPayOrderId(long subPayOrderId) {
     	         	    this.subPayOrderId = subPayOrderId;
     	        }
    
        [DataMember(Order = 3)]
    private int? delayedDays;
    
        /**
       * @return 延迟时间（天）
    */
        public int? getDelayedDays() {
               	return delayedDays;
            }
    
    /**
     * 设置延迟时间（天）     *
     * 参数示例：<pre>7</pre>     
             * 此参数必填
          */
    public void setDelayedDays(int delayedDays) {
     	         	    this.delayedDays = delayedDays;
     	        }
    
    
  }
}