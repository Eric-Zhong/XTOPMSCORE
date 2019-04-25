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
public class AlibabaPanamaPushTaoResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private bool? success;
    
        /**
       * @return 是否成功	
    */
        public bool? getSuccess() {
               	return success;
            }
    
    /**
     * 设置是否成功	     *
          
             * 此参数必填
          */
    public void setSuccess(bool success) {
     	         	    this.success = success;
     	        }
    
        [DataMember(Order = 2)]
    private long? itemId;
    
        /**
       * @return 淘宝商品ID	
    */
        public long? getItemId() {
               	return itemId;
            }
    
    /**
     * 设置淘宝商品ID	     *
          
             * 此参数必填
          */
    public void setItemId(long itemId) {
     	         	    this.itemId = itemId;
     	        }
    
        [DataMember(Order = 3)]
    private long? offerId;
    
        /**
       * @return 1688商品ID	
    */
        public long? getOfferId() {
               	return offerId;
            }
    
    /**
     * 设置1688商品ID	     *
          
             * 此参数必填
          */
    public void setOfferId(long offerId) {
     	         	    this.offerId = offerId;
     	        }
    
        [DataMember(Order = 4)]
    private long? requestId;
    
        /**
       * @return 请求ID，排查问题时请提供	
    */
        public long? getRequestId() {
               	return requestId;
            }
    
    /**
     * 设置请求ID，排查问题时请提供	     *
          
             * 此参数必填
          */
    public void setRequestId(long requestId) {
     	         	    this.requestId = requestId;
     	        }
    
        [DataMember(Order = 5)]
    private string errorMsg;
    
        /**
       * @return 错误信息	
    */
        public string getErrorMsg() {
               	return errorMsg;
            }
    
    /**
     * 设置错误信息	     *
          
             * 此参数必填
          */
    public void setErrorMsg(string errorMsg) {
     	         	    this.errorMsg = errorMsg;
     	        }
    
        [DataMember(Order = 6)]
    private string errorCode;
    
        /**
       * @return 错误码	
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置错误码	     *
          
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
    
  }
}