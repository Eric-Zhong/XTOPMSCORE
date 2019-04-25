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
public class AlibabaSearchProductSearchResultInfo {

       [DataMember(Order = 1)]
    private int? amountOnSale;
    
        /**
       * @return 可售数量
    */
        public int? getAmountOnSale() {
               	return amountOnSale;
            }
    
    /**
     * 设置可售数量     *
     * 参数示例：<pre>100</pre>     
             * 此参数必填
          */
    public void setAmountOnSale(int amountOnSale) {
     	         	    this.amountOnSale = amountOnSale;
     	        }
    
        [DataMember(Order = 2)]
    private double? minPurchaseQuantity;
    
        /**
       * @return 最小起批量
    */
        public double? getMinPurchaseQuantity() {
               	return minPurchaseQuantity;
            }
    
    /**
     * 设置最小起批量     *
     * 参数示例：<pre>3</pre>     
             * 此参数必填
          */
    public void setMinPurchaseQuantity(double minPurchaseQuantity) {
     	         	    this.minPurchaseQuantity = minPurchaseQuantity;
     	        }
    
        [DataMember(Order = 3)]
    private string picUrl;
    
        /**
       * @return 产品的图片地址
    */
        public string getPicUrl() {
               	return picUrl;
            }
    
    /**
     * 设置产品的图片地址     *
     * 参数示例：<pre>img/ibank/2018/794/316/9422613497_991974782.jpg</pre>     
             * 此参数必填
          */
    public void setPicUrl(string picUrl) {
     	         	    this.picUrl = picUrl;
     	        }
    
        [DataMember(Order = 4)]
    private double? price;
    
        /**
       * @return 参考商品价格
    */
        public double? getPrice() {
               	return price;
            }
    
    /**
     * 设置参考商品价格     *
     * 参数示例：<pre>100</pre>     
             * 此参数必填
          */
    public void setPrice(double price) {
     	         	    this.price = price;
     	        }
    
        [DataMember(Order = 5)]
    private long? productID;
    
        /**
       * @return 商品ID
    */
        public long? getProductID() {
               	return productID;
            }
    
    /**
     * 设置商品ID     *
     * 参数示例：<pre>1123123331</pre>     
             * 此参数必填
          */
    public void setProductID(long productID) {
     	         	    this.productID = productID;
     	        }
    
        [DataMember(Order = 6)]
    private double? bookedCount;
    
        /**
       * @return 商品售卖了多少笔(以订单为维度)
    */
        public double? getBookedCount() {
               	return bookedCount;
            }
    
    /**
     * 设置商品售卖了多少笔(以订单为维度)     *
     * 参数示例：<pre>2123</pre>     
             * 此参数必填
          */
    public void setBookedCount(double bookedCount) {
     	         	    this.bookedCount = bookedCount;
     	        }
    
        [DataMember(Order = 7)]
    private double? saleQuantity;
    
        /**
       * @return 该商品售卖了多少件(以商品单位为维度)
    */
        public double? getSaleQuantity() {
               	return saleQuantity;
            }
    
    /**
     * 设置该商品售卖了多少件(以商品单位为维度)     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setSaleQuantity(double saleQuantity) {
     	         	    this.saleQuantity = saleQuantity;
     	        }
    
        [DataMember(Order = 8)]
    private string province;
    
        /**
       * @return 商品发货省份码
    */
        public string getProvince() {
               	return province;
            }
    
    /**
     * 设置商品发货省份码     *
     * 参数示例：<pre>浙江</pre>     
             * 此参数必填
          */
    public void setProvince(string province) {
     	         	    this.province = province;
     	        }
    
        [DataMember(Order = 9)]
    private string city;
    
        /**
       * @return 商品发货城市
    */
        public string getCity() {
               	return city;
            }
    
    /**
     * 设置商品发货城市     *
     * 参数示例：<pre>杭州</pre>     
             * 此参数必填
          */
    public void setCity(string city) {
     	         	    this.city = city;
     	        }
    
        [DataMember(Order = 10)]
    private double? retailPrice;
    
        /**
       * @return 建议零售价
    */
        public double? getRetailPrice() {
               	return retailPrice;
            }
    
    /**
     * 设置建议零售价     *
     * 参数示例：<pre>100</pre>     
             * 此参数必填
          */
    public void setRetailPrice(double retailPrice) {
     	         	    this.retailPrice = retailPrice;
     	        }
    
        [DataMember(Order = 11)]
    private string subject;
    
        /**
       * @return 商品标题
    */
        public string getSubject() {
               	return subject;
            }
    
    /**
     * 设置商品标题     *
     * 参数示例：<pre>【原D现货】韩版新秋女裙 时尚方格<font color=red>小</font>立领不规则下摆气质<font color=red>连衣裙</font></pre>     
             * 此参数必填
          */
    public void setSubject(string subject) {
     	         	    this.subject = subject;
     	        }
    
        [DataMember(Order = 12)]
    private string unit;
    
        /**
       * @return 商品单位
    */
        public string getUnit() {
               	return unit;
            }
    
    /**
     * 设置商品单位     *
     * 参数示例：<pre>件</pre>     
             * 此参数必填
          */
    public void setUnit(string unit) {
     	         	    this.unit = unit;
     	        }
    
        [DataMember(Order = 13)]
    private AlibabaSimpleSku[] skuList;
    
        /**
       * @return sku信息
    */
        public AlibabaSimpleSku[] getSkuList() {
               	return skuList;
            }
    
    /**
     * 设置sku信息     *
     * 参数示例：<pre>[]</pre>     
             * 此参数必填
          */
    public void setSkuList(AlibabaSimpleSku[] skuList) {
     	         	    this.skuList = skuList;
     	        }
    
    
  }
}