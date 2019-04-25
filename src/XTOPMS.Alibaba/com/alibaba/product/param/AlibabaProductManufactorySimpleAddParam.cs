using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.product.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductManufactorySimpleAddParam : GatewayAPIRequest {

    public AlibabaProductManufactorySimpleAddParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.manufactory.simple.add",1);
	}
	
       [DataMember(Order = 1)]
    private double? price;
    
        /**
       * @return 售卖价格
    */
        public double? getPrice() {
               	return price;
            }
    
    /**
     * 设置售卖价格     *
     * 参数示例：<pre>100.00</pre>     
             * 此参数必填
          */
    public void setPrice(double price) {
     	         	    this.price = price;
     	        }
    
        [DataMember(Order = 2)]
    private bool? supportOnlineTrade;
    
        /**
       * @return 是否支持在线交易，只有开通旺铺后才能发布可在线交易商品
    */
        public bool? getSupportOnlineTrade() {
               	return supportOnlineTrade;
            }
    
    /**
     * 设置是否支持在线交易，只有开通旺铺后才能发布可在线交易商品     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setSupportOnlineTrade(bool supportOnlineTrade) {
     	         	    this.supportOnlineTrade = supportOnlineTrade;
     	        }
    
        [DataMember(Order = 3)]
    private string description;
    
        /**
       * @return offer描述
    */
        public string getDescription() {
               	return description;
            }
    
    /**
     * 设置offer描述     *
     * 参数示例：<pre>测试简单商品</pre>     
             * 此参数必填
          */
    public void setDescription(string description) {
     	         	    this.description = description;
     	        }
    
        [DataMember(Order = 4)]
    private string subject;
    
        /**
       * @return offer标题
    */
        public string getSubject() {
               	return subject;
            }
    
    /**
     * 设置offer标题     *
     * 参数示例：<pre>测试简单商品</pre>     
             * 此参数必填
          */
    public void setSubject(string subject) {
     	         	    this.subject = subject;
     	        }
    
        [DataMember(Order = 5)]
    private long? categoryId;
    
        /**
       * @return offer的类目ID
    */
        public long? getCategoryId() {
               	return categoryId;
            }
    
    /**
     * 设置offer的类目ID     *
     * 参数示例：<pre>126552002</pre>     
             * 此参数必填
          */
    public void setCategoryId(long categoryId) {
     	         	    this.categoryId = categoryId;
     	        }
    
        [DataMember(Order = 6)]
    private string[] images;
    
        /**
       * @return 主图信息
    */
        public string[] getImages() {
               	return images;
            }
    
    /**
     * 设置主图信息     *
     * 参数示例：<pre>["img/ibank/2018/891/043/9246340198_1660977857.jpg","img/ibank/2018/767/613/9246316767_1660977857.jpg","img/ibank/2018/603/271/9265172306_1660977857.jpg","img/ibank/2018/381/343/9246343183_1660977857.jpg","img/ibank/2018/552/733/9246337255_1660977857.jpg" ]</pre>     
             * 此参数必填
          */
    public void setImages(string[] images) {
     	         	    this.images = images;
     	        }
    
        [DataMember(Order = 7)]
    private long? tradeAmount;
    
        /**
       * @return 库存总数
    */
        public long? getTradeAmount() {
               	return tradeAmount;
            }
    
    /**
     * 设置库存总数     *
     * 参数示例：<pre>1000</pre>     
             * 此参数必填
          */
    public void setTradeAmount(long tradeAmount) {
     	         	    this.tradeAmount = tradeAmount;
     	        }
    
        [DataMember(Order = 8)]
    private string tradeRetailPrice;
    
        /**
       * @return 建议零售价
    */
        public string getTradeRetailPrice() {
               	return tradeRetailPrice;
            }
    
    /**
     * 设置建议零售价     *
     * 参数示例：<pre>100</pre>     
             * 此参数必填
          */
    public void setTradeRetailPrice(string tradeRetailPrice) {
     	         	    this.tradeRetailPrice = tradeRetailPrice;
     	        }
    
    
  }
}