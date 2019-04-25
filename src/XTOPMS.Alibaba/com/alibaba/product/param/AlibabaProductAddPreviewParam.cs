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
public class AlibabaProductAddPreviewParam : GatewayAPIRequest {

    public AlibabaProductAddPreviewParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.add.preview",1);
	}
	
       [DataMember(Order = 1)]
    private string productType;
    
        /**
       * @return 商品类型，在线批发商品(wholesale)或者询盘商品(sourcing)，1688网站缺省为wholesale
    */
        public string getProductType() {
               	return productType;
            }
    
    /**
     * 设置商品类型，在线批发商品(wholesale)或者询盘商品(sourcing)，1688网站缺省为wholesale     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setProductType(string productType) {
     	         	    this.productType = productType;
     	        }
    
        [DataMember(Order = 2)]
    private long? categoryID;
    
        /**
       * @return 类目ID，由相应类目API获取
    */
        public long? getCategoryID() {
               	return categoryID;
            }
    
    /**
     * 设置类目ID，由相应类目API获取     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setCategoryID(long categoryID) {
     	         	    this.categoryID = categoryID;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaProductProductAttribute[] attributes;
    
        /**
       * @return 商品属性和属性值。若webSite=1688，此字段必填
    */
        public AlibabaProductProductAttribute[] getAttributes() {
               	return attributes;
            }
    
    /**
     * 设置商品属性和属性值。若webSite=1688，此字段必填     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setAttributes(AlibabaProductProductAttribute[] attributes) {
     	         	    this.attributes = attributes;
     	        }
    
        [DataMember(Order = 4)]
    private long[] groupID;
    
        /**
       * @return 分组ID，确定商品所属分组。1688可传入多个分组ID，国际站同一个商品只能属于一个分组，因此默认只取第一个
    */
        public long[] getGroupID() {
               	return groupID;
            }
    
    /**
     * 设置分组ID，确定商品所属分组。1688可传入多个分组ID，国际站同一个商品只能属于一个分组，因此默认只取第一个     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setGroupID(long[] groupID) {
     	         	    this.groupID = groupID;
     	        }
    
        [DataMember(Order = 5)]
    private string subject;
    
        /**
       * @return 商品标题，最多128个字符。标题内容将被系统切分作为关键字，因此API将不再单独提供关键字字段。
    */
        public string getSubject() {
               	return subject;
            }
    
    /**
     * 设置商品标题，最多128个字符。标题内容将被系统切分作为关键字，因此API将不再单独提供关键字字段。     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setSubject(string subject) {
     	         	    this.subject = subject;
     	        }
    
        [DataMember(Order = 6)]
    private string description;
    
        /**
       * @return 商品详情描述，可包含图片中心的图片URL
    */
        public string getDescription() {
               	return description;
            }
    
    /**
     * 设置商品详情描述，可包含图片中心的图片URL     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setDescription(string description) {
     	         	    this.description = description;
     	        }
    
        [DataMember(Order = 7)]
    private string language;
    
        /**
       * @return 语种，参见FAQ 语种枚举值，1688网站默认传入CHINESE
    */
        public string getLanguage() {
               	return language;
            }
    
    /**
     * 设置语种，参见FAQ 语种枚举值，1688网站默认传入CHINESE     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setLanguage(string language) {
     	         	    this.language = language;
     	        }
    
        [DataMember(Order = 8)]
    private int? periodOfValidity;
    
        /**
       * @return 信息有效期，按天计算，国际站可不填
    */
        public int? getPeriodOfValidity() {
               	return periodOfValidity;
            }
    
    /**
     * 设置信息有效期，按天计算，国际站可不填     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setPeriodOfValidity(int periodOfValidity) {
     	         	    this.periodOfValidity = periodOfValidity;
     	        }
    
        [DataMember(Order = 9)]
    private int? bizType;
    
        /**
       * @return 业务类型。1：商品，2：加工，3：代理，4：合作，5：商务服务；不传入默认按照商品发布；国际站按默认商品。
    */
        public int? getBizType() {
               	return bizType;
            }
    
    /**
     * 设置业务类型。1：商品，2：加工，3：代理，4：合作，5：商务服务；不传入默认按照商品发布；国际站按默认商品。     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setBizType(int bizType) {
     	         	    this.bizType = bizType;
     	        }
    
        [DataMember(Order = 10)]
    private bool? pictureAuth;
    
        /**
       * @return 是否图片私密信息，国际站此字段无效
    */
        public bool? getPictureAuth() {
               	return pictureAuth;
            }
    
    /**
     * 设置是否图片私密信息，国际站此字段无效     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setPictureAuth(bool pictureAuth) {
     	         	    this.pictureAuth = pictureAuth;
     	        }
    
        [DataMember(Order = 11)]
    private AlibabaProductProductImageInfo image;
    
        /**
       * @return 商品主图
    */
        public AlibabaProductProductImageInfo getImage() {
               	return image;
            }
    
    /**
     * 设置商品主图     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setImage(AlibabaProductProductImageInfo image) {
     	         	    this.image = image;
     	        }
    
        [DataMember(Order = 12)]
    private AlibabaProductProductSKUInfo[] skuInfos;
    
        /**
       * @return SKU信息，这里可传入多组信息
    */
        public AlibabaProductProductSKUInfo[] getSkuInfos() {
               	return skuInfos;
            }
    
    /**
     * 设置SKU信息，这里可传入多组信息     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setSkuInfos(AlibabaProductProductSKUInfo[] skuInfos) {
     	         	    this.skuInfos = skuInfos;
     	        }
    
        [DataMember(Order = 13)]
    private AlibabaProductProductSaleInfo saleInfo;
    
        /**
       * @return 商品销售信息
    */
        public AlibabaProductProductSaleInfo getSaleInfo() {
               	return saleInfo;
            }
    
    /**
     * 设置商品销售信息     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setSaleInfo(AlibabaProductProductSaleInfo saleInfo) {
     	         	    this.saleInfo = saleInfo;
     	        }
    
        [DataMember(Order = 14)]
    private AlibabaProductProductShippingInfo shippingInfo;
    
        /**
       * @return 商品物流信息
    */
        public AlibabaProductProductShippingInfo getShippingInfo() {
               	return shippingInfo;
            }
    
    /**
     * 设置商品物流信息     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setShippingInfo(AlibabaProductProductShippingInfo shippingInfo) {
     	         	    this.shippingInfo = shippingInfo;
     	        }
    
        [DataMember(Order = 15)]
    private string webSite;
    
        /**
       * @return 站点信息，指定调用的API是属于国际站（alibaba）还是1688网站（1688）
    */
        public string getWebSite() {
               	return webSite;
            }
    
    /**
     * 设置站点信息，指定调用的API是属于国际站（alibaba）还是1688网站（1688）     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setWebSite(string webSite) {
     	         	    this.webSite = webSite;
     	        }
    
    
  }
}