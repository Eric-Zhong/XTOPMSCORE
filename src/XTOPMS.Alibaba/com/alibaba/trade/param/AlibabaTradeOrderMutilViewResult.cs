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
public class AlibabaTradeOrderMutilViewResult {

       [DataMember(Order = 1)]
    private AlibabaTradeSimpleBuyer buyer;
    
        /**
       * @return 
    */
        public AlibabaTradeSimpleBuyer getBuyer() {
               	return buyer;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyer(AlibabaTradeSimpleBuyer buyer) {
     	         	    this.buyer = buyer;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaTradeOrderViewModel[] orderModels;
    
        /**
       * @return 
    */
        public AlibabaTradeOrderViewModel[] getOrderModels() {
               	return orderModels;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderModels(AlibabaTradeOrderViewModel[] orderModels) {
     	         	    this.orderModels = orderModels;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaTradeReceiveAddress receiveAddress;
    
        /**
       * @return 
    */
        public AlibabaTradeReceiveAddress getReceiveAddress() {
               	return receiveAddress;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiveAddress(AlibabaTradeReceiveAddress receiveAddress) {
     	         	    this.receiveAddress = receiveAddress;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaTradeResultCodeDef resultCode;
    
        /**
       * @return 
    */
        public AlibabaTradeResultCodeDef getResultCode() {
               	return resultCode;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setResultCode(AlibabaTradeResultCodeDef resultCode) {
     	         	    this.resultCode = resultCode;
     	        }
    
    
  }
}