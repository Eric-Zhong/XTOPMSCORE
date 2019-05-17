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
public class AlibabaTradeGetSellerViewResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaOpenplatformTradeModelTradeInfo result;
    
        /**
       * @return 返回结果
    */
        public AlibabaOpenplatformTradeModelTradeInfo getResult() {
               	return result;
            }
    
    /**
     * 设置返回结果     *
          
             * 此参数必填
          */
    public void setResult(AlibabaOpenplatformTradeModelTradeInfo result) {
     	         	    this.result = result;
     	        }
    
        [DataMember(Order = 2)]
    private string errorCode;
    
        /**
       * @return 错误码
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置错误码     *
          
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 3)]
    private string errorMessage;
    
        /**
       * @return 错误信息
    */
        public string getErrorMessage() {
               	return errorMessage;
            }
    
    /**
     * 设置错误信息     *
          
             * 此参数必填
          */
    public void setErrorMessage(string errorMessage) {
     	         	    this.errorMessage = errorMessage;
     	        }
    
        [DataMember(Order = 4)]
    private string success;
    
        /**
       * @return 是否成功
    */
        public string getSuccess() {
               	return success;
            }
    
    /**
     * 设置是否成功     *
          
             * 此参数必填
          */
    public void setSuccess(string success) {
     	         	    this.success = success;
     	        }
    
    
  }
}