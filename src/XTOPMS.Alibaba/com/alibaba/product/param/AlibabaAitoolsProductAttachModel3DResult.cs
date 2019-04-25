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
public class AlibabaAitoolsProductAttachModel3DResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private long? productID;
    
        /**
       * @return 1688 商品 ID。若 API 无错误产生，则表示 3D 信息设置成功，可在商品预览页面查看商品的 3D 模型。
    */
        public long? getProductID() {
               	return productID;
            }
    
    /**
     * 设置1688 商品 ID。若 API 无错误产生，则表示 3D 信息设置成功，可在商品预览页面查看商品的 3D 模型。     *
          
             * 此参数必填
          */
    public void setProductID(long productID) {
     	         	    this.productID = productID;
     	        }
    
    
  }
}