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
public class AlibabaProductDescriptionDetailInfo {

       [DataMember(Order = 1)]
    private string title;
    
        /**
       * @return 细节描述标题
    */
        public string getTitle() {
               	return title;
            }
    
    /**
     * 设置细节描述标题     *
     * 参数示例：<pre>领型细节</pre>     
             * 此参数必填
          */
    public void setTitle(string title) {
     	         	    this.title = title;
     	        }
    
        [DataMember(Order = 2)]
    private string description;
    
        /**
       * @return 细节描述文案
    */
        public string getDescription() {
               	return description;
            }
    
    /**
     * 设置细节描述文案     *
     * 参数示例：<pre>一句简短的描述，1-3句话，可能为空</pre>     
             * 此参数必填
          */
    public void setDescription(string description) {
     	         	    this.description = description;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaProductDescriptionImageInfo image;
    
        /**
       * @return 细节图片信息
    */
        public AlibabaProductDescriptionImageInfo getImage() {
               	return image;
            }
    
    /**
     * 设置细节图片信息     *
     * 参数示例：<pre>{"url":"http://foo/bar.jpg"}</pre>     
             * 此参数必填
          */
    public void setImage(AlibabaProductDescriptionImageInfo image) {
     	         	    this.image = image;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaAitoolsProductDetailOriginalImageInfo originalImage;
    
        /**
       * @return 细节切图所在的原图信息，ISV 可根据此信息对默认的切图信息进行调整和定制
    */
        public AlibabaAitoolsProductDetailOriginalImageInfo getOriginalImage() {
               	return originalImage;
            }
    
    /**
     * 设置细节切图所在的原图信息，ISV 可根据此信息对默认的切图信息进行调整和定制     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setOriginalImage(AlibabaAitoolsProductDetailOriginalImageInfo originalImage) {
     	         	    this.originalImage = originalImage;
     	        }
    
    
  }
}