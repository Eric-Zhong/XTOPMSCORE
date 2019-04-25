using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.search.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaSearchSupplyProductParam : GatewayAPIRequest {

    public AlibabaSearchSupplyProductParam() {
        this.ApiId = new APIId("com.alibaba.search", "alibaba.search.supply.product",1);
	}
	
       [DataMember(Order = 1)]
    private int? pageNum;
    
        /**
       * @return 分页时的页数
    */
        public int? getPageNum() {
               	return pageNum;
            }
    
    /**
     * 设置分页时的页数     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setPageNum(int pageNum) {
     	         	    this.pageNum = pageNum;
     	        }
    
        [DataMember(Order = 2)]
    private int? pageSize;
    
        /**
       * @return 每一页的大小
    */
        public int? getPageSize() {
               	return pageSize;
            }
    
    /**
     * 设置每一页的大小     *
     * 参数示例：<pre>20</pre>     
             * 此参数必填
          */
    public void setPageSize(int pageSize) {
     	         	    this.pageSize = pageSize;
     	        }
    
        [DataMember(Order = 3)]
    private string productPublishTime;
    
        /**
       * @return 卖家商品发布的时间，如果不设置则查找所有
    */
        public DateTime? getProductPublishTime() {
                 if (productPublishTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(productPublishTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置卖家商品发布的时间，如果不设置则查找所有     *
     * 参数示例：<pre>20180809000000000+0800</pre>     
             * 此参数必填
          */
    public void setProductPublishTime(DateTime productPublishTime) {
     	         	    this.productPublishTime = DateUtil.format(productPublishTime);
     	        }
    
        [DataMember(Order = 4)]
    private long? sellerUserId;
    
        /**
       * @return 卖家用户ID
    */
        public long? getSellerUserId() {
               	return sellerUserId;
            }
    
    /**
     * 设置卖家用户ID     *
     * 参数示例：<pre>1624961198</pre>     
             * 此参数必填
          */
    public void setSellerUserId(long sellerUserId) {
     	         	    this.sellerUserId = sellerUserId;
     	        }
    
    
  }
}