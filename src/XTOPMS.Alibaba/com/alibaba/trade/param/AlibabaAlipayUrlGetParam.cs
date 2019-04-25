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
public class AlibabaAlipayUrlGetParam : GatewayAPIRequest {

    public AlibabaAlipayUrlGetParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.alipay.url.get",1);
	}
	
       [DataMember(Order = 1)]
    private long[] orderIdList;
    
        /**
       * @return 订单Id列表,最多批量30个订单，订单过多会导致超时，建议一次10个订单
    */
        public long[] getOrderIdList() {
               	return orderIdList;
            }
    
    /**
     * 设置订单Id列表,最多批量30个订单，订单过多会导致超时，建议一次10个订单     *
     * 参数示例：<pre>[74321349391498520]</pre>     
             * 此参数必填
          */
    public void setOrderIdList(long[] orderIdList) {
     	         	    this.orderIdList = orderIdList;
     	        }
    
    
  }
}