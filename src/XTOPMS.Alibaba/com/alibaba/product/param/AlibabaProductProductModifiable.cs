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
public class AlibabaProductProductModifiable {

       [DataMember(Order = 1)]
    private long? productId;
    
        /**
       * @return 商品ID
    */
        public long? getProductId() {
               	return productId;
            }
    
    /**
     * 设置商品ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductId(long productId) {
     	         	    this.productId = productId;
     	        }
    
        [DataMember(Order = 2)]
    private bool? modifiable;
    
        /**
       * @return 是否可以修改
    */
        public bool? getModifiable() {
               	return modifiable;
            }
    
    /**
     * 设置是否可以修改     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setModifiable(bool modifiable) {
     	         	    this.modifiable = modifiable;
     	        }
    
        [DataMember(Order = 3)]
    private string desc;
    
        /**
       * @return 如果不能修改，描述信息
    */
        public string getDesc() {
               	return desc;
            }
    
    /**
     * 设置如果不能修改，描述信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDesc(string desc) {
     	         	    this.desc = desc;
     	        }
    
    
  }
}