using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.logistics.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaBulksettlementOpCreateBulkSettlementReceiveNoteParam : GatewayAPIRequest {

    public AlibabaBulksettlementOpCreateBulkSettlementReceiveNoteParam() {
        this.ApiId = new APIId("com.alibaba.logistics", "alibaba.bulksettlement.OpCreateBulkSettlementReceiveNote",2);
	}
	
       [DataMember(Order = 1)]
    private AlibabaBulksettlementOpBulkSettlementSubOrderInfo[] receivedQuantity;
    
        /**
       * @return 子订单号和子订单确认收货数量（包括历史确认收货数量）和单价
    */
        public AlibabaBulksettlementOpBulkSettlementSubOrderInfo[] getReceivedQuantity() {
               	return receivedQuantity;
            }
    
    /**
     * 设置子订单号和子订单确认收货数量（包括历史确认收货数量）和单价     *
     * 参数示例：<pre>null</pre>     
             * 此参数必填
          */
    public void setReceivedQuantity(AlibabaBulksettlementOpBulkSettlementSubOrderInfo[] receivedQuantity) {
     	         	    this.receivedQuantity = receivedQuantity;
     	        }
    
        [DataMember(Order = 2)]
    private long? orderId;
    
        /**
       * @return 订单号
    */
        public long? getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置订单号     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setOrderId(long orderId) {
     	         	    this.orderId = orderId;
     	        }
    
        [DataMember(Order = 3)]
    private string subUserLoginId;
    
        /**
       * @return 子账号的loginId
    */
        public string getSubUserLoginId() {
               	return subUserLoginId;
            }
    
    /**
     * 设置子账号的loginId     *
     * 参数示例：<pre>asd</pre>     
             * 此参数必填
          */
    public void setSubUserLoginId(string subUserLoginId) {
     	         	    this.subUserLoginId = subUserLoginId;
     	        }
    
    
  }
}