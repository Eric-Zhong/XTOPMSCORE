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
public class AlibabaCrossBuildRelationParam : GatewayAPIRequest {

    public AlibabaCrossBuildRelationParam() {
        this.ApiId = new APIId("com.alibaba.product.push", "alibaba.cross.buildRelation",1);
	}
	
       [DataMember(Order = 1)]
    private string obUid;
    
        /**
       * @return 代购用户唯一Id
    */
        public string getObUid() {
               	return obUid;
            }
    
    /**
     * 设置代购用户唯一Id     *
     * 参数示例：<pre>t12412</pre>     
             * 此参数必填
          */
    public void setObUid(string obUid) {
     	         	    this.obUid = obUid;
     	        }
    
        [DataMember(Order = 2)]
    private long[] offerIdList;
    
        /**
       * @return 1688的商品ID列表,列表长度不能超过20个
    */
        public long[] getOfferIdList() {
               	return offerIdList;
            }
    
    /**
     * 设置1688的商品ID列表,列表长度不能超过20个     *
     * 参数示例：<pre>[123456]</pre>     
             * 此参数必填
          */
    public void setOfferIdList(long[] offerIdList) {
     	         	    this.offerIdList = offerIdList;
     	        }
    
    
  }
}