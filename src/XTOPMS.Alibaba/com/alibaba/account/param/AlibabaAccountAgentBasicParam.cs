using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.account.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaAccountAgentBasicParam : GatewayAPIRequest {

    public AlibabaAccountAgentBasicParam() {
        this.ApiId = new APIId("com.alibaba.account", "alibaba.account.agent.basic",1);
	}
	
       [DataMember(Order = 1)]
    private string loginId;
    
        /**
       * @return 用户的loginId，入参不可同时为空
    */
        public string getLoginId() {
               	return loginId;
            }
    
    /**
     * 设置用户的loginId，入参不可同时为空     *
     * 参数示例：<pre>alitestforisv01</pre>     
             * 此参数必填
          */
    public void setLoginId(string loginId) {
     	         	    this.loginId = loginId;
     	        }
    
        [DataMember(Order = 2)]
    private string domain;
    
        /**
       * @return 旺铺域名，入参不可同时为空
    */
        public string getDomain() {
               	return domain;
            }
    
    /**
     * 设置旺铺域名，入参不可同时为空     *
     * 参数示例：<pre>trgm66666.1688.com</pre>     
             * 此参数必填
          */
    public void setDomain(string domain) {
     	         	    this.domain = domain;
     	        }
    
    
  }
}