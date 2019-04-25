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
public class AlibabaLogisticsFreightTemplateAddResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private long? templateID;
    
        /**
       * @return 模板ID
    */
        public long? getTemplateID() {
               	return templateID;
            }
    
    /**
     * 设置模板ID     *
          
             * 此参数必填
          */
    public void setTemplateID(long templateID) {
     	         	    this.templateID = templateID;
     	        }
    
        [DataMember(Order = 2)]
    private string errorCode;
    
        /**
       * @return 错误编码
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置错误编码     *
          
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 3)]
    private string errorMsg;
    
        /**
       * @return 错误信息
    */
        public string getErrorMsg() {
               	return errorMsg;
            }
    
    /**
     * 设置错误信息     *
          
             * 此参数必填
          */
    public void setErrorMsg(string errorMsg) {
     	         	    this.errorMsg = errorMsg;
     	        }
    
    
  }
}