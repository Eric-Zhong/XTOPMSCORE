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
public class AlibabaProductListGetResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaProductProductInfoListResult result;
    
        /**
       * @return 查询结果
    */
        public AlibabaProductProductInfoListResult getResult() {
               	return result;
            }
    
    /**
     * 设置查询结果     *
          
             * 此参数必填
          */
    public void setResult(AlibabaProductProductInfoListResult result) {
     	         	    this.result = result;
     	        }
    
        [DataMember(Order = 2)]
    private string message;
    
        /**
       * @return 错误信息
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置错误信息     *
          
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
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
    private string code;
    
        /**
       * @return 错误码
    */
        public string getCode() {
               	return code;
            }
    
    /**
     * 设置错误码     *
          
             * 此参数必填
          */
    public void setCode(string code) {
     	         	    this.code = code;
     	        }
    
    
  }
}