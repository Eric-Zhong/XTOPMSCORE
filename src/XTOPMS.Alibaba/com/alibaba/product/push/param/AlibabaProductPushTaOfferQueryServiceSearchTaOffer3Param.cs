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
public class AlibabaProductPushTaOfferQueryServiceSearchTaOffer3Param : GatewayAPIRequest {

    public AlibabaProductPushTaOfferQueryServiceSearchTaOffer3Param() {
        this.ApiId = new APIId("com.alibaba.product.push", "alibaba.product.push.TaOfferQueryService.searchTaOffer3",1);
	}
	
   
  }
}