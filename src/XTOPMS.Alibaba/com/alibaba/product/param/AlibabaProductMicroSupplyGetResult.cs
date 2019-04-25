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
public class AlibabaProductMicroSupplyGetResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaProductProductInfo product;
    
        /**
       * @return 商品信息
    */
        public AlibabaProductProductInfo getProduct() {
               	return product;
            }
    
    /**
     * 设置商品信息     *
          
             * 此参数必填
          */
    public void setProduct(AlibabaProductProductInfo product) {
     	         	    this.product = product;
     	        }
    
        [DataMember(Order = 2)]
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
    
        [DataMember(Order = 3)]
    private string errorCode;
    
        /**
       * @return 错误码：400：客户请求参数问题，500：服务端问题
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置错误码：400：客户请求参数问题，500：服务端问题     *
          
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 4)]
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
    
        [DataMember(Order = 5)]
    private string shareInfo;
    
        /**
       * @return 微供转发文案
    */
        public string getShareInfo() {
               	return shareInfo;
            }
    
    /**
     * 设置微供转发文案     *
          
             * 此参数必填
          */
    public void setShareInfo(string shareInfo) {
     	         	    this.shareInfo = shareInfo;
     	        }
    
    
  }
}