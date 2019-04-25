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
public class AlibabaOceanOpenplatformCommonResultModelManufactory {

       [DataMember(Order = 1)]
    private string message;
    
        /**
       * @return 1
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置1     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaOceanOpenplatformBizProductResultSimpleProductCreateResult result;
    
        /**
       * @return 1
    */
        public AlibabaOceanOpenplatformBizProductResultSimpleProductCreateResult getResult() {
               	return result;
            }
    
    /**
     * 设置1     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setResult(AlibabaOceanOpenplatformBizProductResultSimpleProductCreateResult result) {
     	         	    this.result = result;
     	        }
    
        [DataMember(Order = 3)]
    private string subCode;
    
        /**
       * @return 1
    */
        public string getSubCode() {
               	return subCode;
            }
    
    /**
     * 设置1     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setSubCode(string subCode) {
     	         	    this.subCode = subCode;
     	        }
    
        [DataMember(Order = 4)]
    private string subMessage;
    
        /**
       * @return 1
    */
        public string getSubMessage() {
               	return subMessage;
            }
    
    /**
     * 设置1     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setSubMessage(string subMessage) {
     	         	    this.subMessage = subMessage;
     	        }
    
        [DataMember(Order = 5)]
    private string code;
    
        /**
       * @return 1
    */
        public string getCode() {
               	return code;
            }
    
    /**
     * 设置1     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setCode(string code) {
     	         	    this.code = code;
     	        }
    
        [DataMember(Order = 6)]
    private bool? success;
    
        /**
       * @return 1
    */
        public bool? getSuccess() {
               	return success;
            }
    
    /**
     * 设置1     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setSuccess(bool success) {
     	         	    this.success = success;
     	        }
    
    
  }
}