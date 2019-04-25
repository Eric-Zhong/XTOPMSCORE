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
public class AlibabaPaymentChannelPreparePayResult {

       [DataMember(Order = 1)]
    private string paymentCode;
    
        /**
       * @return 付款识别码
    */
        public string getPaymentCode() {
               	return paymentCode;
            }
    
    /**
     * 设置付款识别码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPaymentCode(string paymentCode) {
     	         	    this.paymentCode = paymentCode;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaPaymentBankAccountInfo sellerBankAccountInfo;
    
        /**
       * @return 卖家收款银行账号信息
    */
        public AlibabaPaymentBankAccountInfo getSellerBankAccountInfo() {
               	return sellerBankAccountInfo;
            }
    
    /**
     * 设置卖家收款银行账号信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerBankAccountInfo(AlibabaPaymentBankAccountInfo sellerBankAccountInfo) {
     	         	    this.sellerBankAccountInfo = sellerBankAccountInfo;
     	        }
    
    
  }
}