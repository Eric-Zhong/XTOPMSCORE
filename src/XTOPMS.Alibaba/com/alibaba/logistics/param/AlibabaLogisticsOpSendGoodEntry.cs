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
public class AlibabaLogisticsOpSendGoodEntry {

       [DataMember(Order = 1)]
    private string sourceEntryId;
    
        /**
       * @return 发货对象明细id，对应子订单Id
    */
        public string getSourceEntryId() {
               	return sourceEntryId;
            }
    
    /**
     * 设置发货对象明细id，对应子订单Id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSourceEntryId(string sourceEntryId) {
     	         	    this.sourceEntryId = sourceEntryId;
     	        }
    
        [DataMember(Order = 2)]
    private long? amount;
    
        /**
       * @return 发货对象实发数量
    */
        public long? getAmount() {
               	return amount;
            }
    
    /**
     * 设置发货对象实发数量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAmount(long amount) {
     	         	    this.amount = amount;
     	        }
    
        [DataMember(Order = 3)]
    private double? weight;
    
        /**
       * @return 发货对象实发重量，重量单位默认为千克
    */
        public double? getWeight() {
               	return weight;
            }
    
    /**
     * 设置发货对象实发重量，重量单位默认为千克     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setWeight(double weight) {
     	         	    this.weight = weight;
     	        }
    
    
  }
}