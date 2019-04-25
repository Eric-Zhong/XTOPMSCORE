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
public class AlibabaAitoolsProductAttachModel3DParam : GatewayAPIRequest {

    public AlibabaAitoolsProductAttachModel3DParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.aitools.product.attach.model3D",1);
	}
	
       [DataMember(Order = 1)]
    private string productID;
    
        /**
       * @return 1688 商品 ID，可在商品发布后取得
    */
        public string getProductID() {
               	return productID;
            }
    
    /**
     * 设置1688 商品 ID，可在商品发布后取得     *
     * 参数示例：<pre>123</pre>     
             * 此参数必填
          */
    public void setProductID(string productID) {
     	         	    this.productID = productID;
     	        }
    
        [DataMember(Order = 2)]
    private string recogniseID;
    
        /**
       * @return 识别号，上传 3D 模型后取得的识别号
    */
        public string getRecogniseID() {
               	return recogniseID;
            }
    
    /**
     * 设置识别号，上传 3D 模型后取得的识别号     *
     * 参数示例：<pre>xxxxxxxxxx-xxx</pre>     
             * 此参数必填
          */
    public void setRecogniseID(string recogniseID) {
     	         	    this.recogniseID = recogniseID;
     	        }
    
    
  }
}