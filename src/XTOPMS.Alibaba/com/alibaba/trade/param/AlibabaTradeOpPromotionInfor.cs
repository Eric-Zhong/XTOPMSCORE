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
public class AlibabaTradeOpPromotionInfor {

       [DataMember(Order = 1)]
    private string promotionId;
    
        /**
       * @return 优惠Id
    */
        public string getPromotionId() {
               	return promotionId;
            }
    
    /**
     * 设置优惠Id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPromotionId(string promotionId) {
     	         	    this.promotionId = promotionId;
     	        }
    
        [DataMember(Order = 2)]
    private string instanceStr;
    
        /**
       * @return 优惠实例id串
    */
        public string getInstanceStr() {
               	return instanceStr;
            }
    
    /**
     * 设置优惠实例id串     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setInstanceStr(string instanceStr) {
     	         	    this.instanceStr = instanceStr;
     	        }
    
        [DataMember(Order = 3)]
    private int? chooseFreeFreight;
    
        /**
       * @return 1代表选中,0代表没有选中
    */
        public int? getChooseFreeFreight() {
               	return chooseFreeFreight;
            }
    
    /**
     * 设置1代表选中,0代表没有选中     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setChooseFreeFreight(int chooseFreeFreight) {
     	         	    this.chooseFreeFreight = chooseFreeFreight;
     	        }
    
        [DataMember(Order = 4)]
    private string marketingScene;
    
        /**
       * @return 市场
    */
        public string getMarketingScene() {
               	return marketingScene;
            }
    
    /**
     * 设置市场     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMarketingScene(string marketingScene) {
     	         	    this.marketingScene = marketingScene;
     	        }
    
        [DataMember(Order = 5)]
    private string promotionType;
    
        /**
       * @return 跨店优惠类型key
    */
        public string getPromotionType() {
               	return promotionType;
            }
    
    /**
     * 设置跨店优惠类型key     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPromotionType(string promotionType) {
     	         	    this.promotionType = promotionType;
     	        }
    
    
  }
}