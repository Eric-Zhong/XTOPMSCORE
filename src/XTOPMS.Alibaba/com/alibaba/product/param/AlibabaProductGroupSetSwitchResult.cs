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
public class AlibabaProductGroupSetSwitchResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private bool? isSuccess;
    
        /**
       * @return 是否设置成功，true设置成功，false设置失败
    */
        public bool? getIsSuccess() {
               	return isSuccess;
            }
    
    /**
     * 设置是否设置成功，true设置成功，false设置失败     *
          
             * 此参数必填
          */
    public void setIsSuccess(bool isSuccess) {
     	         	    this.isSuccess = isSuccess;
     	        }
    
    
  }
}