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
public class AlibabaProductManufactorySimpleAddResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaOceanOpenplatformCommonResultModelManufactory simpleProductCreateResultModel;
    
        /**
       * @return 返回结果
    */
        public AlibabaOceanOpenplatformCommonResultModelManufactory getSimpleProductCreateResultModel() {
               	return simpleProductCreateResultModel;
            }
    
    /**
     * 设置返回结果     *
          
             * 此参数必填
          */
    public void setSimpleProductCreateResultModel(AlibabaOceanOpenplatformCommonResultModelManufactory simpleProductCreateResultModel) {
     	         	    this.simpleProductCreateResultModel = simpleProductCreateResultModel;
     	        }
    
    
  }
}