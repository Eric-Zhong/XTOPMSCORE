using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.product.push.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaPanamaCommonResult {

       [DataMember(Order = 1)]
    private string errorCode;
    
        /**
       * @return 错误码
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置错误码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 2)]
    private string errorMsg;
    
        /**
       * @return 错误信息
    */
        public string getErrorMsg() {
               	return errorMsg;
            }
    
    /**
     * 设置错误信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setErrorMsg(string errorMsg) {
     	         	    this.errorMsg = errorMsg;
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
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSuccess(bool success) {
     	         	    this.success = success;
     	        }
    
        [DataMember(Order = 4)]
    private string info;
    
        /**
       * @return 接口调用结果描述信息
    */
        public string getInfo() {
               	return info;
            }
    
    /**
     * 设置接口调用结果描述信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setInfo(string info) {
     	         	    this.info = info;
     	        }
    
    
  }
}