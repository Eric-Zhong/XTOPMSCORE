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
public class AlibabaAitoolsProductAttrResolveParam : GatewayAPIRequest {

    public AlibabaAitoolsProductAttrResolveParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.aitools.product.attr.resolve",1);
	}
	
       [DataMember(Order = 1)]
    private string recogniseID;
    
        /**
       * @return 资源上传后生成的识别号
    */
        public string getRecogniseID() {
               	return recogniseID;
            }
    
    /**
     * 设置资源上传后生成的识别号     *
     * 参数示例：<pre>xxxxxxxxx-xxx</pre>     
             * 此参数必填
          */
    public void setRecogniseID(string recogniseID) {
     	         	    this.recogniseID = recogniseID;
     	        }
    
        [DataMember(Order = 2)]
    private string rootCategoryID;
    
        /**
       * @return 一级类目ID
    */
        public string getRootCategoryID() {
               	return rootCategoryID;
            }
    
    /**
     * 设置一级类目ID     *
     * 参数示例：<pre>10166</pre>     
             * 此参数必填
          */
    public void setRootCategoryID(string rootCategoryID) {
     	         	    this.rootCategoryID = rootCategoryID;
     	        }
    
    
  }
}