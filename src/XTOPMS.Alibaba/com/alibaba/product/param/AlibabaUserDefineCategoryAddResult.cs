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
public class AlibabaUserDefineCategoryAddResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private long? catId;
    
        /**
       * @return 新建的类目的id
    */
        public long? getCatId() {
               	return catId;
            }
    
    /**
     * 设置新建的类目的id     *
          
             * 此参数必填
          */
    public void setCatId(long catId) {
     	         	    this.catId = catId;
     	        }
    
    
  }
}