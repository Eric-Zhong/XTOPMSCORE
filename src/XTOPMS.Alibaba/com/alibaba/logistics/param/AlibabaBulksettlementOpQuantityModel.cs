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
public class AlibabaBulksettlementOpQuantityModel {

       [DataMember(Order = 1)]
    private double? realAmount;
    
        /**
       * @return 真实购买数量，浮点型标识，可直接用于外部展示使用，比如0.001吨，在原有的quantity字段中记录的是1
    */
        public double? getRealAmount() {
               	return realAmount;
            }
    
    /**
     * 设置真实购买数量，浮点型标识，可直接用于外部展示使用，比如0.001吨，在原有的quantity字段中记录的是1     *
     * 参数示例：<pre>0.001</pre>     
             * 此参数必填
          */
    public void setRealAmount(double realAmount) {
     	         	    this.realAmount = realAmount;
     	        }
    
        [DataMember(Order = 2)]
    private double? amountFactor;
    
        /**
       * @return 数量精度系数，比如0.001吨，此时精度系数为1000
    */
        public double? getAmountFactor() {
               	return amountFactor;
            }
    
    /**
     * 设置数量精度系数，比如0.001吨，此时精度系数为1000     *
     * 参数示例：<pre>1000</pre>     
             * 此参数必填
          */
    public void setAmountFactor(double amountFactor) {
     	         	    this.amountFactor = amountFactor;
     	        }
    
        [DataMember(Order = 3)]
    private long? calAmount;
    
        /**
       * @return 整数购买数，数值上等于realAmount*amoutFactor，与原有模型中的quantity字段数值相等
    */
        public long? getCalAmount() {
               	return calAmount;
            }
    
    /**
     * 设置整数购买数，数值上等于realAmount*amoutFactor，与原有模型中的quantity字段数值相等     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setCalAmount(long calAmount) {
     	         	    this.calAmount = calAmount;
     	        }
    
        [DataMember(Order = 4)]
    private string realAmountStr;
    
        /**
       * @return 真实购买数，字符型
    */
        public string getRealAmountStr() {
               	return realAmountStr;
            }
    
    /**
     * 设置真实购买数，字符型     *
     * 参数示例：<pre>0.001</pre>     
             * 此参数必填
          */
    public void setRealAmountStr(string realAmountStr) {
     	         	    this.realAmountStr = realAmountStr;
     	        }
    
    
  }
}