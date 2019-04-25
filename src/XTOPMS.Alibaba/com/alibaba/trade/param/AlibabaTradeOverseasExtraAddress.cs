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
public class AlibabaTradeOverseasExtraAddress {

       [DataMember(Order = 1)]
    private string channelName;
    
        /**
       * @return 路线名称
    */
        public string getChannelName() {
               	return channelName;
            }
    
    /**
     * 设置路线名称     *
     * 参数示例：<pre>欧洲小包</pre>     
             * 此参数必填
          */
    public void setChannelName(string channelName) {
     	         	    this.channelName = channelName;
     	        }
    
        [DataMember(Order = 2)]
    private string channelId;
    
        /**
       * @return 路线id
    */
        public string getChannelId() {
               	return channelId;
            }
    
    /**
     * 设置路线id     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setChannelId(string channelId) {
     	         	    this.channelId = channelId;
     	        }
    
        [DataMember(Order = 3)]
    private string shippingCompanyId;
    
        /**
       * @return 货代公司id
    */
        public string getShippingCompanyId() {
               	return shippingCompanyId;
            }
    
    /**
     * 设置货代公司id     *
     * 参数示例：<pre>222</pre>     
             * 此参数必填
          */
    public void setShippingCompanyId(string shippingCompanyId) {
     	         	    this.shippingCompanyId = shippingCompanyId;
     	        }
    
        [DataMember(Order = 4)]
    private string shippingCompanyName;
    
        /**
       * @return 货代公司名称
    */
        public string getShippingCompanyName() {
               	return shippingCompanyName;
            }
    
    /**
     * 设置货代公司名称     *
     * 参数示例：<pre>货代公司1</pre>     
             * 此参数必填
          */
    public void setShippingCompanyName(string shippingCompanyName) {
     	         	    this.shippingCompanyName = shippingCompanyName;
     	        }
    
        [DataMember(Order = 5)]
    private string countryCode;
    
        /**
       * @return 国家code
    */
        public string getCountryCode() {
               	return countryCode;
            }
    
    /**
     * 设置国家code     *
     * 参数示例：<pre>UK</pre>     
             * 此参数必填
          */
    public void setCountryCode(string countryCode) {
     	         	    this.countryCode = countryCode;
     	        }
    
        [DataMember(Order = 6)]
    private string country;
    
        /**
       * @return 国家
    */
        public string getCountry() {
               	return country;
            }
    
    /**
     * 设置国家     *
     * 参数示例：<pre>英国</pre>     
             * 此参数必填
          */
    public void setCountry(string country) {
     	         	    this.country = country;
     	        }
    
        [DataMember(Order = 7)]
    private string email;
    
        /**
       * @return 买家邮箱
    */
        public string getEmail() {
               	return email;
            }
    
    /**
     * 设置买家邮箱     *
     * 参数示例：<pre>aaa@gmail.com</pre>     
             * 此参数必填
          */
    public void setEmail(string email) {
     	         	    this.email = email;
     	        }
    
    
  }
}