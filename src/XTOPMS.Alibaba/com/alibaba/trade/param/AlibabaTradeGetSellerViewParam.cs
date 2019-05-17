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
    public class AlibabaTradeGetSellerViewParam : GatewayAPIRequest
    {

        public AlibabaTradeGetSellerViewParam()
        {
            this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.get.sellerView", 1);
        }

        [DataMember(Order = 1)]
        private long? orderId;

        /**
        * @return 交易的订单id
        */
        public long? getOrderId()
        {
            return orderId;
        }

        /**
         * 设置交易的订单id     *
         * 参数示例：<pre>123456</pre>     
         * 此参数必填
        */
        public void setOrderId(long orderId)
        {
            this.orderId = orderId;
        }

        [DataMember(Order = 2)]
        private string includeFields;

        /**
        * @return 查询结果中包含的域，GuaranteesTerms：保障条款，NativeLogistics：物流信息，RateDetail：评价详情，OrderInvoice：发票信息。默认返回GuaranteesTerms、NativeLogistics、OrderInvoice。
        */
        public string getIncludeFields()
        {
            return includeFields;
        }

        /**
         * 设置查询结果中包含的域，GuaranteesTerms：保障条款，NativeLogistics：物流信息，RateDetail：评价详情，OrderInvoice：发票信息。默认返回GuaranteesTerms、NativeLogistics、OrderInvoice。     *
         * 参数示例：<pre>GuaranteesTerms,NativeLogistics,RateDetail,OrderInvoice</pre>     
         * 此参数必填
        */
        public void setIncludeFields(string includeFields)
        {
            this.includeFields = includeFields;
        }


    }
}