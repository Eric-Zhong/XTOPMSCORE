using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.product.push.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductPushIdentity {

       [DataMember(Order = 1)]
    private string content;
    
        /**
       * @return 
    */
        public string getContent() {
               	return content;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setContent(string content) {
     	         	    this.content = content;
     	        }
    
    
  }
}