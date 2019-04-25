using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.logistics.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaGlobalAddressLevelDivisionParam : GatewayAPIRequest {

    public AlibabaGlobalAddressLevelDivisionParam() {
        this.ApiId = new APIId("com.alibaba.logistics", "alibaba.globalAddress.levelDivision",1);
	}
	
       [DataMember(Order = 1)]
    private long? areaId;
    
        /**
       * @return 需要查询的地区ID
    */
        public long? getAreaId() {
               	return areaId;
            }
    
    /**
     * 设置需要查询的地区ID     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setAreaId(long areaId) {
     	         	    this.areaId = areaId;
     	        }
    
    
  }
}