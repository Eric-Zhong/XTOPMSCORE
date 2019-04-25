using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.account.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaSubAccountListParam : GatewayAPIRequest {

    public AlibabaSubAccountListParam() {
        this.ApiId = new APIId("com.alibaba.account", "alibaba.subAccount.list",1);
	}
	
   
  }
}