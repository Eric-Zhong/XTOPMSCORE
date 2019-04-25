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
public class AlibabaOrderDetailCaigouQuoteInfo {

       [DataMember(Order = 1)]
    private string productQuoteName;
    
        /**
       * @return 供应单项的名称
    */
        public string getProductQuoteName() {
               	return productQuoteName;
            }
    
    /**
     * 设置供应单项的名称     *
     * 参数示例：<pre>物料01</pre>     
             * 此参数必填
          */
    public void setProductQuoteName(string productQuoteName) {
     	         	    this.productQuoteName = productQuoteName;
     	        }
    
        [DataMember(Order = 2)]
    private decimal? price;
    
        /**
       * @return 价格，单位：元
    */
        public decimal? getPrice() {
               	return price;
            }
    
    /**
     * 设置价格，单位：元     *
     * 参数示例：<pre>100</pre>     
             * 此参数必填
          */
    public void setPrice(decimal price) {
     	         	    this.price = price;
     	        }
    
        [DataMember(Order = 3)]
    private double? count;
    
        /**
       * @return 购买数量
    */
        public double? getCount() {
               	return count;
            }
    
    /**
     * 设置购买数量     *
     * 参数示例：<pre>10</pre>     
             * 此参数必填
          */
    public void setCount(double count) {
     	         	    this.count = count;
     	        }
    
    
  }
}