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
public class AlibabaCreateOrderPreviewResultModel {

       [DataMember(Order = 1)]
    private long? discountFee;
    
        /**
       * @return 计算完货品金额后再次进行的减免金额. 单位: 分
    */
        public long? getDiscountFee() {
               	return discountFee;
            }
    
    /**
     * 设置计算完货品金额后再次进行的减免金额. 单位: 分     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDiscountFee(long discountFee) {
     	         	    this.discountFee = discountFee;
     	        }
    
        [DataMember(Order = 2)]
    private string[] tradeModeNameList;
    
        /**
       * @return 当前交易可以支持的交易方式列表。某些场景的创建订单接口需要使用。
    */
        public string[] getTradeModeNameList() {
               	return tradeModeNameList;
            }
    
    /**
     * 设置当前交易可以支持的交易方式列表。某些场景的创建订单接口需要使用。     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTradeModeNameList(string[] tradeModeNameList) {
     	         	    this.tradeModeNameList = tradeModeNameList;
     	        }
    
        [DataMember(Order = 3)]
    private bool? status;
    
        /**
       * @return 状态
    */
        public bool? getStatus() {
               	return status;
            }
    
    /**
     * 设置状态     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStatus(bool status) {
     	         	    this.status = status;
     	        }
    
        [DataMember(Order = 4)]
    private bool? taoSampleSinglePromotion;
    
        /**
       * @return 是否有淘货源单品优惠  false:有单品优惠   true：没有单品优惠
    */
        public bool? getTaoSampleSinglePromotion() {
               	return taoSampleSinglePromotion;
            }
    
    /**
     * 设置是否有淘货源单品优惠  false:有单品优惠   true：没有单品优惠     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTaoSampleSinglePromotion(bool taoSampleSinglePromotion) {
     	         	    this.taoSampleSinglePromotion = taoSampleSinglePromotion;
     	        }
    
        [DataMember(Order = 5)]
    private long? sumPayment;
    
        /**
       * @return 订单总费用, 单位为分.
    */
        public long? getSumPayment() {
               	return sumPayment;
            }
    
    /**
     * 设置订单总费用, 单位为分.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSumPayment(long sumPayment) {
     	         	    this.sumPayment = sumPayment;
     	        }
    
        [DataMember(Order = 6)]
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
    
        [DataMember(Order = 7)]
    private long? sumCarriage;
    
        /**
       * @return 总运费信息, 单位为分.
    */
        public long? getSumCarriage() {
               	return sumCarriage;
            }
    
    /**
     * 设置总运费信息, 单位为分.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSumCarriage(long sumCarriage) {
     	         	    this.sumCarriage = sumCarriage;
     	        }
    
        [DataMember(Order = 8)]
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
    
        [DataMember(Order = 9)]
    private long? sumPaymentNoCarriage;
    
        /**
       * @return 不包含运费的货品总费用, 单位为分.
    */
        public long? getSumPaymentNoCarriage() {
               	return sumPaymentNoCarriage;
            }
    
    /**
     * 设置不包含运费的货品总费用, 单位为分.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSumPaymentNoCarriage(long sumPaymentNoCarriage) {
     	         	    this.sumPaymentNoCarriage = sumPaymentNoCarriage;
     	        }
    
        [DataMember(Order = 10)]
    private long? additionalFee;
    
        /**
       * @return 附加费,单位，分
    */
        public long? getAdditionalFee() {
               	return additionalFee;
            }
    
    /**
     * 设置附加费,单位，分     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAdditionalFee(long additionalFee) {
     	         	    this.additionalFee = additionalFee;
     	        }
    
        [DataMember(Order = 11)]
    private string flowFlag;
    
        /**
       * @return 订单下单流程
    */
        public string getFlowFlag() {
               	return flowFlag;
            }
    
    /**
     * 设置订单下单流程     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFlowFlag(string flowFlag) {
     	         	    this.flowFlag = flowFlag;
     	        }
    
        [DataMember(Order = 12)]
    private AlibabaCreateOrderPreviewResultCargoModel[] cargoList;
    
        /**
       * @return 规格信息
    */
        public AlibabaCreateOrderPreviewResultCargoModel[] getCargoList() {
               	return cargoList;
            }
    
    /**
     * 设置规格信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCargoList(AlibabaCreateOrderPreviewResultCargoModel[] cargoList) {
     	         	    this.cargoList = cargoList;
     	        }
    
        [DataMember(Order = 13)]
    private AlibabaTradePromotionModel[] shopPromotionList;
    
        /**
       * @return 可用店铺级别优惠列表
    */
        public AlibabaTradePromotionModel[] getShopPromotionList() {
               	return shopPromotionList;
            }
    
    /**
     * 设置可用店铺级别优惠列表     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setShopPromotionList(AlibabaTradePromotionModel[] shopPromotionList) {
     	         	    this.shopPromotionList = shopPromotionList;
     	        }
    
    
  }
}