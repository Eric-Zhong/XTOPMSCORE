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
public class AlibabaTradeSaleproxyPreorderResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaTradeOrderMutilViewResult result;
    
        /**
       * @return 多订单展示处理结果
    */
        public AlibabaTradeOrderMutilViewResult getResult() {
               	return result;
            }
    
    /**
     * 设置多订单展示处理结果     *
          
             * 此参数必填
          */
    public void setResult(AlibabaTradeOrderMutilViewResult result) {
     	         	    this.result = result;
     	        }
    
        [DataMember(Order = 2)]
    private string errorCode;
    
        /**
       * @return 错误信息
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置错误信息     *
          
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