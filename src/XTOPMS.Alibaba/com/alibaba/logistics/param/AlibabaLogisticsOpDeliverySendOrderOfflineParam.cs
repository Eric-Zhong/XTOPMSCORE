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
public class AlibabaLogisticsOpDeliverySendOrderOfflineParam : GatewayAPIRequest {

    public AlibabaLogisticsOpDeliverySendOrderOfflineParam() {
        this.ApiId = new APIId("com.alibaba.logistics", "alibaba.logistics.OpDeliverySendOrder.offline",1);
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
       * @return JSON字符串，cpCode 为物流公司code，对应物流公司信息获取接口的companyNo（非数字Id）; logisticsCpName:物流公司名称，对应物流公司信息获取接口的companyName； mailNo：运单号； 可以通过获取 "物流公司列表-自联物流" 接口查询到数据。
    */
        public string getExtBody() {
               	return extBody;
            }
    
    /**
     * 设置JSON字符串，cpCode 为物流公司code，对应物流公司信息获取接口的companyNo（非数字Id）; logisticsCpName:物流公司名称，对应物流公司信息获取接口的companyName； mailNo：运单号； 可以通过获取 "物流公司列表-自联物流" 接口查询到数据。     *
     * 参数示例：<pre>{"cpCode":"SF","logisticsCpName":"顺丰","mailNo":"a123"}</pre>     
             * 此参数必填
          */
    public void setExtBody(string extBody) {
     	         	    this.extBody = extBody;
     	        }
    
        [DataMember(Order = 5)]
    private string extParam;
    
        /**
       * @return JSON 字符串
    */
        public string getExtParam() {
               	return extParam;
            }
    
    /**
     * 设置JSON 字符串     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setExtParam(string extParam) {
     	         	    this.extParam = extParam;
     	        }
    
        [DataMember(Order = 6)]
    private AlibabaLogisticsOpReceiveContacter receiverInfo;
    
        /**
       * @return 收货地址,优先级大于订单收货地址，为空时，使用订单收货地址
    */
        public AlibabaLogisticsOpReceiveContacter getReceiverInfo() {
               	return receiverInfo;
            }
    
    /**
     * 设置收货地址,优先级大于订单收货地址，为空时，使用订单收货地址     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setReceiverInfo(AlibabaLogisticsOpReceiveContacter receiverInfo) {
     	         	    this.receiverInfo = receiverInfo;
     	        }
    
    
  }
}