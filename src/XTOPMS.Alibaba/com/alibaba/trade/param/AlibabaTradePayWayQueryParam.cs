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
public class AlibabaTradePayWayQueryParam : GatewayAPIRequest {

    public AlibabaTradePayWayQueryParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.payWay.query",1);
	}
	
       [DataMember(Order = 1)]
    private string orderId;
    
        /**
       * @return 订单号
    */
        public string getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置订单号     *
     * 参数示例：<pre>123123</pre>     
             * 此参数必填
          */
    public void setOrderId(string orderId) {
     	         	    this.orderId = orderId;
     	        }
    
    
  }
}