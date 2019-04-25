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
public class AlibabaProductEditParam : GatewayAPIRequest {

    public AlibabaProductEditParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.edit",1);
	}
	
       [DataMember(Order = 1)]
    private long? productID;
    
        /**
       * @return 商品ID
    */
        public long? getProductID() {
               	return productID;
            }
    
    /**
     * 设置商品ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductID(long productID) {
     	         	    this.productID = productID;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaProductProductInfo productInfo;
    
        /**
       * @return 商品详细信息
    */
        public AlibabaProductProductInfo getProductInfo() {
               	return productInfo;
            }
    
    /**
     * 设置商品详细信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductInfo(AlibabaProductProductInfo productInfo) {
     	         	    this.productInfo = productInfo;
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
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setWebSite(string webSite) {
     	         	    this.webSite = webSite;
     	        }
    
    
  }
}