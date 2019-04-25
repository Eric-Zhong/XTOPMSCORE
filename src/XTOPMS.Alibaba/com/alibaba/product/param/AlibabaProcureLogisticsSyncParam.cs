using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.product.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProcureLogisticsSyncParam : GatewayAPIRequest {

    public AlibabaProcureLogisticsSyncParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.procure.logistics.sync",1);
	}
	
       [DataMember(Order = 1)]
    private long? orderId;
    
        /**
       * @return 订单号
    */
        public long? getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置订单号     *
     * 参数示例：<pre>123456789</pre>     
             * 此参数必填
          */
    public void setOrderId(long orderId) {
     	         	    this.orderId = orderId;
     	        }
    
        [DataMember(Order = 2)]
    private string actionCode;
    
        /**
       * @return 节点动作code
    */
        public string getActionCode() {
               	return actionCode;
            }
    
    /**
     * 设置节点动作code     *
     * 参数示例：<pre>WMS_PACKAGE_ACCEPT</pre>     
             * 此参数必填
          */
    public void setActionCode(string actionCode) {
     	         	    this.actionCode = actionCode;
     	        }
    
        [DataMember(Order = 3)]
    private long? actionTime;
    
        /**
       * @return 处理时间，系统毫秒数
    */
        public long? getActionTime() {
               	return actionTime;
            }
    
    /**
     * 设置处理时间，系统毫秒数     *
     * 参数示例：<pre>1547536027868</pre>     
             * 此参数必填
          */
    public void setActionTime(long actionTime) {
     	         	    this.actionTime = actionTime;
     	        }
    
        [DataMember(Order = 4)]
    private int? actionType;
    
        /**
       * @return 处理类型， 枚举
    */
        public int? getActionType() {
               	return actionType;
            }
    
    /**
     * 设置处理类型， 枚举     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setActionType(int actionType) {
     	         	    this.actionType = actionType;
     	        }
    
        [DataMember(Order = 5)]
    private string ext;
    
        /**
       * @return 扩展信息， json格式
    */
        public string getExt() {
               	return ext;
            }
    
    /**
     * 设置扩展信息， json格式     *
     * 参数示例：<pre>{ 	"facilityName": "cn", 	"courierName": "EMS", 	"shipmentId": "123456789", 	"weight": "-1", 	"length": "-1", 	"height": "-1", 	"rejectReason": "1" }</pre>     
             * 此参数必填
          */
    public void setExt(string ext) {
     	         	    this.ext = ext;
     	        }
    
        [DataMember(Order = 6)]
    private string obUid;
    
        /**
       * @return 海外小b用户id，多个用户用逗号分隔
    */
        public string getObUid() {
               	return obUid;
            }
    
    /**
     * 设置海外小b用户id，多个用户用逗号分隔     *
     * 参数示例：<pre>th123456789</pre>     
             * 此参数必填
          */
    public void setObUid(string obUid) {
     	         	    this.obUid = obUid;
     	        }
    
    
  }
}