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
public class AlibabaLogisticsOpenPlatformLogisticsTrace {

       [DataMember(Order = 1)]
    private string logisticsId;
    
        /**
       * @return 物流编号，如BX110096003841234
    */
        public string getLogisticsId() {
               	return logisticsId;
            }
    
    /**
     * 设置物流编号，如BX110096003841234     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsId(string logisticsId) {
     	         	    this.logisticsId = logisticsId;
     	        }
    
        [DataMember(Order = 2)]
    private long? orderId;
    
        /**
       * @return 订单编号
    */
        public long? getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置订单编号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderId(long orderId) {
     	         	    this.orderId = orderId;
     	        }
    
        [DataMember(Order = 3)]
    private string logisticsBillNo;
    
        /**
       * @return 物流单编号，如480330616596
    */
        public string getLogisticsBillNo() {
               	return logisticsBillNo;
            }
    
    /**
     * 设置物流单编号，如480330616596     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsBillNo(string logisticsBillNo) {
     	         	    this.logisticsBillNo = logisticsBillNo;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaLogisticsOpenPlatformLogisticsStep[] logisticsSteps;
    
        /**
       * @return 物流跟踪步骤
    */
        public AlibabaLogisticsOpenPlatformLogisticsStep[] getLogisticsSteps() {
               	return logisticsSteps;
            }
    
    /**
     * 设置物流跟踪步骤     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsSteps(AlibabaLogisticsOpenPlatformLogisticsStep[] logisticsSteps) {
     	         	    this.logisticsSteps = logisticsSteps;
     	        }
    
        [DataMember(Order = 5)]
    private AlibabaLogisticsOpenPlatformTraceNode[] traceNodeList;
    
        /**
       * @return 物流周转节点
    */
        public AlibabaLogisticsOpenPlatformTraceNode[] getTraceNodeList() {
               	return traceNodeList;
            }
    
    /**
     * 设置物流周转节点     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTraceNodeList(AlibabaLogisticsOpenPlatformTraceNode[] traceNodeList) {
     	         	    this.traceNodeList = traceNodeList;
     	        }
    
    
  }
}