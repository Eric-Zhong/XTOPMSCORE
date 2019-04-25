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
public class AlibabaPushTaoProductInfoResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaProductProductInfo productInfo;
    
        /**
       * @return 返回结果
    */
        public AlibabaProductProductInfo getProductInfo() {
               	return productInfo;
            }
    
    /**
     * 设置返回结果     *
          
             * 此参数必填
          */
    public void setProductInfo(AlibabaProductProductInfo productInfo) {
     	         	    this.productInfo = productInfo;
     	        }
    
        [DataMember(Order = 2)]
    private string errorCode;
    
        /**
       * @return 返回码
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置返回码     *
          
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 3)]
    private string errorMsg;
    
        /**
       * @return 返回信息
    */
        public string getErrorMsg() {
               	return errorMsg;
            }
    
    /**
     * 设置返回信息     *
          
             * 此参数必填
          */
    public void setErrorMsg(string errorMsg) {
     	         	    this.errorMsg = errorMsg;
     	        }
    
        [DataMember(Order = 4)]
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
    
    
  }
}