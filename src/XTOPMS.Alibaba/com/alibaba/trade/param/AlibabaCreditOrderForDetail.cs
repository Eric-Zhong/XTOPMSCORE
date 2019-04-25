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
public class AlibabaCreditOrderForDetail {

       [DataMember(Order = 1)]
    private long? payAmount;
    
        /**
       * @return 订单金额
    */
        public long? getPayAmount() {
               	return payAmount;
            }
    
    /**
     * 设置订单金额     *
     * 参数示例：<pre>10</pre>     
             * 此参数必填
          */
    public void setPayAmount(long payAmount) {
     	         	    this.payAmount = payAmount;
     	        }
    
        [DataMember(Order = 2)]
    private string createTime;
    
        /**
       * @return 支付时间
    */
        public string getCreateTime() {
               	return createTime;
            }
    
    /**
     * 设置支付时间     *
     * 参数示例：<pre>2018-01-01 00:00:00</pre>     
             * 此参数必填
          */
    public void setCreateTime(string createTime) {
     	         	    this.createTime = createTime;
     	        }
    
        [DataMember(Order = 3)]
    private string status;
    
        /**
       * @return 状态
    */
        public string getStatus() {
               	return status;
            }
    
    /**
     * 设置状态     *
     * 参数示例：<pre>END</pre>     
             * 此参数必填
          */
    public void setStatus(string status) {
     	         	    this.status = status;
     	        }
    
        [DataMember(Order = 4)]
    private string gracePeriodEndTime;
    
        /**
       * @return 最晚还款时间
    */
        public string getGracePeriodEndTime() {
               	return gracePeriodEndTime;
            }
    
    /**
     * 设置最晚还款时间     *
     * 参数示例：<pre>2018-01-01 00:00:00</pre>     
             * 此参数必填
          */
    public void setGracePeriodEndTime(string gracePeriodEndTime) {
     	         	    this.gracePeriodEndTime = gracePeriodEndTime;
     	        }
    
        [DataMember(Order = 5)]
    private string statusStr;
    
        /**
       * @return 状态描述
    */
        public string getStatusStr() {
               	return statusStr;
            }
    
    /**
     * 设置状态描述     *
     * 参数示例：<pre>已完结</pre>     
             * 此参数必填
          */
    public void setStatusStr(string statusStr) {
     	         	    this.statusStr = statusStr;
     	        }
    
        [DataMember(Order = 6)]
    private long? restRepayAmount;
    
        /**
       * @return 应还金额
    */
        public long? getRestRepayAmount() {
               	return restRepayAmount;
            }
    
    /**
     * 设置应还金额     *
     * 参数示例：<pre>11</pre>     
             * 此参数必填
          */
    public void setRestRepayAmount(long restRepayAmount) {
     	         	    this.restRepayAmount = restRepayAmount;
     	        }
    
    
  }
}