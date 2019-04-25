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
public class AlibabaBulksettlementOpBulkSettlementSubOrderInfo {

       [DataMember(Order = 1)]
    private string orderEntryId;
    
        /**
       * @return 子订单号
    */
        public string getOrderEntryId() {
               	return orderEntryId;
            }
    
    /**
     * 设置子订单号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderEntryId(string orderEntryId) {
     	         	    this.orderEntryId = orderEntryId;
     	        }
    
        [DataMember(Order = 2)]
    private long? quantity;
    
        /**
       * @return 商品数量
    */
        public long? getQuantity() {
               	return quantity;
            }
    
    /**
     * 设置商品数量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setQuantity(long quantity) {
     	         	    this.quantity = quantity;
     	        }
    
        [DataMember(Order = 3)]
    private double? realQuantity;
    
        /**
       * @return 支持小数的商品数量
    */
        public double? getRealQuantity() {
               	return realQuantity;
            }
    
    /**
     * 设置支持小数的商品数量     *
     * 参数示例：<pre>0.001</pre>     
             * 此参数必填
          */
    public void setRealQuantity(double realQuantity) {
     	         	    this.realQuantity = realQuantity;
     	        }
    
        [DataMember(Order = 4)]
    private double? price;
    
        /**
       * @return 商品价格
    */
        public double? getPrice() {
               	return price;
            }
    
    /**
     * 设置商品价格     *
     * 参数示例：<pre>1.0</pre>     
             * 此参数必填
          */
    public void setPrice(double price) {
     	         	    this.price = price;
     	        }
    
    
  }
}