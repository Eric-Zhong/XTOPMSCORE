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
public class AlibabaProductPushMicroSupplySyncUserPlatformParam : GatewayAPIRequest {

    public AlibabaProductPushMicroSupplySyncUserPlatformParam() {
        this.ApiId = new APIId("com.alibaba.product.push", "alibaba.product.push.microSupply.syncUserPlatform",1);
	}
	
       [DataMember(Order = 1)]
    private AlibabaProductPushMicroSupplyShopModel userPlatformDetails;
    
        /**
       * @return 
    */
        public AlibabaProductPushMicroSupplyShopModel getUserPlatformDetails() {
               	return userPlatformDetails;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUserPlatformDetails(AlibabaProductPushMicroSupplyShopModel userPlatformDetails) {
     	         	    this.userPlatformDetails = userPlatformDetails;
     	        }
    
    
  }
}