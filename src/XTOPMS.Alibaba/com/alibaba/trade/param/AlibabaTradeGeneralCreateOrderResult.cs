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
public class AlibabaTradeGeneralCreateOrderResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaOpenplatformTradeResultTradeCreateGeneralOrderResult result;
    
        /**
       * @return 返回参数示例
    */
        public AlibabaOpenplatformTradeResultTradeCreateGeneralOrderResult getResult() {
               	return result;
            }
    
    /**
     * 设置返回参数示例     *
          
             * 此参数必填
          */
    public void setResult(AlibabaOpenplatformTradeResultTradeCreateGeneralOrderResult result) {
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
    private string extErrorMessage;
    
        /**
       * @return 错误信息扩展
    */
        public string getExtErrorMessage() {
               	return extErrorMessage;
            }
    
    /**
     * 设置错误信息扩展     *
          
             * 此参数必填
          */
    public void setExtErrorMessage(string extErrorMessage) {
     	         	    this.extErrorMessage = extErrorMessage;
     	        }
    
    
  }
}