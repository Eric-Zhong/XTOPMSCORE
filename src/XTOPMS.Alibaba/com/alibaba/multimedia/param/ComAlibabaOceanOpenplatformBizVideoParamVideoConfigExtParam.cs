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
public class ComAlibabaOceanOpenplatformBizVideoParamVideoConfigExtParam {

       [DataMember(Order = 1)]
    private bool? containsTitle;
    
        /**
       * @return 是否需要标题
    */
        public bool? getContainsTitle() {
               	return containsTitle;
            }
    
    /**
     * 设置是否需要标题     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setContainsTitle(bool containsTitle) {
     	         	    this.containsTitle = containsTitle;
     	        }
    
        [DataMember(Order = 2)]
    private bool? containsVideoFragment;
    
        /**
       * @return 是否包含视频片段
    */
        public bool? getContainsVideoFragment() {
               	return containsVideoFragment;
            }
    
    /**
     * 设置是否包含视频片段     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setContainsVideoFragment(bool containsVideoFragment) {
     	         	    this.containsVideoFragment = containsVideoFragment;
     	        }
    
        [DataMember(Order = 3)]
    private bool? containsSubTitle;
    
        /**
       * @return 是否包含字幕
    */
        public bool? getContainsSubTitle() {
               	return containsSubTitle;
            }
    
    /**
     * 设置是否包含字幕     *
     * 参数示例：<pre>false</pre>     
             * 此参数必填
          */
    public void setContainsSubTitle(bool containsSubTitle) {
     	         	    this.containsSubTitle = containsSubTitle;
     	        }
    
        [DataMember(Order = 4)]
    private bool? logoEnding;
    
        /**
       * @return 是否使用logo图作为ending
    */
        public bool? getLogoEnding() {
               	return logoEnding;
            }
    
    /**
     * 设置是否使用logo图作为ending     *
     * 参数示例：<pre>false</pre>     
             * 此参数必填
          */
    public void setLogoEnding(bool logoEnding) {
     	         	    this.logoEnding = logoEnding;
     	        }
    
        [DataMember(Order = 5)]
    private bool? visualization;
    
        /**
       * @return 是否使用可视化特效
    */
        public bool? getVisualization() {
               	return visualization;
            }
    
    /**
     * 设置是否使用可视化特效     *
     * 参数示例：<pre>fasle</pre>     
             * 此参数必填
          */
    public void setVisualization(bool visualization) {
     	         	    this.visualization = visualization;
     	        }
    
    
  }
}