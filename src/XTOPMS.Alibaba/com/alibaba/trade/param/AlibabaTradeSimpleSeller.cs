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
public class AlibabaTradeSimpleSeller {

       [DataMember(Order = 1)]
    private string companyName;
    
        /**
       * @return 
    */
        public string getCompanyName() {
               	return companyName;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCompanyName(string companyName) {
     	         	    this.companyName = companyName;
     	        }
    
        [DataMember(Order = 2)]
    private bool? isFree;
    
        /**
       * @return 
    */
        public bool? getIsFree() {
               	return isFree;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsFree(bool isFree) {
     	         	    this.isFree = isFree;
     	        }
    
        [DataMember(Order = 3)]
    private bool? isGuaranteeSupport;
    
        /**
       * @return 
    */
        public bool? getIsGuaranteeSupport() {
               	return isGuaranteeSupport;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsGuaranteeSupport(bool isGuaranteeSupport) {
     	         	    this.isGuaranteeSupport = isGuaranteeSupport;
     	        }
    
        [DataMember(Order = 4)]
    private bool? isTP;
    
        /**
       * @return 
    */
        public bool? getIsTP() {
               	return isTP;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsTP(bool isTP) {
     	         	    this.isTP = isTP;
     	        }
    
        [DataMember(Order = 5)]
    private string memberId;
    
        /**
       * @return 
    */
        public string getMemberId() {
               	return memberId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMemberId(string memberId) {
     	         	    this.memberId = memberId;
     	        }
    
        [DataMember(Order = 6)]
    private string mobile;
    
        /**
       * @return 
    */
        public string getMobile() {
               	return mobile;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMobile(string mobile) {
     	         	    this.mobile = mobile;
     	        }
    
        [DataMember(Order = 7)]
    private string name;
    
        /**
       * @return 
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
        [DataMember(Order = 8)]
    private long? userId;
    
        /**
       * @return 
    */
        public long? getUserId() {
               	return userId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUserId(long userId) {
     	         	    this.userId = userId;
     	        }
    
    
  }
}