using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.p4p.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaCpsOpenTradeBillDTO {

       [DataMember(Order = 1)]
    private long? bizId;
    
        /**
       * @return 主订单号
    */
        public long? getBizId() {
               	return bizId;
            }
    
    /**
     * 设置主订单号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBizId(long bizId) {
     	         	    this.bizId = bizId;
     	        }
    
        [DataMember(Order = 2)]
    private long? bizSubId;
    
        /**
       * @return 子订单号
    */
        public long? getBizSubId() {
               	return bizSubId;
            }
    
    /**
     * 设置子订单号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBizSubId(long bizSubId) {
     	         	    this.bizSubId = bizSubId;
     	        }
    
        [DataMember(Order = 3)]
    private long? feedId;
    
        /**
       * @return 商品ID
    */
        public long? getFeedId() {
               	return feedId;
            }
    
    /**
     * 设置商品ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFeedId(long feedId) {
     	         	    this.feedId = feedId;
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
    private double? tradeAmount;
    
        /**
       * @return 成交金额
    */
        public double? getTradeAmount() {
               	return tradeAmount;
            }
    
    /**
     * 设置成交金额     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTradeAmount(double tradeAmount) {
     	         	    this.tradeAmount = tradeAmount;
     	        }
    
        [DataMember(Order = 6)]
    private int? tradeNumber;
    
        /**
       * @return 成交商品数
    */
        public int? getTradeNumber() {
               	return tradeNumber;
            }
    
    /**
     * 设置成交商品数     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTradeNumber(int tradeNumber) {
     	         	    this.tradeNumber = tradeNumber;
     	        }
    
        [DataMember(Order = 7)]
    private string createTime;
    
        /**
       * @return 创建时间
    */
        public DateTime? getCreateTime() {
                 if (createTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(createTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置创建时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCreateTime(DateTime createTime) {
     	         	    this.createTime = DateUtil.format(createTime);
     	        }
    
        [DataMember(Order = 8)]
    private string confirmTime;
    
        /**
       * @return 确定收货时间
    */
        public DateTime? getConfirmTime() {
                 if (confirmTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(confirmTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置确定收货时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setConfirmTime(DateTime confirmTime) {
     	         	    this.confirmTime = DateUtil.format(confirmTime);
     	        }
    
        [DataMember(Order = 9)]
    private int? orderState;
    
        /**
       * @return 订单状态
    */
        public int? getOrderState() {
               	return orderState;
            }
    
    /**
     * 设置订单状态     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderState(int orderState) {
     	         	    this.orderState = orderState;
     	        }
    
        [DataMember(Order = 10)]
    private string settleTime;
    
        /**
       * @return 结算时间
    */
        public DateTime? getSettleTime() {
                 if (settleTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(settleTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置结算时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSettleTime(DateTime settleTime) {
     	         	    this.settleTime = DateUtil.format(settleTime);
     	        }
    
        [DataMember(Order = 11)]
    private int? settleState;
    
        /**
       * @return 结算状态
    */
        public int? getSettleState() {
               	return settleState;
            }
    
    /**
     * 设置结算状态     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSettleState(int settleState) {
     	         	    this.settleState = settleState;
     	        }
    
        [DataMember(Order = 12)]
    private double? ratio;
    
        /**
       * @return 佣金比例
    */
        public double? getRatio() {
               	return ratio;
            }
    
    /**
     * 设置佣金比例     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRatio(double ratio) {
     	         	    this.ratio = ratio;
     	        }
    
        [DataMember(Order = 13)]
    private double? commission;
    
        /**
       * @return 佣金金额
    */
        public double? getCommission() {
               	return commission;
            }
    
    /**
     * 设置佣金金额     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCommission(double commission) {
     	         	    this.commission = commission;
     	        }
    
        [DataMember(Order = 14)]
    private double? subCommission;
    
        /**
       * @return 子推客佣金
    */
        public double? getSubCommission() {
               	return subCommission;
            }
    
    /**
     * 设置子推客佣金     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubCommission(double subCommission) {
     	         	    this.subCommission = subCommission;
     	        }
    
        [DataMember(Order = 15)]
    private int? type;
    
        /**
       * @return 推广类型 0：商品，1：店铺，2：活动，9：三方
    */
        public int? getType() {
               	return type;
            }
    
    /**
     * 设置推广类型 0：商品，1：店铺，2：活动，9：三方     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setType(int type) {
     	         	    this.type = type;
     	        }
    
        [DataMember(Order = 16)]
    private long? mediaId;
    
        /**
       * @return 媒体
    */
        public long? getMediaId() {
               	return mediaId;
            }
    
    /**
     * 设置媒体     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMediaId(long mediaId) {
     	         	    this.mediaId = mediaId;
     	        }
    
        [DataMember(Order = 17)]
    private long? mediaZoneId;
    
        /**
       * @return 推广位
    */
        public long? getMediaZoneId() {
               	return mediaZoneId;
            }
    
    /**
     * 设置推广位     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMediaZoneId(long mediaZoneId) {
     	         	    this.mediaZoneId = mediaZoneId;
     	        }
    
        [DataMember(Order = 18)]
    private long? tkId;
    
        /**
       * @return 推客id
    */
        public long? getTkId() {
               	return tkId;
            }
    
    /**
     * 设置推客id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTkId(long tkId) {
     	         	    this.tkId = tkId;
     	        }
    
        [DataMember(Order = 19)]
    private long? subTkId;
    
        /**
       * @return 子推客id
    */
        public long? getSubTkId() {
               	return subTkId;
            }
    
    /**
     * 设置子推客id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubTkId(long subTkId) {
     	         	    this.subTkId = subTkId;
     	        }
    
        [DataMember(Order = 20)]
    private double? tkRatio;
    
        /**
       * @return 主推客的分佣比例
    */
        public double? getTkRatio() {
               	return tkRatio;
            }
    
    /**
     * 设置主推客的分佣比例     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTkRatio(double tkRatio) {
     	         	    this.tkRatio = tkRatio;
     	        }
    
        [DataMember(Order = 21)]
    private double? subTkRatio;
    
        /**
       * @return 子推客分佣比例
    */
        public double? getSubTkRatio() {
               	return subTkRatio;
            }
    
    /**
     * 设置子推客分佣比例     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubTkRatio(double subTkRatio) {
     	         	    this.subTkRatio = subTkRatio;
     	        }
    
        [DataMember(Order = 22)]
    private double? platformRatio;
    
        /**
       * @return 平台分成比例
    */
        public double? getPlatformRatio() {
               	return platformRatio;
            }
    
    /**
     * 设置平台分成比例     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPlatformRatio(double platformRatio) {
     	         	    this.platformRatio = platformRatio;
     	        }
    
        [DataMember(Order = 23)]
    private long? buyerId;
    
        /**
       * @return 买家id
    */
        public long? getBuyerId() {
               	return buyerId;
            }
    
    /**
     * 设置买家id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerId(long buyerId) {
     	         	    this.buyerId = buyerId;
     	        }
    
        [DataMember(Order = 24)]
    private long? sellerId;
    
        /**
       * @return 卖家id
    */
        public long? getSellerId() {
               	return sellerId;
            }
    
    /**
     * 设置卖家id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerId(long sellerId) {
     	         	    this.sellerId = sellerId;
     	        }
    
        [DataMember(Order = 25)]
    private string tradeType;
    
        /**
       * @return 交易类型，对应交易线的类型
    */
        public string getTradeType() {
               	return tradeType;
            }
    
    /**
     * 设置交易类型，对应交易线的类型     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTradeType(string tradeType) {
     	         	    this.tradeType = tradeType;
     	        }
    
        [DataMember(Order = 26)]
    private double? subsidizationRatio;
    
        /**
       * @return 补贴金额比例
    */
        public double? getSubsidizationRatio() {
               	return subsidizationRatio;
            }
    
    /**
     * 设置补贴金额比例     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubsidizationRatio(double subsidizationRatio) {
     	         	    this.subsidizationRatio = subsidizationRatio;
     	        }
    
        [DataMember(Order = 27)]
    private double? subsidizationAmount;
    
        /**
       * @return 推客补贴金额
    */
        public double? getSubsidizationAmount() {
               	return subsidizationAmount;
            }
    
    /**
     * 设置推客补贴金额     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubsidizationAmount(double subsidizationAmount) {
     	         	    this.subsidizationAmount = subsidizationAmount;
     	        }
    
        [DataMember(Order = 28)]
    private double? subSubsidizationAmount;
    
        /**
       * @return 子推客补贴金额
    */
        public double? getSubSubsidizationAmount() {
               	return subSubsidizationAmount;
            }
    
    /**
     * 设置子推客补贴金额     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubSubsidizationAmount(double subSubsidizationAmount) {
     	         	    this.subSubsidizationAmount = subSubsidizationAmount;
     	        }
    
        [DataMember(Order = 29)]
    private string ext;
    
        /**
       * @return ext字段
    */
        public string getExt() {
               	return ext;
            }
    
    /**
     * 设置ext字段     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setExt(string ext) {
     	         	    this.ext = ext;
     	        }
    
    
  }
}