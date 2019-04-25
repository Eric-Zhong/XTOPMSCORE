using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.product.push.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductPushMicroSupplySyncPushProductResultParam : GatewayAPIRequest {

    public AlibabaProductPushMicroSupplySyncPushProductResultParam() {
        this.ApiId = new APIId("com.alibaba.product.push", "alibaba.product.push.microSupply.syncPushProductResult",1);
	}
	
       [DataMember(Order = 1)]
    private AlibabaProductPushMicroSupplyPuHuoModel[] pushProductResults;
    
        /**
       * @return 商品级别的铺货结果
    */
        public AlibabaProductPushMicroSupplyPuHuoModel[] getPushProductResults() {
               	return pushProductResults;
            }
    
    /**
     * 设置商品级别的铺货结果     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setPushProductResults(AlibabaProductPushMicroSupplyPuHuoModel[] pushProductResults) {
     	         	    this.pushProductResults = pushProductResults;
     	        }
    
    
  }
}