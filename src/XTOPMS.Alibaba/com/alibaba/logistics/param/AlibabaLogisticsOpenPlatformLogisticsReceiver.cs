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
public class AlibabaLogisticsOpenPlatformLogisticsReceiver {

       [DataMember(Order = 1)]
    private string receiverName;
    
        /**
       * @return 收件人名字
    */
        public string getReceiverName() {
               	return receiverName;
            }
    
    /**
     * 设置收件人名字     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiverName(string receiverName) {
     	         	    this.receiverName = receiverName;
     	        }
    
        [DataMember(Order = 2)]
    private string receiverPhone;
    
        /**
       * @return 收件人电话
    */
        public string getReceiverPhone() {
               	return receiverPhone;
            }
    
    /**
     * 设置收件人电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiverPhone(string receiverPhone) {
     	         	    this.receiverPhone = receiverPhone;
     	        }
    
        [DataMember(Order = 3)]
    private string receiverMobile;
    
        /**
       * @return 收件人电话
    */
        public string getReceiverMobile() {
               	return receiverMobile;
            }
    
    /**
     * 设置收件人电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiverMobile(string receiverMobile) {
     	         	    this.receiverMobile = receiverMobile;
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
    private string receiverProvinceCode;
    
        /**
       * @return 省编码
    */
        public string getReceiverProvinceCode() {
               	return receiverProvinceCode;
            }
    
    /**
     * 设置省编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiverProvinceCode(string receiverProvinceCode) {
     	         	    this.receiverProvinceCode = receiverProvinceCode;
     	        }
    
        [DataMember(Order = 6)]
    private string receiverCityCode;
    
        /**
       * @return 市编码
    */
        public string getReceiverCityCode() {
               	return receiverCityCode;
            }
    
    /**
     * 设置市编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiverCityCode(string receiverCityCode) {
     	         	    this.receiverCityCode = receiverCityCode;
     	        }
    
        [DataMember(Order = 7)]
    private string receiverCountyCode;
    
        /**
       * @return 国家编码
    */
        public string getReceiverCountyCode() {
               	return receiverCountyCode;
            }
    
    /**
     * 设置国家编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiverCountyCode(string receiverCountyCode) {
     	         	    this.receiverCountyCode = receiverCountyCode;
     	        }
    
        [DataMember(Order = 8)]
    private string receiverAddress;
    
        /**
       * @return 地址
    */
        public string getReceiverAddress() {
               	return receiverAddress;
            }
    
    /**
     * 设置地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiverAddress(string receiverAddress) {
     	         	    this.receiverAddress = receiverAddress;
     	        }
    
        [DataMember(Order = 9)]
    private string receiverProvince;
    
        /**
       * @return 省份
    */
        public string getReceiverProvince() {
               	return receiverProvince;
            }
    
    /**
     * 设置省份     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiverProvince(string receiverProvince) {
     	         	    this.receiverProvince = receiverProvince;
     	        }
    
        [DataMember(Order = 10)]
    private string receiverCity;
    
        /**
       * @return 城市
    */
        public string getReceiverCity() {
               	return receiverCity;
            }
    
    /**
     * 设置城市     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiverCity(string receiverCity) {
     	         	    this.receiverCity = receiverCity;
     	        }
    
        [DataMember(Order = 11)]
    private string receiverCounty;
    
        /**
       * @return 国家
    */
        public string getReceiverCounty() {
               	return receiverCounty;
            }
    
    /**
     * 设置国家     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiverCounty(string receiverCounty) {
     	         	    this.receiverCounty = receiverCounty;
     	        }
    
    
  }
}