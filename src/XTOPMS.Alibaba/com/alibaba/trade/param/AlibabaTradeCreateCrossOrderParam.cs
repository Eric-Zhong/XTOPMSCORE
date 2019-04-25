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
public class AlibabaTradeCreateCrossOrderParam : GatewayAPIRequest {

    public AlibabaTradeCreateCrossOrderParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.createCrossOrder",1);
	}
	
       [DataMember(Order = 1)]
    private string flow;
    
        /**
       * @return 流程
    */
        public string getFlow() {
               	return flow;
            }
    
    /**
     * 设置流程     *
     * 参数示例：<pre>general（创建大市场订单），saleproxy（创建分销订单）</pre>     
             * 此参数必填
          */
    public void setFlow(string flow) {
     	         	    this.flow = flow;
     	        }
    
        [DataMember(Order = 2)]
    private string message;
    
        /**
       * @return 买家留言
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置买家留言     *
     * 参数示例：<pre>留言</pre>     
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaTradeFastAddress addressParam;
    
        /**
       * @return 收货地址信息
    */
        public AlibabaTradeFastAddress getAddressParam() {
               	return addressParam;
            }
    
    /**
     * 设置收货地址信息     *
     * 参数示例：<pre>{"address":"网商路699号","phone": "0517-88990077","mobile": "15251667788","fullName": "张三","postCode": "000000","areaText": "滨江区","townText": "","cityText": "杭州市","provinceText": "浙江省"}</pre>     
             * 此参数必填
          */
    public void setAddressParam(AlibabaTradeFastAddress addressParam) {
     	         	    this.addressParam = addressParam;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaTradeFastCargo[] cargoParamList;
    
        /**
       * @return 商品信息
    */
        public AlibabaTradeFastCargo[] getCargoParamList() {
               	return cargoParamList;
            }
    
    /**
     * 设置商品信息     *
     * 参数示例：<pre>[{"specId": "b266e0726506185beaf205cbae88530d","quantity": 5,"offerId": 554456348334},{"specId": "2ba3d63866a71fbae83909d9b4814f01","quantity": 6,"offerId": 554456348334}]</pre>     
             * 此参数必填
          */
    public void setCargoParamList(AlibabaTradeFastCargo[] cargoParamList) {
     	         	    this.cargoParamList = cargoParamList;
     	        }
    
        [DataMember(Order = 5)]
    private AlibabaTradeFastInvoice invoiceParam;
    
        /**
       * @return 发票信息
    */
        public AlibabaTradeFastInvoice getInvoiceParam() {
               	return invoiceParam;
            }
    
    /**
     * 设置发票信息     *
     * 参数示例：<pre>{"invoiceType":0,"cityText": "杭州市","provinceText": "浙江省","address": "网商路699号","phone": "0517-88990077","mobile": "15251667788","fullName": "张五","postCode": "000000","areaText": "滨江区","companyName": "测试公司","taxpayerIdentifier": "123455"}</pre>     
             * 此参数必填
          */
    public void setInvoiceParam(AlibabaTradeFastInvoice invoiceParam) {
     	         	    this.invoiceParam = invoiceParam;
     	        }
    
        [DataMember(Order = 6)]
    private string tradeType;
    
        /**
       * @return 由于不同的商品支持的交易方式不同，没有一种交易方式是全局通用的，所以当前下单可使用的交易方式必须通过下单预览接口的tradeModeNameList获取。交易方式类型说明：fxassure（交易4.0通用担保交易），alipay（大市场通用的支付宝担保交易（目前在做切流，后续会下掉）），period（普通账期交易）, assure（大买家企业采购询报价下单时需要使用的担保交易流程）, creditBuy（诚E赊），bank（银行转账），631staged（631分阶段付款），37staged（37分阶段）；此字段不传则系统默认会选取一个可用的交易方式下单，默认使用的方式是支付宝担宝交易。
    */
        public string getTradeType() {
               	return tradeType;
            }
    
    /**
     * 设置由于不同的商品支持的交易方式不同，没有一种交易方式是全局通用的，所以当前下单可使用的交易方式必须通过下单预览接口的tradeModeNameList获取。交易方式类型说明：fxassure（交易4.0通用担保交易），alipay（大市场通用的支付宝担保交易（目前在做切流，后续会下掉）），period（普通账期交易）, assure（大买家企业采购询报价下单时需要使用的担保交易流程）, creditBuy（诚E赊），bank（银行转账），631staged（631分阶段付款），37staged（37分阶段）；此字段不传则系统默认会选取一个可用的交易方式下单，默认使用的方式是支付宝担宝交易。     *
     * 参数示例：<pre>fxassure</pre>     
             * 此参数必填
          */
    public void setTradeType(string tradeType) {
     	         	    this.tradeType = tradeType;
     	        }
    
        [DataMember(Order = 7)]
    private string shopPromotionId;
    
        /**
       * @return 店铺优惠ID，通过“创建订单前预览数据接口”获得。为空默认使用默认优惠
    */
        public string getShopPromotionId() {
               	return shopPromotionId;
            }
    
    /**
     * 设置店铺优惠ID，通过“创建订单前预览数据接口”获得。为空默认使用默认优惠     *
     * 参数示例：<pre>itemCoupon-5600812521_31032085284-398517001570</pre>     
             * 此参数必填
          */
    public void setShopPromotionId(string shopPromotionId) {
     	         	    this.shopPromotionId = shopPromotionId;
     	        }
    
    
  }
}