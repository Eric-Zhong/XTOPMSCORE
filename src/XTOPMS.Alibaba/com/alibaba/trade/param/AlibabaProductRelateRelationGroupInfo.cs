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
public class AlibabaProductRelateRelationGroupInfo {

       [DataMember(Order = 1)]
    private string code;
    
        /**
       * @return 
    */
        public string getCode() {
               	return code;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCode(string code) {
     	         	    this.code = code;
     	        }
    
        [DataMember(Order = 2)]
    private string description;
    
        /**
       * @return 
    */
        public string getDescription() {
               	return description;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDescription(string description) {
     	         	    this.description = description;
     	        }
    
        [DataMember(Order = 3)]
    private bool? related;
    
        /**
       * @return 
    */
        public bool? getRelated() {
               	return related;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRelated(bool related) {
     	         	    this.related = related;
     	        }
    
    
  }
}