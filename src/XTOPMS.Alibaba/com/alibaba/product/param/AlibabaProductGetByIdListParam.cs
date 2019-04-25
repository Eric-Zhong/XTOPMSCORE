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
public class AlibabaProductGetByIdListParam : GatewayAPIRequest {

    public AlibabaProductGetByIdListParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.getByIdList",1);
	}
	
       [DataMember(Order = 1)]
    private long[] productIdList;
    
        /**
       * @return 商品Id列表
    */
        public long[] getProductIdList() {
               	return productIdList;
            }
    
    /**
     * 设置商品Id列表     *
     * 参数示例：<pre>[573198114093,574286066987]</pre>     
             * 此参数必填
          */
    public void setProductIdList(long[] productIdList) {
     	         	    this.productIdList = productIdList;
     	        }
    
    
  }
}