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
public class AlibabaProductPushTaOrderQueryServiceSumWebUnionCooperationByParamResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private long? result;
    
        /**
       * @return 预估佣金，单位分
    */
        public long? getResult() {
               	return result;
            }
    
    /**
     * 设置预估佣金，单位分     *
          
             * 此参数必填
          */
    public void setResult(long result) {
     	         	    this.result = result;
     	        }
    
    
  }
}