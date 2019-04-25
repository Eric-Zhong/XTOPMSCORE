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
public class AlibabaBulksettlementOpCreateBulkSettlementReceiveNoteResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaBulksettlementOpReceiveGoodsResult result;
    
        /**
       * @return 处理结果
    */
        public AlibabaBulksettlementOpReceiveGoodsResult getResult() {
               	return result;
            }
    
    /**
     * 设置处理结果     *
          
             * 此参数必填
          */
    public void setResult(AlibabaBulksettlementOpReceiveGoodsResult result) {
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
    private string errorMesage;
    
        /**
       * @return 错误描述
    */
        public string getErrorMesage() {
               	return errorMesage;
            }
    
    /**
     * 设置错误描述     *
          
             * 此参数必填
          */
    public void setErrorMesage(string errorMesage) {
     	         	    this.errorMesage = errorMesage;
     	        }
    
        [DataMember(Order = 4)]
    private string extErrorMessage;
    
        /**
       * @return 扩展错误描述
    */
        public string getExtErrorMessage() {
               	return extErrorMessage;
            }
    
    /**
     * 设置扩展错误描述     *
          
             * 此参数必填
          */
    public void setExtErrorMessage(string extErrorMessage) {
     	         	    this.extErrorMessage = extErrorMessage;
     	        }
    
    
  }
}