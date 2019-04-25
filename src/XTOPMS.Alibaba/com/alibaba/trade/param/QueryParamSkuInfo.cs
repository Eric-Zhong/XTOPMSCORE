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
public class QueryParamSkuInfo {

       [DataMember(Order = 1)]
    private string specId;
    
        /**
       * @return 购买的规格ID，无规格商品可不填
    */
        public string getSpecId() {
               	return specId;
            }
    
    /**
     * 设置购买的规格ID，无规格商品可不填     *
     * 参数示例：<pre>111asd121313411df</pre>     
             * 此参数必填
          */
    public void setSpecId(string specId) {
     	         	    this.specId = specId;
     	        }
    
        [DataMember(Order = 2)]
    private double? quantity;
    
        /**
       * @return 购买数量
    */
        public double? getQuantity() {
               	return quantity;
            }
    
    /**
     * 设置购买数量     *
     * 参数示例：<pre>10</pre>     
             * 此参数必填
          */
    public void setQuantity(double quantity) {
     	         	    this.quantity = quantity;
     	        }
    
    
  }
}