using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.trade.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaTradeRefundOpAgreeReturnGoodsParam : GatewayAPIRequest {

    public AlibabaTradeRefundOpAgreeReturnGoodsParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.refund.OpAgreeReturnGoods",1);
	}
	
       [DataMember(Order = 1)]
    private string refundId;
    
        /**
       * @return 退款单Id
    */
        public string getRefundId() {
               	return refundId;
            }
    
    /**
     * 设置退款单Id     *
     * 参数示例：<pre>TQ123456</pre>     
             * 此参数必填
          */
    public void setRefundId(string refundId) {
     	         	    this.refundId = refundId;
     	        }
    
        [DataMember(Order = 2)]
    private string address;
    
        /**
       * @return 卖家收货地址
    */
        public string getAddress() {
               	return address;
            }
    
    /**
     * 设置卖家收货地址     *
     * 参数示例：<pre>浙江省杭州市滨江区XXXX</pre>     
             * 此参数必填
          */
    public void setAddress(string address) {
     	         	    this.address = address;
     	        }
    
        [DataMember(Order = 3)]
    private string post;
    
        /**
       * @return 邮编
    */
        public string getPost() {
               	return post;
            }
    
    /**
     * 设置邮编     *
     * 参数示例：<pre>100010</pre>     
             * 此参数必填
          */
    public void setPost(string post) {
     	         	    this.post = post;
     	        }
    
        [DataMember(Order = 4)]
    private string phone;
    
        /**
       * @return 电话
    */
        public string getPhone() {
               	return phone;
            }
    
    /**
     * 设置电话     *
     * 参数示例：<pre>0571-XXXXXXXX</pre>     
             * 此参数必填
          */
    public void setPhone(string phone) {
     	         	    this.phone = phone;
     	        }
    
        [DataMember(Order = 5)]
    private string fullName;
    
        /**
       * @return 全名
    */
        public string getFullName() {
               	return fullName;
            }
    
    /**
     * 设置全名     *
     * 参数示例：<pre>全名</pre>     
             * 此参数必填
          */
    public void setFullName(string fullName) {
     	         	    this.fullName = fullName;
     	        }
    
        [DataMember(Order = 6)]
    private string mobilePhone;
    
        /**
       * @return 手机
    */
        public string getMobilePhone() {
               	return mobilePhone;
            }
    
    /**
     * 设置手机     *
     * 参数示例：<pre>1380000XXXX</pre>     
             * 此参数必填
          */
    public void setMobilePhone(string mobilePhone) {
     	         	    this.mobilePhone = mobilePhone;
     	        }
    
        [DataMember(Order = 7)]
    private string discription;
    
        /**
       * @return 说明
    */
        public string getDiscription() {
               	return discription;
            }
    
    /**
     * 设置说明     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setDiscription(string discription) {
     	         	    this.discription = discription;
     	        }
    
        [DataMember(Order = 8)]
    private int? disputeType;
    
        /**
       * @return 1表示售中，2表示售后
    */
        public int? getDisputeType() {
               	return disputeType;
            }
    
    /**
     * 设置1表示售中，2表示售后     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setDisputeType(int disputeType) {
     	         	    this.disputeType = disputeType;
     	        }
    
    
  }
}