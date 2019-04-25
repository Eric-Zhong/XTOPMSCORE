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
public class AlibabaOpenplatformTradeKeyValuePair {

       [DataMember(Order = 1)]
    private string key;
    
        /**
       * @return 键
    */
        public string getKey() {
               	return key;
            }
    
    /**
     * 设置键     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setKey(string key) {
     	         	    this.key = key;
     	        }
    
        [DataMember(Order = 2)]
    private string value;
    
        /**
       * @return 值
    */
        public string getValue() {
               	return value;
            }
    
    /**
     * 设置值     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setValue(string value) {
     	         	    this.value = value;
     	        }
    
        [DataMember(Order = 3)]
    private string description;
    
        /**
       * @return 描述
    */
        public string getDescription() {
               	return description;
            }
    
    /**
     * 设置描述     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDescription(string description) {
     	         	    this.description = description;
     	        }
    
    
  }
}