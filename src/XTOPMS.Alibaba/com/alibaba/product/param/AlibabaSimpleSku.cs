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
public class AlibabaSimpleSku {

       [DataMember(Order = 1)]
    private string description;
    
        /**
       * @return 规格描述
    */
        public string getDescription() {
               	return description;
            }
    
    /**
     * 设置规格描述     *
     * 参数示例：<pre>颜色:红色;尺码:L</pre>     
             * 此参数必填
          */
    public void setDescription(string description) {
     	         	    this.description = description;
     	        }
    
        [DataMember(Order = 2)]
    private int? amountOnSale;
    
        /**
       * @return 可售数量
    */
        public int? getAmountOnSale() {
               	return amountOnSale;
            }
    
    /**
     * 设置可售数量     *
     * 参数示例：<pre>100</pre>     
             * 此参数必填
          */
    public void setAmountOnSale(int amountOnSale) {
     	         	    this.amountOnSale = amountOnSale;
     	        }
    
        [DataMember(Order = 3)]
    private long? skuId;
    
        /**
       * @return skuID，全局唯一标示
    */
        public long? getSkuId() {
               	return skuId;
            }
    
    /**
     * 设置skuID，全局唯一标示     *
     * 参数示例：<pre>3508426014362</pre>     
             * 此参数必填
          */
    public void setSkuId(long skuId) {
     	         	    this.skuId = skuId;
     	        }
    
        [DataMember(Order = 4)]
    private string specId;
    
        /**
       * @return specID，商品内唯一，不同商品间可能重复
    */
        public string getSpecId() {
               	return specId;
            }
    
    /**
     * 设置specID，商品内唯一，不同商品间可能重复     *
     * 参数示例：<pre>8d28b045489c250b69870da3b7c71b1d</pre>     
             * 此参数必填
          */
    public void setSpecId(string specId) {
     	         	    this.specId = specId;
     	        }
    
    
  }
}