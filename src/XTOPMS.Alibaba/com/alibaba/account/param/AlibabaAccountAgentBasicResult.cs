using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.account.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaAccountAgentBasicResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaAccountSimpleAccountInfo result;
    
        /**
       * @return 会员信息
    */
        public AlibabaAccountSimpleAccountInfo getResult() {
               	return result;
            }
    
    /**
     * 设置会员信息     *
          
             * 此参数必填
          */
    public void setResult(AlibabaAccountSimpleAccountInfo result) {
     	         	    this.result = result;
     	        }
    
        [DataMember(Order = 2)]
    private string errorCode;
    
        /**
       * @return 错误编码
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置错误编码     *
          
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
    
    
  }
}