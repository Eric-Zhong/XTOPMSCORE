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
public class AlibabaCreateOrderPreviewResultCargoModel {

       [DataMember(Order = 1)]
    private double? amount;
    
        /**
       * @return 产品总金额
    */
        public double? getAmount() {
               	return amount;
            }
    
    /**
     * 设置产品总金额     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAmount(double amount) {
     	         	    this.amount = amount;
     	        }
    
        [DataMember(Order = 2)]
    private string message;
    
        /**
       * @return 返回信息
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置返回信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
        [DataMember(Order = 3)]
    private double? finalUnitPrice;
    
        /**
       * @return 最终单价
    */
        public double? getFinalUnitPrice() {
               	return finalUnitPrice;
            }
    
    /**
     * 设置最终单价     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFinalUnitPrice(double finalUnitPrice) {
     	         	    this.finalUnitPrice = finalUnitPrice;
     	        }
    
        [DataMember(Order = 4)]
    private string specId;
    
        /**
       * @return 规格ID，offer内唯一
    */
        public string getSpecId() {
               	return specId;
            }
    
    /**
     * 设置规格ID，offer内唯一     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSpecId(string specId) {
     	         	    this.specId = specId;
     	        }
    
        [DataMember(Order = 5)]
    private long? skuId;
    
        /**
       * @return 规格ID，全局唯一
    */
        public long? getSkuId() {
               	return skuId;
            }
    
    /**
     * 设置规格ID，全局唯一     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkuId(long skuId) {
     	         	    this.skuId = skuId;
     	        }
    
        [DataMember(Order = 6)]
    private string resultCode;
    
        /**
       * @return 返回码
    */
        public string getResultCode() {
               	return resultCode;
            }
    
    /**
     * 设置返回码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setResultCode(string resultCode) {
     	         	    this.resultCode = resultCode;
     	        }
    
        [DataMember(Order = 7)]
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
    
        [DataMember(Order = 8)]
    private AlibabaTradePromotionModel[] cargoPromotionList;
    
        /**
       * @return 商品优惠列表
    */
        public AlibabaTradePromotionModel[] getCargoPromotionList() {
               	return cargoPromotionList;
            }
    
    /**
     * 设置商品优惠列表     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCargoPromotionList(AlibabaTradePromotionModel[] cargoPromotionList) {
     	         	    this.cargoPromotionList = cargoPromotionList;
     	        }
    
    
  }
}