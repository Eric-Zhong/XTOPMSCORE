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
public class AlibabaOpenplatformTradeModelProductItemInfo {

       [DataMember(Order = 1)]
    private string cargoNumber;
    
        /**
       * @return 指定单品货号，国际站无需关注。该字段不一定有值，仅仅在下单时才会把货号记录(如果卖家设置了单品货号的话)。别的订单类型的货号只能通过商品接口去获取。请注意：通过商品接口获取时的货号和下单时的货号可能不一致，因为下单完成后卖家可能修改商品信息，改变了货号。
    */
        public string getCargoNumber() {
               	return cargoNumber;
            }
    
    /**
     * 设置指定单品货号，国际站无需关注。该字段不一定有值，仅仅在下单时才会把货号记录(如果卖家设置了单品货号的话)。别的订单类型的货号只能通过商品接口去获取。请注意：通过商品接口获取时的货号和下单时的货号可能不一致，因为下单完成后卖家可能修改商品信息，改变了货号。     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCargoNumber(string cargoNumber) {
     	         	    this.cargoNumber = cargoNumber;
     	        }
    
        [DataMember(Order = 2)]
    private string description;
    
        /**
       * @return 描述,1688无此信息
    */
        public string getDescription() {
               	return description;
            }
    
    /**
     * 设置描述,1688无此信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDescription(string description) {
     	         	    this.description = description;
     	        }
    
        [DataMember(Order = 3)]
    private decimal? itemAmount;
    
        /**
       * @return 实付金额，单位为元
    */
        public decimal? getItemAmount() {
               	return itemAmount;
            }
    
    /**
     * 设置实付金额，单位为元     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setItemAmount(decimal itemAmount) {
     	         	    this.itemAmount = itemAmount;
     	        }
    
        [DataMember(Order = 4)]
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
    
        [DataMember(Order = 5)]
    private decimal? price;
    
        /**
       * @return 原始单价，以元为单位
    */
        public decimal? getPrice() {
               	return price;
            }
    
    /**
     * 设置原始单价，以元为单位     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPrice(decimal price) {
     	         	    this.price = price;
     	        }
    
        [DataMember(Order = 6)]
    private long? productID;
    
        /**
       * @return 产品ID（非在线产品为空）
    */
        public long? getProductID() {
               	return productID;
            }
    
    /**
     * 设置产品ID（非在线产品为空）     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductID(long productID) {
     	         	    this.productID = productID;
     	        }
    
        [DataMember(Order = 7)]
    private string[] productImgUrl;
    
        /**
       * @return 商品图片url
    */
        public string[] getProductImgUrl() {
               	return productImgUrl;
            }
    
    /**
     * 设置商品图片url     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductImgUrl(string[] productImgUrl) {
     	         	    this.productImgUrl = productImgUrl;
     	        }
    
        [DataMember(Order = 8)]
    private string productSnapshotUrl;
    
        /**
       * @return 产品快照url，交易订单产生时会自动记录下当时的商品快照，供后续纠纷时参考
    */
        public string getProductSnapshotUrl() {
               	return productSnapshotUrl;
            }
    
    /**
     * 设置产品快照url，交易订单产生时会自动记录下当时的商品快照，供后续纠纷时参考     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductSnapshotUrl(string productSnapshotUrl) {
     	         	    this.productSnapshotUrl = productSnapshotUrl;
     	        }
    
        [DataMember(Order = 9)]
    private decimal? quantity;
    
        /**
       * @return 以unit为单位的数量，例如多少个、多少件、多少箱、多少吨
    */
        public decimal? getQuantity() {
               	return quantity;
            }
    
    /**
     * 设置以unit为单位的数量，例如多少个、多少件、多少箱、多少吨     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setQuantity(decimal quantity) {
     	         	    this.quantity = quantity;
     	        }
    
        [DataMember(Order = 10)]
    private decimal? refund;
    
        /**
       * @return 退款金额，单位为元
    */
        public decimal? getRefund() {
               	return refund;
            }
    
    /**
     * 设置退款金额，单位为元     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRefund(decimal refund) {
     	         	    this.refund = refund;
     	        }
    
        [DataMember(Order = 11)]
    private long? skuID;
    
        /**
       * @return skuID
    */
        public long? getSkuID() {
               	return skuID;
            }
    
    /**
     * 设置skuID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkuID(long skuID) {
     	         	    this.skuID = skuID;
     	        }
    
        [DataMember(Order = 12)]
    private int? sort;
    
        /**
       * @return 排序字段，商品列表按此字段进行排序，从0开始，1688不提供
    */
        public int? getSort() {
               	return sort;
            }
    
    /**
     * 设置排序字段，商品列表按此字段进行排序，从0开始，1688不提供     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSort(int sort) {
     	         	    this.sort = sort;
     	        }
    
        [DataMember(Order = 13)]
    private string status;
    
        /**
       * @return 子订单状态
    */
        public string getStatus() {
               	return status;
            }
    
    /**
     * 设置子订单状态     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStatus(string status) {
     	         	    this.status = status;
     	        }
    
        [DataMember(Order = 14)]
    private long? subItemID;
    
        /**
       * @return 子订单号，或商品明细条目ID
    */
        public long? getSubItemID() {
               	return subItemID;
            }
    
    /**
     * 设置子订单号，或商品明细条目ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubItemID(long subItemID) {
     	         	    this.subItemID = subItemID;
     	        }
    
        [DataMember(Order = 15)]
    private string type;
    
        /**
       * @return 类型，国际站使用，供卖家标注商品所属类型
    */
        public string getType() {
               	return type;
            }
    
    /**
     * 设置类型，国际站使用，供卖家标注商品所属类型     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setType(string type) {
     	         	    this.type = type;
     	        }
    
        [DataMember(Order = 16)]
    private string unit;
    
        /**
       * @return 售卖单位	例如：个、件、箱、吨
    */
        public string getUnit() {
               	return unit;
            }
    
    /**
     * 设置售卖单位	例如：个、件、箱、吨     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUnit(string unit) {
     	         	    this.unit = unit;
     	        }
    
        [DataMember(Order = 17)]
    private string weight;
    
        /**
       * @return 重量	按重量单位计算的重量，例如：100
    */
        public string getWeight() {
               	return weight;
            }
    
    /**
     * 设置重量	按重量单位计算的重量，例如：100     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setWeight(string weight) {
     	         	    this.weight = weight;
     	        }
    
        [DataMember(Order = 18)]
    private string weightUnit;
    
        /**
       * @return 重量单位	例如：g，kg，t
    */
        public string getWeightUnit() {
               	return weightUnit;
            }
    
    /**
     * 设置重量单位	例如：g，kg，t     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setWeightUnit(string weightUnit) {
     	         	    this.weightUnit = weightUnit;
     	        }
    
        [DataMember(Order = 19)]
    private AlibabaOpenplatformTradeModelGuaranteeTermsInfo[] guaranteesTerms;
    
        /**
       * @return 保障条款，此字段仅针对1688
    */
        public AlibabaOpenplatformTradeModelGuaranteeTermsInfo[] getGuaranteesTerms() {
               	return guaranteesTerms;
            }
    
    /**
     * 设置保障条款，此字段仅针对1688     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGuaranteesTerms(AlibabaOpenplatformTradeModelGuaranteeTermsInfo[] guaranteesTerms) {
     	         	    this.guaranteesTerms = guaranteesTerms;
     	        }
    
        [DataMember(Order = 20)]
    private string productCargoNumber;
    
        /**
       * @return 指定商品货号，该字段不一定有值，在下单时才会把货号记录。别的订单类型的货号只能通过商品接口去获取。请注意：通过商品接口获取时的货号和下单时的货号可能不一致，因为下单完成后卖家可能修改商品信息，改变了货号。该字段和cargoNUmber的区别是：该字段是定义在商品级别上的货号，cargoNUmber是定义在单品级别的货号
    */
        public string getProductCargoNumber() {
               	return productCargoNumber;
            }
    
    /**
     * 设置指定商品货号，该字段不一定有值，在下单时才会把货号记录。别的订单类型的货号只能通过商品接口去获取。请注意：通过商品接口获取时的货号和下单时的货号可能不一致，因为下单完成后卖家可能修改商品信息，改变了货号。该字段和cargoNUmber的区别是：该字段是定义在商品级别上的货号，cargoNUmber是定义在单品级别的货号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductCargoNumber(string productCargoNumber) {
     	         	    this.productCargoNumber = productCargoNumber;
     	        }
    
        [DataMember(Order = 21)]
    private AlibabaTradeSkuItemDesc[] skuInfos;
    
        /**
       * @return 
    */
        public AlibabaTradeSkuItemDesc[] getSkuInfos() {
               	return skuInfos;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkuInfos(AlibabaTradeSkuItemDesc[] skuInfos) {
     	         	    this.skuInfos = skuInfos;
     	        }
    
        [DataMember(Order = 22)]
    private long? entryDiscount;
    
        /**
       * @return 订单明细涨价或降价的金额
    */
        public long? getEntryDiscount() {
               	return entryDiscount;
            }
    
    /**
     * 设置订单明细涨价或降价的金额     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setEntryDiscount(long entryDiscount) {
     	         	    this.entryDiscount = entryDiscount;
     	        }
    
        [DataMember(Order = 23)]
    private string specId;
    
        /**
       * @return 订单销售属性ID
    */
        public string getSpecId() {
               	return specId;
            }
    
    /**
     * 设置订单销售属性ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSpecId(string specId) {
     	         	    this.specId = specId;
     	        }
    
        [DataMember(Order = 24)]
    private decimal? quantityFactor;
    
        /**
       * @return 以unit为单位的quantity精度系数，值为10的幂次，例如:quantityFactor=1000,unit=吨，那么quantity的最小精度为0.001吨
    */
        public decimal? getQuantityFactor() {
               	return quantityFactor;
            }
    
    /**
     * 设置以unit为单位的quantity精度系数，值为10的幂次，例如:quantityFactor=1000,unit=吨，那么quantity的最小精度为0.001吨     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setQuantityFactor(decimal quantityFactor) {
     	         	    this.quantityFactor = quantityFactor;
     	        }
    
        [DataMember(Order = 25)]
    private string statusStr;
    
        /**
       * @return 子订单状态描述
    */
        public string getStatusStr() {
               	return statusStr;
            }
    
    /**
     * 设置子订单状态描述     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStatusStr(string statusStr) {
     	         	    this.statusStr = statusStr;
     	        }
    
        [DataMember(Order = 26)]
    private string refundStatus;
    
        /**
       * @return WAIT_SELLER_AGREE 等待卖家同意
REFUND_SUCCESS 退款成功
REFUND_CLOSED 退款关闭
WAIT_BUYER_MODIFY 待买家修改
WAIT_BUYER_SEND 等待买家退货
WAIT_SELLER_RECEIVE 等待卖家确认收货
    */
        public string getRefundStatus() {
               	return refundStatus;
            }
    
    /**
     * 设置WAIT_SELLER_AGREE 等待卖家同意
REFUND_SUCCESS 退款成功
REFUND_CLOSED 退款关闭
WAIT_BUYER_MODIFY 待买家修改
WAIT_BUYER_SEND 等待买家退货
WAIT_SELLER_RECEIVE 等待卖家确认收货     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRefundStatus(string refundStatus) {
     	         	    this.refundStatus = refundStatus;
     	        }
    
        [DataMember(Order = 27)]
    private string closeReason;
    
        /**
       * @return 关闭原因
    */
        public string getCloseReason() {
               	return closeReason;
            }
    
    /**
     * 设置关闭原因     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCloseReason(string closeReason) {
     	         	    this.closeReason = closeReason;
     	        }
    
        [DataMember(Order = 28)]
    private int? logisticsStatus;
    
        /**
       * @return 1 未发货
2 已发货
3 已收货
4 已经退货
5 部分发货
8 还未创建物流订单
    */
        public int? getLogisticsStatus() {
               	return logisticsStatus;
            }
    
    /**
     * 设置1 未发货
2 已发货
3 已收货
4 已经退货
5 部分发货
8 还未创建物流订单     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsStatus(int logisticsStatus) {
     	         	    this.logisticsStatus = logisticsStatus;
     	        }
    
        [DataMember(Order = 29)]
    private string gmtCreate;
    
        /**
       * @return 创建时间
    */
        public DateTime? getGmtCreate() {
                 if (gmtCreate != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtCreate);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置创建时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGmtCreate(DateTime gmtCreate) {
     	         	    this.gmtCreate = DateUtil.format(gmtCreate);
     	        }
    
        [DataMember(Order = 30)]
    private string gmtModified;
    
        /**
       * @return 修改时间
    */
        public DateTime? getGmtModified() {
                 if (gmtModified != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtModified);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置修改时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGmtModified(DateTime gmtModified) {
     	         	    this.gmtModified = DateUtil.format(gmtModified);
     	        }
    
        [DataMember(Order = 31)]
    private string gmtCompleted;
    
        /**
       * @return 明细完成时间
    */
        public DateTime? getGmtCompleted() {
                 if (gmtCompleted != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtCompleted);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置明细完成时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGmtCompleted(DateTime gmtCompleted) {
     	         	    this.gmtCompleted = DateUtil.format(gmtCompleted);
     	        }
    
        [DataMember(Order = 32)]
    private string gmtPayExpireTime;
    
        /**
       * @return 库存超时时间，格式为“yyyy-MM-dd HH:mm:ss”
    */
        public string getGmtPayExpireTime() {
               	return gmtPayExpireTime;
            }
    
    /**
     * 设置库存超时时间，格式为“yyyy-MM-dd HH:mm:ss”     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGmtPayExpireTime(string gmtPayExpireTime) {
     	         	    this.gmtPayExpireTime = gmtPayExpireTime;
     	        }
    
        [DataMember(Order = 33)]
    private string refundId;
    
        /**
       * @return 售中退款单号
    */
        public string getRefundId() {
               	return refundId;
            }
    
    /**
     * 设置售中退款单号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRefundId(string refundId) {
     	         	    this.refundId = refundId;
     	        }
    
        [DataMember(Order = 34)]
    private string subItemIDString;
    
        /**
       * @return 子订单号，或商品明细条目ID(字符串类型，由于Long类型的ID可能在JS和PHP中处理有问题，所以可以用字符串类型来处理)
    */
        public string getSubItemIDString() {
               	return subItemIDString;
            }
    
    /**
     * 设置子订单号，或商品明细条目ID(字符串类型，由于Long类型的ID可能在JS和PHP中处理有问题，所以可以用字符串类型来处理)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubItemIDString(string subItemIDString) {
     	         	    this.subItemIDString = subItemIDString;
     	        }
    
        [DataMember(Order = 35)]
    private string refundIdForAs;
    
        /**
       * @return 售后退款单号
    */
        public string getRefundIdForAs() {
               	return refundIdForAs;
            }
    
    /**
     * 设置售后退款单号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRefundIdForAs(string refundIdForAs) {
     	         	    this.refundIdForAs = refundIdForAs;
     	        }
    
    
  }
}