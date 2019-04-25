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
public class ComAlibabaOceanOpenplatformBizVideoResultVideoGenerateResult {

       [DataMember(Order = 1)]
    private string videoName;
    
        /**
       * @return 视频名称
    */
        public string getVideoName() {
               	return videoName;
            }
    
    /**
     * 设置视频名称     *
     * 参数示例：<pre>73a591a6-0357-11e9-851f-02420ba28811.mp4</pre>     
             * 此参数必填
          */
    public void setVideoName(string videoName) {
     	         	    this.videoName = videoName;
     	        }
    
        [DataMember(Order = 2)]
    private string videoUrl;
    
        /**
       * @return 视频地址
    */
        public string getVideoUrl() {
               	return videoUrl;
            }
    
    /**
     * 设置视频地址     *
     * 参数示例：<pre>http://aliwoodvideo.oss-cn-shanghai.aliyuncs.com/73a591a6-0357-11e9-851f-02420ba28811.mp4?Expires=1545356702&OSSAccessKeyId=LTAI8eQPXJfFMkJF&Signature=ZN1O6T6KGnUfWJ8LbWogAUXwBHo%3D</pre>     
             * 此参数必填
          */
    public void setVideoUrl(string videoUrl) {
     	         	    this.videoUrl = videoUrl;
     	        }
    
        [DataMember(Order = 3)]
    private string thumbnail;
    
        /**
       * @return 缩略图名称
    */
        public string getThumbnail() {
               	return thumbnail;
            }
    
    /**
     * 设置缩略图名称     *
     * 参数示例：<pre>b1091c3a-7f46-402e-b548-7c6fd075f35c/thumbnail/73a591a6-0357-11e9-851f-02420ba28811.jpg</pre>     
             * 此参数必填
          */
    public void setThumbnail(string thumbnail) {
     	         	    this.thumbnail = thumbnail;
     	        }
    
        [DataMember(Order = 4)]
    private string thumbnailUrl;
    
        /**
       * @return 缩略图地址
    */
        public string getThumbnailUrl() {
               	return thumbnailUrl;
            }
    
    /**
     * 设置缩略图地址     *
     * 参数示例：<pre>http://aliwoodvideo.oss-cn-shanghai.aliyuncs.com/b1091c3a-7f46-402e-b548-7c6fd075f35c/thumbnail/73a591a6-0357-11e9-851f-02420ba28811.jpg?Expires=1545356702&OSSAccessKeyId=LTAI8eQPXJfFMkJF&Signature=6EWLkdnDsKoYSM6ChnCJCSfSJUE%3D</pre>     
             * 此参数必填
          */
    public void setThumbnailUrl(string thumbnailUrl) {
     	         	    this.thumbnailUrl = thumbnailUrl;
     	        }
    
    
  }
}