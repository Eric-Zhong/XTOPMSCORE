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
public class AlibabaProductDeleteResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private bool? isSuccess;
    
        /**
       * @return 删除是否成功
    */
        public bool? getIsSuccess() {
               	return isSuccess;
            }
    
    /**
     * 设置删除是否成功     *
          
             * 此参数必填
          */
    public void setIsSuccess(bool isSuccess) {
     	         	    this.isSuccess = isSuccess;
     	        }
    
        [DataMember(Order = 2)]
    private string reason;
    
        /**
       * @return 删除不成功的原因描述
    */
        public string getReason() {
               	return reason;
            }
    
    /**
     * 设置删除不成功的原因描述     *
          
             * 此参数必填
          */
    public void setReason(string reason) {
     	         	    this.reason = reason;
     	        }
    
    
  }
}