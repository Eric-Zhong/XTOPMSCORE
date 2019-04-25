using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.multimedia.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class ComAlibabaOceanOpenplatformCommonResultModel {

       [DataMember(Order = 1)]
    private bool? success;
    
        /**
       * @return 是否调用成功
    */
        public bool? getSuccess() {
               	return success;
            }
    
    /**
     * 设置是否调用成功     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setSuccess(bool success) {
     	         	    this.success = success;
     	        }
    
        [DataMember(Order = 2)]
    private string code;
    
        /**
       * @return 错误码
    */
        public string getCode() {
               	return code;
            }
    
    /**
     * 设置错误码     *
     * 参数示例：<pre>null</pre>     
             * 此参数必填
          */
    public void setCode(string code) {
     	         	    this.code = code;
     	        }
    
        [DataMember(Order = 3)]
    private string message;
    
        /**
       * @return 错误描述
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置错误描述     *
     * 参数示例：<pre>null</pre>     
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
        [DataMember(Order = 4)]
    private string subCode;
    
        /**
       * @return 子错误码
    */
        public string getSubCode() {
               	return subCode;
            }
    
    /**
     * 设置子错误码     *
     * 参数示例：<pre>null</pre>     
             * 此参数必填
          */
    public void setSubCode(string subCode) {
     	         	    this.subCode = subCode;
     	        }
    
        [DataMember(Order = 5)]
    private string subMessage;
    
        /**
       * @return 子错误描述
    */
        public string getSubMessage() {
               	return subMessage;
            }
    
    /**
     * 设置子错误描述     *
     * 参数示例：<pre>null</pre>     
             * 此参数必填
          */
    public void setSubMessage(string subMessage) {
     	         	    this.subMessage = subMessage;
     	        }
    
        [DataMember(Order = 6)]
    private string taskId;
    
        /**
       * @return 发起任务后返回的taskId
    */
        public string getTaskId() {
               	return taskId;
            }
    
    /**
     * 设置发起任务后返回的taskId     *
     * 参数示例：<pre>39b2c5f0-49ad-4d18-9501-d074b51dfa1f_genVideo_1545272350345</pre>     
             * 此参数必填
          */
    public void setTaskId(string taskId) {
     	         	    this.taskId = taskId;
     	        }
    
    
  }
}