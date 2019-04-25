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
public class AlibabaOpenplatformTradeBizOrderCommitResult {

       [DataMember(Order = 1)]
    private string[] afterFlowIds;
    
        /**
       * @return 需要后续执行的流程标示列表。是一个List<String>
    */
        public string[] getAfterFlowIds() {
               	return afterFlowIds;
            }
    
    /**
     * 设置需要后续执行的流程标示列表。是一个List<String>     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAfterFlowIds(string[] afterFlowIds) {
     	         	    this.afterFlowIds = afterFlowIds;
     	        }
    
        [DataMember(Order = 2)]
    private bool? customOffer;
    
        /**
       * @return 是否加工定制下单
    */
        public bool? getCustomOffer() {
               	return customOffer;
            }
    
    /**
     * 设置是否加工定制下单     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCustomOffer(bool customOffer) {
     	         	    this.customOffer = customOffer;
     	        }
    
        [DataMember(Order = 3)]
    private long? orderAmount;
    
        /**
       * @return 订单实付款金额，单位为分
    */
        public long? getOrderAmount() {
               	return orderAmount;
            }
    
    /**
     * 设置订单实付款金额，单位为分     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderAmount(long orderAmount) {
     	         	    this.orderAmount = orderAmount;
     	        }
    
        [DataMember(Order = 4)]
    private long? orderId;
    
        /**
       * @return 下单成功后的订单id.
    */
        public long? getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置下单成功后的订单id.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderId(long orderId) {
     	         	    this.orderId = orderId;
     	        }
    
        [DataMember(Order = 5)]
    private string[] outBizEntryIds;
    
        /**
       * @return 外部业务关联依赖的明细id. 比如: 代销订单的代销id列表。是一个List<String>
    */
        public string[] getOutBizEntryIds() {
               	return outBizEntryIds;
            }
    
    /**
     * 设置外部业务关联依赖的明细id. 比如: 代销订单的代销id列表。是一个List<String>     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOutBizEntryIds(string[] outBizEntryIds) {
     	         	    this.outBizEntryIds = outBizEntryIds;
     	        }
    
        [DataMember(Order = 6)]
    private string payChannel;
    
        /**
       * @return 支付渠道
    */
        public string getPayChannel() {
               	return payChannel;
            }
    
    /**
     * 设置支付渠道     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPayChannel(string payChannel) {
     	         	    this.payChannel = payChannel;
     	        }
    
        [DataMember(Order = 7)]
    private bool? success;
    
        /**
       * @return 是否成功
    */
        public bool? getSuccess() {
               	return success;
            }
    
    /**
     * 设置是否成功     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSuccess(bool success) {
     	         	    this.success = success;
     	        }
    
        [DataMember(Order = 8)]
    private AlibabaOpenplatformTradeBizSimpleOrderModel orderModel;
    
        /**
       * @return 下单成功后,会将订单简易模型返回
    */
        public AlibabaOpenplatformTradeBizSimpleOrderModel getOrderModel() {
               	return orderModel;
            }
    
    /**
     * 设置下单成功后,会将订单简易模型返回     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderModel(AlibabaOpenplatformTradeBizSimpleOrderModel orderModel) {
     	         	    this.orderModel = orderModel;
     	        }
    
        [DataMember(Order = 9)]
    private AlibabaOpenplatformTradeResultCodeDef resultCode;
    
        /**
       * @return 结果码
    */
        public AlibabaOpenplatformTradeResultCodeDef getResultCode() {
               	return resultCode;
            }
    
    /**
     * 设置结果码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setResultCode(AlibabaOpenplatformTradeResultCodeDef resultCode) {
     	         	    this.resultCode = resultCode;
     	        }
    
        [DataMember(Order = 10)]
    private AlibabaTradeComKeyValuePair[] extModels;
    
        /**
       * @return 扩展属性
    */
        public AlibabaTradeComKeyValuePair[] getExtModels() {
               	return extModels;
            }
    
    /**
     * 设置扩展属性     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setExtModels(AlibabaTradeComKeyValuePair[] extModels) {
     	         	    this.extModels = extModels;
     	        }
    
    
  }
}