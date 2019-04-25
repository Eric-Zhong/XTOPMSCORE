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
public class AlibabaPaymentOrderBankCreateParam : GatewayAPIRequest {

    public AlibabaPaymentOrderBankCreateParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.payment.order.bank.create",2);
	}
	
       [DataMember(Order = 1)]
    private long? orderId;
    
        /**
       * @return 采购结算单ID
    */
        public long? getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置采购结算单ID     *
     * 参数示例：<pre>1515615</pre>     
             * 此参数必填
          */
    public void setOrderId(long orderId) {
     	         	    this.orderId = orderId;
     	        }
    
    
  }
}