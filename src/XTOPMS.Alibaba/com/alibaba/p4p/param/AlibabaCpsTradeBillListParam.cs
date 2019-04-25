using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.p4p.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaCpsTradeBillListParam : GatewayAPIRequest {

    public AlibabaCpsTradeBillListParam() {
        this.ApiId = new APIId("com.alibaba.p4p", "alibaba.cps.tradeBillList",1);
	}
	
       [DataMember(Order = 1)]
    private string queryOrderType;
    
        /**
       * @return 订单状态查询类型
    */
        public string getQueryOrderType() {
               	return queryOrderType;
            }
    
    /**
     * 设置订单状态查询类型     *
     * 参数示例：<pre>全部订单:orderAll
订单结算:orderSettle
 订单付款:orderPay</pre>     
             * 此参数必填
          */
    public void setQueryOrderType(string queryOrderType) {
     	         	    this.queryOrderType = queryOrderType;
     	        }
    
        [DataMember(Order = 2)]
    private string queryTimeType;
    
        /**
       * @return 订单时间查询类型
    */
        public string getQueryTimeType() {
               	return queryTimeType;
            }
    
    /**
     * 设置订单时间查询类型     *
     * 参数示例：<pre>*1.0 订单创建时间查询类型:gmtCreateTime(订单创建)
* 1.1 订单成功时间查询类型:confirmTime(订单成功)
     * 1.2 订单结算时间查询类型:settleTime(订单结算)
     * 2.1 维权创建时间查询类型:rightsStartTime
     * 2.2 维权完成时间查询类型:rightsEndTime
     * 3   订单结算时间查询类型:settleTime</pre>     
             * 此参数必填
          */
    public void setQueryTimeType(string queryTimeType) {
     	         	    this.queryTimeType = queryTimeType;
     	        }
    
        [DataMember(Order = 3)]
    private string queryStartTime;
    
        /**
       * @return 查询开始时间
    */
        public string getQueryStartTime() {
               	return queryStartTime;
            }
    
    /**
     * 设置查询开始时间     *
     * 参数示例：<pre>2017-12-01</pre>     
             * 此参数必填
          */
    public void setQueryStartTime(string queryStartTime) {
     	         	    this.queryStartTime = queryStartTime;
     	        }
    
        [DataMember(Order = 4)]
    private string queryEndTime;
    
        /**
       * @return 查询结束时间
    */
        public string getQueryEndTime() {
               	return queryEndTime;
            }
    
    /**
     * 设置查询结束时间     *
     * 参数示例：<pre>2017-12-31</pre>     
             * 此参数必填
          */
    public void setQueryEndTime(string queryEndTime) {
     	         	    this.queryEndTime = queryEndTime;
     	        }
    
        [DataMember(Order = 5)]
    private int? orderState;
    
        /**
       * @return 订单状态
    */
        public int? getOrderState() {
               	return orderState;
            }
    
    /**
     * 设置订单状态     *
     * 参数示例：<pre>订单创建10;已付款20;交易成功50;交易关闭80</pre>     
             * 此参数必填
          */
    public void setOrderState(int orderState) {
     	         	    this.orderState = orderState;
     	        }
    
        [DataMember(Order = 6)]
    private int? settleState;
    
        /**
       * @return 结算状态
    */
        public int? getSettleState() {
               	return settleState;
            }
    
    /**
     * 设置结算状态     *
     * 参数示例：<pre>1结算成功状态;2结算失败状态</pre>     
             * 此参数必填
          */
    public void setSettleState(int settleState) {
     	         	    this.settleState = settleState;
     	        }
    
        [DataMember(Order = 7)]
    private int? rightsState;
    
        /**
       * @return 维权状态
    */
        public int? getRightsState() {
               	return rightsState;
            }
    
    /**
     * 设置维权状态     *
     * 参数示例：<pre>10维权中;30维权成功;40退款关闭</pre>     
             * 此参数必填
          */
    public void setRightsState(int rightsState) {
     	         	    this.rightsState = rightsState;
     	        }
    
        [DataMember(Order = 8)]
    private int? pageNo;
    
        /**
       * @return 页偏移量
    */
        public int? getPageNo() {
               	return pageNo;
            }
    
    /**
     * 设置页偏移量     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setPageNo(int pageNo) {
     	         	    this.pageNo = pageNo;
     	        }
    
        [DataMember(Order = 9)]
    private int? pageSize;
    
        /**
       * @return 页大小
    */
        public int? getPageSize() {
               	return pageSize;
            }
    
    /**
     * 设置页大小     *
     * 参数示例：<pre>100</pre>     
             * 此参数必填
          */
    public void setPageSize(int pageSize) {
     	         	    this.pageSize = pageSize;
     	        }
    
    
  }
}