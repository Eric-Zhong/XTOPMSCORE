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
public class AlibabaTradeCustomsAttributesInfo {

       [DataMember(Order = 1)]
    private string sku;
    
        /**
       * @return sku标识
    */
        public string getSku() {
               	return sku;
            }
    
    /**
     * 设置sku标识     *
     * 参数示例：<pre>1234</pre>     
             * 此参数必填
          */
    public void setSku(string sku) {
     	         	    this.sku = sku;
     	        }
    
        [DataMember(Order = 2)]
    private string cName;
    
        /**
       * @return 中文名称
    */
        public string getCName() {
               	return cName;
            }
    
    /**
     * 设置中文名称     *
     * 参数示例：<pre>测试</pre>     
             * 此参数必填
          */
    public void setCName(string cName) {
     	         	    this.cName = cName;
     	        }
    
        [DataMember(Order = 3)]
    private string enName;
    
        /**
       * @return 英文名称
    */
        public string getEnName() {
               	return enName;
            }
    
    /**
     * 设置英文名称     *
     * 参数示例：<pre>test</pre>     
             * 此参数必填
          */
    public void setEnName(string enName) {
     	         	    this.enName = enName;
     	        }
    
        [DataMember(Order = 4)]
    private double? amount;
    
        /**
       * @return 申报价值
    */
        public double? getAmount() {
               	return amount;
            }
    
    /**
     * 设置申报价值     *
     * 参数示例：<pre>3000.0</pre>     
             * 此参数必填
          */
    public void setAmount(double amount) {
     	         	    this.amount = amount;
     	        }
    
        [DataMember(Order = 5)]
    private double? quantity;
    
        /**
       * @return 数量
    */
        public double? getQuantity() {
               	return quantity;
            }
    
    /**
     * 设置数量     *
     * 参数示例：<pre>1.0</pre>     
             * 此参数必填
          */
    public void setQuantity(double quantity) {
     	         	    this.quantity = quantity;
     	        }
    
        [DataMember(Order = 6)]
    private double? weight;
    
        /**
       * @return 重量（kg）
    */
        public double? getWeight() {
               	return weight;
            }
    
    /**
     * 设置重量（kg）     *
     * 参数示例：<pre>0.5</pre>     
             * 此参数必填
          */
    public void setWeight(double weight) {
     	         	    this.weight = weight;
     	        }
    
        [DataMember(Order = 7)]
    private string currency;
    
        /**
       * @return 报关币种
    */
        public string getCurrency() {
               	return currency;
            }
    
    /**
     * 设置报关币种     *
     * 参数示例：<pre>CNY</pre>     
             * 此参数必填
          */
    public void setCurrency(string currency) {
     	         	    this.currency = currency;
     	        }
    
    
  }
}