using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.search.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaSearchRelationGroupInfo {

       [DataMember(Order = 1)]
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
    
        [DataMember(Order = 2)]
    private string code;
    
        /**
       * @return 关系code
    */
        public string getCode() {
               	return code;
            }
    
    /**
     * 设置关系code     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCode(string code) {
     	         	    this.code = code;
     	        }
    
        [DataMember(Order = 3)]
    private bool? related;
    
        /**
       * @return 是否 在该关系下有关联
    */
        public bool? getRelated() {
               	return related;
            }
    
    /**
     * 设置是否 在该关系下有关联     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRelated(bool related) {
     	         	    this.related = related;
     	        }
    
    
  }
}