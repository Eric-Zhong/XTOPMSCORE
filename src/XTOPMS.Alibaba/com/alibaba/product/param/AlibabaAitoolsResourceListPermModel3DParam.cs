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
public class AlibabaAitoolsResourceListPermModel3DParam : GatewayAPIRequest {

    public AlibabaAitoolsResourceListPermModel3DParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.aitools.resource.list.perm.model3D",1);
	}
	
   
  }
}