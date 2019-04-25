using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.trade.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaTradeResultCodeDef {

       [DataMember(Order = 1)]
    private string message;
    
        /**
       * @return 错误描述
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置错误描述     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
        [DataMember(Order = 2)]
    private string resultCode;
    
        /**
       * @return 错误码
    */
        public string getResultCode() {
               	return resultCode;
            }
    
    /**
     * 设置错误码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setResultCode(string resultCode) {
     	         	    this.resultCode = resultCode;
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
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSuccess(bool success) {
     	         	    this.success = success;
     	        }
    
    
  }
}