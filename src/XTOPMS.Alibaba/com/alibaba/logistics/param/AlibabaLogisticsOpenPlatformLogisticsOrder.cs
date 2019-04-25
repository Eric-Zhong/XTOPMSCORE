using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.logistics.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaLogisticsOpenPlatformLogisticsOrder {

       [DataMember(Order = 1)]
    private string logisticsId;
    
        /**
       * @return 物流信息ID
    */
        public string getLogisticsId() {
               	return logisticsId;
            }
    
    /**
     * 设置物流信息ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsId(string logisticsId) {
     	         	    this.logisticsId = logisticsId;
     	        }
    
        [DataMember(Order = 2)]
    private string logisticsBillNo;
    
        /**
       * @return 物流单号，运单号
    */
        public string getLogisticsBillNo() {
               	return logisticsBillNo;
            }
    
    /**
     * 设置物流单号，运单号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsBillNo(string logisticsBillNo) {
     	         	    this.logisticsBillNo = logisticsBillNo;
     	        }
    
        [DataMember(Order = 3)]
    private string orderEntryIds;
    
        /**
       * @return 订单号列表，无子订单的等于主订单编号，否则为对应子订单列表
    */
        public string getOrderEntryIds() {
               	return orderEntryIds;
            }
    
    /**
     * 设置订单号列表，无子订单的等于主订单编号，否则为对应子订单列表     *
     * 参数示例：<pre>129232515787615400,129232515788615400,129232515789615400,129232515790615400</pre>     
             * 此参数必填
          */
    public void setOrderEntryIds(string orderEntryIds) {
     	         	    this.orderEntryIds = orderEntryIds;
     	        }
    
        [DataMember(Order = 4)]
    private string status;
    
        /**
       * @return 物流状态。WAITACCEPT:未受理;CANCEL:已撤销;ACCEPT:已受理;TRANSPORT:运输中;NOGET:揽件失败;SIGN:已签收;UNSIGN:签收异常
    */
        public string getStatus() {
               	return status;
            }
    
    /**
     * 设置物流状态。WAITACCEPT:未受理;CANCEL:已撤销;ACCEPT:已受理;TRANSPORT:运输中;NOGET:揽件失败;SIGN:已签收;UNSIGN:签收异常     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStatus(string status) {
     	         	    this.status = status;
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
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsCompanyId(string logisticsCompanyId) {
     	         	    this.logisticsCompanyId = logisticsCompanyId;
     	        }
    
        [DataMember(Order = 6)]
    private string logisticsCompanyName;
    
        /**
       * @return 物流公司编码
    */
        public string getLogisticsCompanyName() {
               	return logisticsCompanyName;
            }
    
    /**
     * 设置物流公司编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsCompanyName(string logisticsCompanyName) {
     	         	    this.logisticsCompanyName = logisticsCompanyName;
     	        }
    
        [DataMember(Order = 7)]
    private string remarks;
    
        /**
       * @return 备注
    */
        public string getRemarks() {
               	return remarks;
            }
    
    /**
     * 设置备注     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRemarks(string remarks) {
     	         	    this.remarks = remarks;
     	        }
    
        [DataMember(Order = 8)]
    private string serviceFeature;
    
        /**
       * @return 
    */
        public string getServiceFeature() {
               	return serviceFeature;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setServiceFeature(string serviceFeature) {
     	         	    this.serviceFeature = serviceFeature;
     	        }
    
        [DataMember(Order = 9)]
    private string gmtSystemSend;
    
        /**
       * @return 
    */
        public string getGmtSystemSend() {
               	return gmtSystemSend;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGmtSystemSend(string gmtSystemSend) {
     	         	    this.gmtSystemSend = gmtSystemSend;
     	        }
    
        [DataMember(Order = 10)]
    private AlibabaLogisticsOpenPlatformLogisticsSendGood[] sendGoods;
    
        /**
       * @return 商品信息
    */
        public AlibabaLogisticsOpenPlatformLogisticsSendGood[] getSendGoods() {
               	return sendGoods;
            }
    
    /**
     * 设置商品信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSendGoods(AlibabaLogisticsOpenPlatformLogisticsSendGood[] sendGoods) {
     	         	    this.sendGoods = sendGoods;
     	        }
    
        [DataMember(Order = 11)]
    private AlibabaLogisticsOpenPlatformLogisticsReceiver receiver;
    
        /**
       * @return 收件人信息
    */
        public AlibabaLogisticsOpenPlatformLogisticsReceiver getReceiver() {
               	return receiver;
            }
    
    /**
     * 设置收件人信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiver(AlibabaLogisticsOpenPlatformLogisticsReceiver receiver) {
     	         	    this.receiver = receiver;
     	        }
    
        [DataMember(Order = 12)]
    private AlibabaLogisticsOpenPlatformLogisticsSender sender;
    
        /**
       * @return 发件人信息
    */
        public AlibabaLogisticsOpenPlatformLogisticsSender getSender() {
               	return sender;
            }
    
    /**
     * 设置发件人信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSender(AlibabaLogisticsOpenPlatformLogisticsSender sender) {
     	         	    this.sender = sender;
     	        }
    
    
  }
}