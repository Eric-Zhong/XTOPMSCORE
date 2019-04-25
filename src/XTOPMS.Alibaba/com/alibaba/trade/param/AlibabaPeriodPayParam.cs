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
public class AlibabaPeriodPayParam : GatewayAPIRequest {

    public AlibabaPeriodPayParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.period.pay",1);
	}
	
       [DataMember(Order = 1)]
    private long? orderId;
    
        /**
       * @return 订单号
    */
        public long? getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置订单号     *
     * 参数示例：<pre>201248543076615400</pre>     
             * 此参数必填
          */
    public void setOrderId(long orderId) {
     	         	    this.orderId = orderId;
     	        }
    
    
  }
}