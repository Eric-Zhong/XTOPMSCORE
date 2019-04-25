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
public class AlibabaProductPushTaOrderQueryServiceQueryTradeBillNotOutListParam : GatewayAPIRequest {

    public AlibabaProductPushTaOrderQueryServiceQueryTradeBillNotOutListParam() {
        this.ApiId = new APIId("com.alibaba.product.push", "alibaba.product.push.TaOrderQueryService.queryTradeBillNotOutList",1);
	}
	
       [DataMember(Order = 1)]
    private string startTime;
    
        /**
       * @return 账单创建时间查询开始值
    */
        public DateTime? getStartTime() {
                 if (startTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(startTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置账单创建时间查询开始值     *
     * 参数示例：<pre>20180600000000000+0800</pre>     
             * 此参数必填
          */
    public void setStartTime(DateTime startTime) {
     	         	    this.startTime = DateUtil.format(startTime);
     	        }
    
        [DataMember(Order = 2)]
    private string endTime;
    
        /**
       * @return 账单创建时间查询结束值
    */
        public DateTime? getEndTime() {
                 if (endTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(endTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置账单创建时间查询结束值     *
     * 参数示例：<pre>20180900000000000+0800</pre>     
             * 此参数必填
          */
    public void setEndTime(DateTime endTime) {
     	         	    this.endTime = DateUtil.format(endTime);
     	        }
    
        [DataMember(Order = 3)]
    private int? limit;
    
        /**
       * @return 每页显示记录数
    */
        public int? getLimit() {
               	return limit;
            }
    
    /**
     * 设置每页显示记录数     *
     * 参数示例：<pre>10</pre>     
             * 此参数必填
          */
    public void setLimit(int limit) {
     	         	    this.limit = limit;
     	        }
    
        [DataMember(Order = 4)]
    private int? pageNumber;
    
        /**
       * @return 当前页
    */
        public int? getPageNumber() {
               	return pageNumber;
            }
    
    /**
     * 设置当前页     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setPageNumber(int pageNumber) {
     	         	    this.pageNumber = pageNumber;
     	        }
    
        [DataMember(Order = 5)]
    private bool? seller;
    
        /**
       * @return 标识userId用户类型,false为推客,true为卖家
    */
        public bool? getSeller() {
               	return seller;
            }
    
    /**
     * 设置标识userId用户类型,false为推客,true为卖家     *
     * 参数示例：<pre>false</pre>     
             * 此参数必填
          */
    public void setSeller(bool seller) {
     	         	    this.seller = seller;
     	        }
    
    
  }
}