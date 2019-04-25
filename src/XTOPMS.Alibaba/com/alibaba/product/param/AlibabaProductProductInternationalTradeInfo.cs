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
public class AlibabaProductProductInternationalTradeInfo {

       [DataMember(Order = 1)]
    private string fobCurrency;
    
        /**
       * @return FOB价格货币，参见FAQ 货币枚举值
    */
        public string getFobCurrency() {
               	return fobCurrency;
            }
    
    /**
     * 设置FOB价格货币，参见FAQ 货币枚举值     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFobCurrency(string fobCurrency) {
     	         	    this.fobCurrency = fobCurrency;
     	        }
    
        [DataMember(Order = 2)]
    private string fobMinPrice;
    
        /**
       * @return FOB最小价格
    */
        public string getFobMinPrice() {
               	return fobMinPrice;
            }
    
    /**
     * 设置FOB最小价格     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFobMinPrice(string fobMinPrice) {
     	         	    this.fobMinPrice = fobMinPrice;
     	        }
    
        [DataMember(Order = 3)]
    private string fobMaxPrice;
    
        /**
       * @return FOB最大价格
    */
        public string getFobMaxPrice() {
               	return fobMaxPrice;
            }
    
    /**
     * 设置FOB最大价格     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFobMaxPrice(string fobMaxPrice) {
     	         	    this.fobMaxPrice = fobMaxPrice;
     	        }
    
        [DataMember(Order = 4)]
    private string fobUnitType;
    
        /**
       * @return FOB计量单位，参见FAQ 计量单位枚举值
    */
        public string getFobUnitType() {
               	return fobUnitType;
            }
    
    /**
     * 设置FOB计量单位，参见FAQ 计量单位枚举值     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFobUnitType(string fobUnitType) {
     	         	    this.fobUnitType = fobUnitType;
     	        }
    
        [DataMember(Order = 5)]
    private string[] paymentMethods;
    
        /**
       * @return 付款方式，参见FAQ 付款方式枚举值
    */
        public string[] getPaymentMethods() {
               	return paymentMethods;
            }
    
    /**
     * 设置付款方式，参见FAQ 付款方式枚举值     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPaymentMethods(string[] paymentMethods) {
     	         	    this.paymentMethods = paymentMethods;
     	        }
    
        [DataMember(Order = 6)]
    private int? minOrderQuantity;
    
        /**
       * @return 最小起订量
    */
        public int? getMinOrderQuantity() {
               	return minOrderQuantity;
            }
    
    /**
     * 设置最小起订量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMinOrderQuantity(int minOrderQuantity) {
     	         	    this.minOrderQuantity = minOrderQuantity;
     	        }
    
        [DataMember(Order = 7)]
    private string minOrderUnitType;
    
        /**
       * @return 最小起订量计量单位，参见FAQ 计量单位枚举值
    */
        public string getMinOrderUnitType() {
               	return minOrderUnitType;
            }
    
    /**
     * 设置最小起订量计量单位，参见FAQ 计量单位枚举值     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMinOrderUnitType(string minOrderUnitType) {
     	         	    this.minOrderUnitType = minOrderUnitType;
     	        }
    
        [DataMember(Order = 8)]
    private int? supplyQuantity;
    
        /**
       * @return supplyQuantity
    */
        public int? getSupplyQuantity() {
               	return supplyQuantity;
            }
    
    /**
     * 设置supplyQuantity     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSupplyQuantity(int supplyQuantity) {
     	         	    this.supplyQuantity = supplyQuantity;
     	        }
    
        [DataMember(Order = 9)]
    private string supplyUnitType;
    
        /**
       * @return 供货能力计量单位，参见FAQ 计量单位枚举值
    */
        public string getSupplyUnitType() {
               	return supplyUnitType;
            }
    
    /**
     * 设置供货能力计量单位，参见FAQ 计量单位枚举值     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSupplyUnitType(string supplyUnitType) {
     	         	    this.supplyUnitType = supplyUnitType;
     	        }
    
        [DataMember(Order = 10)]
    private string supplyPeriodType;
    
        /**
       * @return 供货能力周期，参见FAQ 时间周期枚举值
    */
        public string getSupplyPeriodType() {
               	return supplyPeriodType;
            }
    
    /**
     * 设置供货能力周期，参见FAQ 时间周期枚举值     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSupplyPeriodType(string supplyPeriodType) {
     	         	    this.supplyPeriodType = supplyPeriodType;
     	        }
    
        [DataMember(Order = 11)]
    private string deliveryPort;
    
        /**
       * @return 发货港口
    */
        public string getDeliveryPort() {
               	return deliveryPort;
            }
    
    /**
     * 设置发货港口     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDeliveryPort(string deliveryPort) {
     	         	    this.deliveryPort = deliveryPort;
     	        }
    
        [DataMember(Order = 12)]
    private string deliveryTime;
    
        /**
       * @return 发货期限
    */
        public string getDeliveryTime() {
               	return deliveryTime;
            }
    
    /**
     * 设置发货期限     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDeliveryTime(string deliveryTime) {
     	         	    this.deliveryTime = deliveryTime;
     	        }
    
        [DataMember(Order = 13)]
    private int? consignmentDate;
    
        /**
       * @return 新发货期限
    */
        public int? getConsignmentDate() {
               	return consignmentDate;
            }
    
    /**
     * 设置新发货期限     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setConsignmentDate(int consignmentDate) {
     	         	    this.consignmentDate = consignmentDate;
     	        }
    
        [DataMember(Order = 14)]
    private string packagingDesc;
    
        /**
       * @return 常规包装
    */
        public string getPackagingDesc() {
               	return packagingDesc;
            }
    
    /**
     * 设置常规包装     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPackagingDesc(string packagingDesc) {
     	         	    this.packagingDesc = packagingDesc;
     	        }
    
    
  }
}