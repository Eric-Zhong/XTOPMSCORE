using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.product.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductFollowResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private int? code;
    
        /**
       * @return code,0表示成功
    */
        public int? getCode() {
               	return code;
            }
    
    /**
     * 设置code,0表示成功     *
          
             * 此参数必填
          */
    public void setCode(int code) {
     	         	    this.code = code;
     	        }
    
        [DataMember(Order = 2)]
    private string message;
    
        /**
       * @return 结果的描述
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置结果的描述     *
          
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
    
  }
}