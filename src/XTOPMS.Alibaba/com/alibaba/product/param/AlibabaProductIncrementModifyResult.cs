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
public class AlibabaProductIncrementModifyResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaProductProductInfo result;
    
        /**
       * @return 商品信息
    */
        public AlibabaProductProductInfo getResult() {
               	return result;
            }
    
    /**
     * 设置商品信息     *
          
             * 此参数必填
          */
    public void setResult(AlibabaProductProductInfo result) {
     	         	    this.result = result;
     	        }
    
        [DataMember(Order = 2)]
    private string errorCode;
    
        /**
       * @return 错误码标识
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置错误码标识     *
          
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 3)]
    private string errorMessage;
    
        /**
       * @return 错误描述
    */
        public string getErrorMessage() {
               	return errorMessage;
            }
    
    /**
     * 设置错误描述     *
          
             * 此参数必填
          */
    public void setErrorMessage(string errorMessage) {
     	         	    this.errorMessage = errorMessage;
     	        }
    
    
  }
}