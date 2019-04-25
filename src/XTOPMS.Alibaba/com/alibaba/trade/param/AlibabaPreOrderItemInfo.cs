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
public class AlibabaPreOrderItemInfo {

       [DataMember(Order = 1)]
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
    
        [DataMember(Order = 2)]
    private string sourceType;
    
        /**
       * @return 货品来源
    */
        public string getSourceType() {
               	return sourceType;
            }
    
    /**
     * 设置货品来源     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSourceType(string sourceType) {
     	         	    this.sourceType = sourceType;
     	        }
    
        [DataMember(Order = 3)]
    private string auctionUnit;
    
        /**
       * @return 货品单位
    */
        public string getAuctionUnit() {
               	return auctionUnit;
            }
    
    /**
     * 设置货品单位     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAuctionUnit(string auctionUnit) {
     	         	    this.auctionUnit = auctionUnit;
     	        }
    
        [DataMember(Order = 4)]
    private long? discountFee;
    
        /**
       * @return 优惠金额
    */
        public long? getDiscountFee() {
               	return discountFee;
            }
    
    /**
     * 设置优惠金额     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDiscountFee(long discountFee) {
     	         	    this.discountFee = discountFee;
     	        }
    
        [DataMember(Order = 5)]
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
    
        [DataMember(Order = 6)]
    private int? status;
    
        /**
       * @return 状态
    */
        public int? getStatus() {
               	return status;
            }
    
    /**
     * 设置状态     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStatus(int status) {
     	         	    this.status = status;
     	        }
    
        [DataMember(Order = 7)]
    private string remark;
    
        /**
       * @return 备注
    */
        public string getRemark() {
               	return remark;
            }
    
    /**
     * 设置备注     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRemark(string remark) {
     	         	    this.remark = remark;
     	        }
    
        [DataMember(Order = 8)]
    private long? adjustFee;
    
        /**
       * @return 改价金额
    */
        public long? getAdjustFee() {
               	return adjustFee;
            }
    
    /**
     * 设置改价金额     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAdjustFee(long adjustFee) {
     	         	    this.adjustFee = adjustFee;
     	        }
    
        [DataMember(Order = 9)]
    private long? buyerId;
    
        /**
       * @return 买家userId
    */
        public long? getBuyerId() {
               	return buyerId;
            }
    
    /**
     * 设置买家userId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerId(long buyerId) {
     	         	    this.buyerId = buyerId;
     	        }
    
        [DataMember(Order = 10)]
    private string auctionPicUrl;
    
        /**
       * @return 货品图片url
    */
        public string getAuctionPicUrl() {
               	return auctionPicUrl;
            }
    
    /**
     * 设置货品图片url     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAuctionPicUrl(string auctionPicUrl) {
     	         	    this.auctionPicUrl = auctionPicUrl;
     	        }
    
        [DataMember(Order = 11)]
    private long? id;
    
        /**
       * @return 主键
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置主键     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setId(long id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 12)]
    private long? orderDraftId;
    
        /**
       * @return 开单记录id
    */
        public long? getOrderDraftId() {
               	return orderDraftId;
            }
    
    /**
     * 设置开单记录id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderDraftId(long orderDraftId) {
     	         	    this.orderDraftId = orderDraftId;
     	        }
    
        [DataMember(Order = 13)]
    private long? auctionPrice;
    
        /**
       * @return 货品单价
    */
        public long? getAuctionPrice() {
               	return auctionPrice;
            }
    
    /**
     * 设置货品单价     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAuctionPrice(long auctionPrice) {
     	         	    this.auctionPrice = auctionPrice;
     	        }
    
        [DataMember(Order = 14)]
    private long? totalFee;
    
        /**
       * @return 总价格
    */
        public long? getTotalFee() {
               	return totalFee;
            }
    
    /**
     * 设置总价格     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTotalFee(long totalFee) {
     	         	    this.totalFee = totalFee;
     	        }
    
        [DataMember(Order = 15)]
    private int? auctionNumber;
    
        /**
       * @return 货品货号
    */
        public int? getAuctionNumber() {
               	return auctionNumber;
            }
    
    /**
     * 设置货品货号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAuctionNumber(int auctionNumber) {
     	         	    this.auctionNumber = auctionNumber;
     	        }
    
        [DataMember(Order = 16)]
    private long? sellerId;
    
        /**
       * @return 卖家userId
    */
        public long? getSellerId() {
               	return sellerId;
            }
    
    /**
     * 设置卖家userId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerId(long sellerId) {
     	         	    this.sellerId = sellerId;
     	        }
    
        [DataMember(Order = 17)]
    private string specId;
    
        /**
       * @return 规格编号，同一个Offer不重复
    */
        public string getSpecId() {
               	return specId;
            }
    
    /**
     * 设置规格编号，同一个Offer不重复     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSpecId(string specId) {
     	         	    this.specId = specId;
     	        }
    
        [DataMember(Order = 18)]
    private long? auctionId;
    
        /**
       * @return 货品id
    */
        public long? getAuctionId() {
               	return auctionId;
            }
    
    /**
     * 设置货品id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAuctionId(long auctionId) {
     	         	    this.auctionId = auctionId;
     	        }
    
        [DataMember(Order = 19)]
    private long? skuId;
    
        /**
       * @return 规格ID，全局唯一
    */
        public long? getSkuId() {
               	return skuId;
            }
    
    /**
     * 设置规格ID，全局唯一     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkuId(long skuId) {
     	         	    this.skuId = skuId;
     	        }
    
        [DataMember(Order = 20)]
    private string auctionTitle;
    
        /**
       * @return 货品名称
    */
        public string getAuctionTitle() {
               	return auctionTitle;
            }
    
    /**
     * 设置货品名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAuctionTitle(string auctionTitle) {
     	         	    this.auctionTitle = auctionTitle;
     	        }
    
        [DataMember(Order = 21)]
    private long? buyAmount;
    
        /**
       * @return 购买数量
    */
        public long? getBuyAmount() {
               	return buyAmount;
            }
    
    /**
     * 设置购买数量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyAmount(long buyAmount) {
     	         	    this.buyAmount = buyAmount;
     	        }
    
    
  }
}