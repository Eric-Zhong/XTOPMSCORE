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
public class AlibabaAitoolsProductRemoveModel3DParam : GatewayAPIRequest {

    public AlibabaAitoolsProductRemoveModel3DParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.aitools.product.remove.model3D",1);
	}
	
       [DataMember(Order = 1)]
    private string productID;
    
        /**
       * @return 1688 商品 ID
    */
        public string getProductID() {
               	return productID;
            }
    
    /**
     * 设置1688 商品 ID     *
     * 参数示例：<pre>123</pre>     
             * 此参数必填
          */
    public void setProductID(string productID) {
     	         	    this.productID = productID;
     	        }
    
    
  }
}