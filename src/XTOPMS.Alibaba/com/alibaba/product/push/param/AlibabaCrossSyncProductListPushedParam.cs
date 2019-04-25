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
public class AlibabaCrossSyncProductListPushedParam : GatewayAPIRequest {

    public AlibabaCrossSyncProductListPushedParam() {
        this.ApiId = new APIId("com.alibaba.product.push", "alibaba.cross.syncProductListPushed",1);
	}
	
       [DataMember(Order = 1)]
    private long[] productIdList;
    
        /**
       * @return 1688的商品ID列表,列表长度不能超过20个
    */
        public long[] getProductIdList() {
               	return productIdList;
            }
    
    /**
     * 设置1688的商品ID列表,列表长度不能超过20个     *
     * 参数示例：<pre>[123456]</pre>     
             * 此参数必填
          */
    public void setProductIdList(long[] productIdList) {
     	         	    this.productIdList = productIdList;
     	        }
    
    
  }
}