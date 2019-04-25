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
public class AlibabaOpenplatformTradeBizCargoGroup {

       [DataMember(Order = 1)]
    private string group;
    
        /**
       * @return 信息所属分组。多订单提交时用来分组。
    */
        public string getGroup() {
               	return group;
            }
    
    /**
     * 设置信息所属分组。多订单提交时用来分组。     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGroup(string group) {
     	         	    this.group = group;
     	        }
    
        [DataMember(Order = 2)]
    private string cargoKey;
    
        /**
       * @return 商品id
    */
        public string getCargoKey() {
               	return cargoKey;
            }
    
    /**
     * 设置商品id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCargoKey(string cargoKey) {
     	         	    this.cargoKey = cargoKey;
     	        }
    
        [DataMember(Order = 3)]
    private string name;
    
        /**
       * @return 商品名称
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置商品名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
        [DataMember(Order = 4)]
    private string unit;
    
        /**
       * @return 销售单位
    */
        public string getUnit() {
               	return unit;
            }
    
    /**
     * 设置销售单位     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUnit(string unit) {
     	         	    this.unit = unit;
     	        }
    
        [DataMember(Order = 5)]
    private double? quantity;
    
        /**
       * @return 商品数量(计算金额用)
    */
        public double? getQuantity() {
               	return quantity;
            }
    
    /**
     * 设置商品数量(计算金额用)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setQuantity(double quantity) {
     	         	    this.quantity = quantity;
     	        }
    
        [DataMember(Order = 6)]
    private double? packageNum;
    
        /**
       * @return 商品件数
    */
        public double? getPackageNum() {
               	return packageNum;
            }
    
    /**
     * 设置商品件数     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPackageNum(double packageNum) {
     	         	    this.packageNum = packageNum;
     	        }
    
        [DataMember(Order = 7)]
    private double? unitPrice;
    
        /**
       * @return 产品单价, 单位:元.
    */
        public double? getUnitPrice() {
               	return unitPrice;
            }
    
    /**
     * 设置产品单价, 单位:元.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUnitPrice(double unitPrice) {
     	         	    this.unitPrice = unitPrice;
     	        }
    
        [DataMember(Order = 8)]
    private long? offerId;
    
        /**
       * @return Offer Id
    */
        public long? getOfferId() {
               	return offerId;
            }
    
    /**
     * 设置Offer Id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOfferId(long offerId) {
     	         	    this.offerId = offerId;
     	        }
    
        [DataMember(Order = 9)]
    private string specId;
    
        /**
       * @return sku offer 时商品对应的specId.
    */
        public string getSpecId() {
               	return specId;
            }
    
    /**
     * 设置sku offer 时商品对应的specId.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSpecId(string specId) {
     	         	    this.specId = specId;
     	        }
    
        [DataMember(Order = 10)]
    private long? skuId;
    
        /**
       * @return sku offer 时商品对应的skuId.
    */
        public long? getSkuId() {
               	return skuId;
            }
    
    /**
     * 设置sku offer 时商品对应的skuId.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkuId(long skuId) {
     	         	    this.skuId = skuId;
     	        }
    
        [DataMember(Order = 11)]
    private long? categoryId;
    
        /**
       * @return 类目id
    */
        public long? getCategoryId() {
               	return categoryId;
            }
    
    /**
     * 设置类目id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCategoryId(long categoryId) {
     	         	    this.categoryId = categoryId;
     	        }
    
        [DataMember(Order = 12)]
    private double? productAmount;
    
        /**
       * @return 金额，提交的时候需要判断金额是否发生变化。单位:元
    */
        public double? getProductAmount() {
               	return productAmount;
            }
    
    /**
     * 设置金额，提交的时候需要判断金额是否发生变化。单位:元     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductAmount(double productAmount) {
     	         	    this.productAmount = productAmount;
     	        }
    
        [DataMember(Order = 13)]
    private int? chooseFreeFreight;
    
        /**
       * @return 用户选择单品免运费 "0"：用户没有选择免用费 "1":用户选择免运费.
    */
        public int? getChooseFreeFreight() {
               	return chooseFreeFreight;
            }
    
    /**
     * 设置用户选择单品免运费 "0"：用户没有选择免用费 "1":用户选择免运费.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setChooseFreeFreight(int chooseFreeFreight) {
     	         	    this.chooseFreeFreight = chooseFreeFreight;
     	        }
    
        [DataMember(Order = 14)]
    private double? discount;
    
        /**
       * @return 折扣。若没有填1.0
    */
        public double? getDiscount() {
               	return discount;
            }
    
    /**
     * 设置折扣。若没有填1.0     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDiscount(double discount) {
     	         	    this.discount = discount;
     	        }
    
        [DataMember(Order = 15)]
    private int? isVirtual;
    
        /**
       * @return 是否虚拟物品 0:不是， 1：虚拟物品
    */
        public int? getIsVirtual() {
               	return isVirtual;
            }
    
    /**
     * 设置是否虚拟物品 0:不是， 1：虚拟物品     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsVirtual(int isVirtual) {
     	         	    this.isVirtual = isVirtual;
     	        }
    
        [DataMember(Order = 16)]
    private long? cartId;
    
        /**
       * @return 淘宝cartId
    */
        public long? getCartId() {
               	return cartId;
            }
    
    /**
     * 设置淘宝cartId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCartId(long cartId) {
     	         	    this.cartId = cartId;
     	        }
    
        [DataMember(Order = 17)]
    private string promotionId;
    
        /**
       * @return 单品优惠id
    */
        public string getPromotionId() {
               	return promotionId;
            }
    
    /**
     * 设置单品优惠id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPromotionId(string promotionId) {
     	         	    this.promotionId = promotionId;
     	        }
    
        [DataMember(Order = 18)]
    private string mergedJsonVar;
    
        /**
       * @return json格式的所有数据. 批量下单进行了使用.
    */
        public string getMergedJsonVar() {
               	return mergedJsonVar;
            }
    
    /**
     * 设置json格式的所有数据. 批量下单进行了使用.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMergedJsonVar(string mergedJsonVar) {
     	         	    this.mergedJsonVar = mergedJsonVar;
     	        }
    
        [DataMember(Order = 19)]
    private bool? buyerCharge;
    
        /**
       * @return 单个商品关联运费模板时买家承担服务费。true:买家，false:卖家
    */
        public bool? getBuyerCharge() {
               	return buyerCharge;
            }
    
    /**
     * 设置单个商品关联运费模板时买家承担服务费。true:买家，false:卖家     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerCharge(bool buyerCharge) {
     	         	    this.buyerCharge = buyerCharge;
     	        }
    
        [DataMember(Order = 20)]
    private string ext;
    
        /**
       * @return 扩张属性，以json串形式，存与offer同一级别的属性
    */
        public string getExt() {
               	return ext;
            }
    
    /**
     * 设置扩张属性，以json串形式，存与offer同一级别的属性     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setExt(string ext) {
     	         	    this.ext = ext;
     	        }
    
        [DataMember(Order = 21)]
    private string attachedType;
    
        /**
       * @return 附加标的物类型, 拆单校验遇到此标记会越过此标的物的拆单结果比较 默认没有值, 存样服务: "cyfw"
    */
        public string getAttachedType() {
               	return attachedType;
            }
    
    /**
     * 设置附加标的物类型, 拆单校验遇到此标记会越过此标的物的拆单结果比较 默认没有值, 存样服务: "cyfw"     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAttachedType(string attachedType) {
     	         	    this.attachedType = attachedType;
     	        }
    
        [DataMember(Order = 22)]
    private bool? free;
    
        /**
       * @return 是否免费, 一般用于服务类型商品.
    */
        public bool? getFree() {
               	return free;
            }
    
    /**
     * 设置是否免费, 一般用于服务类型商品.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFree(bool free) {
     	         	    this.free = free;
     	        }
    
        [DataMember(Order = 23)]
    private string gift;
    
        /**
       * @return 赠品标记, hg: 换购 , zs: 赠送
    */
        public string getGift() {
               	return gift;
            }
    
    /**
     * 设置赠品标记, hg: 换购 , zs: 赠送     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGift(string gift) {
     	         	    this.gift = gift;
     	        }
    
        [DataMember(Order = 24)]
    private AlibabaTradeComKeyValuePair[] extParams;
    
        /**
       * @return 扩展数据
    */
        public AlibabaTradeComKeyValuePair[] getExtParams() {
               	return extParams;
            }
    
    /**
     * 设置扩展数据     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setExtParams(AlibabaTradeComKeyValuePair[] extParams) {
     	         	    this.extParams = extParams;
     	        }
    
        [DataMember(Order = 25)]
    private string supplierName;
    
        /**
       * @return 供应商名字
    */
        public string getSupplierName() {
               	return supplierName;
            }
    
    /**
     * 设置供应商名字     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSupplierName(string supplierName) {
     	         	    this.supplierName = supplierName;
     	        }
    
        [DataMember(Order = 26)]
    private string warehouse;
    
        /**
       * @return 仓库名称
    */
        public string getWarehouse() {
               	return warehouse;
            }
    
    /**
     * 设置仓库名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setWarehouse(string warehouse) {
     	         	    this.warehouse = warehouse;
     	        }
    
        [DataMember(Order = 27)]
    private double? discountFee;
    
        /**
       * @return 减免金额, 单位, 元
    */
        public double? getDiscountFee() {
               	return discountFee;
            }
    
    /**
     * 设置减免金额, 单位, 元     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDiscountFee(double discountFee) {
     	         	    this.discountFee = discountFee;
     	        }
    
        [DataMember(Order = 28)]
    private double? additionalFee;
    
        /**
       * @return 附加费,单位，元
    */
        public double? getAdditionalFee() {
               	return additionalFee;
            }
    
    /**
     * 设置附加费,单位，元     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAdditionalFee(double additionalFee) {
     	         	    this.additionalFee = additionalFee;
     	        }
    
        [DataMember(Order = 29)]
    private string sellerMemberId;
    
        /**
       * @return 卖家memberId
    */
        public string getSellerMemberId() {
               	return sellerMemberId;
            }
    
    /**
     * 设置卖家memberId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerMemberId(string sellerMemberId) {
     	         	    this.sellerMemberId = sellerMemberId;
     	        }
    
        [DataMember(Order = 30)]
    private AlibabaOpenplatformTradeJsonGoodsParam jsonGoodsParam;
    
        /**
       * @return 当前提交订单操作, 订单块对应的展示订单的货品url参数模型(本次提交订单对应的展示订单url参数, 此模型的该属性不由前端直接赋值)
    */
        public AlibabaOpenplatformTradeJsonGoodsParam getJsonGoodsParam() {
               	return jsonGoodsParam;
            }
    
    /**
     * 设置当前提交订单操作, 订单块对应的展示订单的货品url参数模型(本次提交订单对应的展示订单url参数, 此模型的该属性不由前端直接赋值)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setJsonGoodsParam(AlibabaOpenplatformTradeJsonGoodsParam jsonGoodsParam) {
     	         	    this.jsonGoodsParam = jsonGoodsParam;
     	        }
    
        [DataMember(Order = 31)]
    private AlibabaOpenplatformTradeSpecInfo specInfo;
    
        /**
       * @return 规格属性
    */
        public AlibabaOpenplatformTradeSpecInfo getSpecInfo() {
               	return specInfo;
            }
    
    /**
     * 设置规格属性     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSpecInfo(AlibabaOpenplatformTradeSpecInfo specInfo) {
     	         	    this.specInfo = specInfo;
     	        }
    
    
  }
}