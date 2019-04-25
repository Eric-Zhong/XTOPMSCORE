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
public class AlibabaCrossSyncProductListPushedResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaPanamaCommonResult result;
    
        /**
       * @return 同步结果
    */
        public AlibabaPanamaCommonResult getResult() {
               	return result;
            }
    
    /**
     * 设置同步结果     *
          
             * 此参数必填
          */
    public void setResult(AlibabaPanamaCommonResult result) {
     	         	    this.result = result;
     	        }
    
    
  }
}