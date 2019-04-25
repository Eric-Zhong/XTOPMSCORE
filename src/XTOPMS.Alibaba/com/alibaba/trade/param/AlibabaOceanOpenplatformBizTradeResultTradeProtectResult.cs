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
public class AlibabaOceanOpenplatformBizTradeResultTradeProtectResult {

       [DataMember(Order = 1)]
    private string orderId;
    
        /**
       * @return 订单ID
    */
        public string getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置订单ID     *
     * 参数示例：<pre>12344</pre>     
             * 此参数必填
          */
    public void setOrderId(string orderId) {
     	         	    this.orderId = orderId;
     	        }
    
    
  }
}