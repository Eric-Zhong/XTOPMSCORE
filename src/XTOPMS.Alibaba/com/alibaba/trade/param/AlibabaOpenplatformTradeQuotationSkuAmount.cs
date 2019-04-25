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
public class AlibabaOpenplatformTradeQuotationSkuAmount {

       [DataMember(Order = 1)]
    private long? quoteItemId;
    
        /**
       * @return 报价项ID
    */
        public long? getQuoteItemId() {
               	return quoteItemId;
            }
    
    /**
     * 设置报价项ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setQuoteItemId(long quoteItemId) {
     	         	    this.quoteItemId = quoteItemId;
     	        }
    
        [DataMember(Order = 2)]
    private double? itemCount;
    
        /**
       * @return 下单数量
    */
        public double? getItemCount() {
               	return itemCount;
            }
    
    /**
     * 设置下单数量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setItemCount(double itemCount) {
     	         	    this.itemCount = itemCount;
     	        }
    
    
  }
}