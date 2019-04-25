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
public class AlibabaProductSellerGetResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaProductSellerInfo[] sellerInfoList;
    
        /**
       * @return 卖家信息列表
    */
        public AlibabaProductSellerInfo[] getSellerInfoList() {
               	return sellerInfoList;
            }
    
    /**
     * 设置卖家信息列表     *
          
             * 此参数必填
          */
    public void setSellerInfoList(AlibabaProductSellerInfo[] sellerInfoList) {
     	         	    this.sellerInfoList = sellerInfoList;
     	        }
    
        [DataMember(Order = 2)]
    private bool? success;
    
        /**
       * @return 是否调用成功
    */
        public bool? getSuccess() {
               	return success;
            }
    
    /**
     * 设置是否调用成功     *
          
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
    
    
  }
}