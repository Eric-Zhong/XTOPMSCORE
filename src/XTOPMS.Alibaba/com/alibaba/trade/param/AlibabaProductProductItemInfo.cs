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
public class AlibabaProductProductItemInfo {

       [DataMember(Order = 1)]
    private string description;
    
        /**
       * @return 商品描述
    */
        public string getDescription() {
               	return description;
            }
    
    /**
     * 设置商品描述     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDescription(string description) {
     	         	    this.description = description;
     	        }
    
        [DataMember(Order = 2)]
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
    
        [DataMember(Order = 3)]
    private string spuId;
    
        /**
       * @return 商品的ID
    */
        public string getSpuId() {
               	return spuId;
            }
    
    /**
     * 设置商品的ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSpuId(string spuId) {
     	         	    this.spuId = spuId;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaCommonUrl url;
    
        /**
       * @return 商品URL
    */
        public AlibabaCommonUrl getUrl() {
               	return url;
            }
    
    /**
     * 设置商品URL     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUrl(AlibabaCommonUrl url) {
     	         	    this.url = url;
     	        }
    
        [DataMember(Order = 5)]
    private AlibabaProductRelateRelationGroupInfo relationGroupInfos;
    
        /**
       * @return 商品关联信息
    */
        public AlibabaProductRelateRelationGroupInfo getRelationGroupInfos() {
               	return relationGroupInfos;
            }
    
    /**
     * 设置商品关联信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRelationGroupInfos(AlibabaProductRelateRelationGroupInfo relationGroupInfos) {
     	         	    this.relationGroupInfos = relationGroupInfos;
     	        }
    
        [DataMember(Order = 6)]
    private AlibabaCommonUrl[] imgUrls;
    
        /**
       * @return 图片地址
    */
        public AlibabaCommonUrl[] getImgUrls() {
               	return imgUrls;
            }
    
    /**
     * 设置图片地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setImgUrls(AlibabaCommonUrl[] imgUrls) {
     	         	    this.imgUrls = imgUrls;
     	        }
    
        [DataMember(Order = 7)]
    private AlibabaTradeItemIn[] relatedItems;
    
        /**
       * @return 关联的单品信息
    */
        public AlibabaTradeItemIn[] getRelatedItems() {
               	return relatedItems;
            }
    
    /**
     * 设置关联的单品信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRelatedItems(AlibabaTradeItemIn[] relatedItems) {
     	         	    this.relatedItems = relatedItems;
     	        }
    
        [DataMember(Order = 8)]
    private string sellerId;
    
        /**
       * @return 供应商userId
    */
        public string getSellerId() {
               	return sellerId;
            }
    
    /**
     * 设置供应商userId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerId(string sellerId) {
     	         	    this.sellerId = sellerId;
     	        }
    
        [DataMember(Order = 9)]
    private string sellerMemberId;
    
        /**
       * @return 供应商memberId
    */
        public string getSellerMemberId() {
               	return sellerMemberId;
            }
    
    /**
     * 设置供应商memberId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerMemberId(string sellerMemberId) {
     	         	    this.sellerMemberId = sellerMemberId;
     	        }
    
        [DataMember(Order = 10)]
    private string sellerLoginId;
    
        /**
       * @return 供应商旺旺Id
    */
        public string getSellerLoginId() {
               	return sellerLoginId;
            }
    
    /**
     * 设置供应商旺旺Id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerLoginId(string sellerLoginId) {
     	         	    this.sellerLoginId = sellerLoginId;
     	        }
    
        [DataMember(Order = 11)]
    private bool? buyAlone;
    
        /**
       * @return 商品是否只能单独创建一个订单
    */
        public bool? getBuyAlone() {
               	return buyAlone;
            }
    
    /**
     * 设置商品是否只能单独创建一个订单     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyAlone(bool buyAlone) {
     	         	    this.buyAlone = buyAlone;
     	        }
    
    
  }
}