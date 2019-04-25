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
public class AlibabaOpenplatformTradeResultCodeDef {

       [DataMember(Order = 1)]
    private string message;
    
        /**
       * @return 
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
        [DataMember(Order = 2)]
    private string resultCode;
    
        /**
       * @return 
    */
        public string getResultCode() {
               	return resultCode;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setResultCode(string resultCode) {
     	         	    this.resultCode = resultCode;
     	        }
    
    
  }
}