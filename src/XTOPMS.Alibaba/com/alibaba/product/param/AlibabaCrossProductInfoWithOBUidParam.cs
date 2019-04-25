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
public class AlibabaCrossProductInfoWithOBUidParam : GatewayAPIRequest {

    public AlibabaCrossProductInfoWithOBUidParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.cross.productInfoWithOBUid",1);
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
     * 参数示例：<pre>T12433661</pre>     
             * 此参数必填
          */
    public void setObUid(string obUid) {
     	         	    this.obUid = obUid;
     	        }
    
        [DataMember(Order = 2)]
    private long? offerId;
    
        /**
       * @return 1688商品ID，等同于productId
    */
        public long? getOfferId() {
               	return offerId;
            }
    
    /**
     * 设置1688商品ID，等同于productId     *
     * 参数示例：<pre>573741401425</pre>     
             * 此参数必填
          */
    public void setOfferId(long offerId) {
     	         	    this.offerId = offerId;
     	        }
    
    
  }
}