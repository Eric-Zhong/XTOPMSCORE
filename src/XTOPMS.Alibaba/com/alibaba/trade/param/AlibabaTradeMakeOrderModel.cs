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
public class AlibabaTradeMakeOrderModel {

       [DataMember(Order = 1)]
    private long? additionalFee;
    
        /**
       * @return 
    */
        public long? getAdditionalFee() {
               	return additionalFee;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAdditionalFee(long additionalFee) {
     	         	    this.additionalFee = additionalFee;
     	        }
    
        [DataMember(Order = 2)]
    private int? auccountPeriod;
    
        /**
       * @return 
    */
        public int? getAuccountPeriod() {
               	return auccountPeriod;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAuccountPeriod(int auccountPeriod) {
     	         	    this.auccountPeriod = auccountPeriod;
     	        }
    
        [DataMember(Order = 3)]
    private string bizGroup;
    
        /**
       * @return 
    */
        public string getBizGroup() {
               	return bizGroup;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBizGroup(string bizGroup) {
     	         	    this.bizGroup = bizGroup;
     	        }
    
        [DataMember(Order = 4)]
    private string client;
    
        /**
       * @return 
    */
        public string getClient() {
               	return client;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setClient(string client) {
     	         	    this.client = client;
     	        }
    
        [DataMember(Order = 5)]
    private long? discountFee;
    
        /**
       * @return 
    */
        public long? getDiscountFee() {
               	return discountFee;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDiscountFee(long discountFee) {
     	         	    this.discountFee = discountFee;
     	        }
    
        [DataMember(Order = 6)]
    private bool? famousStep;
    
        /**
       * @return 
    */
        public bool? getFamousStep() {
               	return famousStep;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFamousStep(bool famousStep) {
     	         	    this.famousStep = famousStep;
     	        }
    
        [DataMember(Order = 7)]
    private string flowFlag;
    
        /**
       * @return 
    */
        public string getFlowFlag() {
               	return flowFlag;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFlowFlag(string flowFlag) {
     	         	    this.flowFlag = flowFlag;
     	        }
    
        [DataMember(Order = 8)]
    private string group;
    
        /**
       * @return 
    */
        public string getGroup() {
               	return group;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGroup(string group) {
     	         	    this.group = group;
     	        }
    
        [DataMember(Order = 9)]
    private bool? hasBeenDealtWireless;
    
        /**
       * @return 
    */
        public bool? getHasBeenDealtWireless() {
               	return hasBeenDealtWireless;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setHasBeenDealtWireless(bool hasBeenDealtWireless) {
     	         	    this.hasBeenDealtWireless = hasBeenDealtWireless;
     	        }
    
        [DataMember(Order = 10)]
    private long? instantSenceQuota;
    
        /**
       * @return 
    */
        public long? getInstantSenceQuota() {
               	return instantSenceQuota;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setInstantSenceQuota(long instantSenceQuota) {
     	         	    this.instantSenceQuota = instantSenceQuota;
     	        }
    
        [DataMember(Order = 11)]
    private long? instantSenceRaiseQuota;
    
        /**
       * @return 
    */
        public long? getInstantSenceRaiseQuota() {
               	return instantSenceRaiseQuota;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setInstantSenceRaiseQuota(long instantSenceRaiseQuota) {
     	         	    this.instantSenceRaiseQuota = instantSenceRaiseQuota;
     	        }
    
        [DataMember(Order = 12)]
    private int? isSupportNormalPayInsant;
    
        /**
       * @return 
    */
        public int? getIsSupportNormalPayInsant() {
               	return isSupportNormalPayInsant;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsSupportNormalPayInsant(int isSupportNormalPayInsant) {
     	         	    this.isSupportNormalPayInsant = isSupportNormalPayInsant;
     	        }
    
        [DataMember(Order = 13)]
    private string message;
    
        /**
       * @return 
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
        [DataMember(Order = 14)]
    private string remark;
    
        /**
       * @return 
    */
        public string getRemark() {
               	return remark;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRemark(string remark) {
     	         	    this.remark = remark;
     	        }
    
        [DataMember(Order = 15)]
    private string resultCode;
    
        /**
       * @return 
    */
        public string getResultCode() {
               	return resultCode;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setResultCode(string resultCode) {
     	         	    this.resultCode = resultCode;
     	        }
    
        [DataMember(Order = 16)]
    private bool? status;
    
        /**
       * @return 
    */
        public bool? getStatus() {
               	return status;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStatus(bool status) {
     	         	    this.status = status;
     	        }
    
        [DataMember(Order = 17)]
    private string subBizType;
    
        /**
       * @return 
    */
        public string getSubBizType() {
               	return subBizType;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubBizType(string subBizType) {
     	         	    this.subBizType = subBizType;
     	        }
    
        [DataMember(Order = 18)]
    private long? sumCarriage;
    
        /**
       * @return 
    */
        public long? getSumCarriage() {
               	return sumCarriage;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSumCarriage(long sumCarriage) {
     	         	    this.sumCarriage = sumCarriage;
     	        }
    
        [DataMember(Order = 19)]
    private long? sumPayment;
    
        /**
       * @return 
    */
        public long? getSumPayment() {
               	return sumPayment;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSumPayment(long sumPayment) {
     	         	    this.sumPayment = sumPayment;
     	        }
    
        [DataMember(Order = 20)]
    private long? sumPaymentNoCarriage;
    
        /**
       * @return 
    */
        public long? getSumPaymentNoCarriage() {
               	return sumPaymentNoCarriage;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSumPaymentNoCarriage(long sumPaymentNoCarriage) {
     	         	    this.sumPaymentNoCarriage = sumPaymentNoCarriage;
     	        }
    
        [DataMember(Order = 21)]
    private bool? supportInvoice;
    
        /**
       * @return 
    */
        public bool? getSupportInvoice() {
               	return supportInvoice;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSupportInvoice(bool supportInvoice) {
     	         	    this.supportInvoice = supportInvoice;
     	        }
    
        [DataMember(Order = 22)]
    private string supportStepPay;
    
        /**
       * @return 
    */
        public string getSupportStepPay() {
               	return supportStepPay;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSupportStepPay(string supportStepPay) {
     	         	    this.supportStepPay = supportStepPay;
     	        }
    
        [DataMember(Order = 23)]
    private AlibabaTradeSimpleBuyer buyer;
    
        /**
       * @return 
    */
        public AlibabaTradeSimpleBuyer getBuyer() {
               	return buyer;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyer(AlibabaTradeSimpleBuyer buyer) {
     	         	    this.buyer = buyer;
     	        }
    
        [DataMember(Order = 24)]
    private AlibabaPaymentPayChannels payChannels;
    
        /**
       * @return 
    */
        public AlibabaPaymentPayChannels getPayChannels() {
               	return payChannels;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPayChannels(AlibabaPaymentPayChannels payChannels) {
     	         	    this.payChannels = payChannels;
     	        }
    
        [DataMember(Order = 25)]
    private AlibabaTradeSimpleSeller seller;
    
        /**
       * @return 
    */
        public AlibabaTradeSimpleSeller getSeller() {
               	return seller;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSeller(AlibabaTradeSimpleSeller seller) {
     	         	    this.seller = seller;
     	        }
    
        [DataMember(Order = 26)]
    private AlibabaTradeSimpleSeller simpleSeller;
    
        /**
       * @return 
    */
        public AlibabaTradeSimpleSeller getSimpleSeller() {
               	return simpleSeller;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSimpleSeller(AlibabaTradeSimpleSeller simpleSeller) {
     	         	    this.simpleSeller = simpleSeller;
     	        }
    
        [DataMember(Order = 27)]
    private AlibabaTradeTradeModeModel tradeModeModel;
    
        /**
       * @return 
    */
        public AlibabaTradeTradeModeModel getTradeModeModel() {
               	return tradeModeModel;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTradeModeModel(AlibabaTradeTradeModeModel tradeModeModel) {
     	         	    this.tradeModeModel = tradeModeModel;
     	        }
    
        [DataMember(Order = 28)]
    private AlibabaTradeToleranceCollection toleranceCollection;
    
        /**
       * @return 
    */
        public AlibabaTradeToleranceCollection getToleranceCollection() {
               	return toleranceCollection;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToleranceCollection(AlibabaTradeToleranceCollection toleranceCollection) {
     	         	    this.toleranceCollection = toleranceCollection;
     	        }
    
        [DataMember(Order = 29)]
    private AlibabaTradeCargo[] cargos;
    
        /**
       * @return 货品信息
    */
        public AlibabaTradeCargo[] getCargos() {
               	return cargos;
            }
    
    /**
     * 设置货品信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCargos(AlibabaTradeCargo[] cargos) {
     	         	    this.cargos = cargos;
     	        }
    
        [DataMember(Order = 30)]
    private AlibabaTradeOpPromotionInfor shopPromotionInfo;
    
        /**
       * @return 店铺级别的优惠信息
    */
        public AlibabaTradeOpPromotionInfor getShopPromotionInfo() {
               	return shopPromotionInfo;
            }
    
    /**
     * 设置店铺级别的优惠信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setShopPromotionInfo(AlibabaTradeOpPromotionInfor shopPromotionInfo) {
     	         	    this.shopPromotionInfo = shopPromotionInfo;
     	        }
    
    
  }
}