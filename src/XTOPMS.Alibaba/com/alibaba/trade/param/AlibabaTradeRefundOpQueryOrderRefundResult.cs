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
public class AlibabaTradeRefundOpQueryOrderRefundResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaTradeRefundOpQueryOrderRefundResult result;
    
        /**
       * @return 查询结果
    */
        public AlibabaTradeRefundOpQueryOrderRefundResult getResult() {
               	return result;
            }
    
    /**
     * 设置查询结果     *
          
             * 此参数必填
          */
    public void setResult(AlibabaTradeRefundOpQueryOrderRefundResult result) {
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
       * @return 错误描述信息
    */
        public string getErrorMessage() {
               	return errorMessage;
            }
    
    /**
     * 设置错误描述信息     *
          
             * 此参数必填
          */
    public void setErrorMessage(string errorMessage) {
     	         	    this.errorMessage = errorMessage;
     	        }
    
        [DataMember(Order = 4)]
    private string extErrorMessage;
    
        /**
       * @return 补充错误描述信息
    */
        public string getExtErrorMessage() {
               	return extErrorMessage;
            }
    
    /**
     * 设置补充错误描述信息     *
          
             * 此参数必填
          */
    public void setExtErrorMessage(string extErrorMessage) {
     	         	    this.extErrorMessage = extErrorMessage;
     	        }
    
    
  }
}