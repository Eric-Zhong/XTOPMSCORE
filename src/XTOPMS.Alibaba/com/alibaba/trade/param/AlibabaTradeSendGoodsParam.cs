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
public class AlibabaTradeSendGoodsParam : GatewayAPIRequest {

    public AlibabaTradeSendGoodsParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.sendGoods",1);
	}
	
       [DataMember(Order = 1)]
    private string webSite;
    
        /**
       * @return 站点信息，指定调用的API是属于国际站（alibaba）还是1688网站（1688）
    */
        public string getWebSite() {
               	return webSite;
            }
    
    /**
     * 设置站点信息，指定调用的API是属于国际站（alibaba）还是1688网站（1688）     *
     * 参数示例：<pre>1688</pre>     
             * 此参数必填
          */
    public void setWebSite(string webSite) {
     	         	    this.webSite = webSite;
     	        }
    
        [DataMember(Order = 2)]
    private string orderId;
    
        /**
       * @return 订单ID
    */
        public string getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置订单ID     *
     * 参数示例：<pre>123423</pre>     
             * 此参数必填
          */
    public void setOrderId(string orderId) {
     	         	    this.orderId = orderId;
     	        }
    
        [DataMember(Order = 3)]
    private string orderEntryIds;
    
        /**
       * @return 订单明细ID, 多个明细请用英文逗号分隔
    */
        public string getOrderEntryIds() {
               	return orderEntryIds;
            }
    
    /**
     * 设置订单明细ID, 多个明细请用英文逗号分隔     *
     * 参数示例：<pre>13234,1233</pre>     
             * 此参数必填
          */
    public void setOrderEntryIds(string orderEntryIds) {
     	         	    this.orderEntryIds = orderEntryIds;
     	        }
    
        [DataMember(Order = 4)]
    private string remarks;
    
        /**
       * @return 用户备注
    */
        public string getRemarks() {
               	return remarks;
            }
    
    /**
     * 设置用户备注     *
     * 参数示例：<pre>发货备注</pre>     
             * 此参数必填
          */
    public void setRemarks(string remarks) {
     	         	    this.remarks = remarks;
     	        }
    
        [DataMember(Order = 5)]
    private string logisticsCompanyId;
    
        /**
       * @return 物流公司ID
    */
        public string getLogisticsCompanyId() {
               	return logisticsCompanyId;
            }
    
    /**
     * 设置物流公司ID     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setLogisticsCompanyId(string logisticsCompanyId) {
     	         	    this.logisticsCompanyId = logisticsCompanyId;
     	        }
    
        [DataMember(Order = 6)]
    private string selfCompanyName;
    
        /**
       * @return logisticsCompanyId=8时，这个字段必填，需要填写其他的物流公司名称
    */
        public string getSelfCompanyName() {
               	return selfCompanyName;
            }
    
    /**
     * 设置logisticsCompanyId=8时，这个字段必填，需要填写其他的物流公司名称     *
     * 参数示例：<pre>物流公司名字</pre>     
             * 此参数必填
          */
    public void setSelfCompanyName(string selfCompanyName) {
     	         	    this.selfCompanyName = selfCompanyName;
     	        }
    
        [DataMember(Order = 7)]
    private string logisticsBillNo;
    
        /**
       * @return 物流公司运单号
    */
        public string getLogisticsBillNo() {
               	return logisticsBillNo;
            }
    
    /**
     * 设置物流公司运单号     *
     * 参数示例：<pre>123234234234</pre>     
             * 此参数必填
          */
    public void setLogisticsBillNo(string logisticsBillNo) {
     	         	    this.logisticsBillNo = logisticsBillNo;
     	        }
    
        [DataMember(Order = 8)]
    private string gmtSystemSend;
    
        /**
       * @return 系统发货时间
    */
        public string getGmtSystemSend() {
               	return gmtSystemSend;
            }
    
    /**
     * 设置系统发货时间     *
     * 参数示例：<pre>2012-04-13 09:38:00</pre>     
             * 此参数必填
          */
    public void setGmtSystemSend(string gmtSystemSend) {
     	         	    this.gmtSystemSend = gmtSystemSend;
     	        }
    
        [DataMember(Order = 9)]
    private string gmtLogisticsCompanySend;
    
        /**
       * @return 卖家发货时间
    */
        public string getGmtLogisticsCompanySend() {
               	return gmtLogisticsCompanySend;
            }
    
    /**
     * 设置卖家发货时间     *
     * 参数示例：<pre>2012-04-13 09:38:00</pre>     
             * 此参数必填
          */
    public void setGmtLogisticsCompanySend(string gmtLogisticsCompanySend) {
     	         	    this.gmtLogisticsCompanySend = gmtLogisticsCompanySend;
     	        }
    
    
  }
}