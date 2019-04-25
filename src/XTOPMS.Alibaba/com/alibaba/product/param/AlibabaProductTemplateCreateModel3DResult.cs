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
public class AlibabaProductTemplateCreateModel3DResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaProductProductInfo productInfo;
    
        /**
       * @return 基于产品模型生成的模版信息
    */
        public AlibabaProductProductInfo getProductInfo() {
               	return productInfo;
            }
    
    /**
     * 设置基于产品模型生成的模版信息     *
          
             * 此参数必填
          */
    public void setProductInfo(AlibabaProductProductInfo productInfo) {
     	         	    this.productInfo = productInfo;
     	        }
    
    
  }
}