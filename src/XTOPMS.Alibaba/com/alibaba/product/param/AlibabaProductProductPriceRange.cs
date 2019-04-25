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
public class AlibabaProductProductPriceRange {

       [DataMember(Order = 1)]
    private int? startQuantity;
    
        /**
       * @return 起批量
    */
        public int? getStartQuantity() {
               	return startQuantity;
            }
    
    /**
     * 设置起批量     *
     * 参数示例：<pre>3</pre>     
             * 此参数必填
          */
    public void setStartQuantity(int startQuantity) {
     	         	    this.startQuantity = startQuantity;
     	        }
    
        [DataMember(Order = 2)]
    private double? price;
    
        /**
       * @return 价格
    */
        public double? getPrice() {
               	return price;
            }
    
    /**
     * 设置价格     *
     * 参数示例：<pre>445</pre>     
             * 此参数必填
          */
    public void setPrice(double price) {
     	         	    this.price = price;
     	        }
    
    
  }
}