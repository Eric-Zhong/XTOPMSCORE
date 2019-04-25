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
public class AlibabaLogisticsOpQueryLogisticCompanyListPrintResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaLogisticsOpLogisticsCompanyModel[] result;
    
        /**
       * @return 物流公司列表
    */
        public AlibabaLogisticsOpLogisticsCompanyModel[] getResult() {
               	return result;
            }
    
    /**
     * 设置物流公司列表     *
          
             * 此参数必填
          */
    public void setResult(AlibabaLogisticsOpLogisticsCompanyModel[] result) {
     	         	    this.result = result;
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
    private string errorCode;
    
        /**
       * @return 错误码
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置错误码     *
          
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 4)]
    private string errorMessage;
    
        /**
       * @return 错误码描述
    */
        public string getErrorMessage() {
               	return errorMessage;
            }
    
    /**
     * 设置错误码描述     *
          
             * 此参数必填
          */
    public void setErrorMessage(string errorMessage) {
     	         	    this.errorMessage = errorMessage;
     	        }
    
        [DataMember(Order = 5)]
    private string extErrorMessage;
    
        /**
       * @return 扩展错误码描述
    */
        public string getExtErrorMessage() {
               	return extErrorMessage;
            }
    
    /**
     * 设置扩展错误码描述     *
          
             * 此参数必填
          */
    public void setExtErrorMessage(string extErrorMessage) {
     	         	    this.extErrorMessage = extErrorMessage;
     	        }
    
    
  }
}