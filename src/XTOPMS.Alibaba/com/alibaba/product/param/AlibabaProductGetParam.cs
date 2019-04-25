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
public class AlibabaProductGetParam : GatewayAPIRequest {

    public AlibabaProductGetParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.get",1);
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
     * 参数示例：<pre>123456</pre>     
             * 此参数必填
          */
    public void setProductID(long productID) {
     	         	    this.productID = productID;
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
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setWebSite(string webSite) {
     	         	    this.webSite = webSite;
     	        }
    
        [DataMember(Order = 3)]
    private string scene;
    
        /**
       * @return 业务场景 零售通(lst) 1688市场(1688)
    */
        public string getScene() {
               	return scene;
            }
    
    /**
     * 设置业务场景 零售通(lst) 1688市场(1688)     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setScene(string scene) {
     	         	    this.scene = scene;
     	        }
    
    
  }
}