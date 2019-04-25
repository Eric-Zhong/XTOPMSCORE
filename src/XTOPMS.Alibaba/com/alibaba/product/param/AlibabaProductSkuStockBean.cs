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
public class AlibabaProductSkuStockBean {

       [DataMember(Order = 1)]
    private string skuId;
    
        /**
       * @return 有的产品拥有sku信息，对已售数量的变更需要指定SKU信息。请注意：针对1688的业务场景，该字段请填写specId，不要填写skuId。
    */
        public string getSkuId() {
               	return skuId;
            }
    
    /**
     * 设置有的产品拥有sku信息，对已售数量的变更需要指定SKU信息。请注意：针对1688的业务场景，该字段请填写specId，不要填写skuId。     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkuId(string skuId) {
     	         	    this.skuId = skuId;
     	        }
    
        [DataMember(Order = 2)]
    private int? stockChange;
    
        /**
       * @return 如果值为5，说明增加5个可售数量。如果值为-9，说明减少9个可售数量。
    */
        public int? getStockChange() {
               	return stockChange;
            }
    
    /**
     * 设置如果值为5，说明增加5个可售数量。如果值为-9，说明减少9个可售数量。     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStockChange(int stockChange) {
     	         	    this.stockChange = stockChange;
     	        }
    
    
  }
}