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
public class AlibabaBulksettlementOpBulkSettlementQueryReceiveNoteListResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaBulksettlementOpReceiveNoteModels result;
    
        /**
       * @return 
    */
        public AlibabaBulksettlementOpReceiveNoteModels getResult() {
               	return result;
            }
    
    /**
     * 设置     *
          
             * 此参数必填
          */
    public void setResult(AlibabaBulksettlementOpReceiveNoteModels result) {
     	         	    this.result = result;
     	        }
    
        [DataMember(Order = 2)]
    private string success;
    
        /**
       * @return 
    */
        public string getSuccess() {
               	return success;
            }
    
    /**
     * 设置     *
          
             * 此参数必填
          */
    public void setSuccess(string success) {
     	         	    this.success = success;
     	        }
    
        [DataMember(Order = 3)]
    private string errorCode;
    
        /**
       * @return 
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置     *
          
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 4)]
    private string errorMessage;
    
        /**
       * @return 
    */
        public string getErrorMessage() {
               	return errorMessage;
            }
    
    /**
     * 设置     *
          
             * 此参数必填
          */
    public void setErrorMessage(string errorMessage) {
     	         	    this.errorMessage = errorMessage;
     	        }
    
        [DataMember(Order = 5)]
    private string extErrorMessage;
    
        /**
       * @return 
    */
        public string getExtErrorMessage() {
               	return extErrorMessage;
            }
    
    /**
     * 设置     *
          
             * 此参数必填
          */
    public void setExtErrorMessage(string extErrorMessage) {
     	         	    this.extErrorMessage = extErrorMessage;
     	        }
    
    
  }
}