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
public class AlibabaTradeFastAddress {

       [DataMember(Order = 1)]
    private long? addressId;
    
        /**
       * @return 收货地址id
    */
        public long? getAddressId() {
               	return addressId;
            }
    
    /**
     * 设置收货地址id     *
     * 参数示例：<pre>1234</pre>     
             * 此参数必填
          */
    public void setAddressId(long addressId) {
     	         	    this.addressId = addressId;
     	        }
    
        [DataMember(Order = 2)]
    private string fullName;
    
        /**
       * @return 收货人姓名
    */
        public string getFullName() {
               	return fullName;
            }
    
    /**
     * 设置收货人姓名     *
     * 参数示例：<pre>张三</pre>     
             * 此参数必填
          */
    public void setFullName(string fullName) {
     	         	    this.fullName = fullName;
     	        }
    
        [DataMember(Order = 3)]
    private string mobile;
    
        /**
       * @return 手机
    */
        public string getMobile() {
               	return mobile;
            }
    
    /**
     * 设置手机     *
     * 参数示例：<pre>15251667788</pre>     
             * 此参数必填
          */
    public void setMobile(string mobile) {
     	         	    this.mobile = mobile;
     	        }
    
        [DataMember(Order = 4)]
    private string phone;
    
        /**
       * @return 电话
    */
        public string getPhone() {
               	return phone;
            }
    
    /**
     * 设置电话     *
     * 参数示例：<pre>0517-88990077</pre>     
             * 此参数必填
          */
    public void setPhone(string phone) {
     	         	    this.phone = phone;
     	        }
    
        [DataMember(Order = 5)]
    private string postCode;
    
        /**
       * @return 邮编
    */
        public string getPostCode() {
               	return postCode;
            }
    
    /**
     * 设置邮编     *
     * 参数示例：<pre>000000</pre>     
             * 此参数必填
          */
    public void setPostCode(string postCode) {
     	         	    this.postCode = postCode;
     	        }
    
        [DataMember(Order = 6)]
    private string cityText;
    
        /**
       * @return 市文本
    */
        public string getCityText() {
               	return cityText;
            }
    
    /**
     * 设置市文本     *
     * 参数示例：<pre>杭州市</pre>     
             * 此参数必填
          */
    public void setCityText(string cityText) {
     	         	    this.cityText = cityText;
     	        }
    
        [DataMember(Order = 7)]
    private string provinceText;
    
        /**
       * @return 省份文本
    */
        public string getProvinceText() {
               	return provinceText;
            }
    
    /**
     * 设置省份文本     *
     * 参数示例：<pre>浙江省</pre>     
             * 此参数必填
          */
    public void setProvinceText(string provinceText) {
     	         	    this.provinceText = provinceText;
     	        }
    
        [DataMember(Order = 8)]
    private string areaText;
    
        /**
       * @return 区文本
    */
        public string getAreaText() {
               	return areaText;
            }
    
    /**
     * 设置区文本     *
     * 参数示例：<pre>滨江区</pre>     
             * 此参数必填
          */
    public void setAreaText(string areaText) {
     	         	    this.areaText = areaText;
     	        }
    
        [DataMember(Order = 9)]
    private string townText;
    
        /**
       * @return 镇文本
    */
        public string getTownText() {
               	return townText;
            }
    
    /**
     * 设置镇文本     *
     * 参数示例：<pre>长河镇</pre>     
             * 此参数必填
          */
    public void setTownText(string townText) {
     	         	    this.townText = townText;
     	        }
    
        [DataMember(Order = 10)]
    private string address;
    
        /**
       * @return 街道地址
    */
        public string getAddress() {
               	return address;
            }
    
    /**
     * 设置街道地址     *
     * 参数示例：<pre>网商路699号</pre>     
             * 此参数必填
          */
    public void setAddress(string address) {
     	         	    this.address = address;
     	        }
    
        [DataMember(Order = 11)]
    private string districtCode;
    
        /**
       * @return 地址编码
    */
        public string getDistrictCode() {
               	return districtCode;
            }
    
    /**
     * 设置地址编码     *
     * 参数示例：<pre>310107</pre>     
             * 此参数必填
          */
    public void setDistrictCode(string districtCode) {
     	         	    this.districtCode = districtCode;
     	        }
    
    
  }
}