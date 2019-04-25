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
public class AlibabaPaymentPayChannels {

       [DataMember(Order = 1)]
    private AlibabaPaymentPayChannel[] availbleChannels;
    
        /**
       * @return 可选支付渠道
    */
        public AlibabaPaymentPayChannel[] getAvailbleChannels() {
               	return availbleChannels;
            }
    
    /**
     * 设置可选支付渠道     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAvailbleChannels(AlibabaPaymentPayChannel[] availbleChannels) {
     	         	    this.availbleChannels = availbleChannels;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaPaymentPayChannel defaultSelected;
    
        /**
       * @return 默认已选支付渠道
    */
        public AlibabaPaymentPayChannel getDefaultSelected() {
               	return defaultSelected;
            }
    
    /**
     * 设置默认已选支付渠道     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDefaultSelected(AlibabaPaymentPayChannel defaultSelected) {
     	         	    this.defaultSelected = defaultSelected;
     	        }
    
    
  }
}