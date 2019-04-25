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
public class AlibabaTradeSubPayInfo {

       [DataMember(Order = 1)]
    private long? actualPayFee;
    
        /**
       * @return 
    */
        public long? getActualPayFee() {
               	return actualPayFee;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setActualPayFee(long actualPayFee) {
     	         	    this.actualPayFee = actualPayFee;
     	        }
    
        [DataMember(Order = 2)]
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
    
        [DataMember(Order = 3)]
    private string agreement;
    
        /**
       * @return 
    */
        public string getAgreement() {
               	return agreement;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAgreement(string agreement) {
     	         	    this.agreement = agreement;
     	        }
    
        [DataMember(Order = 4)]
    private long? amount;
    
        /**
       * @return 
    */
        public long? getAmount() {
               	return amount;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAmount(long amount) {
     	         	    this.amount = amount;
     	        }
    
        [DataMember(Order = 5)]
    private long? buyerConfirmTimeout;
    
        /**
       * @return 
    */
        public long? getBuyerConfirmTimeout() {
               	return buyerConfirmTimeout;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerConfirmTimeout(long buyerConfirmTimeout) {
     	         	    this.buyerConfirmTimeout = buyerConfirmTimeout;
     	        }
    
        [DataMember(Order = 6)]
    private long? buyerPayTimeout;
    
        /**
       * @return 
    */
        public long? getBuyerPayTimeout() {
               	return buyerPayTimeout;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerPayTimeout(long buyerPayTimeout) {
     	         	    this.buyerPayTimeout = buyerPayTimeout;
     	        }
    
        [DataMember(Order = 7)]
    private double? deliveryPercent;
    
        /**
       * @return 
    */
        public double? getDeliveryPercent() {
               	return deliveryPercent;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDeliveryPercent(double deliveryPercent) {
     	         	    this.deliveryPercent = deliveryPercent;
     	        }
    
        [DataMember(Order = 8)]
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
    
        [DataMember(Order = 9)]
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
    
        [DataMember(Order = 10)]
    private int? instantPay;
    
        /**
       * @return 
    */
        public int? getInstantPay() {
               	return instantPay;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setInstantPay(int instantPay) {
     	         	    this.instantPay = instantPay;
     	        }
    
        [DataMember(Order = 11)]
    private int? isStepPayAll;
    
        /**
       * @return 
    */
        public int? getIsStepPayAll() {
               	return isStepPayAll;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsStepPayAll(int isStepPayAll) {
     	         	    this.isStepPayAll = isStepPayAll;
     	        }
    
        [DataMember(Order = 12)]
    private long? itemDiscountFee;
    
        /**
       * @return 
    */
        public long? getItemDiscountFee() {
               	return itemDiscountFee;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setItemDiscountFee(long itemDiscountFee) {
     	         	    this.itemDiscountFee = itemDiscountFee;
     	        }
    
        [DataMember(Order = 13)]
    private string key;
    
        /**
       * @return 
    */
        public string getKey() {
               	return key;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setKey(string key) {
     	         	    this.key = key;
     	        }
    
        [DataMember(Order = 14)]
    private int? needLogistics;
    
        /**
       * @return 
    */
        public int? getNeedLogistics() {
               	return needLogistics;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setNeedLogistics(int needLogistics) {
     	         	    this.needLogistics = needLogistics;
     	        }
    
        [DataMember(Order = 15)]
    private int? needSellerAction;
    
        /**
       * @return 
    */
        public int? getNeedSellerAction() {
               	return needSellerAction;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setNeedSellerAction(int needSellerAction) {
     	         	    this.needSellerAction = needSellerAction;
     	        }
    
        [DataMember(Order = 16)]
    private int? needSellerCallNext;
    
        /**
       * @return 
    */
        public int? getNeedSellerCallNext() {
               	return needSellerCallNext;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setNeedSellerCallNext(int needSellerCallNext) {
     	         	    this.needSellerCallNext = needSellerCallNext;
     	        }
    
        [DataMember(Order = 17)]
    private long? payFee;
    
        /**
       * @return 
    */
        public long? getPayFee() {
               	return payFee;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPayFee(long payFee) {
     	         	    this.payFee = payFee;
     	        }
    
        [DataMember(Order = 18)]
    private double? percent;
    
        /**
       * @return 
    */
        public double? getPercent() {
               	return percent;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPercent(double percent) {
     	         	    this.percent = percent;
     	        }
    
        [DataMember(Order = 19)]
    private long? postFee;
    
        /**
       * @return 
    */
        public long? getPostFee() {
               	return postFee;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPostFee(long postFee) {
     	         	    this.postFee = postFee;
     	        }
    
        [DataMember(Order = 20)]
    private long? price;
    
        /**
       * @return 
    */
        public long? getPrice() {
               	return price;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPrice(long price) {
     	         	    this.price = price;
     	        }
    
        [DataMember(Order = 21)]
    private string sellerActionName;
    
        /**
       * @return 
    */
        public string getSellerActionName() {
               	return sellerActionName;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerActionName(string sellerActionName) {
     	         	    this.sellerActionName = sellerActionName;
     	        }
    
        [DataMember(Order = 22)]
    private string stepName;
    
        /**
       * @return 
    */
        public string getStepName() {
               	return stepName;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStepName(string stepName) {
     	         	    this.stepName = stepName;
     	        }
    
        [DataMember(Order = 23)]
    private int? stepNo;
    
        /**
       * @return 
    */
        public int? getStepNo() {
               	return stepNo;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStepNo(int stepNo) {
     	         	    this.stepNo = stepNo;
     	        }
    
        [DataMember(Order = 24)]
    private string stepTemplateInfo;
    
        /**
       * @return 
    */
        public string getStepTemplateInfo() {
               	return stepTemplateInfo;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStepTemplateInfo(string stepTemplateInfo) {
     	         	    this.stepTemplateInfo = stepTemplateInfo;
     	        }
    
        [DataMember(Order = 25)]
    private long? templateId;
    
        /**
       * @return 
    */
        public long? getTemplateId() {
               	return templateId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTemplateId(long templateId) {
     	         	    this.templateId = templateId;
     	        }
    
        [DataMember(Order = 26)]
    private int? transferAfterConfirm;
    
        /**
       * @return 
    */
        public int? getTransferAfterConfirm() {
               	return transferAfterConfirm;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTransferAfterConfirm(int transferAfterConfirm) {
     	         	    this.transferAfterConfirm = transferAfterConfirm;
     	        }
    
    
  }
}