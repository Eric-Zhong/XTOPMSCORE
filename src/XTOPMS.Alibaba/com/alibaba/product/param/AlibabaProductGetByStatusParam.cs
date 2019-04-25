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
public class AlibabaProductGetByStatusParam : GatewayAPIRequest {

    public AlibabaProductGetByStatusParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.getByStatus",1);
	}
	
   
  }
}