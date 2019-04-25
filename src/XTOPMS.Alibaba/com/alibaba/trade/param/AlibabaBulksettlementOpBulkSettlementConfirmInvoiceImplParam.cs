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
public class AlibabaBulksettlementOpBulkSettlementConfirmInvoiceImplParam : GatewayAPIRequest {

    public AlibabaBulksettlementOpBulkSettlementConfirmInvoiceImplParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.bulksettlement.OpBulkSettlementConfirmInvoiceImpl",2);
	}
	
       [DataMember(Order = 1)]
    private long? settlemnetId;
    
        /**
       * @return 结算单Id
    */
        public long? getSettlemnetId() {
               	return settlemnetId;
            }
    
    /**
     * 设置结算单Id     *
     * 参数示例：<pre>151454</pre>     
             * 此参数必填
          */
    public void setSettlemnetId(long settlemnetId) {
     	         	    this.settlemnetId = settlemnetId;
     	        }
    
    
  }
}