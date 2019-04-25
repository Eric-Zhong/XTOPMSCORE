using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.product.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductGroupSetSwitchParam : GatewayAPIRequest {

    public AlibabaProductGroupSetSwitchParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.group.setSwitch",1);
	}
	
       [DataMember(Order = 1)]
    private bool? switchValue;
    
        /**
       * @return 设置状态，true：已开启；false：未开启
    */
        public bool? getSwitchValue() {
               	return switchValue;
            }
    
    /**
     * 设置设置状态，true：已开启；false：未开启     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setSwitchValue(bool switchValue) {
     	         	    this.switchValue = switchValue;
     	        }
    
        [DataMember(Order = 2)]
    private string webSite;
    
        /**
       * @return 站点信息，指定调用的API是属于国际站（alibaba）还是1688网站（1688）
    */
        public string getWebSite() {
               	return webSite;
            }
    
    /**
     * 设置站点信息，指定调用的API是属于国际站（alibaba）还是1688网站（1688）     *
     * 参数示例：<pre>1688</pre>     
             * 此参数必填
          */
    public void setWebSite(string webSite) {
     	         	    this.webSite = webSite;
     	        }
    
    
  }
}