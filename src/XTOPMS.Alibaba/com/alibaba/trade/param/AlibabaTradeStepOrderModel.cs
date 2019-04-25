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
public class AlibabaTradeStepOrderModel {

       [DataMember(Order = 1)]
    private long? stepOrderId;
    
        /**
       * @return 阶段id
    */
        public long? getStepOrderId() {
               	return stepOrderId;
            }
    
    /**
     * 设置阶段id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStepOrderId(long stepOrderId) {
     	         	    this.stepOrderId = stepOrderId;
     	        }
    
        [DataMember(Order = 2)]
    private string stepOrderStatus;
    
        /**
       * @return waitactivate  未开始（待激活）
waitsellerpush 等待卖家推进
success 本阶段完成
settlebill 分账
cancel 本阶段终止
inactiveandcancel 本阶段未开始便终止
waitbuyerpay 等待买家付款
waitsellersend 等待卖家发货
waitbuyerreceive 等待买家确认收货
waitselleract 等待卖家XX操作
waitbuyerconfirmaction 等待买家确认XX操作
    */
        public string getStepOrderStatus() {
               	return stepOrderStatus;
            }
    
    /**
     * 设置waitactivate  未开始（待激活）
waitsellerpush 等待卖家推进
success 本阶段完成
settlebill 分账
cancel 本阶段终止
inactiveandcancel 本阶段未开始便终止
waitbuyerpay 等待买家付款
waitsellersend 等待卖家发货
waitbuyerreceive 等待买家确认收货
waitselleract 等待卖家XX操作
waitbuyerconfirmaction 等待买家确认XX操作     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStepOrderStatus(string stepOrderStatus) {
     	         	    this.stepOrderStatus = stepOrderStatus;
     	        }
    
        [DataMember(Order = 3)]
    private int? stepPayStatus;
    
        /**
       * @return 1 未冻结/未付款
2 已冻结/已付款
4 已退款
6 已转交易
8 交易未付款被关闭
    */
        public int? getStepPayStatus() {
               	return stepPayStatus;
            }
    
    /**
     * 设置1 未冻结/未付款
2 已冻结/已付款
4 已退款
6 已转交易
8 交易未付款被关闭     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStepPayStatus(int stepPayStatus) {
     	         	    this.stepPayStatus = stepPayStatus;
     	        }
    
        [DataMember(Order = 4)]
    private int? stepNo;
    
        /**
       * @return 阶段序列：1、2、3...
    */
        public int? getStepNo() {
               	return stepNo;
            }
    
    /**
     * 设置阶段序列：1、2、3...     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStepNo(int stepNo) {
     	         	    this.stepNo = stepNo;
     	        }
    
        [DataMember(Order = 5)]
    private bool? lastStep;
    
        /**
       * @return 是否最后一个阶段
    */
        public bool? getLastStep() {
               	return lastStep;
            }
    
    /**
     * 设置是否最后一个阶段     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLastStep(bool lastStep) {
     	         	    this.lastStep = lastStep;
     	        }
    
        [DataMember(Order = 6)]
    private bool? hasDisbursed;
    
        /**
       * @return 是否已打款给卖家
    */
        public bool? getHasDisbursed() {
               	return hasDisbursed;
            }
    
    /**
     * 设置是否已打款给卖家     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setHasDisbursed(bool hasDisbursed) {
     	         	    this.hasDisbursed = hasDisbursed;
     	        }
    
        [DataMember(Order = 7)]
    private decimal? payFee;
    
        /**
       * @return 创建时需要付款的金额，不含运费
    */
        public decimal? getPayFee() {
               	return payFee;
            }
    
    /**
     * 设置创建时需要付款的金额，不含运费     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPayFee(decimal payFee) {
     	         	    this.payFee = payFee;
     	        }
    
        [DataMember(Order = 8)]
    private decimal? actualPayFee;
    
        /**
       * @return 应付款（含运费）= 单价×数量-单品优惠-店铺优惠+运费+修改的金额（除运费外，均指分摊后的金额）
    */
        public decimal? getActualPayFee() {
               	return actualPayFee;
            }
    
    /**
     * 设置应付款（含运费）= 单价×数量-单品优惠-店铺优惠+运费+修改的金额（除运费外，均指分摊后的金额）     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setActualPayFee(decimal actualPayFee) {
     	         	    this.actualPayFee = actualPayFee;
     	        }
    
        [DataMember(Order = 9)]
    private decimal? discountFee;
    
        /**
       * @return 本阶段分摊的店铺优惠
    */
        public decimal? getDiscountFee() {
               	return discountFee;
            }
    
    /**
     * 设置本阶段分摊的店铺优惠     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDiscountFee(decimal discountFee) {
     	         	    this.discountFee = discountFee;
     	        }
    
        [DataMember(Order = 10)]
    private decimal? itemDiscountFee;
    
        /**
       * @return 本阶段分摊的单品优惠
    */
        public decimal? getItemDiscountFee() {
               	return itemDiscountFee;
            }
    
    /**
     * 设置本阶段分摊的单品优惠     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setItemDiscountFee(decimal itemDiscountFee) {
     	         	    this.itemDiscountFee = itemDiscountFee;
     	        }
    
        [DataMember(Order = 11)]
    private decimal? price;
    
        /**
       * @return 本阶段分摊的单价
    */
        public decimal? getPrice() {
               	return price;
            }
    
    /**
     * 设置本阶段分摊的单价     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPrice(decimal price) {
     	         	    this.price = price;
     	        }
    
        [DataMember(Order = 12)]
    private long? amount;
    
        /**
       * @return 购买数量
    */
        public long? getAmount() {
               	return amount;
            }
    
    /**
     * 设置购买数量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAmount(long amount) {
     	         	    this.amount = amount;
     	        }
    
        [DataMember(Order = 13)]
    private decimal? postFee;
    
        /**
       * @return 运费
    */
        public decimal? getPostFee() {
               	return postFee;
            }
    
    /**
     * 设置运费     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPostFee(decimal postFee) {
     	         	    this.postFee = postFee;
     	        }
    
        [DataMember(Order = 14)]
    private decimal? adjustFee;
    
        /**
       * @return 修改价格修改的金额
    */
        public decimal? getAdjustFee() {
               	return adjustFee;
            }
    
    /**
     * 设置修改价格修改的金额     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAdjustFee(decimal adjustFee) {
     	         	    this.adjustFee = adjustFee;
     	        }
    
        [DataMember(Order = 15)]
    private string gmtCreate;
    
        /**
       * @return 创建时间
    */
        public DateTime? getGmtCreate() {
                 if (gmtCreate != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtCreate);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置创建时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGmtCreate(DateTime gmtCreate) {
     	         	    this.gmtCreate = DateUtil.format(gmtCreate);
     	        }
    
        [DataMember(Order = 16)]
    private string gmtModified;
    
        /**
       * @return 修改时间
    */
        public DateTime? getGmtModified() {
                 if (gmtModified != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtModified);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置修改时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGmtModified(DateTime gmtModified) {
     	         	    this.gmtModified = DateUtil.format(gmtModified);
     	        }
    
        [DataMember(Order = 17)]
    private string enterTime;
    
        /**
       * @return 开始时间
    */
        public DateTime? getEnterTime() {
                 if (enterTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(enterTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置开始时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setEnterTime(DateTime enterTime) {
     	         	    this.enterTime = DateUtil.format(enterTime);
     	        }
    
        [DataMember(Order = 18)]
    private string payTime;
    
        /**
       * @return 付款时间
    */
        public DateTime? getPayTime() {
                 if (payTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(payTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置付款时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPayTime(DateTime payTime) {
     	         	    this.payTime = DateUtil.format(payTime);
     	        }
    
        [DataMember(Order = 19)]
    private string sellerActionTime;
    
        /**
       * @return 卖家操作时间
    */
        public DateTime? getSellerActionTime() {
                 if (sellerActionTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(sellerActionTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置卖家操作时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerActionTime(DateTime sellerActionTime) {
     	         	    this.sellerActionTime = DateUtil.format(sellerActionTime);
     	        }
    
        [DataMember(Order = 20)]
    private string endTime;
    
        /**
       * @return 本阶段结束时间
    */
        public DateTime? getEndTime() {
                 if (endTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(endTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置本阶段结束时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setEndTime(DateTime endTime) {
     	         	    this.endTime = DateUtil.format(endTime);
     	        }
    
        [DataMember(Order = 21)]
    private string messagePath;
    
        /**
       * @return 卖家操作留言路径
    */
        public string getMessagePath() {
               	return messagePath;
            }
    
    /**
     * 设置卖家操作留言路径     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMessagePath(string messagePath) {
     	         	    this.messagePath = messagePath;
     	        }
    
        [DataMember(Order = 22)]
    private string picturePath;
    
        /**
       * @return 卖家上传图片凭据路径
    */
        public string getPicturePath() {
               	return picturePath;
            }
    
    /**
     * 设置卖家上传图片凭据路径     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPicturePath(string picturePath) {
     	         	    this.picturePath = picturePath;
     	        }
    
        [DataMember(Order = 23)]
    private string message;
    
        /**
       * @return 卖家操作留言
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置卖家操作留言     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
        [DataMember(Order = 24)]
    private long? templateId;
    
        /**
       * @return 使用的模板id
    */
        public long? getTemplateId() {
               	return templateId;
            }
    
    /**
     * 设置使用的模板id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTemplateId(long templateId) {
     	         	    this.templateId = templateId;
     	        }
    
        [DataMember(Order = 25)]
    private string stepName;
    
        /**
       * @return 当前步骤的名称
    */
        public string getStepName() {
               	return stepName;
            }
    
    /**
     * 设置当前步骤的名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStepName(string stepName) {
     	         	    this.stepName = stepName;
     	        }
    
        [DataMember(Order = 26)]
    private string sellerActionName;
    
        /**
       * @return 卖家操作名称
    */
        public string getSellerActionName() {
               	return sellerActionName;
            }
    
    /**
     * 设置卖家操作名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerActionName(string sellerActionName) {
     	         	    this.sellerActionName = sellerActionName;
     	        }
    
        [DataMember(Order = 27)]
    private long? buyerPayTimeout;
    
        /**
       * @return 买家不付款的超时时间(秒)
    */
        public long? getBuyerPayTimeout() {
               	return buyerPayTimeout;
            }
    
    /**
     * 设置买家不付款的超时时间(秒)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerPayTimeout(long buyerPayTimeout) {
     	         	    this.buyerPayTimeout = buyerPayTimeout;
     	        }
    
        [DataMember(Order = 28)]
    private long? buyerConfirmTimeout;
    
        /**
       * @return 买家不确认的超时时间
    */
        public long? getBuyerConfirmTimeout() {
               	return buyerConfirmTimeout;
            }
    
    /**
     * 设置买家不确认的超时时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerConfirmTimeout(long buyerConfirmTimeout) {
     	         	    this.buyerConfirmTimeout = buyerConfirmTimeout;
     	        }
    
        [DataMember(Order = 29)]
    private bool? needLogistics;
    
        /**
       * @return 是否需要物流
    */
        public bool? getNeedLogistics() {
               	return needLogistics;
            }
    
    /**
     * 设置是否需要物流     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setNeedLogistics(bool needLogistics) {
     	         	    this.needLogistics = needLogistics;
     	        }
    
        [DataMember(Order = 30)]
    private bool? needSellerAction;
    
        /**
       * @return 是否需要卖家操作和买家确认
    */
        public bool? getNeedSellerAction() {
               	return needSellerAction;
            }
    
    /**
     * 设置是否需要卖家操作和买家确认     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setNeedSellerAction(bool needSellerAction) {
     	         	    this.needSellerAction = needSellerAction;
     	        }
    
        [DataMember(Order = 31)]
    private bool? transferAfterConfirm;
    
        /**
       * @return 阶段结束是否打款
    */
        public bool? getTransferAfterConfirm() {
               	return transferAfterConfirm;
            }
    
    /**
     * 设置阶段结束是否打款     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTransferAfterConfirm(bool transferAfterConfirm) {
     	         	    this.transferAfterConfirm = transferAfterConfirm;
     	        }
    
        [DataMember(Order = 32)]
    private bool? needSellerCallNext;
    
        /**
       * @return 是否需要卖家推进
    */
        public bool? getNeedSellerCallNext() {
               	return needSellerCallNext;
            }
    
    /**
     * 设置是否需要卖家推进     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setNeedSellerCallNext(bool needSellerCallNext) {
     	         	    this.needSellerCallNext = needSellerCallNext;
     	        }
    
        [DataMember(Order = 33)]
    private bool? instantPay;
    
        /**
       * @return 是否允许即时到帐
    */
        public bool? getInstantPay() {
               	return instantPay;
            }
    
    /**
     * 设置是否允许即时到帐     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setInstantPay(bool instantPay) {
     	         	    this.instantPay = instantPay;
     	        }
    
    
  }
}