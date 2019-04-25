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
public class AlibabaTradeFastOffer {

       [DataMember(Order = 1)]
    private string offerId;
    
        /**
       * @return 下单失败的商品
    */
        public string getOfferId() {
               	return offerId;
            }
    
    /**
     * 设置下单失败的商品     *
     * 参数示例：<pre>554456348334</pre>     
             * 此参数必填
          */
    public void setOfferId(string offerId) {
     	         	    this.offerId = offerId;
     	        }
    
        [DataMember(Order = 2)]
    private string specId;
    
        /**
       * @return 下单失败商品的规格ID
    */
        public string getSpecId() {
               	return specId;
            }
    
    /**
     * 设置下单失败商品的规格ID     *
     * 参数示例：<pre>b266e0726506185beaf205cbae88530d</pre>     
             * 此参数必填
          */
    public void setSpecId(string specId) {
     	         	    this.specId = specId;
     	        }
    
        [DataMember(Order = 3)]
    private string errorCode;
    
        /**
       * @return 下单失败的错误编码
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置下单失败的错误编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 4)]
    private string errorMessage;
    
        /**
       * @return 下单失败的错误描述
    */
        public string getErrorMessage() {
               	return errorMessage;
            }
    
    /**
     * 设置下单失败的错误描述     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setErrorMessage(string errorMessage) {
     	         	    this.errorMessage = errorMessage;
     	        }
    
    
  }
}