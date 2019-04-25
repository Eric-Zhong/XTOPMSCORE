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
public class AlibabaProductSKUAttrInfo {

       [DataMember(Order = 1)]
    private long? attributeID;
    
        /**
       * @return sku属性ID
    */
        public long? getAttributeID() {
               	return attributeID;
            }
    
    /**
     * 设置sku属性ID     *
     * 参数示例：<pre>3216</pre>     
             * 此参数必填
          */
    public void setAttributeID(long attributeID) {
     	         	    this.attributeID = attributeID;
     	        }
    
        [DataMember(Order = 2)]
    private string attributeValue;
    
        /**
       * @return sku值内容
    */
        public string getAttributeValue() {
               	return attributeValue;
            }
    
    /**
     * 设置sku值内容     *
     * 参数示例：<pre>白色</pre>     
             * 此参数必填
          */
    public void setAttributeValue(string attributeValue) {
     	         	    this.attributeValue = attributeValue;
     	        }
    
        [DataMember(Order = 3)]
    private string skuImageUrl;
    
        /**
       * @return sku图片名
    */
        public string getSkuImageUrl() {
               	return skuImageUrl;
            }
    
    /**
     * 设置sku图片名     *
     * 参数示例：<pre>img/ibank/2018/852/384/9326483258_1660977857.jpg</pre>     
             * 此参数必填
          */
    public void setSkuImageUrl(string skuImageUrl) {
     	         	    this.skuImageUrl = skuImageUrl;
     	        }
    
        [DataMember(Order = 4)]
    private string attributeDisplayName;
    
        /**
       * @return sku属性ID所对应的显示名，比如颜色，尺码
    */
        public string getAttributeDisplayName() {
               	return attributeDisplayName;
            }
    
    /**
     * 设置sku属性ID所对应的显示名，比如颜色，尺码     *
     * 参数示例：<pre>颜色</pre>     
             * 此参数必填
          */
    public void setAttributeDisplayName(string attributeDisplayName) {
     	         	    this.attributeDisplayName = attributeDisplayName;
     	        }
    
        [DataMember(Order = 5)]
    private string attributeName;
    
        /**
       * @return sku属性ID所对应的显示名，比如颜色，尺码
    */
        public string getAttributeName() {
               	return attributeName;
            }
    
    /**
     * 设置sku属性ID所对应的显示名，比如颜色，尺码     *
     * 参数示例：<pre>颜色</pre>     
             * 此参数必填
          */
    public void setAttributeName(string attributeName) {
     	         	    this.attributeName = attributeName;
     	        }
    
    
  }
}