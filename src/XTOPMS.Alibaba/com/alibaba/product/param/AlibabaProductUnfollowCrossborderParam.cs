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
public class AlibabaProductUnfollowCrossborderParam : GatewayAPIRequest {

    public AlibabaProductUnfollowCrossborderParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.unfollow.crossborder",1);
	}
	
       [DataMember(Order = 1)]
    private long? productId;
    
        /**
       * @return 商品id
    */
        public long? getProductId() {
               	return productId;
            }
    
    /**
     * 设置商品id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductId(long productId) {
     	         	    this.productId = productId;
     	        }
    
    
  }
}