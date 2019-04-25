using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.trade.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaOpenplatformTradeBizReceiveAddressGroup {

       [DataMember(Order = 1)]
    private string address;
    
        /**
       * @return 街道地址
    */
        public string getAddress() {
               	return address;
            }
    
    /**
     * 设置街道地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAddress(string address) {
     	         	    this.address = address;
     	        }
    
        [DataMember(Order = 2)]
    private long? addressId;
    
        /**
       * @return 用户在阿里巴巴已经保存的收货地址的id
    */
        public long? getAddressId() {
               	return addressId;
            }
    
    /**
     * 设置用户在阿里巴巴已经保存的收货地址的id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAddressId(long addressId) {
     	         	    this.addressId = addressId;
     	        }
    
        [DataMember(Order = 3)]
    private string areaCode;
    
        /**
       * @return 地区编码
    */
        public string getAreaCode() {
               	return areaCode;
            }
    
    /**
     * 设置地区编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAreaCode(string areaCode) {
     	         	    this.areaCode = areaCode;
     	        }
    
        [DataMember(Order = 4)]
    private string areaText;
    
        /**
       * @return 地区
    */
        public string getAreaText() {
               	return areaText;
            }
    
    /**
     * 设置地区     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAreaText(string areaText) {
     	         	    this.areaText = areaText;
     	        }
    
        [DataMember(Order = 5)]
    private string cityCode;
    
        /**
       * @return 城市编码
    */
        public string getCityCode() {
               	return cityCode;
            }
    
    /**
     * 设置城市编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCityCode(string cityCode) {
     	         	    this.cityCode = cityCode;
     	        }
    
        [DataMember(Order = 6)]
    private string cityText;
    
        /**
       * @return 城市
    */
        public string getCityText() {
               	return cityText;
            }
    
    /**
     * 设置城市     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCityText(string cityText) {
     	         	    this.cityText = cityText;
     	        }
    
        [DataMember(Order = 7)]
    private string fullName;
    
        /**
       * @return 收货人姓名
    */
        public string getFullName() {
               	return fullName;
            }
    
    /**
     * 设置收货人姓名     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFullName(string fullName) {
     	         	    this.fullName = fullName;
     	        }
    
        [DataMember(Order = 8)]
    private string group;
    
        /**
       * @return 信息所属分组。多订单提交时用来分组
    */
        public string getGroup() {
               	return group;
            }
    
    /**
     * 设置信息所属分组。多订单提交时用来分组     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGroup(string group) {
     	         	    this.group = group;
     	        }
    
        [DataMember(Order = 9)]
    private bool? isTemp;
    
        /**
       * @return 是否为临时地址
    */
        public bool? getIsTemp() {
               	return isTemp;
            }
    
    /**
     * 设置是否为临时地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsTemp(bool isTemp) {
     	         	    this.isTemp = isTemp;
     	        }
    
        [DataMember(Order = 10)]
    private string memberId;
    
        /**
       * @return 
    */
        public string getMemberId() {
               	return memberId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMemberId(string memberId) {
     	         	    this.memberId = memberId;
     	        }
    
        [DataMember(Order = 11)]
    private string mobile;
    
        /**
       * @return 手机
    */
        public string getMobile() {
               	return mobile;
            }
    
    /**
     * 设置手机     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMobile(string mobile) {
     	         	    this.mobile = mobile;
     	        }
    
        [DataMember(Order = 12)]
    private string phone;
    
        /**
       * @return 电话
    */
        public string getPhone() {
               	return phone;
            }
    
    /**
     * 设置电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPhone(string phone) {
     	         	    this.phone = phone;
     	        }
    
        [DataMember(Order = 13)]
    private string pickType;
    
        /**
       * @return 提货类型
    */
        public string getPickType() {
               	return pickType;
            }
    
    /**
     * 设置提货类型     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPickType(string pickType) {
     	         	    this.pickType = pickType;
     	        }
    
        [DataMember(Order = 14)]
    private string postCode;
    
        /**
       * @return 邮编
    */
        public string getPostCode() {
               	return postCode;
            }
    
    /**
     * 设置邮编     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPostCode(string postCode) {
     	         	    this.postCode = postCode;
     	        }
    
        [DataMember(Order = 15)]
    private string provinceCode;
    
        /**
       * @return 省份编码
    */
        public string getProvinceCode() {
               	return provinceCode;
            }
    
    /**
     * 设置省份编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProvinceCode(string provinceCode) {
     	         	    this.provinceCode = provinceCode;
     	        }
    
        [DataMember(Order = 16)]
    private string provinceText;
    
        /**
       * @return 省份
    */
        public string getProvinceText() {
               	return provinceText;
            }
    
    /**
     * 设置省份     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProvinceText(string provinceText) {
     	         	    this.provinceText = provinceText;
     	        }
    
        [DataMember(Order = 17)]
    private bool? isText;
    
        /**
       * @return 收货地址是否以文本传输
    */
        public bool? getIsText() {
               	return isText;
            }
    
    /**
     * 设置收货地址是否以文本传输     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsText(bool isText) {
     	         	    this.isText = isText;
     	        }
    
        [DataMember(Order = 18)]
    private string warehouse;
    
        /**
       * @return 仓库名称
    */
        public string getWarehouse() {
               	return warehouse;
            }
    
    /**
     * 设置仓库名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setWarehouse(string warehouse) {
     	         	    this.warehouse = warehouse;
     	        }
    
        [DataMember(Order = 19)]
    private bool? isDefault;
    
        /**
       * @return 是否为默认地址
    */
        public bool? getIsDefault() {
               	return isDefault;
            }
    
    /**
     * 设置是否为默认地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsDefault(bool isDefault) {
     	         	    this.isDefault = isDefault;
     	        }
    
    
  }
}