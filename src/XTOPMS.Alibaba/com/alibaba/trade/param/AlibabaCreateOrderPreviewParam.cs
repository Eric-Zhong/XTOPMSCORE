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
public class AlibabaCreateOrderPreviewParam : GatewayAPIRequest {

    public AlibabaCreateOrderPreviewParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.createOrder.preview",1);
	}
	
       [DataMember(Order = 1)]
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
    
        [DataMember(Order = 2)]
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
    
        [DataMember(Order = 3)]
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
    
        [DataMember(Order = 4)]
    private string flow;
    
        /**
       * @return general（创建大市场订单），saleproxy（创建分销订单）。saleproxy流程将校验分销关系
    */
        public string getFlow() {
               	return flow;
            }
    
    /**
     * 设置general（创建大市场订单），saleproxy（创建分销订单）。saleproxy流程将校验分销关系     *
     * 参数示例：<pre>general</pre>     
             * 此参数必填
          */
    public void setFlow(string flow) {
     	         	    this.flow = flow;
     	        }
    
    
  }
}