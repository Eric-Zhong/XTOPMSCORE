using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.logistics.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaBulksettlementOpBulkSettlementQueryReceiveNoteListParam : GatewayAPIRequest {

    public AlibabaBulksettlementOpBulkSettlementQueryReceiveNoteListParam() {
        this.ApiId = new APIId("com.alibaba.logistics", "alibaba.bulksettlement.OpBulkSettlementQueryReceiveNoteList",1);
	}
	
       [DataMember(Order = 1)]
    private string sellerCompanyName;
    
        /**
       * @return 卖家公司名称
    */
        public string getSellerCompanyName() {
               	return sellerCompanyName;
            }
    
    /**
     * 设置卖家公司名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerCompanyName(string sellerCompanyName) {
     	         	    this.sellerCompanyName = sellerCompanyName;
     	        }
    
        [DataMember(Order = 2)]
    private int? pageSize;
    
        /**
       * @return 搜索起始行(从第几个搜索结果开始返回,从0开始)
    */
        public int? getPageSize() {
               	return pageSize;
            }
    
    /**
     * 设置搜索起始行(从第几个搜索结果开始返回,从0开始)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPageSize(int pageSize) {
     	         	    this.pageSize = pageSize;
     	        }
    
        [DataMember(Order = 3)]
    private string purchaseCompanyName;
    
        /**
       * @return 采购公司名称
    */
        public string getPurchaseCompanyName() {
               	return purchaseCompanyName;
            }
    
    /**
     * 设置采购公司名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPurchaseCompanyName(string purchaseCompanyName) {
     	         	    this.purchaseCompanyName = purchaseCompanyName;
     	        }
    
        [DataMember(Order = 4)]
    private byte? isSuccess;
    
        /**
       * @return 是否正常创建
    */
        public byte? getIsSuccess() {
               	return isSuccess;
            }
    
    /**
     * 设置是否正常创建     *
     * 参数示例：<pre>1 正常 0 不正常</pre>     
             * 此参数必填
          */
    public void setIsSuccess(byte isSuccess) {
     	         	    this.isSuccess = isSuccess;
     	        }
    
        [DataMember(Order = 5)]
    private long? operatorUserId;
    
        /**
       * @return 收货操作者userId 子账号有自己的userId，没有自己的memberId
    */
        public long? getOperatorUserId() {
               	return operatorUserId;
            }
    
    /**
     * 设置收货操作者userId 子账号有自己的userId，没有自己的memberId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOperatorUserId(long operatorUserId) {
     	         	    this.operatorUserId = operatorUserId;
     	        }
    
        [DataMember(Order = 6)]
    private string statusInfo;
    
        /**
       * @return 收货主单状态
    */
        public string getStatusInfo() {
               	return statusInfo;
            }
    
    /**
     * 设置收货主单状态     *
     * 参数示例：<pre>1 待发起结算 2全部已发起结算</pre>     
             * 此参数必填
          */
    public void setStatusInfo(string statusInfo) {
     	         	    this.statusInfo = statusInfo;
     	        }
    
        [DataMember(Order = 7)]
    private string receiveStartTime;
    
        /**
       * @return 收货开始时间
    */
        public DateTime? getReceiveStartTime() {
                 if (receiveStartTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(receiveStartTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置收货开始时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiveStartTime(DateTime receiveStartTime) {
     	         	    this.receiveStartTime = DateUtil.format(receiveStartTime);
     	        }
    
        [DataMember(Order = 8)]
    private string receiveEndTime;
    
        /**
       * @return 收货结束时间
    */
        public DateTime? getReceiveEndTime() {
                 if (receiveEndTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(receiveEndTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置收货结束时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiveEndTime(DateTime receiveEndTime) {
     	         	    this.receiveEndTime = DateUtil.format(receiveEndTime);
     	        }
    
        [DataMember(Order = 9)]
    private int? pageNo;
    
        /**
       * @return 页码，从1开始
    */
        public int? getPageNo() {
               	return pageNo;
            }
    
    /**
     * 设置页码，从1开始     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPageNo(int pageNo) {
     	         	    this.pageNo = pageNo;
     	        }
    
        [DataMember(Order = 10)]
    private int? startRow;
    
        /**
       * @return 
    */
        public int? getStartRow() {
               	return startRow;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStartRow(int startRow) {
     	         	    this.startRow = startRow;
     	        }
    
        [DataMember(Order = 11)]
    private string buyerLoginId;
    
        /**
       * @return 
    */
        public string getBuyerLoginId() {
               	return buyerLoginId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerLoginId(string buyerLoginId) {
     	         	    this.buyerLoginId = buyerLoginId;
     	        }
    
        [DataMember(Order = 12)]
    private string orderId;
    
        /**
       * @return 主订单ID
    */
        public string getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置主订单ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderId(string orderId) {
     	         	    this.orderId = orderId;
     	        }
    
    
  }
}