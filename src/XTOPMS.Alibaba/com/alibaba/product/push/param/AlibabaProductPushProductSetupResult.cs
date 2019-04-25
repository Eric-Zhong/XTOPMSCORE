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
public class AlibabaProductPushProductSetupResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private string result;
    
        /**
       * @return 
    */
        public string getResult() {
               	return result;
            }
    
    /**
     * 设置     *
          
             * 此参数必填
          */
    public void setResult(string result) {
     	         	    this.result = result;
     	        }
    
    
  }
}