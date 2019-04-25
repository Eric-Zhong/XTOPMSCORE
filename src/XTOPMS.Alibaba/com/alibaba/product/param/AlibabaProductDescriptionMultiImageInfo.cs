using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.product.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductDescriptionMultiImageInfo {

       [DataMember(Order = 1)]
    private string title;
    
        /**
       * @return 多图部分的标题
    */
        public string getTitle() {
               	return title;
            }
    
    /**
     * 设置多图部分的标题     *
     * 参数示例：<pre>多种颜色</pre>     
             * 此参数必填
          */
    public void setTitle(string title) {
     	         	    this.title = title;
     	        }
    
        [DataMember(Order = 2)]
    private string description;
    
        /**
       * @return 多图部分的描述，可能为空
    */
        public string getDescription() {
               	return description;
            }
    
    /**
     * 设置多图部分的描述，可能为空     *
     * 参数示例：<pre>包含红色、蓝色、黄色等多种选择</pre>     
             * 此参数必填
          */
    public void setDescription(string description) {
     	         	    this.description = description;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaProductDescriptionImageInfo[] images;
    
        /**
       * @return 多个图片信息
    */
        public AlibabaProductDescriptionImageInfo[] getImages() {
               	return images;
            }
    
    /**
     * 设置多个图片信息     *
     * 参数示例：<pre>[{}]</pre>     
             * 此参数必填
          */
    public void setImages(AlibabaProductDescriptionImageInfo[] images) {
     	         	    this.images = images;
     	        }
    
        [DataMember(Order = 4)]
    private string subTitle;
    
        /**
       * @return 多图部分副标题
    */
        public string getSubTitle() {
               	return subTitle;
            }
    
    /**
     * 设置多图部分副标题     *
     * 参数示例：<pre>Different Colors</pre>     
             * 此参数必填
          */
    public void setSubTitle(string subTitle) {
     	         	    this.subTitle = subTitle;
     	        }
    
    
  }
}