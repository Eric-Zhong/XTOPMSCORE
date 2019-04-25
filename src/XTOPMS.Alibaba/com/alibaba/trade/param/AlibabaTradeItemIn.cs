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
public class AlibabaTradeItemIn {

       [DataMember(Order = 1)]
    private float? quantity;
    
        /**
       * @return 
    */
        public float? getQuantity() {
               	return quantity;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setQuantity(float quantity) {
     	         	    this.quantity = quantity;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaProductItemID itemID;
    
        /**
       * @return 
    */
        public AlibabaProductItemID getItemID() {
               	return itemID;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setItemID(AlibabaProductItemID itemID) {
     	         	    this.itemID = itemID;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaProductItemDetail itemDetail;
    
        /**
       * @return 
    */
        public AlibabaProductItemDetail getItemDetail() {
               	return itemDetail;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setItemDetail(AlibabaProductItemDetail itemDetail) {
     	         	    this.itemDetail = itemDetail;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaCommonMoney itemInFee;
    
        /**
       * @return 
    */
        public AlibabaCommonMoney getItemInFee() {
               	return itemInFee;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setItemInFee(AlibabaCommonMoney itemInFee) {
     	         	    this.itemInFee = itemInFee;
     	        }
    
        [DataMember(Order = 5)]
    private AlibabaProductItemAttribute[] skuInfos;
    
        /**
       * @return 
    */
        public AlibabaProductItemAttribute[] getSkuInfos() {
               	return skuInfos;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkuInfos(AlibabaProductItemAttribute[] skuInfos) {
     	         	    this.skuInfos = skuInfos;
     	        }
    
    
  }
}