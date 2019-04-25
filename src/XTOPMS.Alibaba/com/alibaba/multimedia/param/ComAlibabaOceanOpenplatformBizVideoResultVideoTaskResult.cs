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
public class ComAlibabaOceanOpenplatformBizVideoResultVideoTaskResult {

       [DataMember(Order = 1)]
    private string taskId;
    
        /**
       * @return 标志唯一任务的任务Id，即发起任务时taskId
    */
        public string getTaskId() {
               	return taskId;
            }
    
    /**
     * 设置标志唯一任务的任务Id，即发起任务时taskId     *
     * 参数示例：<pre>b1091c3a-7f46-402e-b548-7c6fd075f35c_genVideo_1545200943613</pre>     
             * 此参数必填
          */
    public void setTaskId(string taskId) {
     	         	    this.taskId = taskId;
     	        }
    
        [DataMember(Order = 2)]
    private string taskStatus;
    
        /**
       * @return 任务状态
    */
        public string getTaskStatus() {
               	return taskStatus;
            }
    
    /**
     * 设置任务状态     *
     * 参数示例：<pre>FAILED,SUCCEED,RUNNING</pre>     
             * 此参数必填
          */
    public void setTaskStatus(string taskStatus) {
     	         	    this.taskStatus = taskStatus;
     	        }
    
        [DataMember(Order = 3)]
    private string taskErrorCode;
    
        /**
       * @return 错误码
    */
        public string getTaskErrorCode() {
               	return taskErrorCode;
            }
    
    /**
     * 设置错误码     *
     * 参数示例：<pre>148003，具体值查看API的错误码描述</pre>     
             * 此参数必填
          */
    public void setTaskErrorCode(string taskErrorCode) {
     	         	    this.taskErrorCode = taskErrorCode;
     	        }
    
        [DataMember(Order = 4)]
    private string businessType;
    
        /**
       * @return 业务字段，即发起任务时的businessType
    */
        public string getBusinessType() {
               	return businessType;
            }
    
    /**
     * 设置业务字段，即发起任务时的businessType     *
     * 参数示例：<pre>douhuo,发起任务时的业务字段</pre>     
             * 此参数必填
          */
    public void setBusinessType(string businessType) {
     	         	    this.businessType = businessType;
     	        }
    
        [DataMember(Order = 5)]
    private ComAlibabaOceanOpenplatformBizVideoResultVideoGenerateResult videoGenerateResult;
    
        /**
       * @return 视频返回的详细结果
    */
        public ComAlibabaOceanOpenplatformBizVideoResultVideoGenerateResult getVideoGenerateResult() {
               	return videoGenerateResult;
            }
    
    /**
     * 设置视频返回的详细结果     *
     * 参数示例：<pre>{       "thumbnail": "b1091c3a-7f46-402e-b548-7c6fd075f35c/thumbnail/73a591a6-0357-11e9-851f-02420ba28811.jpg",       "videoUrl": "http://aliwoodvideo.oss-cn-shanghai.aliyuncs.com/73a591a6-0357-11e9-851f-02420ba28811.mp4?Expires=1545356702&OSSAccessKeyId=LTAI8eQPXJfFMkJF&Signature=ZN1O6T6KGnUfWJ8LbWogAUXwBHo%3D",       "videoName": "73a591a6-0357-11e9-851f-02420ba28811.mp4",       "class": "com.alibaba.ocean.openplatform.biz.video.result.VideoGenerateResult",       "thumbnailUrl": "http://aliwoodvideo.oss-cn-shanghai.aliyuncs.com/b1091c3a-7f46-402e-b548-7c6fd075f35c/thumbnail/73a591a6-0357-11e9-851f-02420ba28811.jpg?Expires=1545356702&OSSAccessKeyId=LTAI8eQPXJfFMkJF&Signature=6EWLkdnDsKoYSM6ChnCJCSfSJUE%3D"     }</pre>     
             * 此参数必填
          */
    public void setVideoGenerateResult(ComAlibabaOceanOpenplatformBizVideoResultVideoGenerateResult videoGenerateResult) {
     	         	    this.videoGenerateResult = videoGenerateResult;
     	        }
    
    
  }
}