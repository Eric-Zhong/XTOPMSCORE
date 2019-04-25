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
public class AlibabaTradeGetSellerViewParam : GatewayAPIRequest {

    public AlibabaTradeGetSellerViewParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.get.sellerView",2);
	}
	
       [DataMember(Order = 1)]
    private string webSite;
    
        /**
       * @return 站点信息，指定调用的API是属于国际站（alibaba）还是1688网站（1688）
    */
        public string getWebSite() {
               	return webSite;
            }
    
    /**
     * 设置站点信息，指定调用的API是属于国际站（alibaba）还是1688网站（1688）     *
     * 参数示例：<pre>1688</pre>     
             * 此参数必填
          */
    public void setWebSite(string webSite) {
     	         	    this.webSite = webSite;
     	        }
    
        [DataMember(Order = 2)]
    private string orderId;
    
        /**
       * @return 交易的订单id
    */
        public string getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置交易的订单id     *
     * 参数示例：<pre>201089727630969811</pre>     
             * 此参数必填
          */
    public void setOrderId(string orderId) {
     	         	    this.orderId = orderId;
     	        }
    
    
  }
}