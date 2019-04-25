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
public class AlibabaProductDescriptionDescriptionInfo {

       [DataMember(Order = 1)]
    private AlibabaProductDescriptionImageInfo mainImage;
    
        /**
       * @return 主图图片信息
    */
        public AlibabaProductDescriptionImageInfo getMainImage() {
               	return mainImage;
            }
    
    /**
     * 设置主图图片信息     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setMainImage(AlibabaProductDescriptionImageInfo mainImage) {
     	         	    this.mainImage = mainImage;
     	        }
    
        [DataMember(Order = 2)]
    private string mainDescriptionText;
    
        /**
       * @return 商品总体描述，可能为空
    */
        public string getMainDescriptionText() {
               	return mainDescriptionText;
            }
    
    /**
     * 设置商品总体描述，可能为空     *
     * 参数示例：<pre>百搭T恤，衬托你的女神气质</pre>     
             * 此参数必填
          */
    public void setMainDescriptionText(string mainDescriptionText) {
     	         	    this.mainDescriptionText = mainDescriptionText;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaProductDescriptionMultiImageInfo[] multiImageParts;
    
        /**
       * @return 多个多图部分的信息，可能为空
    */
        public AlibabaProductDescriptionMultiImageInfo[] getMultiImageParts() {
               	return multiImageParts;
            }
    
    /**
     * 设置多个多图部分的信息，可能为空     *
     * 参数示例：<pre>[{}]</pre>     
             * 此参数必填
          */
    public void setMultiImageParts(AlibabaProductDescriptionMultiImageInfo[] multiImageParts) {
     	         	    this.multiImageParts = multiImageParts;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaProductDescriptionDetailInfo[] details;
    
        /**
       * @return 
    */
        public AlibabaProductDescriptionDetailInfo[] getDetails() {
               	return details;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDetails(AlibabaProductDescriptionDetailInfo[] details) {
     	         	    this.details = details;
     	        }
    
    
  }
}