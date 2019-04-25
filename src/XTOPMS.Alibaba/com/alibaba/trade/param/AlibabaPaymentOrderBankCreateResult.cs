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
public class AlibabaPaymentOrderBankCreateResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaPaymentChannelPreparePayResult result;
    
        /**
       * @return 预支付单返回结果
    */
        public AlibabaPaymentChannelPreparePayResult getResult() {
               	return result;
            }
    
    /**
     * 设置预支付单返回结果     *
          
             * 此参数必填
          */
    public void setResult(AlibabaPaymentChannelPreparePayResult result) {
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
    private string errorMessagge;
    
        /**
       * @return 错误信息
    */
        public string getErrorMessagge() {
               	return errorMessagge;
            }
    
    /**
     * 设置错误信息     *
          
             * 此参数必填
          */
    public void setErrorMessagge(string errorMessagge) {
     	         	    this.errorMessagge = errorMessagge;
     	        }
    
    
  }
}