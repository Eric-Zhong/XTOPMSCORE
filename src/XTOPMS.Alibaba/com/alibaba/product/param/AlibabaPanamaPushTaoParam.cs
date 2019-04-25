using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.product.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaPanamaPushTaoParam : GatewayAPIRequest {

    public AlibabaPanamaPushTaoParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.panama.pushTao",1);
	}
	
       [DataMember(Order = 1)]
    private long? offerId;
    
        /**
       * @return 1688商品ID
    */
        public long? getOfferId() {
               	return offerId;
            }
    
    /**
     * 设置1688商品ID     *
     * 参数示例：<pre>1231213434</pre>     
             * 此参数必填
          */
    public void setOfferId(long offerId) {
     	         	    this.offerId = offerId;
     	        }
    
    
  }
}