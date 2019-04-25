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
public class AlibabaTradeAddFeedbackResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaOceanOpenplatformBizTradeResultTradeFeedbackResult[] result;
    
        /**
       * @return 返回结果
    */
        public AlibabaOceanOpenplatformBizTradeResultTradeFeedbackResult[] getResult() {
               	return result;
            }
    
    /**
     * 设置返回结果     *
          
             * 此参数必填
          */
    public void setResult(AlibabaOceanOpenplatformBizTradeResultTradeFeedbackResult[] result) {
     	         	    this.result = result;
     	        }
    
    
  }
}