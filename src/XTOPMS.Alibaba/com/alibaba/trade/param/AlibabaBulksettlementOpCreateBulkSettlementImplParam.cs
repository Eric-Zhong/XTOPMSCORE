using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.trade.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaBulksettlementOpCreateBulkSettlementImplParam : GatewayAPIRequest {

    public AlibabaBulksettlementOpCreateBulkSettlementImplParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.bulksettlement.OpCreateBulkSettlementImpl",2);
	}
	
   
  }
}