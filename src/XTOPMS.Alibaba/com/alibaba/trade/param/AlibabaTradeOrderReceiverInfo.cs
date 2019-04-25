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
public class AlibabaTradeOrderReceiverInfo {

       [DataMember(Order = 1)]
    private string toFullName;
    
        /**
       * @return 收件人
    */
        public string getToFullName() {
               	return toFullName;
            }
    
    /**
     * 设置收件人     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToFullName(string toFullName) {
     	         	    this.toFullName = toFullName;
     	        }
    
        [DataMember(Order = 2)]
    private string toDivisionCode;
    
        /**
       * @return 收货人地址区域编码
    */
        public string getToDivisionCode() {
               	return toDivisionCode;
            }
    
    /**
     * 设置收货人地址区域编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToDivisionCode(string toDivisionCode) {
     	         	    this.toDivisionCode = toDivisionCode;
     	        }
    
        [DataMember(Order = 3)]
    private string toMobile;
    
        /**
       * @return 收件人移动电话
    */
        public string getToMobile() {
               	return toMobile;
            }
    
    /**
     * 设置收件人移动电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToMobile(string toMobile) {
     	         	    this.toMobile = toMobile;
     	        }
    
        [DataMember(Order = 4)]
    private string toPhone;
    
        /**
       * @return 收件人电话
    */
        public string getToPhone() {
               	return toPhone;
            }
    
    /**
     * 设置收件人电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToPhone(string toPhone) {
     	         	    this.toPhone = toPhone;
     	        }
    
        [DataMember(Order = 5)]
    private string toPost;
    
        /**
       * @return 邮编
    */
        public string getToPost() {
               	return toPost;
            }
    
    /**
     * 设置邮编     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToPost(string toPost) {
     	         	    this.toPost = toPost;
     	        }
    
        [DataMember(Order = 6)]
    private string toTownCode;
    
        /**
       * @return 收货人街道或镇区域编码，可能为空
    */
        public string getToTownCode() {
               	return toTownCode;
            }
    
    /**
     * 设置收货人街道或镇区域编码，可能为空     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToTownCode(string toTownCode) {
     	         	    this.toTownCode = toTownCode;
     	        }
    
        [DataMember(Order = 7)]
    private string toArea;
    
        /**
       * @return 收货地址
    */
        public string getToArea() {
               	return toArea;
            }
    
    /**
     * 设置收货地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToArea(string toArea) {
     	         	    this.toArea = toArea;
     	        }
    
    
  }
}