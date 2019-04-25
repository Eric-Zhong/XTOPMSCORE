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
public class AlibabaProductSimpleAddResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaProductSimpleProductCreateResultModel simpleProductCreateResultModel;
    
        /**
       * @return 返回结果
    */
        public AlibabaProductSimpleProductCreateResultModel getSimpleProductCreateResultModel() {
               	return simpleProductCreateResultModel;
            }
    
    /**
     * 设置返回结果     *
          
             * 此参数必填
          */
    public void setSimpleProductCreateResultModel(AlibabaProductSimpleProductCreateResultModel simpleProductCreateResultModel) {
     	         	    this.simpleProductCreateResultModel = simpleProductCreateResultModel;
     	        }
    
    
  }
}