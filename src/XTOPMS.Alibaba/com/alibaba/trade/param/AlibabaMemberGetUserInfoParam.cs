using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.trade.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaMemberGetUserInfoParam : GatewayAPIRequest {

    public AlibabaMemberGetUserInfoParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.member.getUserInfo",1);
	}
	
       [DataMember(Order = 1)]
    private string domin;
    
        /**
       * @return 店铺域名
    */
        public string getDomin() {
               	return domin;
            }
    
    /**
     * 设置店铺域名     *
     * 参数示例：<pre>xx.1688.com</pre>     
             * 此参数必填
          */
    public void setDomin(string domin) {
     	         	    this.domin = domin;
     	        }
    
    
  }
}