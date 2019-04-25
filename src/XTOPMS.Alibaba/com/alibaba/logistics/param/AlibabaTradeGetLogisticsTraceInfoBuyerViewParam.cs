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
public class AlibabaTradeGetLogisticsTraceInfoBuyerViewParam : GatewayAPIRequest {

    public AlibabaTradeGetLogisticsTraceInfoBuyerViewParam() {
        this.ApiId = new APIId("com.alibaba.logistics", "alibaba.trade.getLogisticsTraceInfo.buyerView",2);
	}
	
       [DataMember(Order = 1)]
    private string logisticsId;
    
        /**
       * @return 该订单下的物流编号
    */
        public string getLogisticsId() {
               	return logisticsId;
            }
    
    /**
     * 设置该订单下的物流编号     *
     * 参数示例：<pre>AL8234243</pre>     
             * 此参数必填
          */
    public void setLogisticsId(string logisticsId) {
     	         	    this.logisticsId = logisticsId;
     	        }
    
        [DataMember(Order = 2)]
    private string orderId;
    
        /**
       * @return 订单号
    */
        public string getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置订单号     *
     * 参数示例：<pre>13342343</pre>     
             * 此参数必填
          */
    public void setOrderId(string orderId) {
     	         	    this.orderId = orderId;
     	        }
    
        [DataMember(Order = 3)]
    private string webSite;
    
        /**
       * @return 是1688业务还是icbu业务
    */
        public string getWebSite() {
               	return webSite;
            }
    
    /**
     * 设置是1688业务还是icbu业务     *
     * 参数示例：<pre>1688或者alibaba</pre>     
             * 此参数必填
          */
    public void setWebSite(string webSite) {
     	         	    this.webSite = webSite;
     	        }
    
    
  }
}