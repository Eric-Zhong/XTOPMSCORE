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
public class AlibabaLogisticResultOpSendOrderModelResult {

       [DataMember(Order = 1)]
    private string logisticsId;
    
        /**
       * @return 物流编号
    */
        public string getLogisticsId() {
               	return logisticsId;
            }
    
    /**
     * 设置物流编号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsId(string logisticsId) {
     	         	    this.logisticsId = logisticsId;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaLogisticsOpSendGood[] sendGoods;
    
        /**
       * @return 发货明细
    */
        public AlibabaLogisticsOpSendGood[] getSendGoods() {
               	return sendGoods;
            }
    
    /**
     * 设置发货明细     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSendGoods(AlibabaLogisticsOpSendGood[] sendGoods) {
     	         	    this.sendGoods = sendGoods;
     	        }
    
    
  }
}