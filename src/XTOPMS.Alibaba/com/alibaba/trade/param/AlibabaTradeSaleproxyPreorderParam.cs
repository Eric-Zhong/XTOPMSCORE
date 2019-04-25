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
public class AlibabaTradeSaleproxyPreorderParam : GatewayAPIRequest {

    public AlibabaTradeSaleproxyPreorderParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.saleproxy.preorder",1);
	}
	
       [DataMember(Order = 1)]
    private AlibabaTradeGoodsInfo[] goods;
    
        /**
       * @return 购买的货物列表
    */
        public AlibabaTradeGoodsInfo[] getGoods() {
               	return goods;
            }
    
    /**
     * 设置购买的货物列表     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setGoods(AlibabaTradeGoodsInfo[] goods) {
     	         	    this.goods = goods;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaTradeReceiveAddress receiveAddress;
    
        /**
       * @return 收货地址，可以填写买家的收货地址ID，或者买家的收货地址信息
    */
        public AlibabaTradeReceiveAddress getReceiveAddress() {
               	return receiveAddress;
            }
    
    /**
     * 设置收货地址，可以填写买家的收货地址ID，或者买家的收货地址信息     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setReceiveAddress(AlibabaTradeReceiveAddress receiveAddress) {
     	         	    this.receiveAddress = receiveAddress;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaTradeComKeyValuePair[] extension;
    
        /**
       * @return 扩展信息
    */
        public AlibabaTradeComKeyValuePair[] getExtension() {
               	return extension;
            }
    
    /**
     * 设置扩展信息     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setExtension(AlibabaTradeComKeyValuePair[] extension) {
     	         	    this.extension = extension;
     	        }
    
    
  }
}