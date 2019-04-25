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
public class AlibabaPaymentPayChannel {

       [DataMember(Order = 1)]
    private string errorCode;
    
        /**
       * @return 
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 2)]
    private bool? isAvaliable;
    
        /**
       * @return 
    */
        public bool? getIsAvaliable() {
               	return isAvaliable;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsAvaliable(bool isAvaliable) {
     	         	    this.isAvaliable = isAvaliable;
     	        }
    
        [DataMember(Order = 3)]
    private bool? isNeedBuyerSign;
    
        /**
       * @return 
    */
        public bool? getIsNeedBuyerSign() {
               	return isNeedBuyerSign;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsNeedBuyerSign(bool isNeedBuyerSign) {
     	         	    this.isNeedBuyerSign = isNeedBuyerSign;
     	        }
    
        [DataMember(Order = 4)]
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
    
    
  }
}