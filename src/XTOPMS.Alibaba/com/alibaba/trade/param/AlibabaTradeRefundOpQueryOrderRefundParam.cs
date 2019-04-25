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
public class AlibabaTradeRefundOpQueryOrderRefundParam : GatewayAPIRequest {

    public AlibabaTradeRefundOpQueryOrderRefundParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.refund.OpQueryOrderRefund",1);
	}
	
       [DataMember(Order = 1)]
    private string refundId;
    
        /**
       * @return 退款单业务主键 TQ+ID
    */
        public string getRefundId() {
               	return refundId;
            }
    
    /**
     * 设置退款单业务主键 TQ+ID     *
     * 参数示例：<pre>TQ11173622***991577</pre>     
             * 此参数必填
          */
    public void setRefundId(string refundId) {
     	         	    this.refundId = refundId;
     	        }
    
        [DataMember(Order = 2)]
    private bool? needTimeOutInfo;
    
        /**
       * @return 需要退款单的超时信息
    */
        public bool? getNeedTimeOutInfo() {
               	return needTimeOutInfo;
            }
    
    /**
     * 设置需要退款单的超时信息     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setNeedTimeOutInfo(bool needTimeOutInfo) {
     	         	    this.needTimeOutInfo = needTimeOutInfo;
     	        }
    
        [DataMember(Order = 3)]
    private bool? needOrderRefundOperation;
    
        /**
       * @return 需要退款单伴随的所有退款操作信息
    */
        public bool? getNeedOrderRefundOperation() {
               	return needOrderRefundOperation;
            }
    
    /**
     * 设置需要退款单伴随的所有退款操作信息     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setNeedOrderRefundOperation(bool needOrderRefundOperation) {
     	         	    this.needOrderRefundOperation = needOrderRefundOperation;
     	        }
    
    
  }
}