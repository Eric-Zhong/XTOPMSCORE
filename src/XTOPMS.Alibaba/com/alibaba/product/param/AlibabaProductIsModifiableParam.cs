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
public class AlibabaProductIsModifiableParam : GatewayAPIRequest {

    public AlibabaProductIsModifiableParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.isModifiable",1);
	}
	
       [DataMember(Order = 1)]
    private long[] productIds;
    
        /**
       * @return 商品ID列表
    */
        public long[] getProductIds() {
               	return productIds;
            }
    
    /**
     * 设置商品ID列表     *
     * 参数示例：<pre>[575053589753]</pre>     
             * 此参数必填
          */
    public void setProductIds(long[] productIds) {
     	         	    this.productIds = productIds;
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