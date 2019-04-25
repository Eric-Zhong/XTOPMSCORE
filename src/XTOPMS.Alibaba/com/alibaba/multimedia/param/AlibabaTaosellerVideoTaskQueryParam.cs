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
public class AlibabaTaosellerVideoTaskQueryParam : GatewayAPIRequest {

    public AlibabaTaosellerVideoTaskQueryParam() {
        this.ApiId = new APIId("com.alibaba.multimedia", "alibaba.taoseller.video.task.query",1);
	}
	
       [DataMember(Order = 1)]
    private string taskId;
    
        /**
       * @return 发起任务时返回的taskId
    */
        public string getTaskId() {
               	return taskId;
            }
    
    /**
     * 设置发起任务时返回的taskId     *
     * 参数示例：<pre>b1091c3a-7f46-402e-b548-7c6fd075f35c_genVideo_1545200943613</pre>     
             * 此参数必填
          */
    public void setTaskId(string taskId) {
     	         	    this.taskId = taskId;
     	        }
    
        [DataMember(Order = 2)]
    private string taosellerUserId;
    
        /**
       * @return 淘卖用户在淘宝的userId
    */
        public string getTaosellerUserId() {
               	return taosellerUserId;
            }
    
    /**
     * 设置淘卖用户在淘宝的userId     *
     * 参数示例：<pre>12345678</pre>     
             * 此参数必填
          */
    public void setTaosellerUserId(string taosellerUserId) {
     	         	    this.taosellerUserId = taosellerUserId;
     	        }
    
    
  }
}