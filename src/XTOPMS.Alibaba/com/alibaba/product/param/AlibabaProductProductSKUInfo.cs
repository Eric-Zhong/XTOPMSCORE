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
public class AlibabaProductProductSKUInfo {

       [DataMember(Order = 1)]
    private AlibabaProductSKUAttrInfo[] attributes;
    
        /**
       * @return SKU属性值，可填多组信息
    */
        public AlibabaProductSKUAttrInfo[] getAttributes() {
               	return attributes;
            }
    
    /**
     * 设置SKU属性值，可填多组信息     *
     * 参数示例：<pre>[]</pre>     
             * 此参数必填
          */
    public void setAttributes(AlibabaProductSKUAttrInfo[] attributes) {
     	         	    this.attributes = attributes;
     	        }
    
        [DataMember(Order = 2)]
    private string cargoNumber;
    
        /**
       * @return 指定规格的货号
    */
        public string getCargoNumber() {
               	return cargoNumber;
            }
    
    /**
     * 设置指定规格的货号     *
     * 参数示例：<pre>666</pre>     
             * 此参数必填
          */
    public void setCargoNumber(string cargoNumber) {
     	         	    this.cargoNumber = cargoNumber;
     	        }
    
        [DataMember(Order = 3)]
    private int? amountOnSale;
    
        /**
       * @return 可销售数量
    */
        public int? getAmountOnSale() {
               	return amountOnSale;
            }
    
    /**
     * 设置可销售数量     *
     * 参数示例：<pre>1490</pre>     
             * 此参数必填
          */
    public void setAmountOnSale(int amountOnSale) {
     	         	    this.amountOnSale = amountOnSale;
     	        }
    
        [DataMember(Order = 4)]
    private double? retailPrice;
    
        /**
       * @return 建议零售价
    */
        public double? getRetailPrice() {
               	return retailPrice;
            }
    
    /**
     * 设置建议零售价     *
     * 参数示例：<pre>445</pre>     
             * 此参数必填
          */
    public void setRetailPrice(double retailPrice) {
     	         	    this.retailPrice = retailPrice;
     	        }
    
        [DataMember(Order = 5)]
    private double? price;
    
        /**
       * @return 报价时该规格的单价
    */
        public double? getPrice() {
               	return price;
            }
    
    /**
     * 设置报价时该规格的单价     *
     * 参数示例：<pre>445</pre>     
             * 此参数必填
          */
    public void setPrice(double price) {
     	         	    this.price = price;
     	        }
    
        [DataMember(Order = 6)]
    private long? skuId;
    
        /**
       * @return skuId,该规格在所有商品中的唯一标记
    */
        public long? getSkuId() {
               	return skuId;
            }
    
    /**
     * 设置skuId,该规格在所有商品中的唯一标记     *
     * 参数示例：<pre>3935963888523</pre>     
             * 此参数必填
          */
    public void setSkuId(long skuId) {
     	         	    this.skuId = skuId;
     	        }
    
        [DataMember(Order = 7)]
    private string specId;
    
        /**
       * @return specId,该规格在本商品内的唯一标记
    */
        public string getSpecId() {
               	return specId;
            }
    
    /**
     * 设置specId,该规格在本商品内的唯一标记     *
     * 参数示例：<pre>b265340beb52182c6bcfbff1fad02f0b</pre>     
             * 此参数必填
          */
    public void setSpecId(string specId) {
     	         	    this.specId = specId;
     	        }
    
        [DataMember(Order = 8)]
    private double? consignPrice;
    
        /**
       * @return 分销基准价。代销场景均使用该价格。无SKU商品查看saleInfo中的consignPrice
    */
        public double? getConsignPrice() {
               	return consignPrice;
            }
    
    /**
     * 设置分销基准价。代销场景均使用该价格。无SKU商品查看saleInfo中的consignPrice     *
     * 参数示例：<pre>445</pre>     
             * 此参数必填
          */
    public void setConsignPrice(double consignPrice) {
     	         	    this.consignPrice = consignPrice;
     	        }
    
    
  }
}