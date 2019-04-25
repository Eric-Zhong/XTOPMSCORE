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
public class AlibabaAitoolsGet3DModelMetaParam : GatewayAPIRequest {

    public AlibabaAitoolsGet3DModelMetaParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.aitools.get3DModelMeta",1);
	}
	
       [DataMember(Order = 1)]
    private string recognizeID;
    
        /**
       * @return 识别ID
    */
        public string getRecognizeID() {
               	return recognizeID;
            }
    
    /**
     * 设置识别ID     *
     * 参数示例：<pre>xxx-xxxx</pre>     
             * 此参数必填
          */
    public void setRecognizeID(string recognizeID) {
     	         	    this.recognizeID = recognizeID;
     	        }
    
    
  }
}