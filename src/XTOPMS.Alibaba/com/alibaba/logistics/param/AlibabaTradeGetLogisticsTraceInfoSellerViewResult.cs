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
public class AlibabaTradeGetLogisticsTraceInfoSellerViewResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaLogisticsOpenPlatformLogisticsTrace[] logisticsTrace;
    
        /**
       * @return []
    */
        public AlibabaLogisticsOpenPlatformLogisticsTrace[] getLogisticsTrace() {
               	return logisticsTrace;
            }
    
    /**
     * 设置[]     *
          
             * 此参数必填
          */
    public void setLogisticsTrace(AlibabaLogisticsOpenPlatformLogisticsTrace[] logisticsTrace) {
     	         	    this.logisticsTrace = logisticsTrace;
     	        }
    
    
  }
}