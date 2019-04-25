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
public class AlibabaPaymentBankAccountInfo {

       [DataMember(Order = 1)]
    private string accountBranch;
    
        /**
       * @return 分行
    */
        public string getAccountBranch() {
               	return accountBranch;
            }
    
    /**
     * 设置分行     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAccountBranch(string accountBranch) {
     	         	    this.accountBranch = accountBranch;
     	        }
    
        [DataMember(Order = 2)]
    private string accountName;
    
        /**
       * @return 账户名
    */
        public string getAccountName() {
               	return accountName;
            }
    
    /**
     * 设置账户名     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAccountName(string accountName) {
     	         	    this.accountName = accountName;
     	        }
    
        [DataMember(Order = 3)]
    private string accountNo;
    
        /**
       * @return 账户
    */
        public string getAccountNo() {
               	return accountNo;
            }
    
    /**
     * 设置账户     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAccountNo(string accountNo) {
     	         	    this.accountNo = accountNo;
     	        }
    
        [DataMember(Order = 4)]
    private string accountPlace;
    
        /**
       * @return 开户地
    */
        public string getAccountPlace() {
               	return accountPlace;
            }
    
    /**
     * 设置开户地     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAccountPlace(string accountPlace) {
     	         	    this.accountPlace = accountPlace;
     	        }
    
        [DataMember(Order = 5)]
    private string groupName;
    
        /**
       * @return 类似开户行，支付宝、网商银行
    */
        public string getGroupName() {
               	return groupName;
            }
    
    /**
     * 设置类似开户行，支付宝、网商银行     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGroupName(string groupName) {
     	         	    this.groupName = groupName;
     	        }
    
        [DataMember(Order = 6)]
    private string paymentLines;
    
        /**
       * @return 联行号
    */
        public string getPaymentLines() {
               	return paymentLines;
            }
    
    /**
     * 设置联行号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPaymentLines(string paymentLines) {
     	         	    this.paymentLines = paymentLines;
     	        }
    
    
  }
}