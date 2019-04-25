using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.account.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaAccountSimpleAccountInfo {

       [DataMember(Order = 1)]
    private string loginId;
    
        /**
       * @return 登录名
    */
        public string getLoginId() {
               	return loginId;
            }
    
    /**
     * 设置登录名     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLoginId(string loginId) {
     	         	    this.loginId = loginId;
     	        }
    
        [DataMember(Order = 2)]
    private long? saleRate;
    
        /**
       * @return 卖家等级
    */
        public long? getSaleRate() {
               	return saleRate;
            }
    
    /**
     * 设置卖家等级     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSaleRate(long saleRate) {
     	         	    this.saleRate = saleRate;
     	        }
    
        [DataMember(Order = 3)]
    private int? maturity;
    
        /**
       * @return 会员成熟度
    */
        public int? getMaturity() {
               	return maturity;
            }
    
    /**
     * 设置会员成熟度     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMaturity(int maturity) {
     	         	    this.maturity = maturity;
     	        }
    
        [DataMember(Order = 4)]
    private string memo;
    
        /**
       * @return 备注
    */
        public string getMemo() {
               	return memo;
            }
    
    /**
     * 设置备注     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMemo(string memo) {
     	         	    this.memo = memo;
     	        }
    
        [DataMember(Order = 5)]
    private string modifyDate;
    
        /**
       * @return 修改日期
    */
        public DateTime? getModifyDate() {
                 if (modifyDate != null)
          {
              DateTime datetime = DateUtil.formatFromStr(modifyDate);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置修改日期     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setModifyDate(DateTime modifyDate) {
     	         	    this.modifyDate = DateUtil.format(modifyDate);
     	        }
    
        [DataMember(Order = 6)]
    private string categoryName;
    
        /**
       * @return 主营行业的类目名称
    */
        public string getCategoryName() {
               	return categoryName;
            }
    
    /**
     * 设置主营行业的类目名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCategoryName(string categoryName) {
     	         	    this.categoryName = categoryName;
     	        }
    
        [DataMember(Order = 7)]
    private int? trustScore;
    
        /**
       * @return 诚信通指数
    */
        public int? getTrustScore() {
               	return trustScore;
            }
    
    /**
     * 设置诚信通指数     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTrustScore(int trustScore) {
     	         	    this.trustScore = trustScore;
     	        }
    
        [DataMember(Order = 8)]
    private long? userId;
    
        /**
       * @return 用户ID
    */
        public long? getUserId() {
               	return userId;
            }
    
    /**
     * 设置用户ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUserId(long userId) {
     	         	    this.userId = userId;
     	        }
    
        [DataMember(Order = 9)]
    private bool? enterpriseAccount;
    
        /**
       * @return 是否是公司会员
    */
        public bool? getEnterpriseAccount() {
               	return enterpriseAccount;
            }
    
    /**
     * 设置是否是公司会员     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setEnterpriseAccount(bool enterpriseAccount) {
     	         	    this.enterpriseAccount = enterpriseAccount;
     	        }
    
        [DataMember(Order = 10)]
    private string createDate;
    
        /**
       * @return 创建时间
    */
        public DateTime? getCreateDate() {
                 if (createDate != null)
          {
              DateTime datetime = DateUtil.formatFromStr(createDate);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置创建时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCreateDate(DateTime createDate) {
     	         	    this.createDate = DateUtil.format(createDate);
     	        }
    
        [DataMember(Order = 11)]
    private string communityLevel;
    
        /**
       * @return 贸易通用户标识
    */
        public string getCommunityLevel() {
               	return communityLevel;
            }
    
    /**
     * 设置贸易通用户标识     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCommunityLevel(string communityLevel) {
     	         	    this.communityLevel = communityLevel;
     	        }
    
        [DataMember(Order = 12)]
    private string joinFrom;
    
        /**
       * @return 注册来源
    */
        public string getJoinFrom() {
               	return joinFrom;
            }
    
    /**
     * 设置注册来源     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setJoinFrom(string joinFrom) {
     	         	    this.joinFrom = joinFrom;
     	        }
    
        [DataMember(Order = 13)]
    private long? rateNum;
    
        /**
       * @return 买家的信用分值(淘宝)
    */
        public long? getRateNum() {
               	return rateNum;
            }
    
    /**
     * 设置买家的信用分值(淘宝)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRateNum(long rateNum) {
     	         	    this.rateNum = rateNum;
     	        }
    
        [DataMember(Order = 14)]
    private string gmtPaidJoin;
    
        /**
       * @return 诚信通加入时间
    */
        public DateTime? getGmtPaidJoin() {
                 if (gmtPaidJoin != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtPaidJoin);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置诚信通加入时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGmtPaidJoin(DateTime gmtPaidJoin) {
     	         	    this.gmtPaidJoin = DateUtil.format(gmtPaidJoin);
     	        }
    
        [DataMember(Order = 15)]
    private long? buyRate;
    
        /**
       * @return 买家等级
    */
        public long? getBuyRate() {
               	return buyRate;
            }
    
    /**
     * 设置买家等级     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyRate(long buyRate) {
     	         	    this.buyRate = buyRate;
     	        }
    
        [DataMember(Order = 16)]
    private int? categoryId;
    
        /**
       * @return 主营行业的类目id
    */
        public int? getCategoryId() {
               	return categoryId;
            }
    
    /**
     * 设置主营行业的类目id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCategoryId(int categoryId) {
     	         	    this.categoryId = categoryId;
     	        }
    
        [DataMember(Order = 17)]
    private string companyName;
    
        /**
       * @return 公司名
    */
        public string getCompanyName() {
               	return companyName;
            }
    
    /**
     * 设置公司名     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCompanyName(string companyName) {
     	         	    this.companyName = companyName;
     	        }
    
        [DataMember(Order = 18)]
    private bool? personAccount;
    
        /**
       * @return 是否是个人账号
    */
        public bool? getPersonAccount() {
               	return personAccount;
            }
    
    /**
     * 设置是否是个人账号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPersonAccount(bool personAccount) {
     	         	    this.personAccount = personAccount;
     	        }
    
        [DataMember(Order = 19)]
    private string homepageUrl;
    
        /**
       * @return 公司主页
    */
        public string getHomepageUrl() {
               	return homepageUrl;
            }
    
    /**
     * 设置公司主页     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setHomepageUrl(string homepageUrl) {
     	         	    this.homepageUrl = homepageUrl;
     	        }
    
        [DataMember(Order = 20)]
    private string saleKeywords;
    
        /**
       * @return 出售关键字
    */
        public string getSaleKeywords() {
               	return saleKeywords;
            }
    
    /**
     * 设置出售关键字     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSaleKeywords(string saleKeywords) {
     	         	    this.saleKeywords = saleKeywords;
     	        }
    
        [DataMember(Order = 21)]
    private int? tpYear;
    
        /**
       * @return 诚信通年限
    */
        public int? getTpYear() {
               	return tpYear;
            }
    
    /**
     * 设置诚信通年限     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTpYear(int tpYear) {
     	         	    this.tpYear = tpYear;
     	        }
    
        [DataMember(Order = 22)]
    private string buyKeywords;
    
        /**
       * @return 求购关键字
    */
        public string getBuyKeywords() {
               	return buyKeywords;
            }
    
    /**
     * 设置求购关键字     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyKeywords(string buyKeywords) {
     	         	    this.buyKeywords = buyKeywords;
     	        }
    
        [DataMember(Order = 23)]
    private string memberBizType;
    
        /**
       * @return 业务类型
 企业单位 ENTERPRISE("5"),
个体经营 SELF_EMPLOYED("6"),
 事业单位或社会团体 ORGANIZATION("7"),
 个人 PERSONAL("8");
    */
        public string getMemberBizType() {
               	return memberBizType;
            }
    
    /**
     * 设置业务类型
 企业单位 ENTERPRISE("5"),
个体经营 SELF_EMPLOYED("6"),
 事业单位或社会团体 ORGANIZATION("7"),
 个人 PERSONAL("8");     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMemberBizType(string memberBizType) {
     	         	    this.memberBizType = memberBizType;
     	        }
    
        [DataMember(Order = 24)]
    private long? rateSum;
    
        /**
       * @return 卖家的信用分值(淘宝)
    */
        public long? getRateSum() {
               	return rateSum;
            }
    
    /**
     * 设置卖家的信用分值(淘宝)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRateSum(long rateSum) {
     	         	    this.rateSum = rateSum;
     	        }
    
        [DataMember(Order = 25)]
    private string[] domainInPlatforms;
    
        /**
       * @return 1688上店铺地址
    */
        public string[] getDomainInPlatforms() {
               	return domainInPlatforms;
            }
    
    /**
     * 设置1688上店铺地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDomainInPlatforms(string[] domainInPlatforms) {
     	         	    this.domainInPlatforms = domainInPlatforms;
     	        }
    
        [DataMember(Order = 26)]
    private string memberId;
    
        /**
       * @return memberId
    */
        public string getMemberId() {
               	return memberId;
            }
    
    /**
     * 设置memberId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMemberId(string memberId) {
     	         	    this.memberId = memberId;
     	        }
    
        [DataMember(Order = 27)]
    private string shopUrl;
    
        /**
       * @return 旺铺首页地址
    */
        public string getShopUrl() {
               	return shopUrl;
            }
    
    /**
     * 设置旺铺首页地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setShopUrl(string shopUrl) {
     	         	    this.shopUrl = shopUrl;
     	        }
    
        [DataMember(Order = 28)]
    private string supplierName;
    
        /**
       * @return 供应商名称
    */
        public string getSupplierName() {
               	return supplierName;
            }
    
    /**
     * 设置供应商名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSupplierName(string supplierName) {
     	         	    this.supplierName = supplierName;
     	        }
    
        [DataMember(Order = 29)]
    private string icon;
    
        /**
       * @return 用户头像
    */
        public string getIcon() {
               	return icon;
            }
    
    /**
     * 设置用户头像     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIcon(string icon) {
     	         	    this.icon = icon;
     	        }
    
        [DataMember(Order = 30)]
    private string phoneNo;
    
        /**
       * @return 固定电话
    */
        public string getPhoneNo() {
               	return phoneNo;
            }
    
    /**
     * 设置固定电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPhoneNo(string phoneNo) {
     	         	    this.phoneNo = phoneNo;
     	        }
    
        [DataMember(Order = 31)]
    private string industry;
    
        /**
       * @return 主营行业
    */
        public string getIndustry() {
               	return industry;
            }
    
    /**
     * 设置主营行业     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIndustry(string industry) {
     	         	    this.industry = industry;
     	        }
    
        [DataMember(Order = 32)]
    private string product;
    
        /**
       * @return 主营产品
    */
        public string getProduct() {
               	return product;
            }
    
    /**
     * 设置主营产品     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProduct(string product) {
     	         	    this.product = product;
     	        }
    
        [DataMember(Order = 33)]
    private string department;
    
        /**
       * @return 部门
    */
        public string getDepartment() {
               	return department;
            }
    
    /**
     * 设置部门     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDepartment(string department) {
     	         	    this.department = department;
     	        }
    
        [DataMember(Order = 34)]
    private string mobileNo;
    
        /**
       * @return 业务联系手机（会员基本信息中编辑）	
业务联系手机
    */
        public string getMobileNo() {
               	return mobileNo;
            }
    
    /**
     * 设置业务联系手机（会员基本信息中编辑）	
业务联系手机     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMobileNo(string mobileNo) {
     	         	    this.mobileNo = mobileNo;
     	        }
    
        [DataMember(Order = 35)]
    private string addressLocation;
    
        /**
       * @return 联系地址
    */
        public string getAddressLocation() {
               	return addressLocation;
            }
    
    /**
     * 设置联系地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAddressLocation(string addressLocation) {
     	         	    this.addressLocation = addressLocation;
     	        }
    
        [DataMember(Order = 36)]
    private string email;
    
        /**
       * @return 业务联系邮箱
    */
        public string getEmail() {
               	return email;
            }
    
    /**
     * 设置业务联系邮箱     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setEmail(string email) {
     	         	    this.email = email;
     	        }
    
        [DataMember(Order = 37)]
    private string sellerName;
    
        /**
       * @return 卖家名称
    */
        public string getSellerName() {
               	return sellerName;
            }
    
    /**
     * 设置卖家名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerName(string sellerName) {
     	         	    this.sellerName = sellerName;
     	        }
    
    
  }
}