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
public class AlibabaProductDescrTemplateCreateStdResult : GatewayAPIResponse {

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
    
        [DataMember(Order = 2)]
    private AlibabaProductDescriptionDescriptionInfo descriptionInfo;
    
        /**
       * @return 商品详情描述结构化信息
    */
        public AlibabaProductDescriptionDescriptionInfo getDescriptionInfo() {
               	return descriptionInfo;
            }
    
    /**
     * 设置商品详情描述结构化信息     *
          
             * 此参数必填
          */
    public void setDescriptionInfo(AlibabaProductDescriptionDescriptionInfo descriptionInfo) {
     	         	    this.descriptionInfo = descriptionInfo;
     	        }
    
    
  }
}