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
public class AlibabaOpenplatformTradeKeyValuePairBizOrderCommitResult {

       [DataMember(Order = 1)]
    private string key;
    
        /**
       * @return key
    */
        public string getKey() {
               	return key;
            }
    
    /**
     * 设置key     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setKey(string key) {
     	         	    this.key = key;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaOpenplatformTradeBizOrderCommitResult value;
    
        /**
       * @return value
    */
        public AlibabaOpenplatformTradeBizOrderCommitResult getValue() {
               	return value;
            }
    
    /**
     * 设置value     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setValue(AlibabaOpenplatformTradeBizOrderCommitResult value) {
     	         	    this.value = value;
     	        }
    
    
  }
}