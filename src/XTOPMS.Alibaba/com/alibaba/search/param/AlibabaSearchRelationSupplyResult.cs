using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.search.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaSearchRelationSupplyResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaSearchRelationAccountInfo[] result;
    
        /**
       * @return 返回的卖家信息
    */
        public AlibabaSearchRelationAccountInfo[] getResult() {
               	return result;
            }
    
    /**
     * 设置返回的卖家信息     *
          
             * 此参数必填
          */
    public void setResult(AlibabaSearchRelationAccountInfo[] result) {
     	         	    this.result = result;
     	        }
    
        [DataMember(Order = 2)]
    private string errorCode;
    
        /**
       * @return 错误code
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置错误code     *
          
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 3)]
    private string errorMessage;
    
        /**
       * @return 错误描述
    */
        public string getErrorMessage() {
               	return errorMessage;
            }
    
    /**
     * 设置错误描述     *
          
             * 此参数必填
          */
    public void setErrorMessage(string errorMessage) {
     	         	    this.errorMessage = errorMessage;
     	        }
    
        [DataMember(Order = 4)]
    private int? pageNum;
    
        /**
       * @return 页数
    */
        public int? getPageNum() {
               	return pageNum;
            }
    
    /**
     * 设置页数     *
          
             * 此参数必填
          */
    public void setPageNum(int pageNum) {
     	         	    this.pageNum = pageNum;
     	        }
    
        [DataMember(Order = 5)]
    private int? pageSize;
    
        /**
       * @return 每页返回数
    */
        public int? getPageSize() {
               	return pageSize;
            }
    
    /**
     * 设置每页返回数     *
          
             * 此参数必填
          */
    public void setPageSize(int pageSize) {
     	         	    this.pageSize = pageSize;
     	        }
    
        [DataMember(Order = 6)]
    private long? totalRecords;
    
        /**
       * @return 总记录数
    */
        public long? getTotalRecords() {
               	return totalRecords;
            }
    
    /**
     * 设置总记录数     *
          
             * 此参数必填
          */
    public void setTotalRecords(long totalRecords) {
     	         	    this.totalRecords = totalRecords;
     	        }
    
    
  }
}