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
public class AlibabaTradeFastInvoice {

       [DataMember(Order = 1)]
    private int? invoiceType;
    
        /**
       * @return 发票类型
0：普通发票，1:增值税发票
    */
        public int? getInvoiceType() {
               	return invoiceType;
            }
    
    /**
     * 设置发票类型
0：普通发票，1:增值税发票     *
     * 参数示例：<pre>0</pre>     
             * 此参数必填
          */
    public void setInvoiceType(int invoiceType) {
     	         	    this.invoiceType = invoiceType;
     	        }
    
        [DataMember(Order = 2)]
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
    
        [DataMember(Order = 3)]
    private string cityText;
    
        /**
       * @return 城市文本
    */
        public string getCityText() {
               	return cityText;
            }
    
    /**
     * 设置城市文本     *
     * 参数示例：<pre>杭州市</pre>     
             * 此参数必填
          */
    public void setCityText(string cityText) {
     	         	    this.cityText = cityText;
     	        }
    
        [DataMember(Order = 4)]
    private string areaText;
    
        /**
       * @return 地区文本
    */
        public string getAreaText() {
               	return areaText;
            }
    
    /**
     * 设置地区文本     *
     * 参数示例：<pre>滨江区</pre>     
             * 此参数必填
          */
    public void setAreaText(string areaText) {
     	         	    this.areaText = areaText;
     	        }
    
        [DataMember(Order = 5)]
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
    
        [DataMember(Order = 6)]
    private string postCode;
    
        /**
       * @return 邮编
    */
        public string getPostCode() {
               	return postCode;
            }
    
    /**
     * 设置邮编     *
     * 参数示例：<pre>333333</pre>     
             * 此参数必填
          */
    public void setPostCode(string postCode) {
     	         	    this.postCode = postCode;
     	        }
    
        [DataMember(Order = 7)]
    private string address;
    
        /**
       * @return 街道
    */
        public string getAddress() {
               	return address;
            }
    
    /**
     * 设置街道     *
     * 参数示例：<pre>网商路699号</pre>     
             * 此参数必填
          */
    public void setAddress(string address) {
     	         	    this.address = address;
     	        }
    
        [DataMember(Order = 8)]
    private string fullName;
    
        /**
       * @return 收票人姓名
    */
        public string getFullName() {
               	return fullName;
            }
    
    /**
     * 设置收票人姓名     *
     * 参数示例：<pre>张三</pre>     
             * 此参数必填
          */
    public void setFullName(string fullName) {
     	         	    this.fullName = fullName;
     	        }
    
        [DataMember(Order = 9)]
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
    
        [DataMember(Order = 10)]
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
    
        [DataMember(Order = 11)]
    private string companyName;
    
        /**
       * @return 购货公司名（发票抬头）
    */
        public string getCompanyName() {
               	return companyName;
            }
    
    /**
     * 设置购货公司名（发票抬头）     *
     * 参数示例：<pre>测试公司</pre>     
             * 此参数必填
          */
    public void setCompanyName(string companyName) {
     	         	    this.companyName = companyName;
     	        }
    
        [DataMember(Order = 12)]
    private string taxpayerIdentifier;
    
        /**
       * @return 纳税识别码
    */
        public string getTaxpayerIdentifier() {
               	return taxpayerIdentifier;
            }
    
    /**
     * 设置纳税识别码     *
     * 参数示例：<pre>12345</pre>     
             * 此参数必填
          */
    public void setTaxpayerIdentifier(string taxpayerIdentifier) {
     	         	    this.taxpayerIdentifier = taxpayerIdentifier;
     	        }
    
        [DataMember(Order = 13)]
    private string bankAndAccount;
    
        /**
       * @return 开户行及帐号
    */
        public string getBankAndAccount() {
               	return bankAndAccount;
            }
    
    /**
     * 设置开户行及帐号     *
     * 参数示例：<pre>网商银行</pre>     
             * 此参数必填
          */
    public void setBankAndAccount(string bankAndAccount) {
     	         	    this.bankAndAccount = bankAndAccount;
     	        }
    
        [DataMember(Order = 14)]
    private string localInvoiceId;
    
        /**
       * @return 增值税本地发票号
    */
        public string getLocalInvoiceId() {
               	return localInvoiceId;
            }
    
    /**
     * 设置增值税本地发票号     *
     * 参数示例：<pre>123123123</pre>     
             * 此参数必填
          */
    public void setLocalInvoiceId(string localInvoiceId) {
     	         	    this.localInvoiceId = localInvoiceId;
     	        }
    
    
  }
}