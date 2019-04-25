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
public class AlibabaAitoolsResourceDeletePermModel3DParam : GatewayAPIRequest {

    public AlibabaAitoolsResourceDeletePermModel3DParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.aitools.resource.delete.perm.model3D",1);
	}
	
       [DataMember(Order = 1)]
    private string[] recogniseIDList;
    
        /**
       * @return 要删除的 3D 模型识别号列表
    */
        public string[] getRecogniseIDList() {
               	return recogniseIDList;
            }
    
    /**
     * 设置要删除的 3D 模型识别号列表     *
     * 参数示例：<pre>["xxxxxxxxxxx-xxx"]</pre>     
             * 此参数必填
          */
    public void setRecogniseIDList(string[] recogniseIDList) {
     	         	    this.recogniseIDList = recogniseIDList;
     	        }
    
    
  }
}