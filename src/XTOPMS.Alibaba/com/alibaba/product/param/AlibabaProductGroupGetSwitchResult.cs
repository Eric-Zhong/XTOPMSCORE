using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.product.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductGroupGetSwitchResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private bool? switchValue;
    
        /**
       * @return true：已开启；false：未开启
    */
        public bool? getSwitchValue() {
               	return switchValue;
            }
    
    /**
     * 设置true：已开启；false：未开启     *
          
             * 此参数必填
          */
    public void setSwitchValue(bool switchValue) {
     	         	    this.switchValue = switchValue;
     	        }
    
    
  }
}