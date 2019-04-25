using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.product.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductTemplateCreateStdParam : GatewayAPIRequest {

    public AlibabaProductTemplateCreateStdParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.template.create.std",1);
	}
	
       [DataMember(Order = 1)]
    private string recogniseID;
    
        /**
       * @return 慧眼识货通过图片识别属性后生成的识别ID
    */
        public string getRecogniseID() {
               	return recogniseID;
            }
    
    /**
     * 设置慧眼识货通过图片识别属性后生成的识别ID     *
     * 参数示例：<pre>123</pre>     
             * 此参数必填
          */
    public void setRecogniseID(string recogniseID) {
     	         	    this.recogniseID = recogniseID;
     	        }
    
        [DataMember(Order = 2)]
    private string categoryID;
    
        /**
       * @return 慧眼识货通过图片识别出的子类目ID
    */
        public string getCategoryID() {
               	return categoryID;
            }
    
    /**
     * 设置慧眼识货通过图片识别出的子类目ID     *
     * 参数示例：<pre>123</pre>     
             * 此参数必填
          */
    public void setCategoryID(string categoryID) {
     	         	    this.categoryID = categoryID;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaProductProductAttribute[] attributes;
    
        /**
       * @return 慧眼识货通过图片识别出的属性列表
    */
        public AlibabaProductProductAttribute[] getAttributes() {
               	return attributes;
            }
    
    /**
     * 设置慧眼识货通过图片识别出的属性列表     *
     * 参数示例：<pre>[]</pre>     
             * 此参数必填
          */
    public void setAttributes(AlibabaProductProductAttribute[] attributes) {
     	         	    this.attributes = attributes;
     	        }
    
        [DataMember(Order = 4)]
    private string articleNumber;
    
        /**
       * @return 货号，非必填
    */
        public string getArticleNumber() {
               	return articleNumber;
            }
    
    /**
     * 设置货号，非必填     *
     * 参数示例：<pre>123</pre>     
             * 此参数必填
          */
    public void setArticleNumber(string articleNumber) {
     	         	    this.articleNumber = articleNumber;
     	        }
    
        [DataMember(Order = 5)]
    private string sendGoodsAddress;
    
        /**
       * @return 发货地址，非必填
    */
        public string getSendGoodsAddress() {
               	return sendGoodsAddress;
            }
    
    /**
     * 设置发货地址，非必填     *
     * 参数示例：<pre>杭州市阿里巴巴</pre>     
             * 此参数必填
          */
    public void setSendGoodsAddress(string sendGoodsAddress) {
     	         	    this.sendGoodsAddress = sendGoodsAddress;
     	        }
    
        [DataMember(Order = 6)]
    private string descriptionTemplateId;
    
        /**
       * @return 指定详情描述模板ID，如果为空，将使用默认样式渲染详情描述
    */
        public string getDescriptionTemplateId() {
               	return descriptionTemplateId;
            }
    
    /**
     * 设置指定详情描述模板ID，如果为空，将使用默认样式渲染详情描述     *
     * 参数示例：<pre>tmpl0000001</pre>     
             * 此参数必填
          */
    public void setDescriptionTemplateId(string descriptionTemplateId) {
     	         	    this.descriptionTemplateId = descriptionTemplateId;
     	        }
    
        [DataMember(Order = 7)]
    private AlibabaProductDescriptionMultiImageInfo[] descriptionMultiImageParts;
    
        /**
       * @return 详情描述中的多图部分，比如多种颜色的展示、多个款式的展示、多个角度的展示等
    */
        public AlibabaProductDescriptionMultiImageInfo[] getDescriptionMultiImageParts() {
               	return descriptionMultiImageParts;
            }
    
    /**
     * 设置详情描述中的多图部分，比如多种颜色的展示、多个款式的展示、多个角度的展示等     *
     * 参数示例：<pre>[{ "title": "多种颜色", "subTitle": "Different Colors", "images": [ { "url": "https://foo.bar.com/baz.jpg" } ] }]</pre>     
             * 此参数必填
          */
    public void setDescriptionMultiImageParts(AlibabaProductDescriptionMultiImageInfo[] descriptionMultiImageParts) {
     	         	    this.descriptionMultiImageParts = descriptionMultiImageParts;
     	        }
    
    
  }
}