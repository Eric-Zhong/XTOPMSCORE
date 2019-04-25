using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.multimedia.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaVideoVideocenterUploadResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private string code;
    
        /**
       * @return 错误描述
    */
        public string getCode() {
               	return code;
            }
    
    /**
     * 设置错误描述     *
          
             * 此参数必填
          */
    public void setCode(string code) {
     	         	    this.code = code;
     	        }
    
        [DataMember(Order = 2)]
    private string message;
    
        /**
       * @return 错误码
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置错误码     *
          
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
        [DataMember(Order = 3)]
    private long? result;
    
        /**
       * @return 上传完成后的videoId
    */
        public long? getResult() {
               	return result;
            }
    
    /**
     * 设置上传完成后的videoId     *
          
             * 此参数必填
          */
    public void setResult(long result) {
     	         	    this.result = result;
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