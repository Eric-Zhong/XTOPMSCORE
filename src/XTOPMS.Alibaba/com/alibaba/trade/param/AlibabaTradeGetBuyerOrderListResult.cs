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
public class AlibabaTradeGetBuyerOrderListResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaOpenplatformTradeModelTradeInfo[] result;
    
        /**
       * @return 查询返回列表
    */
        public AlibabaOpenplatformTradeModelTradeInfo[] getResult() {
               	return result;
            }
    
    /**
     * 设置查询返回列表     *
          
             * 此参数必填
          */
    public void setResult(AlibabaOpenplatformTradeModelTradeInfo[] result) {
     	         	    this.result = result;
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
    
        [DataMember(Order = 4)]
    private long? totalRecord;
    
        /**
       * @return 总记录数
    */
        public long? getTotalRecord() {
               	return totalRecord;
            }
    
    /**
     * 设置总记录数     *
          
             * 此参数必填
          */
    public void setTotalRecord(long totalRecord) {
     	         	    this.totalRecord = totalRecord;
     	        }
    
    
  }
}