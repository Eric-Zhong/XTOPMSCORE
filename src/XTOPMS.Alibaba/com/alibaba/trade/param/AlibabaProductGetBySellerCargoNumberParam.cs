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
public class AlibabaProductGetBySellerCargoNumberParam : GatewayAPIRequest {

    public AlibabaProductGetBySellerCargoNumberParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.product.getBySellerCargoNumber",1);
	}
	
       [DataMember(Order = 1)]
    private AlibabaProductRelateCargoNumberProductRetrieveRequest request;
    
        /**
       * @return 供应商Id及商品信息
    */
        public AlibabaProductRelateCargoNumberProductRetrieveRequest getRequest() {
               	return request;
            }
    
    /**
     * 设置供应商Id及商品信息     *
     * 参数示例：<pre>{"supplyUserId":1623492085,"idListOfSupplier":[{"spuId":"560033667534"}]}</pre>     
             * 此参数必填
          */
    public void setRequest(AlibabaProductRelateCargoNumberProductRetrieveRequest request) {
     	         	    this.request = request;
     	        }
    
    
  }
}