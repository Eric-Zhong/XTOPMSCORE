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
public class AlibabaTradeQuotationOrderCreateParam : GatewayAPIRequest {

    public AlibabaTradeQuotationOrderCreateParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.quotationOrder.create",1);
	}
	
       [DataMember(Order = 1)]
    private AlibabaOpenplatformTradeBizMakeSingleOrderGroup makeSingleOrderGroup;
    
        /**
       * @return 下单详情信息
    */
        public AlibabaOpenplatformTradeBizMakeSingleOrderGroup getMakeSingleOrderGroup() {
               	return makeSingleOrderGroup;
            }
    
    /**
     * 设置下单详情信息     *
     * 参数示例：<pre>{"receiveAddressGroup":{"address":"聚合路699号","areaCode":"330108","fullName":"洪洲阳","mobile":"13817748888","postCode":"311200"}}</pre>     
             * 此参数必填
          */
    public void setMakeSingleOrderGroup(AlibabaOpenplatformTradeBizMakeSingleOrderGroup makeSingleOrderGroup) {
     	         	    this.makeSingleOrderGroup = makeSingleOrderGroup;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaOpenplatformTradeQuotationIdParam quotationInfo;
    
        /**
       * @return 询报价单参数标志
    */
        public AlibabaOpenplatformTradeQuotationIdParam getQuotationInfo() {
               	return quotationInfo;
            }
    
    /**
     * 设置询报价单参数标志     *
     * 参数示例：<pre>{"buyerMemberId":"b2b-2248564064","quoteItemIds":[1107742990902],"supplyNoteId":"959751330902"}</pre>     
             * 此参数必填
          */
    public void setQuotationInfo(AlibabaOpenplatformTradeQuotationIdParam quotationInfo) {
     	         	    this.quotationInfo = quotationInfo;
     	        }
    
        [DataMember(Order = 3)]
    private string subBiz;
    
        /**
       * @return 下单流程类型，普通询报价："buyoffer";分阶段付款："bostep";多种类交易(item种类大于50个)："mulitem";其他方式，在交易下单页面选取："other";
    */
        public string getSubBiz() {
               	return subBiz;
            }
    
    /**
     * 设置下单流程类型，普通询报价："buyoffer";分阶段付款："bostep";多种类交易(item种类大于50个)："mulitem";其他方式，在交易下单页面选取："other";     *
     * 参数示例：<pre>buyoffer</pre>     
             * 此参数必填
          */
    public void setSubBiz(string subBiz) {
     	         	    this.subBiz = subBiz;
     	        }
    
        [DataMember(Order = 4)]
    private bool? subUser;
    
        /**
       * @return 是否子账号
    */
        public bool? getSubUser() {
               	return subUser;
            }
    
    /**
     * 设置是否子账号     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setSubUser(bool subUser) {
     	         	    this.subUser = subUser;
     	        }
    
        [DataMember(Order = 5)]
    private long? subUserId;
    
        /**
       * @return 子账号userid
    */
        public long? getSubUserId() {
               	return subUserId;
            }
    
    /**
     * 设置子账号userid     *
     * 参数示例：<pre>122455</pre>     
             * 此参数必填
          */
    public void setSubUserId(long subUserId) {
     	         	    this.subUserId = subUserId;
     	        }
    
        [DataMember(Order = 6)]
    private string subLoginId;
    
        /**
       * @return 子账号登录ID
    */
        public string getSubLoginId() {
               	return subLoginId;
            }
    
    /**
     * 设置子账号登录ID     *
     * 参数示例：<pre>测试:子账号1</pre>     
             * 此参数必填
          */
    public void setSubLoginId(string subLoginId) {
     	         	    this.subLoginId = subLoginId;
     	        }
    
    
  }
}