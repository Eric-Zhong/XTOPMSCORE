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
public class AlibabaLogisticsFreightTemplateAddParam : GatewayAPIRequest {

    public AlibabaLogisticsFreightTemplateAddParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.logistics.freightTemplate.add",1);
	}
	
       [DataMember(Order = 1)]
    private string templateType;
    
        /**
       * @return 运费模板类型，可选值：freeshipping(全球免邮)，not(全球不发货)
    */
        public string getTemplateType() {
               	return templateType;
            }
    
    /**
     * 设置运费模板类型，可选值：freeshipping(全球免邮)，not(全球不发货)     *
     * 参数示例：<pre>freeshipping</pre>     
             * 此参数必填
          */
    public void setTemplateType(string templateType) {
     	         	    this.templateType = templateType;
     	        }
    
        [DataMember(Order = 2)]
    private string[] dispatchLocations;
    
        /**
       * @return 运费模板发货地，可选值：US（美国）,UK(英国),DE(德国),ES(西班牙),CN(中国)
    */
        public string[] getDispatchLocations() {
               	return dispatchLocations;
            }
    
    /**
     * 设置运费模板发货地，可选值：US（美国）,UK(英国),DE(德国),ES(西班牙),CN(中国)     *
     * 参数示例：<pre>"US"
"UK"</pre>     
             * 此参数必填
          */
    public void setDispatchLocations(string[] dispatchLocations) {
     	         	    this.dispatchLocations = dispatchLocations;
     	        }
    
        [DataMember(Order = 3)]
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