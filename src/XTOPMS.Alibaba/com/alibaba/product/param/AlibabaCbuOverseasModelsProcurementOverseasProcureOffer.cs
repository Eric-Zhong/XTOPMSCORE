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
public class AlibabaCbuOverseasModelsProcurementOverseasProcureOffer {

       [DataMember(Order = 1)]
    private long? productId;
    
        /**
       * @return 商品id
    */
        public long? getProductId() {
               	return productId;
            }
    
    /**
     * 设置商品id     *
     * 参数示例：<pre>550453865151</pre>     
             * 此参数必填
          */
    public void setProductId(long productId) {
     	         	    this.productId = productId;
     	        }
    
        [DataMember(Order = 2)]
    private string productImage;
    
        /**
       * @return 商品主图的相对路径，前缀需自己添加。大小220x220。
    */
        public string getProductImage() {
               	return productImage;
            }
    
    /**
     * 设置商品主图的相对路径，前缀需自己添加。大小220x220。     *
     * 参数示例：<pre>img/ibank/2017/090/722/4129227090_1519475281.220x220.jpg</pre>     
             * 此参数必填
          */
    public void setProductImage(string productImage) {
     	         	    this.productImage = productImage;
     	        }
    
        [DataMember(Order = 3)]
    private string productPrice;
    
        /**
       * @return 商品价格
    */
        public string getProductPrice() {
               	return productPrice;
            }
    
    /**
     * 设置商品价格     *
     * 参数示例：<pre>44.00</pre>     
             * 此参数必填
          */
    public void setProductPrice(string productPrice) {
     	         	    this.productPrice = productPrice;
     	        }
    
        [DataMember(Order = 4)]
    private string productTitle;
    
        /**
       * @return 商品标题
    */
        public string getProductTitle() {
               	return productTitle;
            }
    
    /**
     * 设置商品标题     *
     * 参数示例：<pre>2017新款夏季女装短袖连衣裙女夏装韩版修身显瘦淑女高腰a字裙子</pre>     
             * 此参数必填
          */
    public void setProductTitle(string productTitle) {
     	         	    this.productTitle = productTitle;
     	        }
    
    
  }
}