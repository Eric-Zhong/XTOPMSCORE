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
public class AlibabaOpenplatformTradeBizInvoiceGroup {

       [DataMember(Order = 1)]
    private string address;
    
        /**
       * @return 街道
    */
        public string getAddress() {
               	return address;
            }
    
    /**
     * 设置街道     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAddress(string address) {
     	         	    this.address = address;
     	        }
    
        [DataMember(Order = 2)]
    private string addressAndPhone;
    
        /**
       * @return 地址|电话
    */
        public string getAddressAndPhone() {
               	return addressAndPhone;
            }
    
    /**
     * 设置地址|电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAddressAndPhone(string addressAndPhone) {
     	         	    this.addressAndPhone = addressAndPhone;
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
    private string bankAndAccount;
    
        /**
       * @return 开户行及帐号
    */
        public string getBankAndAccount() {
               	return bankAndAccount;
            }
    
    /**
     * 设置开户行及帐号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBankAndAccount(string bankAndAccount) {
     	         	    this.bankAndAccount = bankAndAccount;
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
    private string companyName;
    
        /**
       * @return 购货公司名
    */
        public string getCompanyName() {
               	return companyName;
            }
    
    /**
     * 设置购货公司名     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCompanyName(string companyName) {
     	         	    this.companyName = companyName;
     	        }
    
        [DataMember(Order = 7)]
    private string fullName;
    
        /**
       * @return 收票人姓名
    */
        public string getFullName() {
               	return fullName;
            }
    
    /**
     * 设置收票人姓名     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFullName(string fullName) {
     	         	    this.fullName = fullName;
     	        }
    
        [DataMember(Order = 8)]
    private bool? invoiceFlag;
    
        /**
       * @return 发票标记
    */
        public bool? getInvoiceFlag() {
               	return invoiceFlag;
            }
    
    /**
     * 设置发票标记     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setInvoiceFlag(bool invoiceFlag) {
     	         	    this.invoiceFlag = invoiceFlag;
     	        }
    
        [DataMember(Order = 9)]
    private int? invoiceType;
    
        /**
       * @return 0：普通发票，1:增值税发票
    */
        public int? getInvoiceType() {
               	return invoiceType;
            }
    
    /**
     * 设置0：普通发票，1:增值税发票     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setInvoiceType(int invoiceType) {
     	         	    this.invoiceType = invoiceType;
     	        }
    
        [DataMember(Order = 10)]
    private string localInvoiceId;
    
        /**
       * @return 增值税本地发票号
    */
        public string getLocalInvoiceId() {
               	return localInvoiceId;
            }
    
    /**
     * 设置增值税本地发票号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLocalInvoiceId(string localInvoiceId) {
     	         	    this.localInvoiceId = localInvoiceId;
     	        }
    
        [DataMember(Order = 11)]
    private string mergedJsonVar;
    
        /**
       * @return 前端提交的json数据格式
    */
        public string getMergedJsonVar() {
               	return mergedJsonVar;
            }
    
    /**
     * 设置前端提交的json数据格式     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMergedJsonVar(string mergedJsonVar) {
     	         	    this.mergedJsonVar = mergedJsonVar;
     	        }
    
        [DataMember(Order = 12)]
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
    
        [DataMember(Order = 13)]
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
    private string taxpayerIdentifier;
    
        /**
       * @return 纳税识别码
    */
        public string getTaxpayerIdentifier() {
               	return taxpayerIdentifier;
            }
    
    /**
     * 设置纳税识别码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTaxpayerIdentifier(string taxpayerIdentifier) {
     	         	    this.taxpayerIdentifier = taxpayerIdentifier;
     	        }
    
    
  }
}