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
public class AlibabaOpenplatformTradeResultTradeCreateGeneralOrderResult {

       [DataMember(Order = 1)]
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
    
        [DataMember(Order = 2)]
    private long? totalSuccessAmount;
    
        /**
       * @return 下单成功的订单总金额
    */
        public long? getTotalSuccessAmount() {
               	return totalSuccessAmount;
            }
    
    /**
     * 设置下单成功的订单总金额     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTotalSuccessAmount(long totalSuccessAmount) {
     	         	    this.totalSuccessAmount = totalSuccessAmount;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaOpenplatformTradeBizOrderCommitResult[] commitResults;
    
        /**
       * @return 多订单提交后的处理结果.
    */
        public AlibabaOpenplatformTradeBizOrderCommitResult[] getCommitResults() {
               	return commitResults;
            }
    
    /**
     * 设置多订单提交后的处理结果.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCommitResults(AlibabaOpenplatformTradeBizOrderCommitResult[] commitResults) {
     	         	    this.commitResults = commitResults;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaOpenplatformTradeBizMutilOrderPublicData mutilOrderPublicData;
    
        /**
       * @return 多订单共有数据属性
    */
        public AlibabaOpenplatformTradeBizMutilOrderPublicData getMutilOrderPublicData() {
               	return mutilOrderPublicData;
            }
    
    /**
     * 设置多订单共有数据属性     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMutilOrderPublicData(AlibabaOpenplatformTradeBizMutilOrderPublicData mutilOrderPublicData) {
     	         	    this.mutilOrderPublicData = mutilOrderPublicData;
     	        }
    
        [DataMember(Order = 5)]
    private AlibabaOpenplatformTradeResultCodeDef resultCode;
    
        /**
       * @return 错误码
    */
        public AlibabaOpenplatformTradeResultCodeDef getResultCode() {
               	return resultCode;
            }
    
    /**
     * 设置错误码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setResultCode(AlibabaOpenplatformTradeResultCodeDef resultCode) {
     	         	    this.resultCode = resultCode;
     	        }
    
        [DataMember(Order = 6)]
    private AlibabaOpenplatformTradeKeyValuePairBizOrderCommitResult[] failOrderMap;
    
        /**
       * @return 处理失败的订单块.
    */
        public AlibabaOpenplatformTradeKeyValuePairBizOrderCommitResult[] getFailOrderMap() {
               	return failOrderMap;
            }
    
    /**
     * 设置处理失败的订单块.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFailOrderMap(AlibabaOpenplatformTradeKeyValuePairBizOrderCommitResult[] failOrderMap) {
     	         	    this.failOrderMap = failOrderMap;
     	        }
    
        [DataMember(Order = 7)]
    private AlibabaOpenplatformTradeKeyValuePairBizOrderCommitResult[] successOrderMap;
    
        /**
       * @return 处理成功的订单块.
    */
        public AlibabaOpenplatformTradeKeyValuePairBizOrderCommitResult[] getSuccessOrderMap() {
               	return successOrderMap;
            }
    
    /**
     * 设置处理成功的订单块.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSuccessOrderMap(AlibabaOpenplatformTradeKeyValuePairBizOrderCommitResult[] successOrderMap) {
     	         	    this.successOrderMap = successOrderMap;
     	        }
    
    
  }
}