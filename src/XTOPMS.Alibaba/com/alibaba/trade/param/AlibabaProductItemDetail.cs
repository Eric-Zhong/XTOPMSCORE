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
public class AlibabaProductItemDetail {

       [DataMember(Order = 1)]
    private string itemName;
    
        /**
       * @return 单品名字
    */
        public string getItemName() {
               	return itemName;
            }
    
    /**
     * 设置单品名字     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setItemName(string itemName) {
     	         	    this.itemName = itemName;
     	        }
    
        [DataMember(Order = 2)]
    private string unitOfMeasure;
    
        /**
       * @return 单位
    */
        public string getUnitOfMeasure() {
               	return unitOfMeasure;
            }
    
    /**
     * 设置单位     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUnitOfMeasure(string unitOfMeasure) {
     	         	    this.unitOfMeasure = unitOfMeasure;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaCommonUrl[] imgUrl;
    
        /**
       * @return 单品URL地址
    */
        public AlibabaCommonUrl[] getImgUrl() {
               	return imgUrl;
            }
    
    /**
     * 设置单品URL地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setImgUrl(AlibabaCommonUrl[] imgUrl) {
     	         	    this.imgUrl = imgUrl;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaCommonUrl url;
    
        /**
       * @return 单品URL地址
    */
        public AlibabaCommonUrl getUrl() {
               	return url;
            }
    
    /**
     * 设置单品URL地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUrl(AlibabaCommonUrl url) {
     	         	    this.url = url;
     	        }
    
        [DataMember(Order = 5)]
    private AlibabaProductUnitPrice unitPrice;
    
        /**
       * @return 单品价格
    */
        public AlibabaProductUnitPrice getUnitPrice() {
               	return unitPrice;
            }
    
    /**
     * 设置单品价格     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUnitPrice(AlibabaProductUnitPrice unitPrice) {
     	         	    this.unitPrice = unitPrice;
     	        }
    
    
  }
}