using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.product.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductSimpleProductCreateResult {

       [DataMember(Order = 1)]
    private string offerId;
    
        /**
       * @return 创建的offerId
    */
        public string getOfferId() {
               	return offerId;
            }
    
    /**
     * 设置创建的offerId     *
     * 参数示例：<pre>12124232</pre>     
             * 此参数必填
          */
    public void setOfferId(string offerId) {
     	         	    this.offerId = offerId;
     	        }
    
    
  }
}