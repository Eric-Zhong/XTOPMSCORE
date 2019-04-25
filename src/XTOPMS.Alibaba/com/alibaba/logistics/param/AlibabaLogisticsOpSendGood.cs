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
public class AlibabaLogisticsOpSendGood {

       [DataMember(Order = 1)]
    private string sourceId;
    
        /**
       * @return 发货对象id,一般是订单id
    */
        public string getSourceId() {
               	return sourceId;
            }
    
    /**
     * 设置发货对象id,一般是订单id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSourceId(string sourceId) {
     	         	    this.sourceId = sourceId;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaLogisticsOpSendGoodEntry[] sendGoodEntries;
    
        /**
       * @return 发货对象明细列表
    */
        public AlibabaLogisticsOpSendGoodEntry[] getSendGoodEntries() {
               	return sendGoodEntries;
            }
    
    /**
     * 设置发货对象明细列表     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSendGoodEntries(AlibabaLogisticsOpSendGoodEntry[] sendGoodEntries) {
     	         	    this.sendGoodEntries = sendGoodEntries;
     	        }
    
    
  }
}