using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.logistics.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaBulksettlementOpSpecItem {

       [DataMember(Order = 1)]
    private string specName;
    
        /**
       * @return 规格属性名称
    */
        public string getSpecName() {
               	return specName;
            }
    
    /**
     * 设置规格属性名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSpecName(string specName) {
     	         	    this.specName = specName;
     	        }
    
        [DataMember(Order = 2)]
    private string specValue;
    
        /**
       * @return 规格属性值
    */
        public string getSpecValue() {
               	return specValue;
            }
    
    /**
     * 设置规格属性值     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSpecValue(string specValue) {
     	         	    this.specValue = specValue;
     	        }
    
        [DataMember(Order = 3)]
    private string unit;
    
        /**
       * @return 规格属性单位
    */
        public string getUnit() {
               	return unit;
            }
    
    /**
     * 设置规格属性单位     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUnit(string unit) {
     	         	    this.unit = unit;
     	        }
    
    
  }
}