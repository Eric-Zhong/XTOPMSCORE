using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.p4p.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaCpsListGroupInfoParam : GatewayAPIRequest {

    public AlibabaCpsListGroupInfoParam() {
        this.ApiId = new APIId("com.alibaba.p4p", "alibaba.cps.listGroupInfo",1);
	}
	
       [DataMember(Order = 1)]
    private long? groupId;
    
        /**
       * @return 组id
    */
        public long? getGroupId() {
               	return groupId;
            }
    
    /**
     * 设置组id     *
     * 参数示例：<pre>9999923</pre>     
             * 此参数必填
          */
    public void setGroupId(long groupId) {
     	         	    this.groupId = groupId;
     	        }
    
    
  }
}