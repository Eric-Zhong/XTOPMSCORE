using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.product.push.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductPushTaZhiTokenServiceParam : GatewayAPIRequest {

    public AlibabaProductPushTaZhiTokenServiceParam() {
        this.ApiId = new APIId("com.alibaba.product.push", "alibaba.product.push.TaZhiTokenService",1);
	}
	
   
  }
}