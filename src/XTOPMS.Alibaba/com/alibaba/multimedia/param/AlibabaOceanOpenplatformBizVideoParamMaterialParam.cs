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
public class AlibabaOceanOpenplatformBizVideoParamMaterialParam {

       [DataMember(Order = 1)]
    private string content;
    
        /**
       * @return 素材内容，主要是针对文字型素材
    */
        public string getContent() {
               	return content;
            }
    
    /**
     * 设置素材内容，主要是针对文字型素材     *
     * 参数示例：<pre>null</pre>     
             * 此参数必填
          */
    public void setContent(string content) {
     	         	    this.content = content;
     	        }
    
        [DataMember(Order = 2)]
    private string label;
    
        /**
       * @return 素材标签
    */
        public string getLabel() {
               	return label;
            }
    
    /**
     * 设置素材标签     *
     * 参数示例：<pre>null</pre>     
             * 此参数必填
          */
    public void setLabel(string label) {
     	         	    this.label = label;
     	        }
    
        [DataMember(Order = 3)]
    private int? linkToIndex;
    
        /**
       * @return 素材在列表中的排序，从0开始
    */
        public int? getLinkToIndex() {
               	return linkToIndex;
            }
    
    /**
     * 设置素材在列表中的排序，从0开始     *
     * 参数示例：<pre>0</pre>     
             * 此参数必填
          */
    public void setLinkToIndex(int linkToIndex) {
     	         	    this.linkToIndex = linkToIndex;
     	        }
    
        [DataMember(Order = 4)]
    private string src;
    
        /**
       * @return 素材链接
    */
        public string getSrc() {
               	return src;
            }
    
    /**
     * 设置素材链接     *
     * 参数示例：<pre>https://xxx/shoes/001.jpg</pre>     
             * 此参数必填
          */
    public void setSrc(string src) {
     	         	    this.src = src;
     	        }
    
        [DataMember(Order = 5)]
    private string style;
    
        /**
       * @return 文字样式
    */
        public string getStyle() {
               	return style;
            }
    
    /**
     * 设置文字样式     *
     * 参数示例：<pre>null</pre>     
             * 此参数必填
          */
    public void setStyle(string style) {
     	         	    this.style = style;
     	        }
    
        [DataMember(Order = 6)]
    private string type;
    
        /**
       * @return 素材类型
    */
        public string getType() {
               	return type;
            }
    
    /**
     * 设置素材类型     *
     * 参数示例：<pre>image</pre>     
             * 此参数必填
          */
    public void setType(string type) {
     	         	    this.type = type;
     	        }
    
    
  }
}