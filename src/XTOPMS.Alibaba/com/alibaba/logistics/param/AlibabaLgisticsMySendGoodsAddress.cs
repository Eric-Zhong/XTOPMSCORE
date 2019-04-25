using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.logistics.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaLgisticsMySendGoodsAddress {

       [DataMember(Order = 1)]
    private string addressName;
    
        /**
       * @return 地址名称
    */
        public string getAddressName() {
               	return addressName;
            }
    
    /**
     * 设置地址名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAddressName(string addressName) {
     	         	    this.addressName = addressName;
     	        }
    
        [DataMember(Order = 2)]
    private string addressType;
    
        /**
       * @return 地址类型
    */
        public string getAddressType() {
               	return addressType;
            }
    
    /**
     * 设置地址类型     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAddressType(string addressType) {
     	         	    this.addressType = addressType;
     	        }
    
        [DataMember(Order = 3)]
    private string areaName;
    
        /**
       * @return 
    */
        public string getAreaName() {
               	return areaName;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAreaName(string areaName) {
     	         	    this.areaName = areaName;
     	        }
    
        [DataMember(Order = 4)]
    private string cityName;
    
        /**
       * @return 
    */
        public string getCityName() {
               	return cityName;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCityName(string cityName) {
     	         	    this.cityName = cityName;
     	        }
    
        [DataMember(Order = 5)]
    private string companyName;
    
        /**
       * @return 
    */
        public string getCompanyName() {
               	return companyName;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCompanyName(string companyName) {
     	         	    this.companyName = companyName;
     	        }
    
        [DataMember(Order = 6)]
    private string country;
    
        /**
       * @return 
    */
        public string getCountry() {
               	return country;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCountry(string country) {
     	         	    this.country = country;
     	        }
    
        [DataMember(Order = 7)]
    private string fullAddress;
    
        /**
       * @return 
    */
        public string getFullAddress() {
               	return fullAddress;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFullAddress(string fullAddress) {
     	         	    this.fullAddress = fullAddress;
     	        }
    
        [DataMember(Order = 8)]
    private long? id;
    
        /**
       * @return 地址Id
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置地址Id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setId(long id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 9)]
    private bool? isDefault;
    
        /**
       * @return 
    */
        public bool? getIsDefault() {
               	return isDefault;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsDefault(bool isDefault) {
     	         	    this.isDefault = isDefault;
     	        }
    
        [DataMember(Order = 10)]
    private string leastCode;
    
        /**
       * @return 
    */
        public string getLeastCode() {
               	return leastCode;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLeastCode(string leastCode) {
     	         	    this.leastCode = leastCode;
     	        }
    
        [DataMember(Order = 11)]
    private string mobile;
    
        /**
       * @return 
    */
        public string getMobile() {
               	return mobile;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMobile(string mobile) {
     	         	    this.mobile = mobile;
     	        }
    
        [DataMember(Order = 12)]
    private string phone;
    
        /**
       * @return 
    */
        public string getPhone() {
               	return phone;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPhone(string phone) {
     	         	    this.phone = phone;
     	        }
    
        [DataMember(Order = 13)]
    private string post;
    
        /**
       * @return 
    */
        public string getPost() {
               	return post;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPost(string post) {
     	         	    this.post = post;
     	        }
    
        [DataMember(Order = 14)]
    private string provinceName;
    
        /**
       * @return 
    */
        public string getProvinceName() {
               	return provinceName;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProvinceName(string provinceName) {
     	         	    this.provinceName = provinceName;
     	        }
    
        [DataMember(Order = 15)]
    private string sendGoodsContactor;
    
        /**
       * @return 联系人
    */
        public string getSendGoodsContactor() {
               	return sendGoodsContactor;
            }
    
    /**
     * 设置联系人     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSendGoodsContactor(string sendGoodsContactor) {
     	         	    this.sendGoodsContactor = sendGoodsContactor;
     	        }
    
        [DataMember(Order = 16)]
    private long? userId;
    
        /**
       * @return 
    */
        public long? getUserId() {
               	return userId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUserId(long userId) {
     	         	    this.userId = userId;
     	        }
    
        [DataMember(Order = 17)]
    private string wangwangNo;
    
        /**
       * @return 
    */
        public string getWangwangNo() {
               	return wangwangNo;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setWangwangNo(string wangwangNo) {
     	         	    this.wangwangNo = wangwangNo;
     	        }
    
    
  }
}