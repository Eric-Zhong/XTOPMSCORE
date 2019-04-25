using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.logistics.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaLogisticsOpQueryLogisticCompanyListPrintParam : GatewayAPIRequest {

    public AlibabaLogisticsOpQueryLogisticCompanyListPrintParam() {
        this.ApiId = new APIId("com.alibaba.logistics", "alibaba.logistics.OpQueryLogisticCompanyList.print",1);
	}
	
   
  }
}