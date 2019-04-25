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
public class AlibabaCrossBorderLogisticsSolutionParam : GatewayAPIRequest {

    public AlibabaCrossBorderLogisticsSolutionParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.crossBorder.logistics.solution",1);
	}
	
       [DataMember(Order = 1)]
    private string offerId;
    
        /**
       * @return 商品ID
    */
        public string getOfferId() {
               	return offerId;
            }
    
    /**
     * 设置商品ID     *
     * 参数示例：<pre>546775917010</pre>     
             * 此参数必填
          */
    public void setOfferId(string offerId) {
     	         	    this.offerId = offerId;
     	        }
    
        [DataMember(Order = 2)]
    private string toAddressText;
    
        /**
       * @return 收件人的地址信息
    */
        public string getToAddressText() {
               	return toAddressText;
            }
    
    /**
     * 设置收件人的地址信息     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setToAddressText(string toAddressText) {
     	         	    this.toAddressText = toAddressText;
     	        }
    
        [DataMember(Order = 3)]
    private string toDivisionId;
    
        /**
       * @return 收件人的地区ID
    */
        public string getToDivisionId() {
               	return toDivisionId;
            }
    
    /**
     * 设置收件人的地区ID     *
     * 参数示例：<pre>2</pre>     
             * 此参数必填
          */
    public void setToDivisionId(string toDivisionId) {
     	         	    this.toDivisionId = toDivisionId;
     	        }
    
        [DataMember(Order = 4)]
    private QueryParamSkuInfo[] skuInfoList;
    
        /**
       * @return 购买的数量及规格信息
    */
        public QueryParamSkuInfo[] getSkuInfoList() {
               	return skuInfoList;
            }
    
    /**
     * 设置购买的数量及规格信息     *
     * 参数示例：<pre>[]</pre>     
             * 此参数必填
          */
    public void setSkuInfoList(QueryParamSkuInfo[] skuInfoList) {
     	         	    this.skuInfoList = skuInfoList;
     	        }
    
    
  }
}