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
public class AlibabaCommonMoney {

       [DataMember(Order = 1)]
    private string value;
    
        /**
       * @return 钱的值，比如1.2
    */
        public string getValue() {
               	return value;
            }
    
    /**
     * 设置钱的值，比如1.2     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setValue(string value) {
     	         	    this.value = value;
     	        }
    
        [DataMember(Order = 2)]
    private string currency;
    
        /**
       * @return 货币
    */
        public string getCurrency() {
               	return currency;
            }
    
    /**
     * 设置货币     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCurrency(string currency) {
     	         	    this.currency = currency;
     	        }
    
    
  }
}