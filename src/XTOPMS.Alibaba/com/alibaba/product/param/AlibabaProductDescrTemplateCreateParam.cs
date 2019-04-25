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
public class AlibabaProductDescrTemplateCreateParam : GatewayAPIRequest {

    public AlibabaProductDescrTemplateCreateParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.descr.template.create",1);
	}
	
       [DataMember(Order = 1)]
    private string recogniseID;
    
        /**
       * @return 商品识别ID
    */
        public string getRecogniseID() {
               	return recogniseID;
            }
    
    /**
     * 设置商品识别ID     *
     * 参数示例：<pre>123456</pre>     
             * 此参数必填
          */
    public void setRecogniseID(string recogniseID) {
     	         	    this.recogniseID = recogniseID;
     	        }
    
        [DataMember(Order = 2)]
    private string categoryID;
    
        /**
       * @return 商品叶子类目ID
    */
        public string getCategoryID() {
               	return categoryID;
            }
    
    /**
     * 设置商品叶子类目ID     *
     * 参数示例：<pre>123</pre>     
             * 此参数必填
          */
    public void setCategoryID(string categoryID) {
     	         	    this.categoryID = categoryID;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaProductProductAttribute[] attributes;
    
        /**
       * @return 商品完善的属性和属性值，包括规格属性
    */
        public AlibabaProductProductAttribute[] getAttributes() {
               	return attributes;
            }
    
    /**
     * 设置商品完善的属性和属性值，包括规格属性     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setAttributes(AlibabaProductProductAttribute[] attributes) {
     	         	    this.attributes = attributes;
     	        }
    
        [DataMember(Order = 4)]
    private string articleNumber;
    
        /**
       * @return 商品货号
    */
        public string getArticleNumber() {
               	return articleNumber;
            }
    
    /**
     * 设置商品货号     *
     * 参数示例：<pre>20180801000123</pre>     
             * 此参数必填
          */
    public void setArticleNumber(string articleNumber) {
     	         	    this.articleNumber = articleNumber;
     	        }
    
        [DataMember(Order = 5)]
    private string sendGoodsAddress;
    
        /**
       * @return 发货地址
    */
        public string getSendGoodsAddress() {
               	return sendGoodsAddress;
            }
    
    /**
     * 设置发货地址     *
     * 参数示例：<pre>杭州市阿里巴巴</pre>     
             * 此参数必填
          */
    public void setSendGoodsAddress(string sendGoodsAddress) {
     	         	    this.sendGoodsAddress = sendGoodsAddress;
     	        }
    
    
  }
}