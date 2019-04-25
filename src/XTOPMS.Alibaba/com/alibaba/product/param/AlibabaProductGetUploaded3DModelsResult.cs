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
public class AlibabaProductGetUploaded3DModelsResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaProductProductThreeDimModel[] product3DModels;
    
        /**
       * @return 已经上传的精美模型列表
    */
        public AlibabaProductProductThreeDimModel[] getProduct3DModels() {
               	return product3DModels;
            }
    
    /**
     * 设置已经上传的精美模型列表     *
          
             * 此参数必填
          */
    public void setProduct3DModels(AlibabaProductProductThreeDimModel[] product3DModels) {
     	         	    this.product3DModels = product3DModels;
     	        }
    
    
  }
}