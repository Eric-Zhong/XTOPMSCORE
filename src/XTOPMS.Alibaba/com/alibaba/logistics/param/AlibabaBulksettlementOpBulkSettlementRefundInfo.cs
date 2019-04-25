using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.logistics.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaBulksettlementOpBulkSettlementRefundInfo {

       [DataMember(Order = 1)]
    private string refundId;
    
        /**
       * @return 退款单号
    */
        public string getRefundId() {
               	return refundId;
            }
    
    /**
     * 设置退款单号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRefundId(string refundId) {
     	         	    this.refundId = refundId;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaBulksettlementOpBulkSettlementSubOrderInfo[] opBulkSettlementSubOrderInfos;
    
        /**
       * @return 退款单中个子订单信息
    */
        public AlibabaBulksettlementOpBulkSettlementSubOrderInfo[] getOpBulkSettlementSubOrderInfos() {
               	return opBulkSettlementSubOrderInfos;
            }
    
    /**
     * 设置退款单中个子订单信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOpBulkSettlementSubOrderInfos(AlibabaBulksettlementOpBulkSettlementSubOrderInfo[] opBulkSettlementSubOrderInfos) {
     	         	    this.opBulkSettlementSubOrderInfos = opBulkSettlementSubOrderInfos;
     	        }
    
    
  }
}