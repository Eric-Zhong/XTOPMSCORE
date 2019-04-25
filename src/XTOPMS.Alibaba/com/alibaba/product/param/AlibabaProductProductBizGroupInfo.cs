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
public class AlibabaProductProductBizGroupInfo {

       [DataMember(Order = 1)]
    private bool? support;
    
        /**
       * @return 是否支持
    */
        public bool? getSupport() {
               	return support;
            }
    
    /**
     * 设置是否支持     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSupport(bool support) {
     	         	    this.support = support;
     	        }
    
        [DataMember(Order = 2)]
    private string description;
    
        /**
       * @return 垂直市场名字，如微供市场、货品市场
    */
        public string getDescription() {
               	return description;
            }
    
    /**
     * 设置垂直市场名字，如微供市场、货品市场     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDescription(string description) {
     	         	    this.description = description;
     	        }
    
        [DataMember(Order = 3)]
    private string code;
    
        /**
       * @return 垂直市场标记
    */
        public string getCode() {
               	return code;
            }
    
    /**
     * 设置垂直市场标记     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCode(string code) {
     	         	    this.code = code;
     	        }
    
    
  }
}