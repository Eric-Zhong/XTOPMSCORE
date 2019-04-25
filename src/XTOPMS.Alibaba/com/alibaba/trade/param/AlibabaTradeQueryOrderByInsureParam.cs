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
public class AlibabaTradeQueryOrderByInsureParam : GatewayAPIRequest {

    public AlibabaTradeQueryOrderByInsureParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.queryOrderByInsure",1);
	}
	
       [DataMember(Order = 1)]
    private AlibabaOceanOpenplatformBizTradeParamTradeProtectParam tradeProtectParam;
    
        /**
       * @return 请求参数
    */
        public AlibabaOceanOpenplatformBizTradeParamTradeProtectParam getTradeProtectParam() {
               	return tradeProtectParam;
            }
    
    /**
     * 设置请求参数     *
     * 参数示例：<pre>{"type":"lp","protectId":"91275389"}</pre>     
             * 此参数必填
          */
    public void setTradeProtectParam(AlibabaOceanOpenplatformBizTradeParamTradeProtectParam tradeProtectParam) {
     	         	    this.tradeProtectParam = tradeProtectParam;
     	        }
    
    
  }
}