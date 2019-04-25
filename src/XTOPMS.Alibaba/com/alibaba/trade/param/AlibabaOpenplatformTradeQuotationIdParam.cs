using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.trade.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaOpenplatformTradeQuotationIdParam {

       [DataMember(Order = 1)]
    private string buyerMemberId;
    
        /**
       * @return 采购商 memberId
    */
        public string getBuyerMemberId() {
               	return buyerMemberId;
            }
    
    /**
     * 设置采购商 memberId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerMemberId(string buyerMemberId) {
     	         	    this.buyerMemberId = buyerMemberId;
     	        }
    
        [DataMember(Order = 2)]
    private long? purchaseNoteId;
    
        /**
       * @return 询价单Id（选填）
    */
        public long? getPurchaseNoteId() {
               	return purchaseNoteId;
            }
    
    /**
     * 设置询价单Id（选填）     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPurchaseNoteId(long purchaseNoteId) {
     	         	    this.purchaseNoteId = purchaseNoteId;
     	        }
    
        [DataMember(Order = 3)]
    private long[] quoteItemIds;
    
        /**
       * @return 报价项id,指定报价项下单时必填
    */
        public long[] getQuoteItemIds() {
               	return quoteItemIds;
            }
    
    /**
     * 设置报价项id,指定报价项下单时必填     *
     * 参数示例：<pre>[63540081872,63540071872,63540061872,63540051872]</pre>     
             * 此参数必填
          */
    public void setQuoteItemIds(long[] quoteItemIds) {
     	         	    this.quoteItemIds = quoteItemIds;
     	        }
    
        [DataMember(Order = 4)]
    private string supplyNoteId;
    
        /**
       * @return 报价单/投标单ID（必填）
    */
        public string getSupplyNoteId() {
               	return supplyNoteId;
            }
    
    /**
     * 设置报价单/投标单ID（必填）     *
     * 参数示例：<pre>38630021872</pre>     
             * 此参数必填
          */
    public void setSupplyNoteId(string supplyNoteId) {
     	         	    this.supplyNoteId = supplyNoteId;
     	        }
    
        [DataMember(Order = 5)]
    private AlibabaOpenplatformTradeQuotationSkuAmount[] skuAmountList;
    
        /**
       * @return 采购商填写的采购量
    */
        public AlibabaOpenplatformTradeQuotationSkuAmount[] getSkuAmountList() {
               	return skuAmountList;
            }
    
    /**
     * 设置采购商填写的采购量     *
     * 参数示例：<pre>[{"quoteItemId":63540051872,"itemCount":100},{"quoteItemId":63540061872,"itemCount":100}]</pre>     
             * 此参数必填
          */
    public void setSkuAmountList(AlibabaOpenplatformTradeQuotationSkuAmount[] skuAmountList) {
     	         	    this.skuAmountList = skuAmountList;
     	        }
    
    
  }
}