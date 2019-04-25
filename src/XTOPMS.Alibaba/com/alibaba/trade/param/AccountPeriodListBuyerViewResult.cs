using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.trade.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AccountPeriodListBuyerViewResult {

       [DataMember(Order = 1)]
    private string totalCount;
    
        /**
       * @return 总数据条数
    */
        public string getTotalCount() {
               	return totalCount;
            }
    
    /**
     * 设置总数据条数     *
     * 参数示例：<pre>100</pre>     
             * 此参数必填
          */
    public void setTotalCount(string totalCount) {
     	         	    this.totalCount = totalCount;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaOceanOpenplatformBizTradeCommonModelAccountPeriodInfo[] accountPeriodList;
    
        /**
       * @return 授信列表
    */
        public AlibabaOceanOpenplatformBizTradeCommonModelAccountPeriodInfo[] getAccountPeriodList() {
               	return accountPeriodList;
            }
    
    /**
     * 设置授信列表     *
     * 参数示例：<pre>[]</pre>     
             * 此参数必填
          */
    public void setAccountPeriodList(AlibabaOceanOpenplatformBizTradeCommonModelAccountPeriodInfo[] accountPeriodList) {
     	         	    this.accountPeriodList = accountPeriodList;
     	        }
    
    
  }
}