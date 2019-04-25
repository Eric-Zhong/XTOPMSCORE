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
public class AlibabaProductPushSimpleItemDesc {

       [DataMember(Order = 1)]
    private string id;
    
        /**
       * @return 唯一标识
    */
        public string getId() {
               	return id;
            }
    
    /**
     * 设置唯一标识     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setId(string id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 2)]
    private double? price;
    
        /**
       * @return 价格
    */
        public double? getPrice() {
               	return price;
            }
    
    /**
     * 设置价格     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPrice(double price) {
     	         	    this.price = price;
     	        }
    
        [DataMember(Order = 3)]
    private string subject;
    
        /**
       * @return 商品名称
    */
        public string getSubject() {
               	return subject;
            }
    
    /**
     * 设置商品名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubject(string subject) {
     	         	    this.subject = subject;
     	        }
    
        [DataMember(Order = 4)]
    private string description;
    
        /**
       * @return 描述
    */
        public string getDescription() {
               	return description;
            }
    
    /**
     * 设置描述     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDescription(string description) {
     	         	    this.description = description;
     	        }
    
        [DataMember(Order = 5)]
    private string url;
    
        /**
       * @return 商品的URL
    */
        public string getUrl() {
               	return url;
            }
    
    /**
     * 设置商品的URL     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUrl(string url) {
     	         	    this.url = url;
     	        }
    
        [DataMember(Order = 6)]
    private AlibabaProductPushPriceRanges[] priceRanges;
    
        /**
       * @return 价格区间
    */
        public AlibabaProductPushPriceRanges[] getPriceRanges() {
               	return priceRanges;
            }
    
    /**
     * 设置价格区间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPriceRanges(AlibabaProductPushPriceRanges[] priceRanges) {
     	         	    this.priceRanges = priceRanges;
     	        }
    
    
  }
}