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
public class AlibabaLogisticsOpDeliverySendOrderDummyParam : GatewayAPIRequest {

    public AlibabaLogisticsOpDeliverySendOrderDummyParam() {
        this.ApiId = new APIId("com.alibaba.logistics", "alibaba.logistics.OpDeliverySendOrder.dummy",1);
	}
	
       [DataMember(Order = 1)]
    private AlibabaLogisticsOpSendGood[] sendGoods;
    
        /**
       * @return 发货对象列表
    */
        public AlibabaLogisticsOpSendGood[] getSendGoods() {
               	return sendGoods;
            }
    
    /**
     * 设置发货对象列表     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setSendGoods(AlibabaLogisticsOpSendGood[] sendGoods) {
     	         	    this.sendGoods = sendGoods;
     	        }
    
        [DataMember(Order = 2)]
    private string remarks;
    
        /**
       * @return 备注
    */
        public string getRemarks() {
               	return remarks;
            }
    
    /**
     * 设置备注     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setRemarks(string remarks) {
     	         	    this.remarks = remarks;
     	        }
    
        [DataMember(Order = 3)]
    private string gmtSend;
    
        /**
       * @return 发货时间
    */
        public DateTime? getGmtSend() {
                 if (gmtSend != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtSend);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置发货时间     *
     * 参数示例：<pre>标准时间格式：yyyyMMddHHmmssSSSZ，例如：20120801154220368+0800</pre>     
             * 此参数必填
          */
    public void setGmtSend(DateTime gmtSend) {
     	         	    this.gmtSend = DateUtil.format(gmtSend);
     	        }
    
        [DataMember(Order = 4)]
    private string extBody;
    
        /**
       * @return JSON字符串,extBodyJson中的noLogisticsCondition必填，取值字符串0到5：“0”：历史无需物流的订单；“1”：其他第三方物流、小型物充商、车队等（noLogisticsName、noLogisticsTel必填）；“2”：补运费、差价（noLogisticsBillNo必填）；“3”：卖家配送（noLogisticsName、noLogisticsTel必填）；“4”：买家自提；“5”：其他原因（remarks必填）。其他字段根据noLogisticsCondition的值不同，必填要求不同。字段说明：无需物流原因:noLogisticsCondition;无需物流名称:noLogisticsName;无需物流电话:noLogisticsTel;无需物流单号，不同的无需物流原因，该字段解释不同:noLogisticsBillNo。
    */
        public string getExtBody() {
               	return extBody;
            }
    
    /**
     * 设置JSON字符串,extBodyJson中的noLogisticsCondition必填，取值字符串0到5：“0”：历史无需物流的订单；“1”：其他第三方物流、小型物充商、车队等（noLogisticsName、noLogisticsTel必填）；“2”：补运费、差价（noLogisticsBillNo必填）；“3”：卖家配送（noLogisticsName、noLogisticsTel必填）；“4”：买家自提；“5”：其他原因（remarks必填）。其他字段根据noLogisticsCondition的值不同，必填要求不同。字段说明：无需物流原因:noLogisticsCondition;无需物流名称:noLogisticsName;无需物流电话:noLogisticsTel;无需物流单号，不同的无需物流原因，该字段解释不同:noLogisticsBillNo。     *
     * 参数示例：<pre>{"noLogisticsBillNo":"111111111111111111","noLogisticsCondition":"3","noLogisticsName":"张三","noLogisticsTel":"13999999999"}</pre>     
             * 此参数必填
          */
    public void setExtBody(string extBody) {
     	         	    this.extBody = extBody;
     	        }
    
        [DataMember(Order = 5)]
    private string extParam;
    
        /**
       * @return {}
    */
        public string getExtParam() {
               	return extParam;
            }
    
    /**
     * 设置{}     *
     * 参数示例：<pre>JSON 字符串</pre>     
             * 此参数必填
          */
    public void setExtParam(string extParam) {
     	         	    this.extParam = extParam;
     	        }
    
        [DataMember(Order = 6)]
    private AlibabaLogisticsOpReceiveContacter receiverInfo;
    
        /**
       * @return 收货地址
    */
        public AlibabaLogisticsOpReceiveContacter getReceiverInfo() {
               	return receiverInfo;
            }
    
    /**
     * 设置收货地址     *
     * 参数示例：<pre>优先级大于订单收货地址，为空时，使用订单收货地址</pre>     
             * 此参数必填
          */
    public void setReceiverInfo(AlibabaLogisticsOpReceiveContacter receiverInfo) {
     	         	    this.receiverInfo = receiverInfo;
     	        }
    
    
  }
}