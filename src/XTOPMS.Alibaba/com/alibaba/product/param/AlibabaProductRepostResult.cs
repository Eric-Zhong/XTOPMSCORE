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
public class AlibabaProductRepostResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaProductProductOperateResult[] result;
    
        /**
       * @return 操作结果
    */
        public AlibabaProductProductOperateResult[] getResult() {
               	return result;
            }
    
    /**
     * 设置操作结果     *
          
             * 此参数必填
          */
    public void setResult(AlibabaProductProductOperateResult[] result) {
     	         	    this.result = result;
     	        }
    
        [DataMember(Order = 2)]
    private string errorCode;
    
        /**
       * @return 错误code
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置错误code     *
          
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 3)]
    private string errorMessage;
    
        /**
       * @return 详细的错误信息，可能有多条，是一个Map，用于开发自己定位问题
    */
        public string getErrorMessage() {
               	return errorMessage;
            }
    
    /**
     * 设置详细的错误信息，可能有多条，是一个Map，用于开发自己定位问题     *
          
             * 此参数必填
          */
    public void setErrorMessage(string errorMessage) {
     	         	    this.errorMessage = errorMessage;
     	        }
    
        [DataMember(Order = 4)]
    private string subErrorCode;
    
        /**
       * @return 单条错误code
    */
        public string getSubErrorCode() {
               	return subErrorCode;
            }
    
    /**
     * 设置单条错误code     *
          
             * 此参数必填
          */
    public void setSubErrorCode(string subErrorCode) {
     	         	    this.subErrorCode = subErrorCode;
     	        }
    
        [DataMember(Order = 5)]
    private string subErrorMessage;
    
        /**
       * @return 单条错误信息，被errorMessage所包含。可用于前台展示
    */
        public string getSubErrorMessage() {
               	return subErrorMessage;
            }
    
    /**
     * 设置单条错误信息，被errorMessage所包含。可用于前台展示     *
          
             * 此参数必填
          */
    public void setSubErrorMessage(string subErrorMessage) {
     	         	    this.subErrorMessage = subErrorMessage;
     	        }
    
    
  }
}