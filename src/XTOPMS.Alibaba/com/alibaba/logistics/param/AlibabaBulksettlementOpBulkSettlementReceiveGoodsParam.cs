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
public class AlibabaBulksettlementOpBulkSettlementReceiveGoodsParam : GatewayAPIRequest {

    public AlibabaBulksettlementOpBulkSettlementReceiveGoodsParam() {
        this.ApiId = new APIId("com.alibaba.logistics", "alibaba.bulksettlement.OpBulkSettlementReceiveGoods",1);
	}
	
       [DataMember(Order = 1)]
    private AlibabaBulksettlementOpBulkSettlementSubOrderInfo[] receivedQuantity;
    
        /**
       * @return 子订单号和子订单确认收货数量（包括历史确认收货数量）
    */
        public AlibabaBulksettlementOpBulkSettlementSubOrderInfo[] getReceivedQuantity() {
               	return receivedQuantity;
            }
    
    /**
     * 设置子订单号和子订单确认收货数量（包括历史确认收货数量）     *
     * 参数示例：<pre>-</pre>     
             * 此参数必填
          */
    public void setReceivedQuantity(AlibabaBulksettlementOpBulkSettlementSubOrderInfo[] receivedQuantity) {
     	         	    this.receivedQuantity = receivedQuantity;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaBulksettlementOpBulkSettlementRefundInfo[] refundIdReceivedQuantity;
    
        /**
       * @return 退款单号，子订单号及退款但中商品数量
    */
        public AlibabaBulksettlementOpBulkSettlementRefundInfo[] getRefundIdReceivedQuantity() {
               	return refundIdReceivedQuantity;
            }
    
    /**
     * 设置退款单号，子订单号及退款但中商品数量     *
     * 参数示例：<pre>-</pre>     
             * 此参数必填
          */
    public void setRefundIdReceivedQuantity(AlibabaBulksettlementOpBulkSettlementRefundInfo[] refundIdReceivedQuantity) {
     	         	    this.refundIdReceivedQuantity = refundIdReceivedQuantity;
     	        }
    
        [DataMember(Order = 3)]
    private long? orderId;
    
        /**
       * @return 订单id
    */
        public long? getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置订单id     *
     * 参数示例：<pre>-</pre>     
             * 此参数必填
          */
    public void setOrderId(long orderId) {
     	         	    this.orderId = orderId;
     	        }
    
        [DataMember(Order = 4)]
    private string subUserLoginId;
    
        /**
       * @return 子账号的loginId
    */
        public string getSubUserLoginId() {
               	return subUserLoginId;
            }
    
    /**
     * 设置子账号的loginId     *
     * 参数示例：<pre>-</pre>     
             * 此参数必填
          */
    public void setSubUserLoginId(string subUserLoginId) {
     	         	    this.subUserLoginId = subUserLoginId;
     	        }
    
    
  }
}