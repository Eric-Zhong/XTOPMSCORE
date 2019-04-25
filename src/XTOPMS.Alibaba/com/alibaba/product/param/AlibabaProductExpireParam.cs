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
public class AlibabaProductExpireParam : GatewayAPIRequest {

    public AlibabaProductExpireParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.expire",1);
	}
	
       [DataMember(Order = 1)]
    private long[] productIds;
    
        /**
       * @return 过期商品的ID列表
    */
        public long[] getProductIds() {
               	return productIds;
            }
    
    /**
     * 设置过期商品的ID列表     *
     * 参数示例：<pre>[575821659346]</pre>     
             * 此参数必填
          */
    public void setProductIds(long[] productIds) {
     	         	    this.productIds = productIds;
     	        }
    
        [DataMember(Order = 2)]
    private string webSite;
    
        /**
       * @return 1688或者alibaba
    */
        public string getWebSite() {
               	return webSite;
            }
    
    /**
     * 设置1688或者alibaba     *
     * 参数示例：<pre>1688</pre>     
             * 此参数必填
          */
    public void setWebSite(string webSite) {
     	         	    this.webSite = webSite;
     	        }
    
    
  }
}