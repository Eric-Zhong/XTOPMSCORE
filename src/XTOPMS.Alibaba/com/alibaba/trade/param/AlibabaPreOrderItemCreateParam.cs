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
public class AlibabaPreOrderItemCreateParam {

       [DataMember(Order = 1)]
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
    
        [DataMember(Order = 2)]
    private long? skuId;
    
        /**
       * @return SKUID，没有SKU的商品可不填
    */
        public long? getSkuId() {
               	return skuId;
            }
    
    /**
     * 设置SKUID，没有SKU的商品可不填     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkuId(long skuId) {
     	         	    this.skuId = skuId;
     	        }
    
        [DataMember(Order = 3)]
    private long? offerId;
    
        /**
       * @return 商品ID
    */
        public long? getOfferId() {
               	return offerId;
            }
    
    /**
     * 设置商品ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOfferId(long offerId) {
     	         	    this.offerId = offerId;
     	        }
    
        [DataMember(Order = 4)]
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
    
        [DataMember(Order = 5)]
    private long? auctionPrice;
    
        /**
       * @return 单价，必传，默认为0，单位：分
    */
        public long? getAuctionPrice() {
               	return auctionPrice;
            }
    
    /**
     * 设置单价，必传，默认为0，单位：分     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAuctionPrice(long auctionPrice) {
     	         	    this.auctionPrice = auctionPrice;
     	        }
    
    
  }
}