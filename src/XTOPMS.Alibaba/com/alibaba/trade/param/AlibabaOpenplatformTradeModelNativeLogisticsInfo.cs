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
public class AlibabaOpenplatformTradeModelNativeLogisticsInfo {

       [DataMember(Order = 1)]
    private string address;
    
        /**
       * @return 详细地址
    */
        public string getAddress() {
               	return address;
            }
    
    /**
     * 设置详细地址     *
     * 参数示例：<pre>杭州市网商路699号</pre>     
             * 此参数必填
          */
    public void setAddress(string address) {
     	         	    this.address = address;
     	        }
    
        [DataMember(Order = 2)]
    private string area;
    
        /**
       * @return 县，区
    */
        public string getArea() {
               	return area;
            }
    
    /**
     * 设置县，区     *
     * 参数示例：<pre>滨江区</pre>     
             * 此参数必填
          */
    public void setArea(string area) {
     	         	    this.area = area;
     	        }
    
        [DataMember(Order = 3)]
    private string areaCode;
    
        /**
       * @return 省市区编码
    */
        public string getAreaCode() {
               	return areaCode;
            }
    
    /**
     * 设置省市区编码     *
     * 参数示例：<pre>330108</pre>     
             * 此参数必填
          */
    public void setAreaCode(string areaCode) {
     	         	    this.areaCode = areaCode;
     	        }
    
        [DataMember(Order = 4)]
    private string city;
    
        /**
       * @return 城市
    */
        public string getCity() {
               	return city;
            }
    
    /**
     * 设置城市     *
     * 参数示例：<pre>杭州市</pre>     
             * 此参数必填
          */
    public void setCity(string city) {
     	         	    this.city = city;
     	        }
    
        [DataMember(Order = 5)]
    private string contactPerson;
    
        /**
       * @return 联系人姓名
    */
        public string getContactPerson() {
               	return contactPerson;
            }
    
    /**
     * 设置联系人姓名     *
     * 参数示例：<pre>张三</pre>     
             * 此参数必填
          */
    public void setContactPerson(string contactPerson) {
     	         	    this.contactPerson = contactPerson;
     	        }
    
        [DataMember(Order = 6)]
    private string fax;
    
        /**
       * @return 传真
    */
        public string getFax() {
               	return fax;
            }
    
    /**
     * 设置传真     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFax(string fax) {
     	         	    this.fax = fax;
     	        }
    
        [DataMember(Order = 7)]
    private string mobile;
    
        /**
       * @return 手机
    */
        public string getMobile() {
               	return mobile;
            }
    
    /**
     * 设置手机     *
     * 参数示例：<pre>13988888888</pre>     
             * 此参数必填
          */
    public void setMobile(string mobile) {
     	         	    this.mobile = mobile;
     	        }
    
        [DataMember(Order = 8)]
    private string province;
    
        /**
       * @return 省份
    */
        public string getProvince() {
               	return province;
            }
    
    /**
     * 设置省份     *
     * 参数示例：<pre>浙江省</pre>     
             * 此参数必填
          */
    public void setProvince(string province) {
     	         	    this.province = province;
     	        }
    
        [DataMember(Order = 9)]
    private string telephone;
    
        /**
       * @return 电话
    */
        public string getTelephone() {
               	return telephone;
            }
    
    /**
     * 设置电话     *
     * 参数示例：<pre>0517-88990077</pre>     
             * 此参数必填
          */
    public void setTelephone(string telephone) {
     	         	    this.telephone = telephone;
     	        }
    
        [DataMember(Order = 10)]
    private string zip;
    
        /**
       * @return 邮编
    */
        public string getZip() {
               	return zip;
            }
    
    /**
     * 设置邮编     *
     * 参数示例：<pre>000000</pre>     
             * 此参数必填
          */
    public void setZip(string zip) {
     	         	    this.zip = zip;
     	        }
    
        [DataMember(Order = 11)]
    private AlibabaOpenplatformTradeModelNativeLogisticsItemsInfo[] logisticsItems;
    
        /**
       * @return 运单明细
    */
        public AlibabaOpenplatformTradeModelNativeLogisticsItemsInfo[] getLogisticsItems() {
               	return logisticsItems;
            }
    
    /**
     * 设置运单明细     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsItems(AlibabaOpenplatformTradeModelNativeLogisticsItemsInfo[] logisticsItems) {
     	         	    this.logisticsItems = logisticsItems;
     	        }
    
        [DataMember(Order = 12)]
    private string townCode;
    
        /**
       * @return 镇，街道地址码
    */
        public string getTownCode() {
               	return townCode;
            }
    
    /**
     * 设置镇，街道地址码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTownCode(string townCode) {
     	         	    this.townCode = townCode;
     	        }
    
        [DataMember(Order = 13)]
    private string town;
    
        /**
       * @return 镇，街道
    */
        public string getTown() {
               	return town;
            }
    
    /**
     * 设置镇，街道     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTown(string town) {
     	         	    this.town = town;
     	        }
    
    
  }
}