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
public class AlibabaTradeCargo {

       [DataMember(Order = 1)]
    private double? additionalFee;
    
        /**
       * @return 
    */
        public double? getAdditionalFee() {
               	return additionalFee;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAdditionalFee(double additionalFee) {
     	         	    this.additionalFee = additionalFee;
     	        }
    
        [DataMember(Order = 2)]
    private double? amount;
    
        /**
       * @return 
    */
        public double? getAmount() {
               	return amount;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAmount(double amount) {
     	         	    this.amount = amount;
     	        }
    
        [DataMember(Order = 3)]
    private string attachedType;
    
        /**
       * @return 
    */
        public string getAttachedType() {
               	return attachedType;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAttachedType(string attachedType) {
     	         	    this.attachedType = attachedType;
     	        }
    
        [DataMember(Order = 4)]
    private string catTree;
    
        /**
       * @return 
    */
        public string getCatTree() {
               	return catTree;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCatTree(string catTree) {
     	         	    this.catTree = catTree;
     	        }
    
        [DataMember(Order = 5)]
    private long? categoryId;
    
        /**
       * @return 
    */
        public long? getCategoryId() {
               	return categoryId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCategoryId(long categoryId) {
     	         	    this.categoryId = categoryId;
     	        }
    
        [DataMember(Order = 6)]
    private bool? dangerous;
    
        /**
       * @return 
    */
        public bool? getDangerous() {
               	return dangerous;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDangerous(bool dangerous) {
     	         	    this.dangerous = dangerous;
     	        }
    
        [DataMember(Order = 7)]
    private double? discountFee;
    
        /**
       * @return 
    */
        public double? getDiscountFee() {
               	return discountFee;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDiscountFee(double discountFee) {
     	         	    this.discountFee = discountFee;
     	        }
    
        [DataMember(Order = 8)]
    private string externalId;
    
        /**
       * @return 
    */
        public string getExternalId() {
               	return externalId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setExternalId(string externalId) {
     	         	    this.externalId = externalId;
     	        }
    
        [DataMember(Order = 9)]
    private double? finalUnitPrice;
    
        /**
       * @return 
    */
        public double? getFinalUnitPrice() {
               	return finalUnitPrice;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFinalUnitPrice(double finalUnitPrice) {
     	         	    this.finalUnitPrice = finalUnitPrice;
     	        }
    
        [DataMember(Order = 10)]
    private string gift;
    
        /**
       * @return 
    */
        public string getGift() {
               	return gift;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGift(string gift) {
     	         	    this.gift = gift;
     	        }
    
        [DataMember(Order = 11)]
    private string icon;
    
        /**
       * @return 
    */
        public string getIcon() {
               	return icon;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIcon(string icon) {
     	         	    this.icon = icon;
     	        }
    
        [DataMember(Order = 12)]
    private long? itemId;
    
        /**
       * @return 
    */
        public long? getItemId() {
               	return itemId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setItemId(long itemId) {
     	         	    this.itemId = itemId;
     	        }
    
        [DataMember(Order = 13)]
    private string key;
    
        /**
       * @return 
    */
        public string getKey() {
               	return key;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setKey(string key) {
     	         	    this.key = key;
     	        }
    
        [DataMember(Order = 14)]
    private string marketingScene;
    
        /**
       * @return 
    */
        public string getMarketingScene() {
               	return marketingScene;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMarketingScene(string marketingScene) {
     	         	    this.marketingScene = marketingScene;
     	        }
    
        [DataMember(Order = 15)]
    private double? maxPrice;
    
        /**
       * @return 
    */
        public double? getMaxPrice() {
               	return maxPrice;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMaxPrice(double maxPrice) {
     	         	    this.maxPrice = maxPrice;
     	        }
    
        [DataMember(Order = 16)]
    private int? maxQuantity;
    
        /**
       * @return 
    */
        public int? getMaxQuantity() {
               	return maxQuantity;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMaxQuantity(int maxQuantity) {
     	         	    this.maxQuantity = maxQuantity;
     	        }
    
        [DataMember(Order = 17)]
    private string message;
    
        /**
       * @return 
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
        [DataMember(Order = 18)]
    private double? miniPrice;
    
        /**
       * @return 
    */
        public double? getMiniPrice() {
               	return miniPrice;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMiniPrice(double miniPrice) {
     	         	    this.miniPrice = miniPrice;
     	        }
    
        [DataMember(Order = 19)]
    private int? miniQuantity;
    
        /**
       * @return 
    */
        public int? getMiniQuantity() {
               	return miniQuantity;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMiniQuantity(int miniQuantity) {
     	         	    this.miniQuantity = miniQuantity;
     	        }
    
        [DataMember(Order = 20)]
    private string name;
    
        /**
       * @return 
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
        [DataMember(Order = 21)]
    private long? offerId;
    
        /**
       * @return 
    */
        public long? getOfferId() {
               	return offerId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOfferId(long offerId) {
     	         	    this.offerId = offerId;
     	        }
    
        [DataMember(Order = 22)]
    private double? orderCargoMaxPrice;
    
        /**
       * @return 
    */
        public double? getOrderCargoMaxPrice() {
               	return orderCargoMaxPrice;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderCargoMaxPrice(double orderCargoMaxPrice) {
     	         	    this.orderCargoMaxPrice = orderCargoMaxPrice;
     	        }
    
        [DataMember(Order = 23)]
    private double? orderCargoMinPrice;
    
        /**
       * @return 
    */
        public double? getOrderCargoMinPrice() {
               	return orderCargoMinPrice;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderCargoMinPrice(double orderCargoMinPrice) {
     	         	    this.orderCargoMinPrice = orderCargoMinPrice;
     	        }
    
        [DataMember(Order = 24)]
    private string orderSourceType;
    
        /**
       * @return 
    */
        public string getOrderSourceType() {
               	return orderSourceType;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderSourceType(string orderSourceType) {
     	         	    this.orderSourceType = orderSourceType;
     	        }
    
        [DataMember(Order = 25)]
    private double? priceFactor;
    
        /**
       * @return 
    */
        public double? getPriceFactor() {
               	return priceFactor;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPriceFactor(double priceFactor) {
     	         	    this.priceFactor = priceFactor;
     	        }
    
        [DataMember(Order = 26)]
    private string productDesc;
    
        /**
       * @return 
    */
        public string getProductDesc() {
               	return productDesc;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductDesc(string productDesc) {
     	         	    this.productDesc = productDesc;
     	        }
    
        [DataMember(Order = 27)]
    private double? promotion;
    
        /**
       * @return 
    */
        public double? getPromotion() {
               	return promotion;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPromotion(double promotion) {
     	         	    this.promotion = promotion;
     	        }
    
        [DataMember(Order = 28)]
    private double? quantity;
    
        /**
       * @return 
    */
        public double? getQuantity() {
               	return quantity;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setQuantity(double quantity) {
     	         	    this.quantity = quantity;
     	        }
    
        [DataMember(Order = 29)]
    private string resultCode;
    
        /**
       * @return 
    */
        public string getResultCode() {
               	return resultCode;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setResultCode(string resultCode) {
     	         	    this.resultCode = resultCode;
     	        }
    
        [DataMember(Order = 30)]
    private long? skuId;
    
        /**
       * @return 
    */
        public long? getSkuId() {
               	return skuId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkuId(long skuId) {
     	         	    this.skuId = skuId;
     	        }
    
        [DataMember(Order = 31)]
    private string specId;
    
        /**
       * @return 
    */
        public string getSpecId() {
               	return specId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSpecId(string specId) {
     	         	    this.specId = specId;
     	        }
    
        [DataMember(Order = 32)]
    private string summImage;
    
        /**
       * @return 
    */
        public string getSummImage() {
               	return summImage;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSummImage(string summImage) {
     	         	    this.summImage = summImage;
     	        }
    
        [DataMember(Order = 33)]
    private string supplierName;
    
        /**
       * @return 
    */
        public string getSupplierName() {
               	return supplierName;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSupplierName(string supplierName) {
     	         	    this.supplierName = supplierName;
     	        }
    
        [DataMember(Order = 34)]
    private string supplyMemberId;
    
        /**
       * @return 
    */
        public string getSupplyMemberId() {
               	return supplyMemberId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSupplyMemberId(string supplyMemberId) {
     	         	    this.supplyMemberId = supplyMemberId;
     	        }
    
        [DataMember(Order = 35)]
    private string taoOfferId;
    
        /**
       * @return 
    */
        public string getTaoOfferId() {
               	return taoOfferId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTaoOfferId(string taoOfferId) {
     	         	    this.taoOfferId = taoOfferId;
     	        }
    
        [DataMember(Order = 36)]
    private string unit;
    
        /**
       * @return 
    */
        public string getUnit() {
               	return unit;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUnit(string unit) {
     	         	    this.unit = unit;
     	        }
    
        [DataMember(Order = 37)]
    private double? unitPrice;
    
        /**
       * @return 
    */
        public double? getUnitPrice() {
               	return unitPrice;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUnitPrice(double unitPrice) {
     	         	    this.unitPrice = unitPrice;
     	        }
    
        [DataMember(Order = 38)]
    private string url;
    
        /**
       * @return 
    */
        public string getUrl() {
               	return url;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUrl(string url) {
     	         	    this.url = url;
     	        }
    
        [DataMember(Order = 39)]
    private bool? isVirtual;
    
        /**
       * @return 
    */
        public bool? getIsVirtual() {
               	return isVirtual;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsVirtual(bool isVirtual) {
     	         	    this.isVirtual = isVirtual;
     	        }
    
        [DataMember(Order = 40)]
    private string warehouse;
    
        /**
       * @return 
    */
        public string getWarehouse() {
               	return warehouse;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setWarehouse(string warehouse) {
     	         	    this.warehouse = warehouse;
     	        }
    
        [DataMember(Order = 41)]
    private double? weight;
    
        /**
       * @return 
    */
        public double? getWeight() {
               	return weight;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setWeight(double weight) {
     	         	    this.weight = weight;
     	        }
    
        [DataMember(Order = 42)]
    private AlibabaTradeSubPayInfo[] subPayInfors;
    
        /**
       * @return 
    */
        public AlibabaTradeSubPayInfo[] getSubPayInfors() {
               	return subPayInfors;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubPayInfors(AlibabaTradeSubPayInfo[] subPayInfors) {
     	         	    this.subPayInfors = subPayInfors;
     	        }
    
        [DataMember(Order = 43)]
    private AlibabaTradeSpecInfo[] specInfo;
    
        /**
       * @return 
    */
        public AlibabaTradeSpecInfo[] getSpecInfo() {
               	return specInfo;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSpecInfo(AlibabaTradeSpecInfo[] specInfo) {
     	         	    this.specInfo = specInfo;
     	        }
    
        [DataMember(Order = 44)]
    private AlibabaTradeCargoImage[] images;
    
        /**
       * @return 
    */
        public AlibabaTradeCargoImage[] getImages() {
               	return images;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setImages(AlibabaTradeCargoImage[] images) {
     	         	    this.images = images;
     	        }
    
        [DataMember(Order = 45)]
    private bool? mixSale;
    
        /**
       * @return 是否支持混批
    */
        public bool? getMixSale() {
               	return mixSale;
            }
    
    /**
     * 设置是否支持混批     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMixSale(bool mixSale) {
     	         	    this.mixSale = mixSale;
     	        }
    
        [DataMember(Order = 46)]
    private int? mixBegin;
    
        /**
       * @return 混批起批量
    */
        public int? getMixBegin() {
               	return mixBegin;
            }
    
    /**
     * 设置混批起批量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMixBegin(int mixBegin) {
     	         	    this.mixBegin = mixBegin;
     	        }
    
        [DataMember(Order = 47)]
    private AlibabaTradeOpPromotionInfor productPromotionInfo;
    
        /**
       * @return 商品行级别的优惠信息
    */
        public AlibabaTradeOpPromotionInfor getProductPromotionInfo() {
               	return productPromotionInfo;
            }
    
    /**
     * 设置商品行级别的优惠信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductPromotionInfo(AlibabaTradeOpPromotionInfor productPromotionInfo) {
     	         	    this.productPromotionInfo = productPromotionInfo;
     	        }
    
    
  }
}