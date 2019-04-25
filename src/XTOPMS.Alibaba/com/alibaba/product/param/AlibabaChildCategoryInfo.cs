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
public class AlibabaChildCategoryInfo {

       [DataMember(Order = 1)]
    private long? id;
    
        /**
       * @return 子类目ID
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置子类目ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setId(long id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 2)]
    private string name;
    
        /**
       * @return 子类目名称
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置子类目名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
    
  }
}