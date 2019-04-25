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
public class AlibabaAitoolsResourceUploadPermModel3DParam : GatewayAPIRequest {

    public AlibabaAitoolsResourceUploadPermModel3DParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.aitools.resource.upload.perm.model3D",1);
	}
	
   
  }
}