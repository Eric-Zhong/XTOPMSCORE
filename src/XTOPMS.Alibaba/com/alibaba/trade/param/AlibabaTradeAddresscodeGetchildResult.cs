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
public class AlibabaTradeAddresscodeGetchildResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaTradeAddressCode[] result;
    
        /**
       * @return 子地区信息，可能为空。如果返回值是空，则说明输入参数无法找到下一级区域信息，或者输入code已经是最底层区域
    */
        public AlibabaTradeAddressCode[] getResult() {
               	return result;
            }
    
    /**
     * 设置子地区信息，可能为空。如果返回值是空，则说明输入参数无法找到下一级区域信息，或者输入code已经是最底层区域     *
          
             * 此参数必填
          */
    public void setResult(AlibabaTradeAddressCode[] result) {
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
    
    
  }
}