using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.search.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaSearchRelationProductInfo {

       [DataMember(Order = 1)]
    private long? productId;
    
        /**
       * @return 商品ID
    */
        public long? getProductId() {
               	return productId;
            }
    
    /**
     * 设置商品ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductId(long productId) {
     	         	    this.productId = productId;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaSearchRelationGroupInfo[] relationDesc;
    
        /**
       * @return 查询商品结果中的关联描述
    */
        public AlibabaSearchRelationGroupInfo[] getRelationDesc() {
               	return relationDesc;
            }
    
    /**
     * 设置查询商品结果中的关联描述     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRelationDesc(AlibabaSearchRelationGroupInfo[] relationDesc) {
     	         	    this.relationDesc = relationDesc;
     	        }
    
        [DataMember(Order = 3)]
    private string offerPublishTime;
    
        /**
       * @return 商品发布时间
    */
        public DateTime? getOfferPublishTime() {
                 if (offerPublishTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(offerPublishTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置商品发布时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOfferPublishTime(DateTime offerPublishTime) {
     	         	    this.offerPublishTime = DateUtil.format(offerPublishTime);
     	        }
    
        [DataMember(Order = 4)]
    private int? saleCounts;
    
        /**
       * @return 售卖数量
    */
        public int? getSaleCounts() {
               	return saleCounts;
            }
    
    /**
     * 设置售卖数量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSaleCounts(int saleCounts) {
     	         	    this.saleCounts = saleCounts;
     	        }
    
        [DataMember(Order = 5)]
    private int? saleScore;
    
        /**
       * @return 售卖分数
    */
        public int? getSaleScore() {
               	return saleScore;
            }
    
    /**
     * 设置售卖分数     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSaleScore(int saleScore) {
     	         	    this.saleScore = saleScore;
     	        }
    
    
  }
}