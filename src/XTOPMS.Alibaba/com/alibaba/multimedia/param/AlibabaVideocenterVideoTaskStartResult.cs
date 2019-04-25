using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.multimedia.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaVideocenterVideoTaskStartResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private string code;
    
        /**
       * @return 错误码
    */
        public string getCode() {
               	return code;
            }
    
    /**
     * 设置错误码     *
          
             * 此参数必填
          */
    public void setCode(string code) {
     	         	    this.code = code;
     	        }
    
        [DataMember(Order = 2)]
    private string message;
    
        /**
       * @return 错误描述
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置错误描述     *
          
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
        [DataMember(Order = 3)]
    private string taskId;
    
        /**
       * @return 任务Id，作为查询任务的入参
    */
        public string getTaskId() {
               	return taskId;
            }
    
    /**
     * 设置任务Id，作为查询任务的入参     *
          
             * 此参数必填
          */
    public void setTaskId(string taskId) {
     	         	    this.taskId = taskId;
     	        }
    
        [DataMember(Order = 4)]
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
    
    
  }
}