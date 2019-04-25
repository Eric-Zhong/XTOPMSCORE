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
public class AlibabaInvoiceOrderInvoiceModel {

       [DataMember(Order = 1)]
    private string invoiceCompanyName;
    
        /**
       * @return 发票公司名称(即发票抬头-title)
    */
        public string getInvoiceCompanyName() {
               	return invoiceCompanyName;
            }
    
    /**
     * 设置发票公司名称(即发票抬头-title)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setInvoiceCompanyName(string invoiceCompanyName) {
     	         	    this.invoiceCompanyName = invoiceCompanyName;
     	        }
    
        [DataMember(Order = 2)]
    private int? invoiceType;
    
        /**
       * @return 发票类型. 0：普通发票，1:增值税发票，9未知类型
    */
        public int? getInvoiceType() {
               	return invoiceType;
            }
    
    /**
     * 设置发票类型. 0：普通发票，1:增值税发票，9未知类型     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setInvoiceType(int invoiceType) {
     	         	    this.invoiceType = invoiceType;
     	        }
    
        [DataMember(Order = 3)]
    private long? localInvoiceId;
    
        /**
       * @return 本地发票号
    */
        public long? getLocalInvoiceId() {
               	return localInvoiceId;
            }
    
    /**
     * 设置本地发票号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLocalInvoiceId(long localInvoiceId) {
     	         	    this.localInvoiceId = localInvoiceId;
     	        }
    
        [DataMember(Order = 4)]
    private long? orderId;
    
        /**
       * @return 订单Id
    */
        public long? getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置订单Id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderId(long orderId) {
     	         	    this.orderId = orderId;
     	        }
    
        [DataMember(Order = 5)]
    private string receiveCode;
    
        /**
       * @return (收件人)址区域编码
    */
        public string getReceiveCode() {
               	return receiveCode;
            }
    
    /**
     * 设置(收件人)址区域编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiveCode(string receiveCode) {
     	         	    this.receiveCode = receiveCode;
     	        }
    
        [DataMember(Order = 6)]
    private string receiveCodeText;
    
        /**
       * @return (收件人) 省市区编码对应的文案(增值税发票信息)
    */
        public string getReceiveCodeText() {
               	return receiveCodeText;
            }
    
    /**
     * 设置(收件人) 省市区编码对应的文案(增值税发票信息)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiveCodeText(string receiveCodeText) {
     	         	    this.receiveCodeText = receiveCodeText;
     	        }
    
        [DataMember(Order = 7)]
    private string receiveMobile;
    
        /**
       * @return （收件者）发票收货人手机
    */
        public string getReceiveMobile() {
               	return receiveMobile;
            }
    
    /**
     * 设置（收件者）发票收货人手机     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiveMobile(string receiveMobile) {
     	         	    this.receiveMobile = receiveMobile;
     	        }
    
        [DataMember(Order = 8)]
    private string receiveName;
    
        /**
       * @return （收件者）发票收货人
    */
        public string getReceiveName() {
               	return receiveName;
            }
    
    /**
     * 设置（收件者）发票收货人     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiveName(string receiveName) {
     	         	    this.receiveName = receiveName;
     	        }
    
        [DataMember(Order = 9)]
    private string receivePhone;
    
        /**
       * @return （收件者）发票收货人电话
    */
        public string getReceivePhone() {
               	return receivePhone;
            }
    
    /**
     * 设置（收件者）发票收货人电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceivePhone(string receivePhone) {
     	         	    this.receivePhone = receivePhone;
     	        }
    
        [DataMember(Order = 10)]
    private string receivePost;
    
        /**
       * @return （收件者）发票收货地址邮编
    */
        public string getReceivePost() {
               	return receivePost;
            }
    
    /**
     * 设置（收件者）发票收货地址邮编     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceivePost(string receivePost) {
     	         	    this.receivePost = receivePost;
     	        }
    
        [DataMember(Order = 11)]
    private string receiveStreet;
    
        /**
       * @return (收件人) 街道地址(增值税发票信息)
    */
        public string getReceiveStreet() {
               	return receiveStreet;
            }
    
    /**
     * 设置(收件人) 街道地址(增值税发票信息)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiveStreet(string receiveStreet) {
     	         	    this.receiveStreet = receiveStreet;
     	        }
    
        [DataMember(Order = 12)]
    private string registerAccountId;
    
        /**
       * @return (公司)银行账号
    */
        public string getRegisterAccountId() {
               	return registerAccountId;
            }
    
    /**
     * 设置(公司)银行账号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRegisterAccountId(string registerAccountId) {
     	         	    this.registerAccountId = registerAccountId;
     	        }
    
        [DataMember(Order = 13)]
    private string registerBank;
    
        /**
       * @return (公司)开户银行
    */
        public string getRegisterBank() {
               	return registerBank;
            }
    
    /**
     * 设置(公司)开户银行     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRegisterBank(string registerBank) {
     	         	    this.registerBank = registerBank;
     	        }
    
        [DataMember(Order = 14)]
    private string registerCode;
    
        /**
       * @return (注册)省市区编码
    */
        public string getRegisterCode() {
               	return registerCode;
            }
    
    /**
     * 设置(注册)省市区编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRegisterCode(string registerCode) {
     	         	    this.registerCode = registerCode;
     	        }
    
        [DataMember(Order = 15)]
    private string registerCodeText;
    
        /**
       * @return (注册)省市区文本
    */
        public string getRegisterCodeText() {
               	return registerCodeText;
            }
    
    /**
     * 设置(注册)省市区文本     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRegisterCodeText(string registerCodeText) {
     	         	    this.registerCodeText = registerCodeText;
     	        }
    
        [DataMember(Order = 16)]
    private string registerPhone;
    
        /**
       * @return （公司）注册电话
    */
        public string getRegisterPhone() {
               	return registerPhone;
            }
    
    /**
     * 设置（公司）注册电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRegisterPhone(string registerPhone) {
     	         	    this.registerPhone = registerPhone;
     	        }
    
        [DataMember(Order = 17)]
    private string registerStreet;
    
        /**
       * @return (注册)街道地址
    */
        public string getRegisterStreet() {
               	return registerStreet;
            }
    
    /**
     * 设置(注册)街道地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRegisterStreet(string registerStreet) {
     	         	    this.registerStreet = registerStreet;
     	        }
    
        [DataMember(Order = 18)]
    private string taxpayerIdentify;
    
        /**
       * @return 纳税人识别号
    */
        public string getTaxpayerIdentify() {
               	return taxpayerIdentify;
            }
    
    /**
     * 设置纳税人识别号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTaxpayerIdentify(string taxpayerIdentify) {
     	         	    this.taxpayerIdentify = taxpayerIdentify;
     	        }
    
    
  }
}