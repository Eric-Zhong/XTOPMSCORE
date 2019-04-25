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
public class AlibabaTradeOrderViewModel {

       [DataMember(Order = 1)]
    private string[] afterFlowIds;
    
        /**
       * @return 
    */
        public string[] getAfterFlowIds() {
               	return afterFlowIds;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAfterFlowIds(string[] afterFlowIds) {
     	         	    this.afterFlowIds = afterFlowIds;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaTradeResultCodeDef resultCode;
    
        /**
       * @return 
    */
        public AlibabaTradeResultCodeDef getResultCode() {
               	return resultCode;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setResultCode(AlibabaTradeResultCodeDef resultCode) {
     	         	    this.resultCode = resultCode;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaTradeMakeOrderModel orderModel;
    
        /**
       * @return 
    */
        public AlibabaTradeMakeOrderModel getOrderModel() {
               	return orderModel;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderModel(AlibabaTradeMakeOrderModel orderModel) {
     	         	    this.orderModel = orderModel;
     	        }
    
    
  }
}