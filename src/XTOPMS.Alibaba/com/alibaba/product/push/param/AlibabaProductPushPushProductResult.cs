using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.product.push.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductPushPushProductResult {

       [DataMember(Order = 1)]
    private string productIdInTargetPlatform;
    
        /**
       * @return 在目标平台的商品ID，纯数字字符串
    */
        public string getProductIdInTargetPlatform() {
               	return productIdInTargetPlatform;
            }
    
    /**
     * 设置在目标平台的商品ID，纯数字字符串     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductIdInTargetPlatform(string productIdInTargetPlatform) {
     	         	    this.productIdInTargetPlatform = productIdInTargetPlatform;
     	        }
    
        [DataMember(Order = 2)]
    private string productIdInPartner;
    
        /**
       * @return 在第三方平台的商品ID
    */
        public string getProductIdInPartner() {
               	return productIdInPartner;
            }
    
    /**
     * 设置在第三方平台的商品ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductIdInPartner(string productIdInPartner) {
     	         	    this.productIdInPartner = productIdInPartner;
     	        }
    
        [DataMember(Order = 3)]
    private string productIdInSource;
    
        /**
       * @return 在源平台的商品ID，纯数字字符串
    */
        public string getProductIdInSource() {
               	return productIdInSource;
            }
    
    /**
     * 设置在源平台的商品ID，纯数字字符串     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductIdInSource(string productIdInSource) {
     	         	    this.productIdInSource = productIdInSource;
     	        }
    
        [DataMember(Order = 4)]
    private string productPushStatus;
    
        /**
       * @return 铺货状态，0：未成功，1：已成功
    */
        public string getProductPushStatus() {
               	return productPushStatus;
            }
    
    /**
     * 设置铺货状态，0：未成功，1：已成功     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductPushStatus(string productPushStatus) {
     	         	    this.productPushStatus = productPushStatus;
     	        }
    
        [DataMember(Order = 5)]
    private AlibabaProductPushSimpleItemDesc productInfoInTargetPlatform;
    
        /**
       * @return 商品级别的铺货结果
    */
        public AlibabaProductPushSimpleItemDesc getProductInfoInTargetPlatform() {
               	return productInfoInTargetPlatform;
            }
    
    /**
     * 设置商品级别的铺货结果     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductInfoInTargetPlatform(AlibabaProductPushSimpleItemDesc productInfoInTargetPlatform) {
     	         	    this.productInfoInTargetPlatform = productInfoInTargetPlatform;
     	        }
    
        [DataMember(Order = 6)]
    private AlibabaProductPushPushProductSKUResult[] skus;
    
        /**
       * @return SKU数组
    */
        public AlibabaProductPushPushProductSKUResult[] getSkus() {
               	return skus;
            }
    
    /**
     * 设置SKU数组     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkus(AlibabaProductPushPushProductSKUResult[] skus) {
     	         	    this.skus = skus;
     	        }
    
        [DataMember(Order = 7)]
    private string userShopIdInTargetPlatform;
    
        /**
       * @return 用户在目标平台的店铺标志，纯数字字符串，对应后台的targetUserId。比如目标平台为淘宝，则需要传递客户在淘宝的用户Id
    */
        public string getUserShopIdInTargetPlatform() {
               	return userShopIdInTargetPlatform;
            }
    
    /**
     * 设置用户在目标平台的店铺标志，纯数字字符串，对应后台的targetUserId。比如目标平台为淘宝，则需要传递客户在淘宝的用户Id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUserShopIdInTargetPlatform(string userShopIdInTargetPlatform) {
     	         	    this.userShopIdInTargetPlatform = userShopIdInTargetPlatform;
     	        }
    
    
  }
}