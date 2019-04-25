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
public class AlibabaTradeAddresscodeGetchildParam : GatewayAPIRequest {

    public AlibabaTradeAddresscodeGetchildParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.addresscode.getchild",1);
	}
	
       [DataMember(Order = 1)]
    private string areaCode;
    
        /**
       * @return 地址码，如果不输入则获取最上层信息
    */
        public string getAreaCode() {
               	return areaCode;
            }
    
    /**
     * 设置地址码，如果不输入则获取最上层信息     *
     * 参数示例：<pre>330108</pre>     
             * 此参数必填
          */
    public void setAreaCode(string areaCode) {
     	         	    this.areaCode = areaCode;
     	        }
    
        [DataMember(Order = 2)]
    private string webSite;
    
        /**
       * @return 站点信息,1688或者alibaba
    */
        public string getWebSite() {
               	return webSite;
            }
    
    /**
     * 设置站点信息,1688或者alibaba     *
     * 参数示例：<pre>1688</pre>     
             * 此参数必填
          */
    public void setWebSite(string webSite) {
     	         	    this.webSite = webSite;
     	        }
    
    
  }
}