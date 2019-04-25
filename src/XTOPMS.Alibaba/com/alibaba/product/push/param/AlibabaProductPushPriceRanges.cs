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
public class AlibabaProductPushPriceRanges {

       [DataMember(Order = 1)]
    private double? price;
    
        /**
       * @return 
    */
        public double? getPrice() {
               	return price;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPrice(double price) {
     	         	    this.price = price;
     	        }
    
        [DataMember(Order = 2)]
    private int? startQuantity;
    
        /**
       * @return 
    */
        public int? getStartQuantity() {
               	return startQuantity;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStartQuantity(int startQuantity) {
     	         	    this.startQuantity = startQuantity;
     	        }
    
    
  }
}