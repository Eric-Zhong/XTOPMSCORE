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
public class AlibabaProductUnitPrice {

       [DataMember(Order = 1)]
    private AlibabaCommonMoney price;
    
        /**
       * @return 单个商品的值
    */
        public AlibabaCommonMoney getPrice() {
               	return price;
            }
    
    /**
     * 设置单个商品的值     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPrice(AlibabaCommonMoney price) {
     	         	    this.price = price;
     	        }
    
    
  }
}