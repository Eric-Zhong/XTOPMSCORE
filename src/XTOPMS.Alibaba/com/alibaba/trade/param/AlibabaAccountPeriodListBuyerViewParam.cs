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
public class AlibabaAccountPeriodListBuyerViewParam : GatewayAPIRequest {

    public AlibabaAccountPeriodListBuyerViewParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.accountPeriod.list.buyerView",1);
	}
	
       [DataMember(Order = 1)]
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
    
        [DataMember(Order = 2)]
    private string sellerLoginId;
    
        /**
       * @return 卖家ID，不填则查询全部
    */
        public string getSellerLoginId() {
               	return sellerLoginId;
            }
    
    /**
     * 设置卖家ID，不填则查询全部     *
     * 参数示例：<pre>alitestforisv01</pre>     
             * 此参数必填
          */
    public void setSellerLoginId(string sellerLoginId) {
     	         	    this.sellerLoginId = sellerLoginId;
     	        }
    
    
  }
}