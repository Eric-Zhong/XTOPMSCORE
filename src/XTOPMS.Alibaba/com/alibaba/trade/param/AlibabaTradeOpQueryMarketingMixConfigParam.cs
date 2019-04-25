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
public class AlibabaTradeOpQueryMarketingMixConfigParam : GatewayAPIRequest {

    public AlibabaTradeOpQueryMarketingMixConfigParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.OpQueryMarketingMixConfig",1);
	}
	
       [DataMember(Order = 1)]
    private string sellerMemberId;
    
        /**
       * @return 卖家memberId
    */
        public string getSellerMemberId() {
               	return sellerMemberId;
            }
    
    /**
     * 设置卖家memberId     *
     * 参数示例：<pre>b2b-1623492085</pre>     
             * 此参数必填
          */
    public void setSellerMemberId(string sellerMemberId) {
     	         	    this.sellerMemberId = sellerMemberId;
     	        }
    
    
  }
}