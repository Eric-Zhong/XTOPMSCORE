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
public class AlibabaPushTaoProductInfoParam : GatewayAPIRequest {

    public AlibabaPushTaoProductInfoParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.pushTao.productInfo",1);
	}
	
       [DataMember(Order = 1)]
    private long? productId;
    
        /**
       * @return 商品ID
    */
        public long? getProductId() {
               	return productId;
            }
    
    /**
     * 设置商品ID     *
     * 参数示例：<pre>56629727***8</pre>     
             * 此参数必填
          */
    public void setProductId(long productId) {
     	         	    this.productId = productId;
     	        }
    
    
  }
}