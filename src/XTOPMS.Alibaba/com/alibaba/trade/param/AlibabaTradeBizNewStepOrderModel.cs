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
public class AlibabaTradeBizNewStepOrderModel {

       [DataMember(Order = 1)]
    private string gmtStart;
    
        /**
       * @return 阶段开始时间
    */
        public DateTime? getGmtStart() {
                 if (gmtStart != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtStart);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置阶段开始时间     *
     * 参数示例：<pre>20180604092517000+0800</pre>     
             * 此参数必填
          */
    public void setGmtStart(DateTime gmtStart) {
     	         	    this.gmtStart = DateUtil.format(gmtStart);
     	        }
    
        [DataMember(Order = 2)]
    private string gmtPay;
    
        /**
       * @return 付款时间
    */
        public DateTime? getGmtPay() {
                 if (gmtPay != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtPay);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置付款时间     *
     * 参数示例：<pre>20180604093243000+0800</pre>     
             * 此参数必填
          */
    public void setGmtPay(DateTime gmtPay) {
     	         	    this.gmtPay = DateUtil.format(gmtPay);
     	        }
    
        [DataMember(Order = 3)]
    private string gmtEnd;
    
        /**
       * @return 阶段结束时间
    */
        public DateTime? getGmtEnd() {
                 if (gmtEnd != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtEnd);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置阶段结束时间     *
     * 参数示例：<pre>20180604093243000+0800</pre>     
             * 此参数必填
          */
    public void setGmtEnd(DateTime gmtEnd) {
     	         	    this.gmtEnd = DateUtil.format(gmtEnd);
     	        }
    
        [DataMember(Order = 4)]
    private int? stepNo;
    
        /**
       * @return 阶段顺序编号
    */
        public int? getStepNo() {
               	return stepNo;
            }
    
    /**
     * 设置阶段顺序编号     *
     * 参数示例：<pre>1</pre>     
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
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setLastStep(bool lastStep) {
     	         	    this.lastStep = lastStep;
     	        }
    
        [DataMember(Order = 6)]
    private string stepName;
    
        /**
       * @return 阶段名称
    */
        public string getStepName() {
               	return stepName;
            }
    
    /**
     * 设置阶段名称     *
     * 参数示例：<pre>全款交易</pre>     
             * 此参数必填
          */
    public void setStepName(string stepName) {
     	         	    this.stepName = stepName;
     	        }
    
        [DataMember(Order = 7)]
    private int? activeStatus;
    
        /**
       * @return 激活状态。0表示未激活，1表示已激活
    */
        public int? getActiveStatus() {
               	return activeStatus;
            }
    
    /**
     * 设置激活状态。0表示未激活，1表示已激活     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setActiveStatus(int activeStatus) {
     	         	    this.activeStatus = activeStatus;
     	        }
    
        [DataMember(Order = 8)]
    private int? payStatus;
    
        /**
       * @return 阶段付款状态。1未付款、2已付款、8付款前取消、12溢短补付款
    */
        public int? getPayStatus() {
               	return payStatus;
            }
    
    /**
     * 设置阶段付款状态。1未付款、2已付款、8付款前取消、12溢短补付款     *
     * 参数示例：<pre>2</pre>     
             * 此参数必填
          */
    public void setPayStatus(int payStatus) {
     	         	    this.payStatus = payStatus;
     	        }
    
        [DataMember(Order = 9)]
    private int? logisticsStatus;
    
        /**
       * @return 物流环节状态：1未发货、2已发货、3已收货、4已全部退货、7发货前取消
    */
        public int? getLogisticsStatus() {
               	return logisticsStatus;
            }
    
    /**
     * 设置物流环节状态：1未发货、2已发货、3已收货、4已全部退货、7发货前取消     *
     * 参数示例：<pre>2</pre>     
             * 此参数必填
          */
    public void setLogisticsStatus(int logisticsStatus) {
     	         	    this.logisticsStatus = logisticsStatus;
     	        }
    
        [DataMember(Order = 10)]
    private decimal? payFee;
    
        /**
       * @return 阶段应付款（包含运费），单位为元
    */
        public decimal? getPayFee() {
               	return payFee;
            }
    
    /**
     * 设置阶段应付款（包含运费），单位为元     *
     * 参数示例：<pre>0.03</pre>     
             * 此参数必填
          */
    public void setPayFee(decimal payFee) {
     	         	    this.payFee = payFee;
     	        }
    
        [DataMember(Order = 11)]
    private decimal? paidFee;
    
        /**
       * @return 阶段已付款（包含运费），单位为元
    */
        public decimal? getPaidFee() {
               	return paidFee;
            }
    
    /**
     * 设置阶段已付款（包含运费），单位为元     *
     * 参数示例：<pre>0.03</pre>     
             * 此参数必填
          */
    public void setPaidFee(decimal paidFee) {
     	         	    this.paidFee = paidFee;
     	        }
    
        [DataMember(Order = 12)]
    private decimal? goodsFee;
    
        /**
       * @return 阶段商品价格分摊 ，单位为元
    */
        public decimal? getGoodsFee() {
               	return goodsFee;
            }
    
    /**
     * 设置阶段商品价格分摊 ，单位为元     *
     * 参数示例：<pre>0</pre>     
             * 此参数必填
          */
    public void setGoodsFee(decimal goodsFee) {
     	         	    this.goodsFee = goodsFee;
     	        }
    
        [DataMember(Order = 13)]
    private decimal? adjustFee;
    
        /**
       * @return 阶段调整价格 ，单位为元
    */
        public decimal? getAdjustFee() {
               	return adjustFee;
            }
    
    /**
     * 设置阶段调整价格 ，单位为元     *
     * 参数示例：<pre>-3175.97</pre>     
             * 此参数必填
          */
    public void setAdjustFee(decimal adjustFee) {
     	         	    this.adjustFee = adjustFee;
     	        }
    
        [DataMember(Order = 14)]
    private decimal? discountFee;
    
        /**
       * @return 阶段优惠价格，单位为元
    */
        public decimal? getDiscountFee() {
               	return discountFee;
            }
    
    /**
     * 设置阶段优惠价格，单位为元     *
     * 参数示例：<pre>0</pre>     
             * 此参数必填
          */
    public void setDiscountFee(decimal discountFee) {
     	         	    this.discountFee = discountFee;
     	        }
    
        [DataMember(Order = 15)]
    private decimal? postFee;
    
        /**
       * @return 阶段的应付邮费，单位为元
    */
        public decimal? getPostFee() {
               	return postFee;
            }
    
    /**
     * 设置阶段的应付邮费，单位为元     *
     * 参数示例：<pre>0</pre>     
             * 此参数必填
          */
    public void setPostFee(decimal postFee) {
     	         	    this.postFee = postFee;
     	        }
    
        [DataMember(Order = 16)]
    private decimal? paidPostFee;
    
        /**
       * @return 阶段已付的邮费，单位为元
    */
        public decimal? getPaidPostFee() {
               	return paidPostFee;
            }
    
    /**
     * 设置阶段已付的邮费，单位为元     *
     * 参数示例：<pre>0</pre>     
             * 此参数必填
          */
    public void setPaidPostFee(decimal paidPostFee) {
     	         	    this.paidPostFee = paidPostFee;
     	        }
    
    
  }
}