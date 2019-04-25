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
public class AlibabaVideoVideocenterUploadParam : GatewayAPIRequest {

    public AlibabaVideoVideocenterUploadParam() {
        this.ApiId = new APIId("com.alibaba.multimedia", "alibaba.video.videocenter.upload",1);
	}
	
       [DataMember(Order = 1)]
    private string fileName;
    
        /**
       * @return 视频名称（必须带后缀）
    */
        public string getFileName() {
               	return fileName;
            }
    
    /**
     * 设置视频名称（必须带后缀）     *
     * 参数示例：<pre>shirt.mp4</pre>     
             * 此参数必填
          */
    public void setFileName(string fileName) {
     	         	    this.fileName = fileName;
     	        }
    
        [DataMember(Order = 2)]
    private string fileUrl;
    
        /**
       * @return 视频地址
    */
        public string getFileUrl() {
               	return fileUrl;
            }
    
    /**
     * 设置视频地址     *
     * 参数示例：<pre>https://xxxx/shirt.mp4</pre>     
             * 此参数必填
          */
    public void setFileUrl(string fileUrl) {
     	         	    this.fileUrl = fileUrl;
     	        }
    
    
  }
}