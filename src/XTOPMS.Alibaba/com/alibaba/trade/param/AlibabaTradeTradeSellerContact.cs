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
public class AlibabaTradeTradeSellerContact {

       [DataMember(Order = 1)]
    private string phone;
    
        /**
       * @return 联系电话
    */
        public string getPhone() {
               	return phone;
            }
    
    /**
     * 设置联系电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPhone(string phone) {
     	         	    this.phone = phone;
     	        }
    
        [DataMember(Order = 2)]
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
    
        [DataMember(Order = 3)]
    private string email;
    
        /**
       * @return 邮箱
    */
        public string getEmail() {
               	return email;
            }
    
    /**
     * 设置邮箱     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setEmail(string email) {
     	         	    this.email = email;
     	        }
    
        [DataMember(Order = 4)]
    private string imInPlatform;
    
        /**
       * @return 联系人在平台的IM账号
    */
        public string getImInPlatform() {
               	return imInPlatform;
            }
    
    /**
     * 设置联系人在平台的IM账号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setImInPlatform(string imInPlatform) {
     	         	    this.imInPlatform = imInPlatform;
     	        }
    
        [DataMember(Order = 5)]
    private string name;
    
        /**
       * @return 联系人名称
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置联系人名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
        [DataMember(Order = 6)]
    private string mobile;
    
        /**
       * @return 联系人手机号
    */
        public string getMobile() {
               	return mobile;
            }
    
    /**
     * 设置联系人手机号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMobile(string mobile) {
     	         	    this.mobile = mobile;
     	        }
    
        [DataMember(Order = 7)]
    private string companyName;
    
        /**
       * @return 公司名称
    */
        public string getCompanyName() {
               	return companyName;
            }
    
    /**
     * 设置公司名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCompanyName(string companyName) {
     	         	    this.companyName = companyName;
     	        }
    
        [DataMember(Order = 8)]
    private string wgSenderName;
    
        /**
       * @return 发件人名称，在微供等分销场景下由分销商设置
    */
        public string getWgSenderName() {
               	return wgSenderName;
            }
    
    /**
     * 设置发件人名称，在微供等分销场景下由分销商设置     *
     * 参数示例：<pre>张**</pre>     
             * 此参数必填
          */
    public void setWgSenderName(string wgSenderName) {
     	         	    this.wgSenderName = wgSenderName;
     	        }
    
        [DataMember(Order = 9)]
    private string wgSenderPhone;
    
        /**
       * @return 发件人电话，在微供等分销场景下由分销商设置
    */
        public string getWgSenderPhone() {
               	return wgSenderPhone;
            }
    
    /**
     * 设置发件人电话，在微供等分销场景下由分销商设置     *
     * 参数示例：<pre>13800000000</pre>     
             * 此参数必填
          */
    public void setWgSenderPhone(string wgSenderPhone) {
     	         	    this.wgSenderPhone = wgSenderPhone;
     	        }
    
    
  }
}