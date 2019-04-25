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
public class AlibabaProductProductStock {

       [DataMember(Order = 1)]
    private long? productId;
    
        /**
       * @return 产品ID
    */
        public long? getProductId() {
               	return productId;
            }
    
    /**
     * 设置产品ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductId(long productId) {
     	         	    this.productId = productId;
     	        }
    
        [DataMember(Order = 2)]
    private int? productAmountChange;
    
        /**
       * @return 有的产品没有sku信息，对已售数量的变更设置在这里。如果值为5，说明增加5个可售数量。如果值为-9，说明减少9个可售数量。
    */
        public int? getProductAmountChange() {
               	return productAmountChange;
            }
    
    /**
     * 设置有的产品没有sku信息，对已售数量的变更设置在这里。如果值为5，说明增加5个可售数量。如果值为-9，说明减少9个可售数量。     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductAmountChange(int productAmountChange) {
     	         	    this.productAmountChange = productAmountChange;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaProductSkuStockBean[] skuStocks;
    
        /**
       * @return SKU的库存的变更信息
    */
        public AlibabaProductSkuStockBean[] getSkuStocks() {
               	return skuStocks;
            }
    
    /**
     * 设置SKU的库存的变更信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkuStocks(AlibabaProductSkuStockBean[] skuStocks) {
     	         	    this.skuStocks = skuStocks;
     	        }
    
    
  }
}