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
public class AlibabaProductPushMicroSupplySyncUserPlatformResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private bool? success;
    
        /**
       * @return 
    */
        public bool? getSuccess() {
               	return success;
            }
    
    /**
     * 设置     *
          
             * 此参数必填
          */
    public void setSuccess(bool success) {
     	         	    this.success = success;
     	        }
    
        [DataMember(Order = 2)]
    private string errorCode;
    
        /**
       * @return 
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置     *
          
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 3)]
    private string errorMessage;
    
        /**
       * @return 
    */
        public string getErrorMessage() {
               	return errorMessage;
            }
    
    /**
     * 设置     *
          
             * 此参数必填
          */
    public void setErrorMessage(string errorMessage) {
     	         	    this.errorMessage = errorMessage;
     	        }
    
    
  }
}