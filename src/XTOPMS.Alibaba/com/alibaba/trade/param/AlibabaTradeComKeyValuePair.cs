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
public class AlibabaTradeComKeyValuePair {

       [DataMember(Order = 1)]
    private string key;
    
        /**
       * @return 键值对的Key
    */
        public string getKey() {
               	return key;
            }
    
    /**
     * 设置键值对的Key     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setKey(string key) {
     	         	    this.key = key;
     	        }
    
        [DataMember(Order = 2)]
    private string value;
    
        /**
       * @return 键值对的Value
    */
        public string getValue() {
               	return value;
            }
    
    /**
     * 设置键值对的Value     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setValue(string value) {
     	         	    this.value = value;
     	        }
    
    
  }
}