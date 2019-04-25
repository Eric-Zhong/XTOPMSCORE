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
public class AlibabaCommonUrl {

       [DataMember(Order = 1)]
    private string name;
    
        /**
       * @return url的类型，比如是商品详情URL， 商品小图标URL，大图标URL
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置url的类型，比如是商品详情URL， 商品小图标URL，大图标URL     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
        [DataMember(Order = 2)]
    private string value;
    
        /**
       * @return url的值
    */
        public string getValue() {
               	return value;
            }
    
    /**
     * 设置url的值     *
     * 参数示例：<pre>http://www.1688.com</pre>     
             * 此参数必填
          */
    public void setValue(string value) {
     	         	    this.value = value;
     	        }
    
    
  }
}