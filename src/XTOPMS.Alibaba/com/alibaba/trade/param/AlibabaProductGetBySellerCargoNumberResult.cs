using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.trade.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductGetBySellerCargoNumberResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaProductRelateCargoNumberProductRetrieveResult[] result;
    
        /**
       * @return 商品信息
    */
        public AlibabaProductRelateCargoNumberProductRetrieveResult[] getResult() {
               	return result;
            }
    
    /**
     * 设置商品信息     *
          
             * 此参数必填
          */
    public void setResult(AlibabaProductRelateCargoNumberProductRetrieveResult[] result) {
     	         	    this.result = result;
     	        }
    
    
  }
}