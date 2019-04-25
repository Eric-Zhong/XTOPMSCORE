using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.product.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductSimpleProductCreateResultModel {

       [DataMember(Order = 1)]
    private string message;
    
        /**
       * @return 返回消息
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置返回消息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
        [DataMember(Order = 2)]
    private string subCode;
    
        /**
       * @return 返回子码
    */
        public string getSubCode() {
               	return subCode;
            }
    
    /**
     * 设置返回子码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubCode(string subCode) {
     	         	    this.subCode = subCode;
     	        }
    
        [DataMember(Order = 3)]
    private string subMessage;
    
        /**
       * @return 返回子消息
    */
        public string getSubMessage() {
               	return subMessage;
            }
    
    /**
     * 设置返回子消息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubMessage(string subMessage) {
     	         	    this.subMessage = subMessage;
     	        }
    
        [DataMember(Order = 4)]
    private string code;
    
        /**
       * @return 返回码
    */
        public string getCode() {
               	return code;
            }
    
    /**
     * 设置返回码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCode(string code) {
     	         	    this.code = code;
     	        }
    
        [DataMember(Order = 5)]
    private string success;
    
        /**
       * @return 是否成功
    */
        public string getSuccess() {
               	return success;
            }
    
    /**
     * 设置是否成功     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSuccess(string success) {
     	         	    this.success = success;
     	        }
    
        [DataMember(Order = 6)]
    private AlibabaProductSimpleProductCreateResult result;
    
        /**
       * @return 
    */
        public AlibabaProductSimpleProductCreateResult getResult() {
               	return result;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setResult(AlibabaProductSimpleProductCreateResult result) {
     	         	    this.result = result;
     	        }
    
    
  }
}