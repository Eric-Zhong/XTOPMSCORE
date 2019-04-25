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
public class AlibabaTradeGoodsInfo {

       [DataMember(Order = 1)]
    private long? cartId;
    
        /**
       * @return 淘宝cartId
    */
        public long? getCartId() {
               	return cartId;
            }
    
    /**
     * 设置淘宝cartId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCartId(long cartId) {
     	         	    this.cartId = cartId;
     	        }
    
        [DataMember(Order = 2)]
    private string ext;
    
        /**
       * @return 该参数是url中完整的id参数对应的json格式数据中,key等于ext的参数值.
    */
        public string getExt() {
               	return ext;
            }
    
    /**
     * 设置该参数是url中完整的id参数对应的json格式数据中,key等于ext的参数值.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setExt(string ext) {
     	         	    this.ext = ext;
     	        }
    
        [DataMember(Order = 3)]
    private string flow;
    
        /**
       * @return 所属流程
    */
        public string getFlow() {
               	return flow;
            }
    
    /**
     * 设置所属流程     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFlow(string flow) {
     	         	    this.flow = flow;
     	        }
    
        [DataMember(Order = 4)]
    private string id;
    
        /**
       * @return id,Cargo 标识
    */
        public string getId() {
               	return id;
            }
    
    /**
     * 设置id,Cargo 标识     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setId(string id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 5)]
    private long? offerId;
    
        /**
       * @return 商品ID，offerId
    */
        public long? getOfferId() {
               	return offerId;
            }
    
    /**
     * 设置商品ID，offerId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOfferId(long offerId) {
     	         	    this.offerId = offerId;
     	        }
    
        [DataMember(Order = 6)]
    private double? quantity;
    
        /**
       * @return 数量
    */
        public double? getQuantity() {
               	return quantity;
            }
    
    /**
     * 设置数量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setQuantity(double quantity) {
     	         	    this.quantity = quantity;
     	        }
    
        [DataMember(Order = 7)]
    private string specId;
    
        /**
       * @return 商品的规格特征值
    */
        public string getSpecId() {
               	return specId;
            }
    
    /**
     * 设置商品的规格特征值     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSpecId(string specId) {
     	         	    this.specId = specId;
     	        }
    
        [DataMember(Order = 8)]
    private string tradeMode;
    
        /**
       * @return 交易模式参数,交易4.0引入
    */
        public string getTradeMode() {
               	return tradeMode;
            }
    
    /**
     * 设置交易模式参数,交易4.0引入     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTradeMode(string tradeMode) {
     	         	    this.tradeMode = tradeMode;
     	        }
    
        [DataMember(Order = 9)]
    private string tradeWay;
    
        /**
       * @return 交易模式交易模式的分类,交易4.0mutilstep的模板id
    */
        public string getTradeWay() {
               	return tradeWay;
            }
    
    /**
     * 设置交易模式交易模式的分类,交易4.0mutilstep的模板id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTradeWay(string tradeWay) {
     	         	    this.tradeWay = tradeWay;
     	        }
    
        [DataMember(Order = 10)]
    private AlibabaTradeComKeyValuePair[] extParams;
    
        /**
       * @return 扩展数据,附加参数集合,自定各个业务场景下的附加属性
    */
        public AlibabaTradeComKeyValuePair[] getExtParams() {
               	return extParams;
            }
    
    /**
     * 设置扩展数据,附加参数集合,自定各个业务场景下的附加属性     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setExtParams(AlibabaTradeComKeyValuePair[] extParams) {
     	         	    this.extParams = extParams;
     	        }
    
    
  }
}