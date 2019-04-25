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
public class AlibabaTradePromotionModel {

       [DataMember(Order = 1)]
    private string promotionId;
    
        /**
       * @return 优惠券ID
    */
        public string getPromotionId() {
               	return promotionId;
            }
    
    /**
     * 设置优惠券ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPromotionId(string promotionId) {
     	         	    this.promotionId = promotionId;
     	        }
    
        [DataMember(Order = 2)]
    private bool? selected;
    
        /**
       * @return 是否默认选中
    */
        public bool? getSelected() {
               	return selected;
            }
    
    /**
     * 设置是否默认选中     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSelected(bool selected) {
     	         	    this.selected = selected;
     	        }
    
        [DataMember(Order = 3)]
    private string text;
    
        /**
       * @return 优惠券名称
    */
        public string getText() {
               	return text;
            }
    
    /**
     * 设置优惠券名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setText(string text) {
     	         	    this.text = text;
     	        }
    
        [DataMember(Order = 4)]
    private string desc;
    
        /**
       * @return 优惠券描述
    */
        public string getDesc() {
               	return desc;
            }
    
    /**
     * 设置优惠券描述     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDesc(string desc) {
     	         	    this.desc = desc;
     	        }
    
        [DataMember(Order = 5)]
    private bool? freePostage;
    
        /**
       * @return 是否免邮
    */
        public bool? getFreePostage() {
               	return freePostage;
            }
    
    /**
     * 设置是否免邮     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFreePostage(bool freePostage) {
     	         	    this.freePostage = freePostage;
     	        }
    
        [DataMember(Order = 6)]
    private long? discountFee;
    
        /**
       * @return 减去金额，单位为分
    */
        public long? getDiscountFee() {
               	return discountFee;
            }
    
    /**
     * 设置减去金额，单位为分     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDiscountFee(long discountFee) {
     	         	    this.discountFee = discountFee;
     	        }
    
    
  }
}