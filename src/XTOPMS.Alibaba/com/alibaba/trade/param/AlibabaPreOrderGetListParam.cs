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
public class AlibabaPreOrderGetListParam : GatewayAPIRequest {

    public AlibabaPreOrderGetListParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.preOrder.getList",1);
	}
	
       [DataMember(Order = 1)]
    private long? orderId;
    
        /**
       * @return 预订单ID
    */
        public long? getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置预订单ID     *
     * 参数示例：<pre>21579698640</pre>     
             * 此参数必填
          */
    public void setOrderId(long orderId) {
     	         	    this.orderId = orderId;
     	        }
    
        [DataMember(Order = 2)]
    private long? pageSize;
    
        /**
       * @return 每页数量，最大20
    */
        public long? getPageSize() {
               	return pageSize;
            }
    
    /**
     * 设置每页数量，最大20     *
     * 参数示例：<pre>10</pre>     
             * 此参数必填
          */
    public void setPageSize(long pageSize) {
     	         	    this.pageSize = pageSize;
     	        }
    
        [DataMember(Order = 3)]
    private long? pageIndex;
    
        /**
       * @return 页码
    */
        public long? getPageIndex() {
               	return pageIndex;
            }
    
    /**
     * 设置页码     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setPageIndex(long pageIndex) {
     	         	    this.pageIndex = pageIndex;
     	        }
    
        [DataMember(Order = 4)]
    private string marketName;
    
        /**
       * @return 专业市场，枚举dxc：大象城，hqb：华强北
    */
        public string getMarketName() {
               	return marketName;
            }
    
    /**
     * 设置专业市场，枚举dxc：大象城，hqb：华强北     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setMarketName(string marketName) {
     	         	    this.marketName = marketName;
     	        }
    
    
  }
}