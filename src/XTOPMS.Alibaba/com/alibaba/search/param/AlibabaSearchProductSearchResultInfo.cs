using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.search.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaSearchProductSearchResultInfo {

       [DataMember(Order = 1)]
    private int? amountOnSale;
    
        /**
       * @return 可售数量
    */
        public int? getAmountOnSale() {
               	return amountOnSale;
            }
    
    /**
     * 设置可售数量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAmountOnSale(int amountOnSale) {
     	         	    this.amountOnSale = amountOnSale;
     	        }
    
        [DataMember(Order = 2)]
    private double? bookedCount;
    
        /**
       * @return 商品售卖了多少笔(以订单为维度)
    */
        public double? getBookedCount() {
               	return bookedCount;
            }
    
    /**
     * 设置商品售卖了多少笔(以订单为维度)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBookedCount(double bookedCount) {
     	         	    this.bookedCount = bookedCount;
     	        }
    
        [DataMember(Order = 3)]
    private double? brandBackRate;
    
        /**
       * @return 品牌回头率
    */
        public double? getBrandBackRate() {
               	return brandBackRate;
            }
    
    /**
     * 设置品牌回头率     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBrandBackRate(double brandBackRate) {
     	         	    this.brandBackRate = brandBackRate;
     	        }
    
        [DataMember(Order = 4)]
    private double? brandBackRateMember;
    
        /**
       * @return 店铺回头率
    */
        public double? getBrandBackRateMember() {
               	return brandBackRateMember;
            }
    
    /**
     * 设置店铺回头率     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBrandBackRateMember(double brandBackRateMember) {
     	         	    this.brandBackRateMember = brandBackRateMember;
     	        }
    
        [DataMember(Order = 5)]
    private long? categoryID;
    
        /**
       * @return 类目ID，标识商品所属类目
    */
        public long? getCategoryID() {
               	return categoryID;
            }
    
    /**
     * 设置类目ID，标识商品所属类目     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCategoryID(long categoryID) {
     	         	    this.categoryID = categoryID;
     	        }
    
        [DataMember(Order = 6)]
    private string city;
    
        /**
       * @return 商品发货城市
    */
        public string getCity() {
               	return city;
            }
    
    /**
     * 设置商品发货城市     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCity(string city) {
     	         	    this.city = city;
     	        }
    
        [DataMember(Order = 7)]
    private string cityCode;
    
        /**
       * @return 商品发货城市码
    */
        public string getCityCode() {
               	return cityCode;
            }
    
    /**
     * 设置商品发货城市码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCityCode(string cityCode) {
     	         	    this.cityCode = cityCode;
     	        }
    
        [DataMember(Order = 8)]
    private double? discountedPrice;
    
        /**
       * @return 打折后价格，如果无折扣，折为空
    */
        public double? getDiscountedPrice() {
               	return discountedPrice;
            }
    
    /**
     * 设置打折后价格，如果无折扣，折为空     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDiscountedPrice(double discountedPrice) {
     	         	    this.discountedPrice = discountedPrice;
     	        }
    
        [DataMember(Order = 9)]
    private double? minPurchaseQuantity;
    
        /**
       * @return 最小起批量
    */
        public double? getMinPurchaseQuantity() {
               	return minPurchaseQuantity;
            }
    
    /**
     * 设置最小起批量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMinPurchaseQuantity(double minPurchaseQuantity) {
     	         	    this.minPurchaseQuantity = minPurchaseQuantity;
     	        }
    
        [DataMember(Order = 10)]
    private string picUrl;
    
        /**
       * @return 产品的图片地址
    */
        public string getPicUrl() {
               	return picUrl;
            }
    
    /**
     * 设置产品的图片地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPicUrl(string picUrl) {
     	         	    this.picUrl = picUrl;
     	        }
    
        [DataMember(Order = 11)]
    private double? price;
    
        /**
       * @return 商品价格
    */
        public double? getPrice() {
               	return price;
            }
    
    /**
     * 设置商品价格     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPrice(double price) {
     	         	    this.price = price;
     	        }
    
        [DataMember(Order = 12)]
    private long? productID;
    
        /**
       * @return 商品ID
    */
        public long? getProductID() {
               	return productID;
            }
    
    /**
     * 设置商品ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductID(long productID) {
     	         	    this.productID = productID;
     	        }
    
        [DataMember(Order = 13)]
    private string proviceCode;
    
        /**
       * @return 商品发货省份
    */
        public string getProviceCode() {
               	return proviceCode;
            }
    
    /**
     * 设置商品发货省份     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProviceCode(string proviceCode) {
     	         	    this.proviceCode = proviceCode;
     	        }
    
        [DataMember(Order = 14)]
    private string province;
    
        /**
       * @return 商品发货省份码
    */
        public string getProvince() {
               	return province;
            }
    
    /**
     * 设置商品发货省份码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProvince(string province) {
     	         	    this.province = province;
     	        }
    
        [DataMember(Order = 15)]
    private double? retailPrice;
    
        /**
       * @return 建议零售价
    */
        public double? getRetailPrice() {
               	return retailPrice;
            }
    
    /**
     * 设置建议零售价     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRetailPrice(double retailPrice) {
     	         	    this.retailPrice = retailPrice;
     	        }
    
        [DataMember(Order = 16)]
    private double? saleQuantity;
    
        /**
       * @return 该商品售卖了多少件(以商品单位为维度)
    */
        public double? getSaleQuantity() {
               	return saleQuantity;
            }
    
    /**
     * 设置该商品售卖了多少件(以商品单位为维度)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSaleQuantity(double saleQuantity) {
     	         	    this.saleQuantity = saleQuantity;
     	        }
    
        [DataMember(Order = 17)]
    private string subject;
    
        /**
       * @return 商品标题
    */
        public string getSubject() {
               	return subject;
            }
    
    /**
     * 设置商品标题     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubject(string subject) {
     	         	    this.subject = subject;
     	        }
    
        [DataMember(Order = 18)]
    private string unit;
    
        /**
       * @return 商品单位
    */
        public string getUnit() {
               	return unit;
            }
    
    /**
     * 设置商品单位     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUnit(string unit) {
     	         	    this.unit = unit;
     	        }
    
        [DataMember(Order = 19)]
    private AlibabaSearchProductBizGroupInfo[] bizGroupInfos;
    
        /**
       * @return 该产品支持的业务(比如微供，采购)
    */
        public AlibabaSearchProductBizGroupInfo[] getBizGroupInfos() {
               	return bizGroupInfos;
            }
    
    /**
     * 设置该产品支持的业务(比如微供，采购)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBizGroupInfos(AlibabaSearchProductBizGroupInfo[] bizGroupInfos) {
     	         	    this.bizGroupInfos = bizGroupInfos;
     	        }
    
    
  }
}