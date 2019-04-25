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
public class AlibabaOceanOpenplatformBizTradeResultPayTypeInfo {

       [DataMember(Order = 1)]
    private long? code;
    
        /**
       * @return 支付渠道编码
    */
        public long? getCode() {
               	return code;
            }
    
    /**
     * 设置支付渠道编码     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setCode(long code) {
     	         	    this.code = code;
     	        }
    
        [DataMember(Order = 2)]
    private string name;
    
        /**
       * @return 支付渠道名称
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置支付渠道名称     *
     * 参数示例：<pre>支付宝</pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
    
  }
}