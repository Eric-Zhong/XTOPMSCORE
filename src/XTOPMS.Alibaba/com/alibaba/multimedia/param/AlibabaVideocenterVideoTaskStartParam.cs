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
public class AlibabaVideocenterVideoTaskStartParam : GatewayAPIRequest {

    public AlibabaVideocenterVideoTaskStartParam() {
        this.ApiId = new APIId("com.alibaba.multimedia", "alibaba.videocenter.video.task.start",1);
	}
	
       [DataMember(Order = 1)]
    private string videoIds;
    
        /**
       * @return 视频Ids
    */
        public string getVideoIds() {
               	return videoIds;
            }
    
    /**
     * 设置视频Ids     *
     * 参数示例：<pre>583941257919</pre>     
             * 此参数必填
          */
    public void setVideoIds(string videoIds) {
     	         	    this.videoIds = videoIds;
     	        }
    
        [DataMember(Order = 2)]
    private string containsTitle;
    
        /**
       * @return 是否需要标题
    */
        public string getContainsTitle() {
               	return containsTitle;
            }
    
    /**
     * 设置是否需要标题     *
     * 参数示例：<pre>false</pre>     
             * 此参数必填
          */
    public void setContainsTitle(string containsTitle) {
     	         	    this.containsTitle = containsTitle;
     	        }
    
        [DataMember(Order = 3)]
    private string containsVideoFragment;
    
        /**
       * @return 是否包含视频片段
    */
        public string getContainsVideoFragment() {
               	return containsVideoFragment;
            }
    
    /**
     * 设置是否包含视频片段     *
     * 参数示例：<pre>false</pre>     
             * 此参数必填
          */
    public void setContainsVideoFragment(string containsVideoFragment) {
     	         	    this.containsVideoFragment = containsVideoFragment;
     	        }
    
        [DataMember(Order = 4)]
    private string containsSubTitle;
    
        /**
       * @return 是否包含字幕
    */
        public string getContainsSubTitle() {
               	return containsSubTitle;
            }
    
    /**
     * 设置是否包含字幕     *
     * 参数示例：<pre>false</pre>     
             * 此参数必填
          */
    public void setContainsSubTitle(string containsSubTitle) {
     	         	    this.containsSubTitle = containsSubTitle;
     	        }
    
        [DataMember(Order = 5)]
    private string logoEnding;
    
        /**
       * @return 是否使用logo图作为ending
    */
        public string getLogoEnding() {
               	return logoEnding;
            }
    
    /**
     * 设置是否使用logo图作为ending     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setLogoEnding(string logoEnding) {
     	         	    this.logoEnding = logoEnding;
     	        }
    
        [DataMember(Order = 6)]
    private string visualization;
    
        /**
       * @return 是否使用可视化特效
    */
        public string getVisualization() {
               	return visualization;
            }
    
    /**
     * 设置是否使用可视化特效     *
     * 参数示例：<pre>false</pre>     
             * 此参数必填
          */
    public void setVisualization(string visualization) {
     	         	    this.visualization = visualization;
     	        }
    
    
  }
}