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
public class AlibabaPhotobankPhotoDeleteBatchResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaProductImageOperateBean[] result;
    
        /**
       * @return 图片批量操作信息结果
    */
        public AlibabaProductImageOperateBean[] getResult() {
               	return result;
            }
    
    /**
     * 设置图片批量操作信息结果     *
          
             * 此参数必填
          */
    public void setResult(AlibabaProductImageOperateBean[] result) {
     	         	    this.result = result;
     	        }
    
        [DataMember(Order = 2)]
    private string errorCode;
    
        /**
       * @return 错误code
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置错误code     *
          
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