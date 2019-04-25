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
public class AlibabaCpsOpenOfferDTO {

       [DataMember(Order = 1)]
    private string loginId;
    
        /**
       * @return login id
    */
        public string getLoginId() {
               	return loginId;
            }
    
    /**
     * 设置login id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLoginId(string loginId) {
     	         	    this.loginId = loginId;
     	        }
    
        [DataMember(Order = 2)]
    private string companyName;
    
        /**
       * @return 公司名称
    */
        public string getCompanyName() {
               	return companyName;
            }
    
    /**
     * 设置公司名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCompanyName(string companyName) {
     	         	    this.companyName = companyName;
     	        }
    
        [DataMember(Order = 3)]
    private long? offerId;
    
        /**
       * @return offer id
    */
        public long? getOfferId() {
               	return offerId;
            }
    
    /**
     * 设置offer id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOfferId(long offerId) {
     	         	    this.offerId = offerId;
     	        }
    
        [DataMember(Order = 4)]
    private long? sellerId;
    
        /**
       * @return 卖家ID
    */
        public long? getSellerId() {
               	return sellerId;
            }
    
    /**
     * 设置卖家ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerId(long sellerId) {
     	         	    this.sellerId = sellerId;
     	        }
    
        [DataMember(Order = 5)]
    private string title;
    
        /**
       * @return offer名称
    */
        public string getTitle() {
               	return title;
            }
    
    /**
     * 设置offer名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTitle(string title) {
     	         	    this.title = title;
     	        }
    
        [DataMember(Order = 6)]
    private string url;
    
        /**
       * @return offer链接
    */
        public string getUrl() {
               	return url;
            }
    
    /**
     * 设置offer链接     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUrl(string url) {
     	         	    this.url = url;
     	        }
    
        [DataMember(Order = 7)]
    private string imgUrl;
    
        /**
       * @return offer主图
    */
        public string getImgUrl() {
               	return imgUrl;
            }
    
    /**
     * 设置offer主图     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setImgUrl(string imgUrl) {
     	         	    this.imgUrl = imgUrl;
     	        }
    
        [DataMember(Order = 8)]
    private double? ratio;
    
        /**
       * @return 佣金比例
    */
        public double? getRatio() {
               	return ratio;
            }
    
    /**
     * 设置佣金比例     *
     * 参数示例：<pre>百分比</pre>     
             * 此参数必填
          */
    public void setRatio(double ratio) {
     	         	    this.ratio = ratio;
     	        }
    
        [DataMember(Order = 9)]
    private int? type;
    
        /**
       * @return 推广类型
    */
        public int? getType() {
               	return type;
            }
    
    /**
     * 设置推广类型     *
     * 参数示例：<pre>0:全店 1:主推</pre>     
             * 此参数必填
          */
    public void setType(int type) {
     	         	    this.type = type;
     	        }
    
        [DataMember(Order = 10)]
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
    
        [DataMember(Order = 11)]
    private string unit;
    
        /**
       * @return 单位
    */
        public string getUnit() {
               	return unit;
            }
    
    /**
     * 设置单位     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUnit(string unit) {
     	         	    this.unit = unit;
     	        }
    
        [DataMember(Order = 12)]
    private int? saleQuantity;
    
        /**
       * @return 销量(月)
    */
        public int? getSaleQuantity() {
               	return saleQuantity;
            }
    
    /**
     * 设置销量(月)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSaleQuantity(int saleQuantity) {
     	         	    this.saleQuantity = saleQuantity;
     	        }
    
        [DataMember(Order = 13)]
    private string categoryId;
    
        /**
       * @return 类目树id
    */
        public string getCategoryId() {
               	return categoryId;
            }
    
    /**
     * 设置类目树id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCategoryId(string categoryId) {
     	         	    this.categoryId = categoryId;
     	        }
    
        [DataMember(Order = 14)]
    private int? tkCnt;
    
        /**
       * @return 月推广量
    */
        public int? getTkCnt() {
               	return tkCnt;
            }
    
    /**
     * 设置月推广量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTkCnt(int tkCnt) {
     	         	    this.tkCnt = tkCnt;
     	        }
    
        [DataMember(Order = 15)]
    private double? tkCommission;
    
        /**
       * @return 月支出佣金
    */
        public double? getTkCommission() {
               	return tkCommission;
            }
    
    /**
     * 设置月支出佣金     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTkCommission(double tkCommission) {
     	         	    this.tkCommission = tkCommission;
     	        }
    
        [DataMember(Order = 16)]
    private int? quantityBegin;
    
        /**
       * @return 起批量
    */
        public int? getQuantityBegin() {
               	return quantityBegin;
            }
    
    /**
     * 设置起批量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setQuantityBegin(int quantityBegin) {
     	         	    this.quantityBegin = quantityBegin;
     	        }
    
        [DataMember(Order = 17)]
    private double? scoreFh;
    
        /**
       * @return 发货速度
    */
        public double? getScoreFh() {
               	return scoreFh;
            }
    
    /**
     * 设置发货速度     *
     * 参数示例：<pre>+代表比行业高，-代表比行业低</pre>     
             * 此参数必填
          */
    public void setScoreFh(double scoreFh) {
     	         	    this.scoreFh = scoreFh;
     	        }
    
        [DataMember(Order = 18)]
    private double? scoreHmRate;
    
        /**
       * @return 货物描述
    */
        public double? getScoreHmRate() {
               	return scoreHmRate;
            }
    
    /**
     * 设置货物描述     *
     * 参数示例：<pre>+代表比行业高，-代表比行业低</pre>     
             * 此参数必填
          */
    public void setScoreHmRate(double scoreHmRate) {
     	         	    this.scoreHmRate = scoreHmRate;
     	        }
    
        [DataMember(Order = 19)]
    private double? scoreXyRate;
    
        /**
       * @return 响应速度
    */
        public double? getScoreXyRate() {
               	return scoreXyRate;
            }
    
    /**
     * 设置响应速度     *
     * 参数示例：<pre>+代表比行业高，-代表比行业低</pre>     
             * 此参数必填
          */
    public void setScoreXyRate(double scoreXyRate) {
     	         	    this.scoreXyRate = scoreXyRate;
     	        }
    
        [DataMember(Order = 20)]
    private bool? slsjFlag;
    
        /**
       * @return 实力商家标志
    */
        public bool? getSlsjFlag() {
               	return slsjFlag;
            }
    
    /**
     * 设置实力商家标志     *
     * 参数示例：<pre>true是；false否</pre>     
             * 此参数必填
          */
    public void setSlsjFlag(bool slsjFlag) {
     	         	    this.slsjFlag = slsjFlag;
     	        }
    
        [DataMember(Order = 21)]
    private bool? sdrzFlag;
    
        /**
       * @return 深度认证标志
    */
        public bool? getSdrzFlag() {
               	return sdrzFlag;
            }
    
    /**
     * 设置深度认证标志     *
     * 参数示例：<pre>true是；false否</pre>     
             * 此参数必填
          */
    public void setSdrzFlag(bool sdrzFlag) {
     	         	    this.sdrzFlag = sdrzFlag;
     	        }
    
        [DataMember(Order = 22)]
    private bool? jkhyFlag;
    
        /**
       * @return 进口货源标志
    */
        public bool? getJkhyFlag() {
               	return jkhyFlag;
            }
    
    /**
     * 设置进口货源标志     *
     * 参数示例：<pre>true是；false否</pre>     
             * 此参数必填
          */
    public void setJkhyFlag(bool jkhyFlag) {
     	         	    this.jkhyFlag = jkhyFlag;
     	        }
    
        [DataMember(Order = 23)]
    private bool? yjdfFlag;
    
        /**
       * @return 一件代发标志
    */
        public bool? getYjdfFlag() {
               	return yjdfFlag;
            }
    
    /**
     * 设置一件代发标志     *
     * 参数示例：<pre>true是；false否</pre>     
             * 此参数必填
          */
    public void setYjdfFlag(bool yjdfFlag) {
     	         	    this.yjdfFlag = yjdfFlag;
     	        }
    
        [DataMember(Order = 24)]
    private int? tpServiceYear;
    
        /**
       * @return 诚信通年限
    */
        public int? getTpServiceYear() {
               	return tpServiceYear;
            }
    
    /**
     * 设置诚信通年限     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTpServiceYear(int tpServiceYear) {
     	         	    this.tpServiceYear = tpServiceYear;
     	        }
    
        [DataMember(Order = 25)]
    private bool? yhqFlag;
    
        /**
       * @return 优惠券标志
    */
        public bool? getYhqFlag() {
               	return yhqFlag;
            }
    
    /**
     * 设置优惠券标志     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setYhqFlag(bool yhqFlag) {
     	         	    this.yhqFlag = yhqFlag;
     	        }
    
        [DataMember(Order = 26)]
    private double? yhqDiscountFee;
    
        /**
       * @return 优惠券面额，单位为元
    */
        public double? getYhqDiscountFee() {
               	return yhqDiscountFee;
            }
    
    /**
     * 设置优惠券面额，单位为元     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setYhqDiscountFee(double yhqDiscountFee) {
     	         	    this.yhqDiscountFee = yhqDiscountFee;
     	        }
    
        [DataMember(Order = 27)]
    private int? yhqRemainingCount;
    
        /**
       * @return 优惠券余量
    */
        public int? getYhqRemainingCount() {
               	return yhqRemainingCount;
            }
    
    /**
     * 设置优惠券余量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setYhqRemainingCount(int yhqRemainingCount) {
     	         	    this.yhqRemainingCount = yhqRemainingCount;
     	        }
    
        [DataMember(Order = 28)]
    private string yhqExt;
    
        /**
       * @return 优惠券其他信息
    */
        public string getYhqExt() {
               	return yhqExt;
            }
    
    /**
     * 设置优惠券其他信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setYhqExt(string yhqExt) {
     	         	    this.yhqExt = yhqExt;
     	        }
    
    
  }
}