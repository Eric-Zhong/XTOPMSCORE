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
public class AlibabaTradeRefundBuyerQueryOrderRefundListParam : GatewayAPIRequest {

    public AlibabaTradeRefundBuyerQueryOrderRefundListParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.refund.buyer.queryOrderRefundList",1);
	}
	
   
  }
}