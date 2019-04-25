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
public class AlibabaOrderMemoAddParam : GatewayAPIRequest {

    public AlibabaOrderMemoAddParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.order.memoAdd",1);
	}
	
       [DataMember(Order = 1)]
    private long? orderId;
    
        /**
       * @return 订单ID
    */
        public long? getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置订单ID     *
     * 参数示例：<pre>1234567</pre>     
             * 此参数必填
          */
    public void setOrderId(long orderId) {
     	         	    this.orderId = orderId;
     	        }
    
        [DataMember(Order = 2)]
    private string memo;
    
        /**
       * @return 备忘信息
    */
        public string getMemo() {
               	return memo;
            }
    
    /**
     * 设置备忘信息     *
     * 参数示例：<pre>订单备忘详情</pre>     
             * 此参数必填
          */
    public void setMemo(string memo) {
     	         	    this.memo = memo;
     	        }
    
        [DataMember(Order = 3)]
    private string remarkIcon;
    
        /**
       * @return 备忘图标，目前仅支持数字。1位红色图标，2为蓝色图标，3为绿色图标，4为黄色图标
    */
        public string getRemarkIcon() {
               	return remarkIcon;
            }
    
    /**
     * 设置备忘图标，目前仅支持数字。1位红色图标，2为蓝色图标，3为绿色图标，4为黄色图标     *
     * 参数示例：<pre>2</pre>     
             * 此参数必填
          */
    public void setRemarkIcon(string remarkIcon) {
     	         	    this.remarkIcon = remarkIcon;
     	        }
    
    
  }
}