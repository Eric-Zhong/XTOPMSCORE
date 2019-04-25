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
public class SendGoodsAddressCreateResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private long? addressId;
    
        /**
       * @return 发货地址ID
    */
        public long? getAddressId() {
               	return addressId;
            }
    
    /**
     * 设置发货地址ID     *
          
             * 此参数必填
          */
    public void setAddressId(long addressId) {
     	         	    this.addressId = addressId;
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
    private string errMsg;
    
        /**
       * @return 错误信息
    */
        public string getErrMsg() {
               	return errMsg;
            }
    
    /**
     * 设置错误信息     *
          
             * 此参数必填
          */
    public void setErrMsg(string errMsg) {
     	         	    this.errMsg = errMsg;
     	        }
    
        [DataMember(Order = 4)]
    private string errCode;
    
        /**
       * @return 错误码
    */
        public string getErrCode() {
               	return errCode;
            }
    
    /**
     * 设置错误码     *
          
             * 此参数必填
          */
    public void setErrCode(string errCode) {
     	         	    this.errCode = errCode;
     	        }
    
    
  }
}