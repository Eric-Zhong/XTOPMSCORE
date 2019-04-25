using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.logistics.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaBulksettlementOpBulkSettlementReceiveGoodsResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaBulksettlementOpReceiveGoodsResult result;
    
        /**
       * @return 结果数据
    */
        public AlibabaBulksettlementOpReceiveGoodsResult getResult() {
               	return result;
            }
    
    /**
     * 设置结果数据     *
          
             * 此参数必填
          */
    public void setResult(AlibabaBulksettlementOpReceiveGoodsResult result) {
     	         	    this.result = result;
     	        }
    
        [DataMember(Order = 2)]
    private string errorCode;
    
        /**
       * @return 错误代码
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置错误代码     *
          
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 3)]
    private string errorMesage;
    
        /**
       * @return 错误消息
    */
        public string getErrorMesage() {
               	return errorMesage;
            }
    
    /**
     * 设置错误消息     *
          
             * 此参数必填
          */
    public void setErrorMesage(string errorMesage) {
     	         	    this.errorMesage = errorMesage;
     	        }
    
        [DataMember(Order = 4)]
    private string extErrorMessage;
    
        /**
       * @return 外部错误消息
    */
        public string getExtErrorMessage() {
               	return extErrorMessage;
            }
    
    /**
     * 设置外部错误消息     *
          
             * 此参数必填
          */
    public void setExtErrorMessage(string extErrorMessage) {
     	         	    this.extErrorMessage = extErrorMessage;
     	        }
    
    
  }
}