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
public class AlibabaTradeSkuItemDesc {

       [DataMember(Order = 1)]
    private string name;
    
        /**
       * @return 属性名
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置属性名     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
        [DataMember(Order = 2)]
    private string value;
    
        /**
       * @return 属性值
    */
        public string getValue() {
               	return value;
            }
    
    /**
     * 设置属性值     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setValue(string value) {
     	         	    this.value = value;
     	        }
    
    
  }
}