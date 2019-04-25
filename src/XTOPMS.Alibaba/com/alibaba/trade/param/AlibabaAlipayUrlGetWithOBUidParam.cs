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
public class AlibabaAlipayUrlGetWithOBUidParam : GatewayAPIRequest {

    public AlibabaAlipayUrlGetWithOBUidParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.alipay.url.getWithOBUid",1);
	}
	
       [DataMember(Order = 1)]
    private string obUid;
    
        /**
       * @return 代购用户唯一Id
    */
        public string getObUid() {
               	return obUid;
            }
    
    /**
     * 设置代购用户唯一Id     *
     * 参数示例：<pre>T212312311</pre>     
             * 此参数必填
          */
    public void setObUid(string obUid) {
     	         	    this.obUid = obUid;
     	        }
    
        [DataMember(Order = 2)]
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