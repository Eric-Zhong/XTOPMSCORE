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
public class AlibabaTradeFastCargo {

       [DataMember(Order = 1)]
    private long? offerId;
    
        /**
       * @return 商品对应的offer id
    */
        public long? getOfferId() {
               	return offerId;
            }
    
    /**
     * 设置商品对应的offer id     *
     * 参数示例：<pre>554456348334</pre>     
             * 此参数必填
          */
    public void setOfferId(long offerId) {
     	         	    this.offerId = offerId;
     	        }
    
        [DataMember(Order = 2)]
    private string specId;
    
        /**
       * @return 商品规格id
    */
        public string getSpecId() {
               	return specId;
            }
    
    /**
     * 设置商品规格id     *
     * 参数示例：<pre>b266e0726506185beaf205cbae88530d</pre>     
             * 此参数必填
          */
    public void setSpecId(string specId) {
     	         	    this.specId = specId;
     	        }
    
        [DataMember(Order = 3)]
    private double? quantity;
    
        /**
       * @return 商品数量(计算金额用)
    */
        public double? getQuantity() {
               	return quantity;
            }
    
    /**
     * 设置商品数量(计算金额用)     *
     * 参数示例：<pre>5</pre>     
             * 此参数必填
          */
    public void setQuantity(double quantity) {
     	         	    this.quantity = quantity;
     	        }
    
    
  }
}