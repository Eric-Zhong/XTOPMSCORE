using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.logistics.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaBulksettlementOpReceiveNoteEntryModel {

       [DataMember(Order = 1)]
    private long? id;
    
        /**
       * @return 收货子单id
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置收货子单id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setId(long id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 2)]
    private long? receiveId;
    
        /**
       * @return 收货单id
    */
        public long? getReceiveId() {
               	return receiveId;
            }
    
    /**
     * 设置收货单id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiveId(long receiveId) {
     	         	    this.receiveId = receiveId;
     	        }
    
        [DataMember(Order = 3)]
    private string statusInfo;
    
        /**
       * @return 收货子单状态
    */
        public string getStatusInfo() {
               	return statusInfo;
            }
    
    /**
     * 设置收货子单状态     *
     * 参数示例：<pre>1 待发起结算
2 已发起结算</pre>     
             * 此参数必填
          */
    public void setStatusInfo(string statusInfo) {
     	         	    this.statusInfo = statusInfo;
     	        }
    
        [DataMember(Order = 4)]
    private long? settlementOrderId;
    
        /**
       * @return 结算单id
    */
        public long? getSettlementOrderId() {
               	return settlementOrderId;
            }
    
    /**
     * 设置结算单id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSettlementOrderId(long settlementOrderId) {
     	         	    this.settlementOrderId = settlementOrderId;
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
    
        [DataMember(Order = 7)]
    private string endTime;
    
        /**
       * @return 发起结算时间
    */
        public DateTime? getEndTime() {
                 if (endTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(endTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置发起结算时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setEndTime(DateTime endTime) {
     	         	    this.endTime = DateUtil.format(endTime);
     	        }
    
        [DataMember(Order = 8)]
    private long? orderId;
    
        /**
       * @return 主订单号
    */
        public long? getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置主订单号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderId(long orderId) {
     	         	    this.orderId = orderId;
     	        }
    
        [DataMember(Order = 9)]
    private long? orderEntryId;
    
        /**
       * @return 子订单号
    */
        public long? getOrderEntryId() {
               	return orderEntryId;
            }
    
    /**
     * 设置子订单号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderEntryId(long orderEntryId) {
     	         	    this.orderEntryId = orderEntryId;
     	        }
    
        [DataMember(Order = 10)]
    private string orderSourceType;
    
        /**
       * @return 该订单明细订购的来源
    */
        public string getOrderSourceType() {
               	return orderSourceType;
            }
    
    /**
     * 设置该订单明细订购的来源     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderSourceType(string orderSourceType) {
     	         	    this.orderSourceType = orderSourceType;
     	        }
    
        [DataMember(Order = 11)]
    private long? price;
    
        /**
       * @return 单价 (实付款-已退款)/总件数，单位：分
    */
        public long? getPrice() {
               	return price;
            }
    
    /**
     * 设置单价 (实付款-已退款)/总件数，单位：分     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPrice(long price) {
     	         	    this.price = price;
     	        }
    
        [DataMember(Order = 12)]
    private long? originalPrice;
    
        /**
       * @return 原始单价，单位：分
    */
        public long? getOriginalPrice() {
               	return originalPrice;
            }
    
    /**
     * 设置原始单价，单位：分     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOriginalPrice(long originalPrice) {
     	         	    this.originalPrice = originalPrice;
     	        }
    
        [DataMember(Order = 13)]
    private long? postFee;
    
        /**
       * @return 运费 单位：分
    */
        public long? getPostFee() {
               	return postFee;
            }
    
    /**
     * 设置运费 单位：分     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPostFee(long postFee) {
     	         	    this.postFee = postFee;
     	        }
    
        [DataMember(Order = 14)]
    private long? actualPayFee;
    
        /**
       * @return 应付款，单位：分；
    */
        public long? getActualPayFee() {
               	return actualPayFee;
            }
    
    /**
     * 设置应付款，单位：分；     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setActualPayFee(long actualPayFee) {
     	         	    this.actualPayFee = actualPayFee;
     	        }
    
        [DataMember(Order = 15)]
    private string productName;
    
        /**
       * @return 产品名称
    */
        public string getProductName() {
               	return productName;
            }
    
    /**
     * 设置产品名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductName(string productName) {
     	         	    this.productName = productName;
     	        }
    
        [DataMember(Order = 16)]
    private long? sourceId;
    
        /**
       * @return 商品Id
    */
        public long? getSourceId() {
               	return sourceId;
            }
    
    /**
     * 设置商品Id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSourceId(long sourceId) {
     	         	    this.sourceId = sourceId;
     	        }
    
        [DataMember(Order = 17)]
    private string summImageUrl;
    
        /**
       * @return 小图图片:全路径,目前动态生成小图规格:64x64
    */
        public string getSummImageUrl() {
               	return summImageUrl;
            }
    
    /**
     * 设置小图图片:全路径,目前动态生成小图规格:64x64     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSummImageUrl(string summImageUrl) {
     	         	    this.summImageUrl = summImageUrl;
     	        }
    
        [DataMember(Order = 18)]
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
    
        [DataMember(Order = 19)]
    private string productMaterialCode;
    
        /**
       * @return 货品的物料编码
    */
        public string getProductMaterialCode() {
               	return productMaterialCode;
            }
    
    /**
     * 设置货品的物料编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductMaterialCode(string productMaterialCode) {
     	         	    this.productMaterialCode = productMaterialCode;
     	        }
    
        [DataMember(Order = 20)]
    private string attributes;
    
        /**
       * @return 扩展属性
    */
        public string getAttributes() {
               	return attributes;
            }
    
    /**
     * 设置扩展属性     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAttributes(string attributes) {
     	         	    this.attributes = attributes;
     	        }
    
        [DataMember(Order = 21)]
    private long? amount;
    
        /**
       * @return 收货件数
    */
        public long? getAmount() {
               	return amount;
            }
    
    /**
     * 设置收货件数     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAmount(long amount) {
     	         	    this.amount = amount;
     	        }
    
        [DataMember(Order = 22)]
    private AlibabaBulksettlementOpSpecItem[] specItems;
    
        /**
       * @return 规格属性条目列表
    */
        public AlibabaBulksettlementOpSpecItem[] getSpecItems() {
               	return specItems;
            }
    
    /**
     * 设置规格属性条目列表     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSpecItems(AlibabaBulksettlementOpSpecItem[] specItems) {
     	         	    this.specItems = specItems;
     	        }
    
        [DataMember(Order = 23)]
    private AlibabaBulksettlementOpQuantityModel quantityModel;
    
        /**
       * @return 数量模型，支持小数
    */
        public AlibabaBulksettlementOpQuantityModel getQuantityModel() {
               	return quantityModel;
            }
    
    /**
     * 设置数量模型，支持小数     *
     * 参数示例：<pre>{"realAmount":0.001,"amountFactor":1000.0,"calAmount":1,"realAmountStr":"0.001"}</pre>     
             * 此参数必填
          */
    public void setQuantityModel(AlibabaBulksettlementOpQuantityModel quantityModel) {
     	         	    this.quantityModel = quantityModel;
     	        }
    
    
  }
}