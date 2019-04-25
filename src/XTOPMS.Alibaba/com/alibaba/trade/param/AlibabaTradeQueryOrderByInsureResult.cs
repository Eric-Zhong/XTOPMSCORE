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
public class AlibabaTradeQueryOrderByInsureResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaOceanOpenplatformBizTradeResultTradeProtectResult result;
    
        /**
       * @return 返回结果
    */
        public AlibabaOceanOpenplatformBizTradeResultTradeProtectResult getResult() {
               	return result;
            }
    
    /**
     * 设置返回结果     *
          
             * 此参数必填
          */
    public void setResult(AlibabaOceanOpenplatformBizTradeResultTradeProtectResult result) {
     	         	    this.result = result;
     	        }
    
    
  }
}