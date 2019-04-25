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
public class AlibabaProductIncrementModifyParam : GatewayAPIRequest {

    public AlibabaProductIncrementModifyParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.incrementModify",1);
	}
	
       [DataMember(Order = 1)]
    private long? productID;
    
        /**
       * @return 商品ID
    */
        public long? getProductID() {
               	return productID;
            }
    
    /**
     * 设置商品ID     *
     * 参数示例：<pre>575779850479</pre>     
             * 此参数必填
          */
    public void setProductID(long productID) {
     	         	    this.productID = productID;
     	        }
    
        [DataMember(Order = 2)]
    private string subject;
    
        /**
       * @return 商品标题，如果不传递或者传递空字符串则不作任何处理
    */
        public string getSubject() {
               	return subject;
            }
    
    /**
     * 设置商品标题，如果不传递或者传递空字符串则不作任何处理     *
     * 参数示例：<pre>HQ-韩国女孩充电器手机贴纸装饰</pre>     
             * 此参数必填
          */
    public void setSubject(string subject) {
     	         	    this.subject = subject;
     	        }
    
        [DataMember(Order = 3)]
    private string description;
    
        /**
       * @return 商品描述，如果不传递或者传递空字符串则不作任何处理.
    */
        public string getDescription() {
               	return description;
            }
    
    /**
     * 设置商品描述，如果不传递或者传递空字符串则不作任何处理.     *
     * 参数示例：<pre>测试增量修改</pre>     
             * 此参数必填
          */
    public void setDescription(string description) {
     	         	    this.description = description;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaProductProductImageInfo image;
    
        /**
       * @return 商品图片，如果不传递或者传递空字符串则不作任何处理请注意，如果ISV需要修改image字段，那么subject和description必须至少传入其一
    */
        public AlibabaProductProductImageInfo getImage() {
               	return image;
            }
    
    /**
     * 设置商品图片，如果不传递或者传递空字符串则不作任何处理请注意，如果ISV需要修改image字段，那么subject和description必须至少传入其一     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setImage(AlibabaProductProductImageInfo image) {
     	         	    this.image = image;
     	        }
    
        [DataMember(Order = 5)]
    private string webSite;
    
        /**
       * @return 1688或者alibaba
    */
        public string getWebSite() {
               	return webSite;
            }
    
    /**
     * 设置1688或者alibaba     *
     * 参数示例：<pre>1688</pre>     
             * 此参数必填
          */
    public void setWebSite(string webSite) {
     	         	    this.webSite = webSite;
     	        }
    
        [DataMember(Order = 6)]
    private bool? supportOnlineTrade;
    
        /**
       * @return 是否允许在线交易
    */
        public bool? getSupportOnlineTrade() {
               	return supportOnlineTrade;
            }
    
    /**
     * 设置是否允许在线交易     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setSupportOnlineTrade(bool supportOnlineTrade) {
     	         	    this.supportOnlineTrade = supportOnlineTrade;
     	        }
    
    
  }
}