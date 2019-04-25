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
public class AlibabaAlipayUrlGetResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private string erroMsg;
    
        /**
       * @return 错误信息
    */
        public string getErroMsg() {
               	return erroMsg;
            }
    
    /**
     * 设置错误信息     *
          
             * 此参数必填
          */
    public void setErroMsg(string erroMsg) {
     	         	    this.erroMsg = erroMsg;
     	        }
    
        [DataMember(Order = 2)]
    private string payUrl;
    
        /**
       * @return 支付链接
    */
        public string getPayUrl() {
               	return payUrl;
            }
    
    /**
     * 设置支付链接     *
          
             * 此参数必填
          */
    public void setPayUrl(string payUrl) {
     	         	    this.payUrl = payUrl;
     	        }
    
        [DataMember(Order = 3)]
    private bool? success;
    
        /**
       * @return 是否成功
    */
        public bool? getSuccess() {
               	return success;
            }
    
    /**
     * 设置是否成功     *
          
             * 此参数必填
          */
    public void setSuccess(bool success) {
     	         	    this.success = success;
     	        }
    
        [DataMember(Order = 4)]
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
    
    
  }
}