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
public class AlibabaTradeOrderRateInfo {

       [DataMember(Order = 1)]
    private int? buyerRateStatus;
    
        /**
       * @return 买家评价状态(4:已评论,5:未评论,6;不需要评论)
    */
        public int? getBuyerRateStatus() {
               	return buyerRateStatus;
            }
    
    /**
     * 设置买家评价状态(4:已评论,5:未评论,6;不需要评论)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerRateStatus(int buyerRateStatus) {
     	         	    this.buyerRateStatus = buyerRateStatus;
     	        }
    
        [DataMember(Order = 2)]
    private int? sellerRateStatus;
    
        /**
       * @return 卖家评价状态(4:已评论,5:未评论,6;不需要评论)
    */
        public int? getSellerRateStatus() {
               	return sellerRateStatus;
            }
    
    /**
     * 设置卖家评价状态(4:已评论,5:未评论,6;不需要评论)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerRateStatus(int sellerRateStatus) {
     	         	    this.sellerRateStatus = sellerRateStatus;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaOrderRateDetail[] buyerRateList;
    
        /**
       * @return 卖家給买家的评价
    */
        public AlibabaOrderRateDetail[] getBuyerRateList() {
               	return buyerRateList;
            }
    
    /**
     * 设置卖家給买家的评价     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerRateList(AlibabaOrderRateDetail[] buyerRateList) {
     	         	    this.buyerRateList = buyerRateList;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaOrderRateDetail[] sellerRateList;
    
        /**
       * @return 买家給卖家的评价
    */
        public AlibabaOrderRateDetail[] getSellerRateList() {
               	return sellerRateList;
            }
    
    /**
     * 设置买家給卖家的评价     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerRateList(AlibabaOrderRateDetail[] sellerRateList) {
     	         	    this.sellerRateList = sellerRateList;
     	        }
    
    
  }
}