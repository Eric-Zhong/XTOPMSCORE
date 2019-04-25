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
public class AlibabaTradeAddFeedbackParam : GatewayAPIRequest {

    public AlibabaTradeAddFeedbackParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.addFeedback",1);
	}
	
       [DataMember(Order = 1)]
    private AlibabaOceanOpenplatformBizTradeParamTradeFeedbackParam tradeFeedbackParam;
    
        /**
       * @return 请求参数
    */
        public AlibabaOceanOpenplatformBizTradeParamTradeFeedbackParam getTradeFeedbackParam() {
               	return tradeFeedbackParam;
            }
    
    /**
     * 设置请求参数     *
     * 参数示例：<pre>{"feedback":"test","orderId":"123123213"}</pre>     
             * 此参数必填
          */
    public void setTradeFeedbackParam(AlibabaOceanOpenplatformBizTradeParamTradeFeedbackParam tradeFeedbackParam) {
     	         	    this.tradeFeedbackParam = tradeFeedbackParam;
     	        }
    
    
  }
}