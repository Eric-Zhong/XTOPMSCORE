using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.logistics.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaGlobalAddressCountryListParam : GatewayAPIRequest {

    public AlibabaGlobalAddressCountryListParam() {
        this.ApiId = new APIId("com.alibaba.logistics", "alibaba.globalAddress.countryList",1);
	}
	
       [DataMember(Order = 1)]
    private string name;
    
        /**
       * @return 中文或英文国家名
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置中文或英文国家名     *
     * 参数示例：<pre>中国</pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
    
  }
}