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
public class AlibabaOceanOpenplatformBizTradeParamTradeProtectParam {

       [DataMember(Order = 1)]
    private string type;
    
        /**
       * @return 保单类型：查询理赔时type传lp，查询运费险时type传bx
    */
        public string getType() {
               	return type;
            }
    
    /**
     * 设置保单类型：查询理赔时type传lp，查询运费险时type传bx     *
     * 参数示例：<pre>lp</pre>     
             * 此参数必填
          */
    public void setType(string type) {
     	         	    this.type = type;
     	        }
    
        [DataMember(Order = 2)]
    private string protectId;
    
        /**
       * @return 保单号
    */
        public string getProtectId() {
               	return protectId;
            }
    
    /**
     * 设置保单号     *
     * 参数示例：<pre>91275389</pre>     
             * 此参数必填
          */
    public void setProtectId(string protectId) {
     	         	    this.protectId = protectId;
     	        }
    
    
  }
}