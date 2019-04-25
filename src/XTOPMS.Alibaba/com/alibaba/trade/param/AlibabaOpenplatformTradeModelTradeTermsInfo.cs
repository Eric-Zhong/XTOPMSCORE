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
public class AlibabaOpenplatformTradeModelTradeTermsInfo {

       [DataMember(Order = 1)]
    private string payStatus;
    
        /**
       * @return 支付状态。国际站：WAIT_PAY(未支付),PAYER_PAID(已完成支付),PART_SUCCESS(部分支付成功),PAY_SUCCESS(支付成功),CLOSED(风控关闭),CANCELLED(支付撤销),SUCCESS(成功),FAIL(失败)。
1688:1(未付款);2(已付款);4(全额退款);6(卖家有收到钱，回款完成) ;7(未创建外部支付单);8 (付款前取消) ; 9(正在支付中);12(账期支付,待到账)
    */
        public string getPayStatus() {
               	return payStatus;
            }
    
    /**
     * 设置支付状态。国际站：WAIT_PAY(未支付),PAYER_PAID(已完成支付),PART_SUCCESS(部分支付成功),PAY_SUCCESS(支付成功),CLOSED(风控关闭),CANCELLED(支付撤销),SUCCESS(成功),FAIL(失败)。
1688:1(未付款);2(已付款);4(全额退款);6(卖家有收到钱，回款完成) ;7(未创建外部支付单);8 (付款前取消) ; 9(正在支付中);12(账期支付,待到账)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPayStatus(string payStatus) {
     	         	    this.payStatus = payStatus;
     	        }
    
        [DataMember(Order = 2)]
    private string payTime;
    
        /**
       * @return 完成阶段支付时间
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
     * 设置完成阶段支付时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPayTime(DateTime payTime) {
     	         	    this.payTime = DateUtil.format(payTime);
     	        }
    
        [DataMember(Order = 3)]
    private string payWay;
    
        /**
       * @return 支付方式。
国际站：ECL(融资支付),CC(信用卡),TT(线下TT),ACH(echecking支付)。
1688:1-支付宝,2-网商银行信任付,3-诚e赊,4-银行转账,5-赊销宝,6-电子承兑票据,7-账期支付,8-合并支付渠道,9-无打款,10-零售通赊购,13-支付平台,12-声明付款
    */
        public string getPayWay() {
               	return payWay;
            }
    
    /**
     * 设置支付方式。
国际站：ECL(融资支付),CC(信用卡),TT(线下TT),ACH(echecking支付)。
1688:1-支付宝,2-网商银行信任付,3-诚e赊,4-银行转账,5-赊销宝,6-电子承兑票据,7-账期支付,8-合并支付渠道,9-无打款,10-零售通赊购,13-支付平台,12-声明付款     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPayWay(string payWay) {
     	         	    this.payWay = payWay;
     	        }
    
        [DataMember(Order = 4)]
    private decimal? phasAmount;
    
        /**
       * @return 付款额
    */
        public decimal? getPhasAmount() {
               	return phasAmount;
            }
    
    /**
     * 设置付款额     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPhasAmount(decimal phasAmount) {
     	         	    this.phasAmount = phasAmount;
     	        }
    
        [DataMember(Order = 5)]
    private long? phase;
    
        /**
       * @return 阶段单id
    */
        public long? getPhase() {
               	return phase;
            }
    
    /**
     * 设置阶段单id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPhase(long phase) {
     	         	    this.phase = phase;
     	        }
    
        [DataMember(Order = 6)]
    private string phaseCondition;
    
        /**
       * @return 阶段条件，1688无此内容
    */
        public string getPhaseCondition() {
               	return phaseCondition;
            }
    
    /**
     * 设置阶段条件，1688无此内容     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPhaseCondition(string phaseCondition) {
     	         	    this.phaseCondition = phaseCondition;
     	        }
    
        [DataMember(Order = 7)]
    private string phaseDate;
    
        /**
       * @return 阶段时间，1688无此内容
    */
        public string getPhaseDate() {
               	return phaseDate;
            }
    
    /**
     * 设置阶段时间，1688无此内容     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPhaseDate(string phaseDate) {
     	         	    this.phaseDate = phaseDate;
     	        }
    
        [DataMember(Order = 8)]
    private bool? cardPay;
    
        /**
       * @return 是否银行卡支付
    */
        public bool? getCardPay() {
               	return cardPay;
            }
    
    /**
     * 设置是否银行卡支付     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCardPay(bool cardPay) {
     	         	    this.cardPay = cardPay;
     	        }
    
        [DataMember(Order = 9)]
    private bool? expressPay;
    
        /**
       * @return 是否快捷支付
    */
        public bool? getExpressPay() {
               	return expressPay;
            }
    
    /**
     * 设置是否快捷支付     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setExpressPay(bool expressPay) {
     	         	    this.expressPay = expressPay;
     	        }
    
    
  }
}