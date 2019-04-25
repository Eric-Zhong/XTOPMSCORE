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
public class AlibabaLogisticsOpReceiveContacter {

       [DataMember(Order = 1)]
    private string provinceCode;
    
        /**
       * @return 省编码
    */
        public string getProvinceCode() {
               	return provinceCode;
            }
    
    /**
     * 设置省编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProvinceCode(string provinceCode) {
     	         	    this.provinceCode = provinceCode;
     	        }
    
        [DataMember(Order = 2)]
    private string cityCode;
    
        /**
       * @return 市编码
    */
        public string getCityCode() {
               	return cityCode;
            }
    
    /**
     * 设置市编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCityCode(string cityCode) {
     	         	    this.cityCode = cityCode;
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
    private string townCode;
    
        /**
       * @return 镇或街道编码
    */
        public string getTownCode() {
               	return townCode;
            }
    
    /**
     * 设置镇或街道编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTownCode(string townCode) {
     	         	    this.townCode = townCode;
     	        }
    
        [DataMember(Order = 5)]
    private string province;
    
        /**
       * @return 省名称，如果传了code，则可以不传
    */
        public string getProvince() {
               	return province;
            }
    
    /**
     * 设置省名称，如果传了code，则可以不传     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProvince(string province) {
     	         	    this.province = province;
     	        }
    
        [DataMember(Order = 6)]
    private string city;
    
        /**
       * @return 市名称，如果传了code，则可以不传
    */
        public string getCity() {
               	return city;
            }
    
    /**
     * 设置市名称，如果传了code，则可以不传     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCity(string city) {
     	         	    this.city = city;
     	        }
    
        [DataMember(Order = 7)]
    private string area;
    
        /**
       * @return 区名称，如果传了code，则可以不传
    */
        public string getArea() {
               	return area;
            }
    
    /**
     * 设置区名称，如果传了code，则可以不传     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setArea(string area) {
     	         	    this.area = area;
     	        }
    
        [DataMember(Order = 8)]
    private string town;
    
        /**
       * @return 镇或街道名称
    */
        public string getTown() {
               	return town;
            }
    
    /**
     * 设置镇或街道名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTown(string town) {
     	         	    this.town = town;
     	        }
    
        [DataMember(Order = 9)]
    private string address;
    
        /**
       * @return 详细地址
    */
        public string getAddress() {
               	return address;
            }
    
    /**
     * 设置详细地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAddress(string address) {
     	         	    this.address = address;
     	        }
    
        [DataMember(Order = 10)]
    private string fullName;
    
        /**
       * @return 姓名
    */
        public string getFullName() {
               	return fullName;
            }
    
    /**
     * 设置姓名     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFullName(string fullName) {
     	         	    this.fullName = fullName;
     	        }
    
        [DataMember(Order = 11)]
    private string corpName;
    
        /**
       * @return 公司名称
    */
        public string getCorpName() {
               	return corpName;
            }
    
    /**
     * 设置公司名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCorpName(string corpName) {
     	         	    this.corpName = corpName;
     	        }
    
        [DataMember(Order = 12)]
    private string post;
    
        /**
       * @return 邮编
    */
        public string getPost() {
               	return post;
            }
    
    /**
     * 设置邮编     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPost(string post) {
     	         	    this.post = post;
     	        }
    
        [DataMember(Order = 13)]
    private string phone;
    
        /**
       * @return 固定电话
    */
        public string getPhone() {
               	return phone;
            }
    
    /**
     * 设置固定电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPhone(string phone) {
     	         	    this.phone = phone;
     	        }
    
        [DataMember(Order = 14)]
    private string mobile;
    
        /**
       * @return 移动电话
    */
        public string getMobile() {
               	return mobile;
            }
    
    /**
     * 设置移动电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMobile(string mobile) {
     	         	    this.mobile = mobile;
     	        }
    
        [DataMember(Order = 15)]
    private string warehouse;
    
        /**
       * @return 仓库
    */
        public string getWarehouse() {
               	return warehouse;
            }
    
    /**
     * 设置仓库     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setWarehouse(string warehouse) {
     	         	    this.warehouse = warehouse;
     	        }
    
        [DataMember(Order = 16)]
    private string codeType;
    
        /**
       * @return 地址编码类型,默认菜鸟标准编码
    */
        public string getCodeType() {
               	return codeType;
            }
    
    /**
     * 设置地址编码类型,默认菜鸟标准编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCodeType(string codeType) {
     	         	    this.codeType = codeType;
     	        }
    
    
  }
}