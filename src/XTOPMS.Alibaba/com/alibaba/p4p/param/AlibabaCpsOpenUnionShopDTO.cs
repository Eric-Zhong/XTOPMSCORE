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
public class AlibabaCpsOpenUnionShopDTO {

       [DataMember(Order = 1)]
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
    
        [DataMember(Order = 2)]
    private string loginId;
    
        /**
       * @return 商家loginId
    */
        public string getLoginId() {
               	return loginId;
            }
    
    /**
     * 设置商家loginId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLoginId(string loginId) {
     	         	    this.loginId = loginId;
     	        }
    
        [DataMember(Order = 3)]
    private string companyName;
    
        /**
       * @return 店铺名称
    */
        public string getCompanyName() {
               	return companyName;
            }
    
    /**
     * 设置店铺名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCompanyName(string companyName) {
     	         	    this.companyName = companyName;
     	        }
    
        [DataMember(Order = 4)]
    private double? tradeGrade;
    
        /**
       * @return 交易勋章
    */
        public double? getTradeGrade() {
               	return tradeGrade;
            }
    
    /**
     * 设置交易勋章     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTradeGrade(double tradeGrade) {
     	         	    this.tradeGrade = tradeGrade;
     	        }
    
        [DataMember(Order = 5)]
    private double? ratio;
    
        /**
       * @return 平均佣金比例
    */
        public double? getRatio() {
               	return ratio;
            }
    
    /**
     * 设置平均佣金比例     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRatio(double ratio) {
     	         	    this.ratio = ratio;
     	        }
    
        [DataMember(Order = 6)]
    private int? productCnt;
    
        /**
       * @return 商品数量
    */
        public int? getProductCnt() {
               	return productCnt;
            }
    
    /**
     * 设置商品数量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductCnt(int productCnt) {
     	         	    this.productCnt = productCnt;
     	        }
    
        [DataMember(Order = 7)]
    private int? tkCnt;
    
        /**
       * @return 30天推广量
    */
        public int? getTkCnt() {
               	return tkCnt;
            }
    
    /**
     * 设置30天推广量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTkCnt(int tkCnt) {
     	         	    this.tkCnt = tkCnt;
     	        }
    
        [DataMember(Order = 8)]
    private string linkUrl;
    
        /**
       * @return 店铺首页
    */
        public string getLinkUrl() {
               	return linkUrl;
            }
    
    /**
     * 设置店铺首页     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLinkUrl(string linkUrl) {
     	         	    this.linkUrl = linkUrl;
     	        }
    
    
  }
}