using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.commissionSale.microsupply.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaChinaMicrosupplyOpenGetOfferImagesParam : GatewayAPIRequest {

    public AlibabaChinaMicrosupplyOpenGetOfferImagesParam() {
        this.ApiId = new APIId("com.alibaba.commissionSale.microsupply", "alibaba.china.microsupply.open.getOfferImages",1);
	}
	
   
  }
}