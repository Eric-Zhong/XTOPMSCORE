using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.trade.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaOceanOpenplatformBizTradeResultTradeFeedbackResult {

       [DataMember(Order = 1)]
    private string errorInfo;
    
        /**
       * @return 错误描述
    */
        public string getErrorInfo() {
               	return errorInfo;
            }
    
    /**
     * 设置错误描述     *
     * 参数示例：<pre>错误描述</pre>     
             * 此参数必填
          */
    public void setErrorInfo(string errorInfo) {
     	         	    this.errorInfo = errorInfo;
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
     * 参数示例：<pre>400_1</pre>     
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 3)]
    private bool? success;
    
        /**
       * @return 是否成功
    */
        public bool? getSuccess() {
               	return success;
            }
    
    /**
     * 设置是否成功     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setSuccess(bool success) {
     	         	    this.success = success;
     	        }
    
    
  }
}