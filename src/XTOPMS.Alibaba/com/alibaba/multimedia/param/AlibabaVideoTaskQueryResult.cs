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
public class AlibabaVideoTaskQueryResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private string code;
    
        /**
       * @return 调用错误码
    */
        public string getCode() {
               	return code;
            }
    
    /**
     * 设置调用错误码     *
          
             * 此参数必填
          */
    public void setCode(string code) {
     	         	    this.code = code;
     	        }
    
        [DataMember(Order = 2)]
    private string message;
    
        /**
       * @return 调用错误描述
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置调用错误描述     *
          
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
        [DataMember(Order = 3)]
    private ComAlibabaOceanOpenplatformBizVideoResultVideoTaskResult videoTaskResult;
    
        /**
       * @return 视频任务返回的具体结果
    */
        public ComAlibabaOceanOpenplatformBizVideoResultVideoTaskResult getVideoTaskResult() {
               	return videoTaskResult;
            }
    
    /**
     * 设置视频任务返回的具体结果     *
          
             * 此参数必填
          */
    public void setVideoTaskResult(ComAlibabaOceanOpenplatformBizVideoResultVideoTaskResult videoTaskResult) {
     	         	    this.videoTaskResult = videoTaskResult;
     	        }
    
        [DataMember(Order = 4)]
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
    
    
  }
}