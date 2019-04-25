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
public class AlibabaProductPushMicroSupplyPuHuoModel {

       [DataMember(Order = 1)]
    private string productId;
    
        /**
       * @return 1688商品ID
    */
        public string getProductId() {
               	return productId;
            }
    
    /**
     * 设置1688商品ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductId(string productId) {
     	         	    this.productId = productId;
     	        }
    
        [DataMember(Order = 2)]
    private string shopName;
    
        /**
       * @return 下游店铺名称
    */
        public string getShopName() {
               	return shopName;
            }
    
    /**
     * 设置下游店铺名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setShopName(string shopName) {
     	         	    this.shopName = shopName;
     	        }
    
        [DataMember(Order = 3)]
    private string imgUrl;
    
        /**
       * @return 铺货首图链接
    */
        public string getImgUrl() {
               	return imgUrl;
            }
    
    /**
     * 设置铺货首图链接     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setImgUrl(string imgUrl) {
     	         	    this.imgUrl = imgUrl;
     	        }
    
        [DataMember(Order = 4)]
    private string productUrlInShop;
    
        /**
       * @return 商品在下游店铺的连接地址，方便用户从平台查看。
    */
        public string getProductUrlInShop() {
               	return productUrlInShop;
            }
    
    /**
     * 设置商品在下游店铺的连接地址，方便用户从平台查看。     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductUrlInShop(string productUrlInShop) {
     	         	    this.productUrlInShop = productUrlInShop;
     	        }
    
    
  }
}