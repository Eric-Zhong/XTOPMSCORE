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
public class AlibabaProductPropertyEditParam : GatewayAPIRequest {

    public AlibabaProductPropertyEditParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.property.edit",1);
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
     * 参数示例：<pre>122122233</pre>     
             * 此参数必填
          */
    public void setProductId(long productId) {
     	         	    this.productId = productId;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaProductProductAttributeParam[] attributes;
    
        /**
       * @return 商品产品属性列表
    */
        public AlibabaProductProductAttributeParam[] getAttributes() {
               	return attributes;
            }
    
    /**
     * 设置商品产品属性列表     *
     * 参数示例：<pre>[]</pre>     
             * 此参数必填
          */
    public void setAttributes(AlibabaProductProductAttributeParam[] attributes) {
     	         	    this.attributes = attributes;
     	        }
    
    
  }
}