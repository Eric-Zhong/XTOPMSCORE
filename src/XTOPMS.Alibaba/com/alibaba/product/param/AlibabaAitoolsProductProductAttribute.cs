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
public class AlibabaAitoolsProductProductAttribute {

       [DataMember(Order = 1)]
    private long? attributeID;
    
        /**
       * @return 属性ID
    */
        public long? getAttributeID() {
               	return attributeID;
            }
    
    /**
     * 设置属性ID     *
     * 参数示例：<pre>123</pre>     
             * 此参数必填
          */
    public void setAttributeID(long attributeID) {
     	         	    this.attributeID = attributeID;
     	        }
    
        [DataMember(Order = 2)]
    private string attributeName;
    
        /**
       * @return 属性名
    */
        public string getAttributeName() {
               	return attributeName;
            }
    
    /**
     * 设置属性名     *
     * 参数示例：<pre>领型</pre>     
             * 此参数必填
          */
    public void setAttributeName(string attributeName) {
     	         	    this.attributeName = attributeName;
     	        }
    
        [DataMember(Order = 3)]
    private long? valueID;
    
        /**
       * @return 属性值ID
    */
        public long? getValueID() {
               	return valueID;
            }
    
    /**
     * 设置属性值ID     *
     * 参数示例：<pre>1234</pre>     
             * 此参数必填
          */
    public void setValueID(long valueID) {
     	         	    this.valueID = valueID;
     	        }
    
        [DataMember(Order = 4)]
    private string value;
    
        /**
       * @return 属性值名
    */
        public string getValue() {
               	return value;
            }
    
    /**
     * 设置属性值名     *
     * 参数示例：<pre>V领</pre>     
             * 此参数必填
          */
    public void setValue(string value) {
     	         	    this.value = value;
     	        }
    
        [DataMember(Order = 5)]
    private bool? isCustom;
    
        /**
       * @return 是否自定义属性
    */
        public bool? getIsCustom() {
               	return isCustom;
            }
    
    /**
     * 设置是否自定义属性     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setIsCustom(bool isCustom) {
     	         	    this.isCustom = isCustom;
     	        }
    
    
  }
}