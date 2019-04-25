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
public class AlibabaSearchProductBizGroupInfo {

       [DataMember(Order = 1)]
    private string code;
    
        /**
       * @return 业务唯一标识
    */
        public string getCode() {
               	return code;
            }
    
    /**
     * 设置业务唯一标识     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCode(string code) {
     	         	    this.code = code;
     	        }
    
        [DataMember(Order = 2)]
    private string description;
    
        /**
       * @return 业务标识描述
    */
        public string getDescription() {
               	return description;
            }
    
    /**
     * 设置业务标识描述     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDescription(string description) {
     	         	    this.description = description;
     	        }
    
        [DataMember(Order = 3)]
    private bool? support;
    
        /**
       * @return 商品是否支持该业务
    */
        public bool? getSupport() {
               	return support;
            }
    
    /**
     * 设置商品是否支持该业务     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSupport(bool support) {
     	         	    this.support = support;
     	        }
    
    
  }
}