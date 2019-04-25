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
public class AlibabaProductProductInfo {

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
     * 参数示例：<pre>584051070147</pre>     
             * 此参数必填
          */
    public void setProductID(long productID) {
     	         	    this.productID = productID;
     	        }
    
        [DataMember(Order = 2)]
    private string productType;
    
        /**
       * @return 商品类型，在线批发商品(wholesale)或者询盘商品(sourcing)，1688网站缺省为wholesale
    */
        public string getProductType() {
               	return productType;
            }
    
    /**
     * 设置商品类型，在线批发商品(wholesale)或者询盘商品(sourcing)，1688网站缺省为wholesale     *
     * 参数示例：<pre>wholesale</pre>     
             * 此参数必填
          */
    public void setProductType(string productType) {
     	         	    this.productType = productType;
     	        }
    
        [DataMember(Order = 3)]
    private long? categoryID;
    
        /**
       * @return 类目ID，标识商品所属类目
    */
        public long? getCategoryID() {
               	return categoryID;
            }
    
    /**
     * 设置类目ID，标识商品所属类目     *
     * 参数示例：<pre>1048182</pre>     
             * 此参数必填
          */
    public void setCategoryID(long categoryID) {
     	         	    this.categoryID = categoryID;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaProductProductAttribute[] attributes;
    
        /**
       * @return 商品属性和属性值
    */
        public AlibabaProductProductAttribute[] getAttributes() {
               	return attributes;
            }
    
    /**
     * 设置商品属性和属性值     *
     * 参数示例：<pre>[]</pre>     
             * 此参数必填
          */
    public void setAttributes(AlibabaProductProductAttribute[] attributes) {
     	         	    this.attributes = attributes;
     	        }
    
        [DataMember(Order = 5)]
    private long[] groupID;
    
        /**
       * @return 分组ID，确定商品所属分组。1688可传入多个分组ID，国际站同一个商品只能属于一个分组，因此默认只取第一个
    */
        public long[] getGroupID() {
               	return groupID;
            }
    
    /**
     * 设置分组ID，确定商品所属分组。1688可传入多个分组ID，国际站同一个商品只能属于一个分组，因此默认只取第一个     *
     * 参数示例：<pre>[107331682]</pre>     
             * 此参数必填
          */
    public void setGroupID(long[] groupID) {
     	         	    this.groupID = groupID;
     	        }
    
        [DataMember(Order = 6)]
    private string status;
    
        /**
       * @return 商品状态。published:上网状态;member expired:会员撤销;auto expired:自然过期;expired:过期(包含手动过期与自动过期);member deleted:会员删除;modified:修改;new:新发;deleted:删除;TBD:to be delete;approved:审批通过;auditing:审核中;untread:审核不通过;
    */
        public string getStatus() {
               	return status;
            }
    
    /**
     * 设置商品状态。published:上网状态;member expired:会员撤销;auto expired:自然过期;expired:过期(包含手动过期与自动过期);member deleted:会员删除;modified:修改;new:新发;deleted:删除;TBD:to be delete;approved:审批通过;auditing:审核中;untread:审核不通过;     *
     * 参数示例：<pre>published</pre>     
             * 此参数必填
          */
    public void setStatus(string status) {
     	         	    this.status = status;
     	        }
    
        [DataMember(Order = 7)]
    private string subject;
    
        /**
       * @return 商品标题，最多128个字符
    */
        public string getSubject() {
               	return subject;
            }
    
    /**
     * 设置商品标题，最多128个字符     *
     * 参数示例：<pre>高端气质OL韩版雪纺女装套头半高领长袖修身型蕾丝衫</pre>     
             * 此参数必填
          */
    public void setSubject(string subject) {
     	         	    this.subject = subject;
     	        }
    
        [DataMember(Order = 8)]
    private string description;
    
        /**
       * @return 商品详情描述，可包含图片中心的图片URL
    */
        public string getDescription() {
               	return description;
            }
    
    /**
     * 设置商品详情描述，可包含图片中心的图片URL     *
     * 参数示例：<pre>高端气质OL韩版雪纺女装套头半高领长袖修身型蕾丝衫</pre>     
             * 此参数必填
          */
    public void setDescription(string description) {
     	         	    this.description = description;
     	        }
    
        [DataMember(Order = 9)]
    private string language;
    
        /**
       * @return 语种，参见FAQ 语种枚举值，1688网站默认传入CHINESE
    */
        public string getLanguage() {
               	return language;
            }
    
    /**
     * 设置语种，参见FAQ 语种枚举值，1688网站默认传入CHINESE     *
     * 参数示例：<pre>ENGLISH</pre>     
             * 此参数必填
          */
    public void setLanguage(string language) {
     	         	    this.language = language;
     	        }
    
        [DataMember(Order = 10)]
    private int? periodOfValidity;
    
        /**
       * @return 信息有效期，按天计算，国际站无此信息
    */
        public int? getPeriodOfValidity() {
               	return periodOfValidity;
            }
    
    /**
     * 设置信息有效期，按天计算，国际站无此信息     *
     * 参数示例：<pre>3650</pre>     
             * 此参数必填
          */
    public void setPeriodOfValidity(int periodOfValidity) {
     	         	    this.periodOfValidity = periodOfValidity;
     	        }
    
        [DataMember(Order = 11)]
    private int? bizType;
    
        /**
       * @return 业务类型。1：商品，2：加工，3：代理，4：合作，5：商务服务。国际站按默认商品。
    */
        public int? getBizType() {
               	return bizType;
            }
    
    /**
     * 设置业务类型。1：商品，2：加工，3：代理，4：合作，5：商务服务。国际站按默认商品。     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setBizType(int bizType) {
     	         	    this.bizType = bizType;
     	        }
    
        [DataMember(Order = 12)]
    private bool? pictureAuth;
    
        /**
       * @return 是否图片私密信息，国际站此字段无效
    */
        public bool? getPictureAuth() {
               	return pictureAuth;
            }
    
    /**
     * 设置是否图片私密信息，国际站此字段无效     *
     * 参数示例：<pre>false</pre>     
             * 此参数必填
          */
    public void setPictureAuth(bool pictureAuth) {
     	         	    this.pictureAuth = pictureAuth;
     	        }
    
        [DataMember(Order = 13)]
    private AlibabaProductProductImageInfo image;
    
        /**
       * @return 商品主图
    */
        public AlibabaProductProductImageInfo getImage() {
               	return image;
            }
    
    /**
     * 设置商品主图     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setImage(AlibabaProductProductImageInfo image) {
     	         	    this.image = image;
     	        }
    
        [DataMember(Order = 14)]
    private AlibabaProductProductSKUInfo[] skuInfos;
    
        /**
       * @return sku信息
    */
        public AlibabaProductProductSKUInfo[] getSkuInfos() {
               	return skuInfos;
            }
    
    /**
     * 设置sku信息     *
     * 参数示例：<pre>[]</pre>     
             * 此参数必填
          */
    public void setSkuInfos(AlibabaProductProductSKUInfo[] skuInfos) {
     	         	    this.skuInfos = skuInfos;
     	        }
    
        [DataMember(Order = 15)]
    private AlibabaProductProductSaleInfo saleInfo;
    
        /**
       * @return 商品销售信息
    */
        public AlibabaProductProductSaleInfo getSaleInfo() {
               	return saleInfo;
            }
    
    /**
     * 设置商品销售信息     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setSaleInfo(AlibabaProductProductSaleInfo saleInfo) {
     	         	    this.saleInfo = saleInfo;
     	        }
    
        [DataMember(Order = 16)]
    private AlibabaProductProductShippingInfo shippingInfo;
    
        /**
       * @return 商品物流信息
    */
        public AlibabaProductProductShippingInfo getShippingInfo() {
               	return shippingInfo;
            }
    
    /**
     * 设置商品物流信息     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setShippingInfo(AlibabaProductProductShippingInfo shippingInfo) {
     	         	    this.shippingInfo = shippingInfo;
     	        }
    
        [DataMember(Order = 17)]
    private AlibabaProductProductExtendInfo[] extendInfos;
    
        /**
       * @return 商品扩展信息
    */
        public AlibabaProductProductExtendInfo[] getExtendInfos() {
               	return extendInfos;
            }
    
    /**
     * 设置商品扩展信息     *
     * 参数示例：<pre>[]</pre>     
             * 此参数必填
          */
    public void setExtendInfos(AlibabaProductProductExtendInfo[] extendInfos) {
     	         	    this.extendInfos = extendInfos;
     	        }
    
        [DataMember(Order = 18)]
    private string supplierUserId;
    
        /**
       * @return 供应商用户ID
    */
        public string getSupplierUserId() {
               	return supplierUserId;
            }
    
    /**
     * 设置供应商用户ID     *
     * 参数示例：<pre>1234</pre>     
             * 此参数必填
          */
    public void setSupplierUserId(string supplierUserId) {
     	         	    this.supplierUserId = supplierUserId;
     	        }
    
        [DataMember(Order = 19)]
    private int? qualityLevel;
    
        /**
       * @return 质量星级(0-5)
    */
        public int? getQualityLevel() {
               	return qualityLevel;
            }
    
    /**
     * 设置质量星级(0-5)     *
     * 参数示例：<pre>5</pre>     
             * 此参数必填
          */
    public void setQualityLevel(int qualityLevel) {
     	         	    this.qualityLevel = qualityLevel;
     	        }
    
        [DataMember(Order = 20)]
    private string supplierLoginId;
    
        /**
       * @return 供应商loginId
    */
        public string getSupplierLoginId() {
               	return supplierLoginId;
            }
    
    /**
     * 设置供应商loginId     *
     * 参数示例：<pre>alitestforisv01</pre>     
             * 此参数必填
          */
    public void setSupplierLoginId(string supplierLoginId) {
     	         	    this.supplierLoginId = supplierLoginId;
     	        }
    
        [DataMember(Order = 21)]
    private string categoryName;
    
        /**
       * @return 类目名
    */
        public string getCategoryName() {
               	return categoryName;
            }
    
    /**
     * 设置类目名     *
     * 参数示例：<pre>连衣裙</pre>     
             * 此参数必填
          */
    public void setCategoryName(string categoryName) {
     	         	    this.categoryName = categoryName;
     	        }
    
        [DataMember(Order = 22)]
    private string mainVedio;
    
        /**
       * @return 主图视频播放地址
    */
        public string getMainVedio() {
               	return mainVedio;
            }
    
    /**
     * 设置主图视频播放地址     *
     * 参数示例：<pre>https://cloud.video.taobao.com/play/u/1685/p/1/e/6/t/1/5224**.mp4</pre>     
             * 此参数必填
          */
    public void setMainVedio(string mainVedio) {
     	         	    this.mainVedio = mainVedio;
     	        }
    
        [DataMember(Order = 23)]
    private string productCargoNumber;
    
        /**
       * @return 商品货号，产品属性中的货号
    */
        public string getProductCargoNumber() {
               	return productCargoNumber;
            }
    
    /**
     * 设置商品货号，产品属性中的货号     *
     * 参数示例：<pre>666</pre>     
             * 此参数必填
          */
    public void setProductCargoNumber(string productCargoNumber) {
     	         	    this.productCargoNumber = productCargoNumber;
     	        }
    
        [DataMember(Order = 24)]
    private bool? crossBorderOffer;
    
        /**
       * @return 是否海外代发
    */
        public bool? getCrossBorderOffer() {
               	return crossBorderOffer;
            }
    
    /**
     * 设置是否海外代发     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setCrossBorderOffer(bool crossBorderOffer) {
     	         	    this.crossBorderOffer = crossBorderOffer;
     	        }
    
        [DataMember(Order = 25)]
    private string referencePrice;
    
        /**
       * @return 参考价格，返回价格区间，可能为空
    */
        public string getReferencePrice() {
               	return referencePrice;
            }
    
    /**
     * 设置参考价格，返回价格区间，可能为空     *
     * 参数示例：<pre>500</pre>     
             * 此参数必填
          */
    public void setReferencePrice(string referencePrice) {
     	         	    this.referencePrice = referencePrice;
     	        }
    
        [DataMember(Order = 26)]
    private string createTime;
    
        /**
       * @return 创建时间
    */
        public DateTime? getCreateTime() {
                 if (createTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(createTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置创建时间     *
     * 参数示例：<pre>20181213201638000+0800</pre>     
             * 此参数必填
          */
    public void setCreateTime(DateTime createTime) {
     	         	    this.createTime = DateUtil.format(createTime);
     	        }
    
        [DataMember(Order = 27)]
    private string lastUpdateTime;
    
        /**
       * @return 最后操作时间
    */
        public DateTime? getLastUpdateTime() {
                 if (lastUpdateTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(lastUpdateTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置最后操作时间     *
     * 参数示例：<pre>20181219175505000+0800</pre>     
             * 此参数必填
          */
    public void setLastUpdateTime(DateTime lastUpdateTime) {
     	         	    this.lastUpdateTime = DateUtil.format(lastUpdateTime);
     	        }
    
        [DataMember(Order = 28)]
    private string expireTime;
    
        /**
       * @return 过期时间
    */
        public DateTime? getExpireTime() {
                 if (expireTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(expireTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置过期时间     *
     * 参数示例：<pre>20281216175505000+0800</pre>     
             * 此参数必填
          */
    public void setExpireTime(DateTime expireTime) {
     	         	    this.expireTime = DateUtil.format(expireTime);
     	        }
    
        [DataMember(Order = 29)]
    private string modifyTime;
    
        /**
       * @return 修改时间
    */
        public DateTime? getModifyTime() {
                 if (modifyTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(modifyTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置修改时间     *
     * 参数示例：<pre>20281216175505000+0800</pre>     
             * 此参数必填
          */
    public void setModifyTime(DateTime modifyTime) {
     	         	    this.modifyTime = DateUtil.format(modifyTime);
     	        }
    
        [DataMember(Order = 30)]
    private string approvedTime;
    
        /**
       * @return 审核时间
    */
        public DateTime? getApprovedTime() {
                 if (approvedTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(approvedTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置审核时间     *
     * 参数示例：<pre>20181219175505000+0800</pre>     
             * 此参数必填
          */
    public void setApprovedTime(DateTime approvedTime) {
     	         	    this.approvedTime = DateUtil.format(approvedTime);
     	        }
    
        [DataMember(Order = 31)]
    private string lastRepostTime;
    
        /**
       * @return 最后重发时间
    */
        public DateTime? getLastRepostTime() {
                 if (lastRepostTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(lastRepostTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置最后重发时间     *
     * 参数示例：<pre>20181217090842000+0800</pre>     
             * 此参数必填
          */
    public void setLastRepostTime(DateTime lastRepostTime) {
     	         	    this.lastRepostTime = DateUtil.format(lastRepostTime);
     	        }
    
        [DataMember(Order = 32)]
    private string bookedCount;
    
        /**
       * @return 成交量
    */
        public string getBookedCount() {
               	return bookedCount;
            }
    
    /**
     * 设置成交量     *
     * 参数示例：<pre>1999</pre>     
             * 此参数必填
          */
    public void setBookedCount(string bookedCount) {
     	         	    this.bookedCount = bookedCount;
     	        }
    
        [DataMember(Order = 33)]
    private string productLine;
    
        /**
       * @return 产品线
    */
        public string getProductLine() {
               	return productLine;
            }
    
    /**
     * 设置产品线     *
     * 参数示例：<pre>默认</pre>     
             * 此参数必填
          */
    public void setProductLine(string productLine) {
     	         	    this.productLine = productLine;
     	        }
    
    
  }
}