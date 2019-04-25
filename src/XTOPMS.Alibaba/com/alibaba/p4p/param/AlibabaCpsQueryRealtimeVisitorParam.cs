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
public class AlibabaCpsQueryRealtimeVisitorParam : GatewayAPIRequest {

    public AlibabaCpsQueryRealtimeVisitorParam() {
        this.ApiId = new APIId("com.alibaba.p4p", "alibaba.cps.queryRealtimeVisitor",1);
	}
	
   
  }
}