using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.product.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductSellerInfo {

       [DataMember(Order = 1)]
    private string sellerMemberId;
    
        /**
       * @return 商品卖家MemberId
    */
        public string getSellerMemberId() {
               	return sellerMemberId;
            }
    
    /**
     * 设置商品卖家MemberId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerMemberId(string sellerMemberId) {
     	         	    this.sellerMemberId = sellerMemberId;
     	        }
    
        [DataMember(Order = 2)]
    private string errorMsg;
    
        /**
       * @return 错误信息
    */
        public string getErrorMsg() {
               	return errorMsg;
            }
    
    /**
     * 设置错误信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setErrorMsg(string errorMsg) {
     	         	    this.errorMsg = errorMsg;
     	        }
    
        [DataMember(Order = 3)]
    private string sellerLoginId;
    
        /**
       * @return 商品卖家LoginId
    */
        public string getSellerLoginId() {
               	return sellerLoginId;
            }
    
    /**
     * 设置商品卖家LoginId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerLoginId(string sellerLoginId) {
     	         	    this.sellerLoginId = sellerLoginId;
     	        }
    
        [DataMember(Order = 4)]
    private long? sellerUserId;
    
        /**
       * @return 商品卖家UserId
    */
        public long? getSellerUserId() {
               	return sellerUserId;
            }
    
    /**
     * 设置商品卖家UserId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerUserId(long sellerUserId) {
     	         	    this.sellerUserId = sellerUserId;
     	        }
    
        [DataMember(Order = 5)]
    private long? productId;
    
        /**
       * @return 商品ID
    */
        public long? getProductId() {
               	return productId;
            }
    
    /**
     * 设置商品ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductId(long productId) {
     	         	    this.productId = productId;
     	        }
    
    
  }
}