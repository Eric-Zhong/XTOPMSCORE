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
public class AlibabaLogisticsOpenPlatformLogisticsSendGood {

       [DataMember(Order = 1)]
    private string goodName;
    
        /**
       * @return 商品名
    */
        public string getGoodName() {
               	return goodName;
            }
    
    /**
     * 设置商品名     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGoodName(string goodName) {
     	         	    this.goodName = goodName;
     	        }
    
        [DataMember(Order = 2)]
    private string quantity;
    
        /**
       * @return 商品数量
    */
        public string getQuantity() {
               	return quantity;
            }
    
    /**
     * 设置商品数量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setQuantity(string quantity) {
     	         	    this.quantity = quantity;
     	        }
    
        [DataMember(Order = 3)]
    private string unit;
    
        /**
       * @return 商品单位
    */
        public string getUnit() {
               	return unit;
            }
    
    /**
     * 设置商品单位     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUnit(string unit) {
     	         	    this.unit = unit;
     	        }
    
    
  }
}