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
public class AlibabaProductProductSaleInfo {

       [DataMember(Order = 1)]
    private bool? supportOnlineTrade;
    
        /**
       * @return 是否支持网上交易。true：支持 false：不支持
    */
        public bool? getSupportOnlineTrade() {
               	return supportOnlineTrade;
            }
    
    /**
     * 设置是否支持网上交易。true：支持 false：不支持     *
     * 参数示例：<pre>TRUE</pre>     
             * 此参数必填
          */
    public void setSupportOnlineTrade(bool supportOnlineTrade) {
     	         	    this.supportOnlineTrade = supportOnlineTrade;
     	        }
    
        [DataMember(Order = 2)]
    private bool? mixWholeSale;
    
        /**
       * @return 是否支持混批
    */
        public bool? getMixWholeSale() {
               	return mixWholeSale;
            }
    
    /**
     * 设置是否支持混批     *
     * 参数示例：<pre>TRUE</pre>     
             * 此参数必填
          */
    public void setMixWholeSale(bool mixWholeSale) {
     	         	    this.mixWholeSale = mixWholeSale;
     	        }
    
        [DataMember(Order = 3)]
    private bool? priceAuth;
    
        /**
       * @return 是否价格私密信息
    */
        public bool? getPriceAuth() {
               	return priceAuth;
            }
    
    /**
     * 设置是否价格私密信息     *
     * 参数示例：<pre>TRUE</pre>     
             * 此参数必填
          */
    public void setPriceAuth(bool priceAuth) {
     	         	    this.priceAuth = priceAuth;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaProductProductPriceRange[] priceRanges;
    
        /**
       * @return 区间价格。按数量范围设定的区间价格
    */
        public AlibabaProductProductPriceRange[] getPriceRanges() {
               	return priceRanges;
            }
    
    /**
     * 设置区间价格。按数量范围设定的区间价格     *
     * 参数示例：<pre>[]</pre>     
             * 此参数必填
          */
    public void setPriceRanges(AlibabaProductProductPriceRange[] priceRanges) {
     	         	    this.priceRanges = priceRanges;
     	        }
    
        [DataMember(Order = 5)]
    private double? amountOnSale;
    
        /**
       * @return 可售数量
    */
        public double? getAmountOnSale() {
               	return amountOnSale;
            }
    
    /**
     * 设置可售数量     *
     * 参数示例：<pre>29900</pre>     
             * 此参数必填
          */
    public void setAmountOnSale(double amountOnSale) {
     	         	    this.amountOnSale = amountOnSale;
     	        }
    
        [DataMember(Order = 6)]
    private string unit;
    
        /**
       * @return 计量单位
    */
        public string getUnit() {
               	return unit;
            }
    
    /**
     * 设置计量单位     *
     * 参数示例：<pre>件</pre>     
             * 此参数必填
          */
    public void setUnit(string unit) {
     	         	    this.unit = unit;
     	        }
    
        [DataMember(Order = 7)]
    private int? minOrderQuantity;
    
        /**
       * @return 最小起订量，范围是1-99999。
    */
        public int? getMinOrderQuantity() {
               	return minOrderQuantity;
            }
    
    /**
     * 设置最小起订量，范围是1-99999。     *
     * 参数示例：<pre>3</pre>     
             * 此参数必填
          */
    public void setMinOrderQuantity(int minOrderQuantity) {
     	         	    this.minOrderQuantity = minOrderQuantity;
     	        }
    
        [DataMember(Order = 8)]
    private int? batchNumber;
    
        /**
       * @return 每批数量，默认为空或者非零值，该属性不为空时sellunit为必填
    */
        public int? getBatchNumber() {
               	return batchNumber;
            }
    
    /**
     * 设置每批数量，默认为空或者非零值，该属性不为空时sellunit为必填     *
     * 参数示例：<pre>12</pre>     
             * 此参数必填
          */
    public void setBatchNumber(int batchNumber) {
     	         	    this.batchNumber = batchNumber;
     	        }
    
        [DataMember(Order = 9)]
    private double? retailprice;
    
        /**
       * @return 建议零售价
    */
        public double? getRetailprice() {
               	return retailprice;
            }
    
    /**
     * 设置建议零售价     *
     * 参数示例：<pre>445</pre>     
             * 此参数必填
          */
    public void setRetailprice(double retailprice) {
     	         	    this.retailprice = retailprice;
     	        }
    
        [DataMember(Order = 10)]
    private string tax;
    
        /**
       * @return 税率相关信息，内容由用户自定
    */
        public string getTax() {
               	return tax;
            }
    
    /**
     * 设置税率相关信息，内容由用户自定     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTax(string tax) {
     	         	    this.tax = tax;
     	        }
    
        [DataMember(Order = 11)]
    private string sellunit;
    
        /**
       * @return 售卖单位，如果为批量售卖，代表售卖的单位，该属性不为空时batchNumber为必填，例如1"手"=12“件"的"手"
    */
        public string getSellunit() {
               	return sellunit;
            }
    
    /**
     * 设置售卖单位，如果为批量售卖，代表售卖的单位，该属性不为空时batchNumber为必填，例如1"手"=12“件"的"手"     *
     * 参数示例：<pre>手</pre>     
             * 此参数必填
          */
    public void setSellunit(string sellunit) {
     	         	    this.sellunit = sellunit;
     	        }
    
        [DataMember(Order = 12)]
    private int? quoteType;
    
        /**
       * @return 0-无SKU按数量报价,1-有SKU按规格报价,2-有SKU按数量报价
    */
        public int? getQuoteType() {
               	return quoteType;
            }
    
    /**
     * 设置0-无SKU按数量报价,1-有SKU按规格报价,2-有SKU按数量报价     *
     * 参数示例：<pre>2</pre>     
             * 此参数必填
          */
    public void setQuoteType(int quoteType) {
     	         	    this.quoteType = quoteType;
     	        }
    
        [DataMember(Order = 13)]
    private double? consignPrice;
    
        /**
       * @return 分销基准价。代销场景均使用该价格。有SKU商品查看skuInfo中的consignPrice
    */
        public double? getConsignPrice() {
               	return consignPrice;
            }
    
    /**
     * 设置分销基准价。代销场景均使用该价格。有SKU商品查看skuInfo中的consignPrice     *
     * 参数示例：<pre>445</pre>     
             * 此参数必填
          */
    public void setConsignPrice(double consignPrice) {
     	         	    this.consignPrice = consignPrice;
     	        }
    
    
  }
}