using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.trade.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaTradeAddresscodeParseParam : GatewayAPIRequest {

    public AlibabaTradeAddresscodeParseParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.addresscode.parse",1);
	}
	
       [DataMember(Order = 1)]
    private string addressInfo;
    
        /**
       * @return 地址信息
    */
        public string getAddressInfo() {
               	return addressInfo;
            }
    
    /**
     * 设置地址信息     *
     * 参数示例：<pre>浙江省 杭州市 滨江区网商路699号</pre>     
             * 此参数必填
          */
    public void setAddressInfo(string addressInfo) {
     	         	    this.addressInfo = addressInfo;
     	        }
    
    
  }
}