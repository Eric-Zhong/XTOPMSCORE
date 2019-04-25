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
public class AlibabaProductPushAttributeRelationMapping {

       [DataMember(Order = 1)]
    private string propertyIdInSource;
    
        /**
       * @return 在源平台(1688)的属性ID
    */
        public string getPropertyIdInSource() {
               	return propertyIdInSource;
            }
    
    /**
     * 设置在源平台(1688)的属性ID     *
     * 参数示例：<pre>123</pre>     
             * 此参数必填
          */
    public void setPropertyIdInSource(string propertyIdInSource) {
     	         	    this.propertyIdInSource = propertyIdInSource;
     	        }
    
        [DataMember(Order = 2)]
    private string propertyTextInSource;
    
        /**
       * @return 在源平台(1688)的属性ID文本
    */
        public string getPropertyTextInSource() {
               	return propertyTextInSource;
            }
    
    /**
     * 设置在源平台(1688)的属性ID文本     *
     * 参数示例：<pre>颜色</pre>     
             * 此参数必填
          */
    public void setPropertyTextInSource(string propertyTextInSource) {
     	         	    this.propertyTextInSource = propertyTextInSource;
     	        }
    
        [DataMember(Order = 3)]
    private string valueIdInSource;
    
        /**
       * @return 在源平台(1688)的属性值ID
    */
        public string getValueIdInSource() {
               	return valueIdInSource;
            }
    
    /**
     * 设置在源平台(1688)的属性值ID     *
     * 参数示例：<pre>1233</pre>     
             * 此参数必填
          */
    public void setValueIdInSource(string valueIdInSource) {
     	         	    this.valueIdInSource = valueIdInSource;
     	        }
    
        [DataMember(Order = 4)]
    private string valueTextInSource;
    
        /**
       * @return 在源平台(1688)的属性值文本
    */
        public string getValueTextInSource() {
               	return valueTextInSource;
            }
    
    /**
     * 设置在源平台(1688)的属性值文本     *
     * 参数示例：<pre>红色</pre>     
             * 此参数必填
          */
    public void setValueTextInSource(string valueTextInSource) {
     	         	    this.valueTextInSource = valueTextInSource;
     	        }
    
        [DataMember(Order = 5)]
    private string propertyIdInTarget;
    
        /**
       * @return 在目标平台(比如TAOBAO)的属性ID
    */
        public string getPropertyIdInTarget() {
               	return propertyIdInTarget;
            }
    
    /**
     * 设置在目标平台(比如TAOBAO)的属性ID     *
     * 参数示例：<pre>234</pre>     
             * 此参数必填
          */
    public void setPropertyIdInTarget(string propertyIdInTarget) {
     	         	    this.propertyIdInTarget = propertyIdInTarget;
     	        }
    
        [DataMember(Order = 6)]
    private string propertyTextInTarget;
    
        /**
       * @return 在目标平台(比如TAOBAO)的属性ID文本
    */
        public string getPropertyTextInTarget() {
               	return propertyTextInTarget;
            }
    
    /**
     * 设置在目标平台(比如TAOBAO)的属性ID文本     *
     * 参数示例：<pre>颜色</pre>     
             * 此参数必填
          */
    public void setPropertyTextInTarget(string propertyTextInTarget) {
     	         	    this.propertyTextInTarget = propertyTextInTarget;
     	        }
    
        [DataMember(Order = 7)]
    private string valueIdInTarget;
    
        /**
       * @return 在目标平台(比如TAOBAO)的属性值的ID
    */
        public string getValueIdInTarget() {
               	return valueIdInTarget;
            }
    
    /**
     * 设置在目标平台(比如TAOBAO)的属性值的ID     *
     * 参数示例：<pre>2341</pre>     
             * 此参数必填
          */
    public void setValueIdInTarget(string valueIdInTarget) {
     	         	    this.valueIdInTarget = valueIdInTarget;
     	        }
    
        [DataMember(Order = 8)]
    private string valueTextInTarget;
    
        /**
       * @return 在目标平台(比如TAOBAO)的属性值的文本
    */
        public string getValueTextInTarget() {
               	return valueTextInTarget;
            }
    
    /**
     * 设置在目标平台(比如TAOBAO)的属性值的文本     *
     * 参数示例：<pre>橙红色</pre>     
             * 此参数必填
          */
    public void setValueTextInTarget(string valueTextInTarget) {
     	         	    this.valueTextInTarget = valueTextInTarget;
     	        }
    
    
  }
}