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
public class AlibabaPreOrderCreateResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private long? orderId;
    
        /**
       * @return 预订单ID
    */
        public long? getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置预订单ID     *
          
             * 此参数必填
          */
    public void setOrderId(long orderId) {
     	         	    this.orderId = orderId;
     	        }
    
        [DataMember(Order = 2)]
    private bool? success;
    
        /**
       * @return 是否成功
    */
        public bool? getSuccess() {
               	return success;
            }
    
    /**
     * 设置是否成功     *
          
             * 此参数必填
          */
    public void setSuccess(bool success) {
     	         	    this.success = success;
     	        }
    
        [DataMember(Order = 3)]
    private string code;
    
        /**
       * @return 状态码
    */
        public string getCode() {
               	return code;
            }
    
    /**
     * 设置状态码     *
          
             * 此参数必填
          */
    public void setCode(string code) {
     	         	    this.code = code;
     	        }
    
        [DataMember(Order = 4)]
    private string message;
    
        /**
       * @return 错误信息
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置错误信息     *
          
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
    
  }
}