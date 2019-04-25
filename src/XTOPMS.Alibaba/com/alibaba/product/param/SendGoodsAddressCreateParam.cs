using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.product.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class SendGoodsAddressCreateParam : GatewayAPIRequest {

    public SendGoodsAddressCreateParam() {
        this.ApiId = new APIId("com.alibaba.product", "sendGoodsAddress.create",1);
	}
	
       [DataMember(Order = 1)]
    private string province;
    
        /**
       * @return 省
    */
        public string getProvince() {
               	return province;
            }
    
    /**
     * 设置省     *
     * 参数示例：<pre>浙江省</pre>     
             * 此参数必填
          */
    public void setProvince(string province) {
     	         	    this.province = province;
     	        }
    
        [DataMember(Order = 2)]
    private string city;
    
        /**
       * @return 城市名
    */
        public string getCity() {
               	return city;
            }
    
    /**
     * 设置城市名     *
     * 参数示例：<pre>杭州市</pre>     
             * 此参数必填
          */
    public void setCity(string city) {
     	         	    this.city = city;
     	        }
    
        [DataMember(Order = 3)]
    private string area;
    
        /**
       * @return 区，没有区可以使用城市名称
    */
        public string getArea() {
               	return area;
            }
    
    /**
     * 设置区，没有区可以使用城市名称     *
     * 参数示例：<pre>滨江区</pre>     
             * 此参数必填
          */
    public void setArea(string area) {
     	         	    this.area = area;
     	        }
    
        [DataMember(Order = 4)]
    private string town;
    
        /**
       * @return 镇，可能为空
    */
        public string getTown() {
               	return town;
            }
    
    /**
     * 设置镇，可能为空     *
     * 参数示例：<pre>**镇</pre>     
             * 此参数必填
          */
    public void setTown(string town) {
     	         	    this.town = town;
     	        }
    
        [DataMember(Order = 5)]
    private string address;
    
        /**
       * @return 详细地址
    */
        public string getAddress() {
               	return address;
            }
    
    /**
     * 设置详细地址     *
     * 参数示例：<pre>网商路699号</pre>     
             * 此参数必填
          */
    public void setAddress(string address) {
     	         	    this.address = address;
     	        }
    
        [DataMember(Order = 6)]
    private string contactor;
    
        /**
       * @return 联系人
    */
        public string getContactor() {
               	return contactor;
            }
    
    /**
     * 设置联系人     *
     * 参数示例：<pre>王小二</pre>     
             * 此参数必填
          */
    public void setContactor(string contactor) {
     	         	    this.contactor = contactor;
     	        }
    
        [DataMember(Order = 7)]
    private string mobile;
    
        /**
       * @return 移动电话，不可和phone同时为空
    */
        public string getMobile() {
               	return mobile;
            }
    
    /**
     * 设置移动电话，不可和phone同时为空     *
     * 参数示例：<pre>1380000****</pre>     
             * 此参数必填
          */
    public void setMobile(string mobile) {
     	         	    this.mobile = mobile;
     	        }
    
        [DataMember(Order = 8)]
    private string phone;
    
        /**
       * @return 固定电话，不可和mobile同时为空，电话格式为：区号-电话号码-分机号
    */
        public string getPhone() {
               	return phone;
            }
    
    /**
     * 设置固定电话，不可和mobile同时为空，电话格式为：区号-电话号码-分机号     *
     * 参数示例：<pre>010-62281010-01</pre>     
             * 此参数必填
          */
    public void setPhone(string phone) {
     	         	    this.phone = phone;
     	        }
    
        [DataMember(Order = 9)]
    private string post;
    
        /**
       * @return 邮政编码
    */
        public string getPost() {
               	return post;
            }
    
    /**
     * 设置邮政编码     *
     * 参数示例：<pre>100001</pre>     
             * 此参数必填
          */
    public void setPost(string post) {
     	         	    this.post = post;
     	        }
    
    
  }
}