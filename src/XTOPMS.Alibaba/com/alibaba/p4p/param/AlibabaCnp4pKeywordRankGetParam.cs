using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.p4p.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaCnp4pKeywordRankGetParam : GatewayAPIRequest {

    public AlibabaCnp4pKeywordRankGetParam() {
        this.ApiId = new APIId("com.alibaba.p4p", "alibaba.cnp4p.keyword.rank.get",1);
	}
	
   
  }
}