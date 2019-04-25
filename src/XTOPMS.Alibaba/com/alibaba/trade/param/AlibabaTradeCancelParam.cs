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
public class AlibabaTradeCancelParam : GatewayAPIRequest {

    public AlibabaTradeCancelParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.cancel",1);
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
    private long? tradeID;
    
        /**
       * @return 交易id，订单号
    */
        public long? getTradeID() {
               	return tradeID;
            }
    
    /**
     * 设置交易id，订单号     *
     * 参数示例：<pre>123456</pre>     
             * 此参数必填
          */
    public void setTradeID(long tradeID) {
     	         	    this.tradeID = tradeID;
     	        }
    
        [DataMember(Order = 3)]
    private string cancelReason;
    
        /**
       * @return 原因描述；buyerCancel:买家取消订单;sellerGoodsLack:卖家库存不足;other:其它
    */
        public string getCancelReason() {
               	return cancelReason;
            }
    
    /**
     * 设置原因描述；buyerCancel:买家取消订单;sellerGoodsLack:卖家库存不足;other:其它     *
     * 参数示例：<pre>other</pre>     
             * 此参数必填
          */
    public void setCancelReason(string cancelReason) {
     	         	    this.cancelReason = cancelReason;
     	        }
    
        [DataMember(Order = 4)]
    private string remark;
    
        /**
       * @return 备注
    */
        public string getRemark() {
               	return remark;
            }
    
    /**
     * 设置备注     *
     * 参数示例：<pre>备注</pre>     
             * 此参数必填
          */
    public void setRemark(string remark) {
     	         	    this.remark = remark;
     	        }
    
    
  }
}