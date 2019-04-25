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
public class AlibabaTradeQuotationOrderCreateResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaOpenplatformTradeResultTradeCreateGeneralOrderResult orderResult;
    
        /**
       * @return 订单创建结果
    */
        public AlibabaOpenplatformTradeResultTradeCreateGeneralOrderResult getOrderResult() {
               	return orderResult;
            }
    
    /**
     * 设置订单创建结果     *
          
             * 此参数必填
          */
    public void setOrderResult(AlibabaOpenplatformTradeResultTradeCreateGeneralOrderResult orderResult) {
     	         	    this.orderResult = orderResult;
     	        }
    
        [DataMember(Order = 2)]
    private string errorCode;
    
        /**
       * @return 错误码
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置错误码     *
          
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 3)]
    private string errorMessage;
    
        /**
       * @return 错误信息
    */
        public string getErrorMessage() {
               	return errorMessage;
            }
    
    /**
     * 设置错误信息     *
          
             * 此参数必填
          */
    public void setErrorMessage(string errorMessage) {
     	         	    this.errorMessage = errorMessage;
     	        }
    
    
  }
}