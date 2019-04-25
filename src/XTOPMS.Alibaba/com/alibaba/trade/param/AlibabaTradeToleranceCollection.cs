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
public class AlibabaTradeToleranceCollection {

       [DataMember(Order = 1)]
    private string toleranceFreight;
    
        /**
       * @return 运费是否被容错. 0: 没有容错。 1：被容错.
    */
        public string getToleranceFreight() {
               	return toleranceFreight;
            }
    
    /**
     * 设置运费是否被容错. 0: 没有容错。 1：被容错.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToleranceFreight(string toleranceFreight) {
     	         	    this.toleranceFreight = toleranceFreight;
     	        }
    
    
  }
}