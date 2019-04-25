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
public class AlibabaTradeReceiveAddress {

       [DataMember(Order = 1)]
    private string address;
    
        /**
       * @return 街道地址，不包括省市编码
    */
        public string getAddress() {
               	return address;
            }
    
    /**
     * 设置街道地址，不包括省市编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAddress(string address) {
     	         	    this.address = address;
     	        }
    
        [DataMember(Order = 2)]
    private string addressCode;
    
        /**
       * @return 地址区域编码
    */
        public string getAddressCode() {
               	return addressCode;
            }
    
    /**
     * 设置地址区域编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAddressCode(string addressCode) {
     	         	    this.addressCode = addressCode;
     	        }
    
        [DataMember(Order = 3)]
    private string addressCodeText;
    
        /**
       * @return * 地址区域编码对应的文本（包括国家，省，城市）
    */
        public string getAddressCodeText() {
               	return addressCodeText;
            }
    
    /**
     * 设置* 地址区域编码对应的文本（包括国家，省，城市）     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAddressCodeText(string addressCodeText) {
     	         	    this.addressCodeText = addressCodeText;
     	        }
    
        [DataMember(Order = 4)]
    private long? addressId;
    
        /**
       * @return 地址ID
    */
        public long? getAddressId() {
               	return addressId;
            }
    
    /**
     * 设置地址ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAddressId(long addressId) {
     	         	    this.addressId = addressId;
     	        }
    
        [DataMember(Order = 5)]
    private string bizType;
    
        /**
       * @return 业务类型
    */
        public string getBizType() {
               	return bizType;
            }
    
    /**
     * 设置业务类型     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBizType(string bizType) {
     	         	    this.bizType = bizType;
     	        }
    
        [DataMember(Order = 6)]
    private bool? isDefault;
    
        /**
       * @return 是否为默认地址
    */
        public bool? getIsDefault() {
               	return isDefault;
            }
    
    /**
     * 设置是否为默认地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsDefault(bool isDefault) {
     	         	    this.isDefault = isDefault;
     	        }
    
        [DataMember(Order = 7)]
    private string fullName;
    
        /**
       * @return 收货人姓名
    */
        public string getFullName() {
               	return fullName;
            }
    
    /**
     * 设置收货人姓名     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFullName(string fullName) {
     	         	    this.fullName = fullName;
     	        }
    
        [DataMember(Order = 8)]
    private bool? latest;
    
        /**
       * @return 是否最近使用的地址
    */
        public bool? getLatest() {
               	return latest;
            }
    
    /**
     * 设置是否最近使用的地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLatest(bool latest) {
     	         	    this.latest = latest;
     	        }
    
        [DataMember(Order = 9)]
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
    
        [DataMember(Order = 10)]
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
    
        [DataMember(Order = 11)]
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
    
    
  }
}