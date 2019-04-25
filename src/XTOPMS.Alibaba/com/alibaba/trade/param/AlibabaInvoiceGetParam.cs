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
public class AlibabaInvoiceGetParam : GatewayAPIRequest {

    public AlibabaInvoiceGetParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.invoice.get",1);
	}
	
       [DataMember(Order = 1)]
    private long? orderId;
    
        /**
       * @return 发票所关联的订单ID
    */
        public long? getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置发票所关联的订单ID     *
     * 参数示例：<pre>192516096574969811</pre>     
             * 此参数必填
          */
    public void setOrderId(long orderId) {
     	         	    this.orderId = orderId;
     	        }
    
    
  }
}