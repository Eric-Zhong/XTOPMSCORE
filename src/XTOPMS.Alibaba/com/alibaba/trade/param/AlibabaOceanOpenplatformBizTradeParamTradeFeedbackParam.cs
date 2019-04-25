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
public class AlibabaOceanOpenplatformBizTradeParamTradeFeedbackParam {

       [DataMember(Order = 1)]
    private string feedback;
    
        /**
       * @return 留言
    */
        public string getFeedback() {
               	return feedback;
            }
    
    /**
     * 设置留言     *
     * 参数示例：<pre>留言</pre>     
             * 此参数必填
          */
    public void setFeedback(string feedback) {
     	         	    this.feedback = feedback;
     	        }
    
        [DataMember(Order = 2)]
    private string orderId;
    
        /**
       * @return 订单ID
    */
        public string getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置订单ID     *
     * 参数示例：<pre>12344444555545</pre>     
             * 此参数必填
          */
    public void setOrderId(string orderId) {
     	         	    this.orderId = orderId;
     	        }
    
    
  }
}