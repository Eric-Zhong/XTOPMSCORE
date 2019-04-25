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
public class AlibabaAitoolsModel3DPvgCheckParam : GatewayAPIRequest {

    public AlibabaAitoolsModel3DPvgCheckParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.aitools.model3D.pvg.check",1);
	}
	
   
  }
}