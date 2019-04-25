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
public class AlibabaProductModifyStockParam : GatewayAPIRequest {

    public AlibabaProductModifyStockParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.modifyStock",1);
	}
	
       [DataMember(Order = 1)]
    private AlibabaProductProductStock[] productStockChange;
    
        /**
       * @return 产品库存变更信息
    */
        public AlibabaProductProductStock[] getProductStockChange() {
               	return productStockChange;
            }
    
    /**
     * 设置产品库存变更信息     *
     * 参数示例：<pre>[]</pre>     
             * 此参数必填
          */
    public void setProductStockChange(AlibabaProductProductStock[] productStockChange) {
     	         	    this.productStockChange = productStockChange;
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
    
        [DataMember(Order = 3)]
    private bool? increaceModify;
    
        /**
       * @return 是否增量更新
    */
        public bool? getIncreaceModify() {
               	return increaceModify;
            }
    
    /**
     * 设置是否增量更新     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setIncreaceModify(bool increaceModify) {
     	         	    this.increaceModify = increaceModify;
     	        }
    
    
  }
}