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
public class AlibabaPreOrderGetListResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaPreOrderInfo[] orderList;
    
        /**
       * @return 预订单列表
    */
        public AlibabaPreOrderInfo[] getOrderList() {
               	return orderList;
            }
    
    /**
     * 设置预订单列表     *
          
             * 此参数必填
          */
    public void setOrderList(AlibabaPreOrderInfo[] orderList) {
     	         	    this.orderList = orderList;
     	        }
    
        [DataMember(Order = 2)]
    private bool? success;
    
        /**
       * @return 是否成功
    */
        public bool? getSuccess() {
               	return success;
            }
    
    /**
     * 设置是否成功     *
          
             * 此参数必填
          */
    public void setSuccess(bool success) {
     	         	    this.success = success;
     	        }
    
        [DataMember(Order = 3)]
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
    
        [DataMember(Order = 4)]
    private string errorMsg;
    
        /**
       * @return 错误信息
    */
        public string getErrorMsg() {
               	return errorMsg;
            }
    
    /**
     * 设置错误信息     *
          
             * 此参数必填
          */
    public void setErrorMsg(string errorMsg) {
     	         	    this.errorMsg = errorMsg;
     	        }
    
        [DataMember(Order = 5)]
    private int? totalCount;
    
        /**
       * @return 总数量
    */
        public int? getTotalCount() {
               	return totalCount;
            }
    
    /**
     * 设置总数量     *
          
             * 此参数必填
          */
    public void setTotalCount(int totalCount) {
     	         	    this.totalCount = totalCount;
     	        }
    
        [DataMember(Order = 6)]
    private int? pageIndex;
    
        /**
       * @return 当前页码
    */
        public int? getPageIndex() {
               	return pageIndex;
            }
    
    /**
     * 设置当前页码     *
          
             * 此参数必填
          */
    public void setPageIndex(int pageIndex) {
     	         	    this.pageIndex = pageIndex;
     	        }
    
    
  }
}