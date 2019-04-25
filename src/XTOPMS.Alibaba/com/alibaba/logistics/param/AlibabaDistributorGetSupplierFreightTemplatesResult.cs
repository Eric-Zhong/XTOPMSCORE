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
public class AlibabaDistributorGetSupplierFreightTemplatesResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaLogisticsFreightTemplate[] result;
    
        /**
       * @return []
    */
        public AlibabaLogisticsFreightTemplate[] getResult() {
               	return result;
            }
    
    /**
     * 设置[]     *
          
             * 此参数必填
          */
    public void setResult(AlibabaLogisticsFreightTemplate[] result) {
     	         	    this.result = result;
     	        }
    
        [DataMember(Order = 2)]
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
    
        [DataMember(Order = 3)]
    private string errorMsg;
    
        /**
       * @return 错误描述
    */
        public string getErrorMsg() {
               	return errorMsg;
            }
    
    /**
     * 设置错误描述     *
          
             * 此参数必填
          */
    public void setErrorMsg(string errorMsg) {
     	         	    this.errorMsg = errorMsg;
     	        }
    
    
  }
}