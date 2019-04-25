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
public class AlibabaLogisticsOpenPlatformLogisticsSender {

       [DataMember(Order = 1)]
    private string senderName;
    
        /**
       * @return 发件人姓名
    */
        public string getSenderName() {
               	return senderName;
            }
    
    /**
     * 设置发件人姓名     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSenderName(string senderName) {
     	         	    this.senderName = senderName;
     	        }
    
        [DataMember(Order = 2)]
    private string senderPhone;
    
        /**
       * @return 发件人电话
    */
        public string getSenderPhone() {
               	return senderPhone;
            }
    
    /**
     * 设置发件人电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSenderPhone(string senderPhone) {
     	         	    this.senderPhone = senderPhone;
     	        }
    
        [DataMember(Order = 3)]
    private string senderMobile;
    
        /**
       * @return 发件人电话
    */
        public string getSenderMobile() {
               	return senderMobile;
            }
    
    /**
     * 设置发件人电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSenderMobile(string senderMobile) {
     	         	    this.senderMobile = senderMobile;
     	        }
    
        [DataMember(Order = 4)]
    private string encrypt;
    
        /**
       * @return 
    */
        public string getEncrypt() {
               	return encrypt;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setEncrypt(string encrypt) {
     	         	    this.encrypt = encrypt;
     	        }
    
        [DataMember(Order = 5)]
    private string senderProvinceCode;
    
        /**
       * @return 省编码
    */
        public string getSenderProvinceCode() {
               	return senderProvinceCode;
            }
    
    /**
     * 设置省编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSenderProvinceCode(string senderProvinceCode) {
     	         	    this.senderProvinceCode = senderProvinceCode;
     	        }
    
        [DataMember(Order = 6)]
    private string senderCityCode;
    
        /**
       * @return 城市编码
    */
        public string getSenderCityCode() {
               	return senderCityCode;
            }
    
    /**
     * 设置城市编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSenderCityCode(string senderCityCode) {
     	         	    this.senderCityCode = senderCityCode;
     	        }
    
        [DataMember(Order = 7)]
    private string senderCountyCode;
    
        /**
       * @return 国家编码
    */
        public string getSenderCountyCode() {
               	return senderCountyCode;
            }
    
    /**
     * 设置国家编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSenderCountyCode(string senderCountyCode) {
     	         	    this.senderCountyCode = senderCountyCode;
     	        }
    
        [DataMember(Order = 8)]
    private string senderAddress;
    
        /**
       * @return 发货人地址
    */
        public string getSenderAddress() {
               	return senderAddress;
            }
    
    /**
     * 设置发货人地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSenderAddress(string senderAddress) {
     	         	    this.senderAddress = senderAddress;
     	        }
    
        [DataMember(Order = 9)]
    private string senderProvince;
    
        /**
       * @return 省份
    */
        public string getSenderProvince() {
               	return senderProvince;
            }
    
    /**
     * 设置省份     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSenderProvince(string senderProvince) {
     	         	    this.senderProvince = senderProvince;
     	        }
    
        [DataMember(Order = 10)]
    private string senderCity;
    
        /**
       * @return 城市
    */
        public string getSenderCity() {
               	return senderCity;
            }
    
    /**
     * 设置城市     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSenderCity(string senderCity) {
     	         	    this.senderCity = senderCity;
     	        }
    
        [DataMember(Order = 11)]
    private string senderCounty;
    
        /**
       * @return 国家
    */
        public string getSenderCounty() {
               	return senderCounty;
            }
    
    /**
     * 设置国家     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSenderCounty(string senderCounty) {
     	         	    this.senderCounty = senderCounty;
     	        }
    
    
  }
}