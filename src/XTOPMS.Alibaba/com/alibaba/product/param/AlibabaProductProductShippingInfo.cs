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
public class AlibabaProductProductShippingInfo {

       [DataMember(Order = 1)]
    private long? freightTemplateID;
    
        /**
       * @return 运费模板ID，0表示运费说明，1表示卖家承担运费，其他值表示使用运费模版。此参数可调用运费模板相关API获取
    */
        public long? getFreightTemplateID() {
               	return freightTemplateID;
            }
    
    /**
     * 设置运费模板ID，0表示运费说明，1表示卖家承担运费，其他值表示使用运费模版。此参数可调用运费模板相关API获取     *
     * 参数示例：<pre>121133</pre>     
             * 此参数必填
          */
    public void setFreightTemplateID(long freightTemplateID) {
     	         	    this.freightTemplateID = freightTemplateID;
     	        }
    
        [DataMember(Order = 2)]
    private double? unitWeight;
    
        /**
       * @return 重量/毛重
    */
        public double? getUnitWeight() {
               	return unitWeight;
            }
    
    /**
     * 设置重量/毛重     *
     * 参数示例：<pre>121</pre>     
             * 此参数必填
          */
    public void setUnitWeight(double unitWeight) {
     	         	    this.unitWeight = unitWeight;
     	        }
    
        [DataMember(Order = 3)]
    private string packageSize;
    
        /**
       * @return 尺寸，单位是厘米，长宽高范围是1-9999999。1688无需关注此字段
    */
        public string getPackageSize() {
               	return packageSize;
            }
    
    /**
     * 设置尺寸，单位是厘米，长宽高范围是1-9999999。1688无需关注此字段     *
     * 参数示例：<pre>10x20x50</pre>     
             * 此参数必填
          */
    public void setPackageSize(string packageSize) {
     	         	    this.packageSize = packageSize;
     	        }
    
        [DataMember(Order = 4)]
    private int? volume;
    
        /**
       * @return 体积，单位是立方厘米，范围是1-9999999，1688无需关注此字段
    */
        public int? getVolume() {
               	return volume;
            }
    
    /**
     * 设置体积，单位是立方厘米，范围是1-9999999，1688无需关注此字段     *
     * 参数示例：<pre>500</pre>     
             * 此参数必填
          */
    public void setVolume(int volume) {
     	         	    this.volume = volume;
     	        }
    
        [DataMember(Order = 5)]
    private int? handlingTime;
    
        /**
       * @return 备货期，单位是天，范围是1-60。1688无需处理此字段
    */
        public int? getHandlingTime() {
               	return handlingTime;
            }
    
    /**
     * 设置备货期，单位是天，范围是1-60。1688无需处理此字段     *
     * 参数示例：<pre>12</pre>     
             * 此参数必填
          */
    public void setHandlingTime(int handlingTime) {
     	         	    this.handlingTime = handlingTime;
     	        }
    
        [DataMember(Order = 6)]
    private long? sendGoodsAddressId;
    
        /**
       * @return 发货地址ID，国际站无需处理此字段
    */
        public long? getSendGoodsAddressId() {
               	return sendGoodsAddressId;
            }
    
    /**
     * 设置发货地址ID，国际站无需处理此字段     *
     * 参数示例：<pre>124431</pre>     
             * 此参数必填
          */
    public void setSendGoodsAddressId(long sendGoodsAddressId) {
     	         	    this.sendGoodsAddressId = sendGoodsAddressId;
     	        }
    
        [DataMember(Order = 7)]
    private string sendGoodsAddressText;
    
        /**
       * @return 发货地描述
    */
        public string getSendGoodsAddressText() {
               	return sendGoodsAddressText;
            }
    
    /**
     * 设置发货地描述     *
     * 参数示例：<pre>asda</pre>     
             * 此参数必填
          */
    public void setSendGoodsAddressText(string sendGoodsAddressText) {
     	         	    this.sendGoodsAddressText = sendGoodsAddressText;
     	        }
    
        [DataMember(Order = 8)]
    private double? suttleWeight;
    
        /**
       * @return 净重
    */
        public double? getSuttleWeight() {
               	return suttleWeight;
            }
    
    /**
     * 设置净重     *
     * 参数示例：<pre>1001</pre>     
             * 此参数必填
          */
    public void setSuttleWeight(double suttleWeight) {
     	         	    this.suttleWeight = suttleWeight;
     	        }
    
        [DataMember(Order = 9)]
    private double? width;
    
        /**
       * @return 宽度
    */
        public double? getWidth() {
               	return width;
            }
    
    /**
     * 设置宽度     *
     * 参数示例：<pre>30</pre>     
             * 此参数必填
          */
    public void setWidth(double width) {
     	         	    this.width = width;
     	        }
    
        [DataMember(Order = 10)]
    private double? height;
    
        /**
       * @return 高度
    */
        public double? getHeight() {
               	return height;
            }
    
    /**
     * 设置高度     *
     * 参数示例：<pre>20</pre>     
             * 此参数必填
          */
    public void setHeight(double height) {
     	         	    this.height = height;
     	        }
    
        [DataMember(Order = 11)]
    private double? length;
    
        /**
       * @return 长度
    */
        public double? getLength() {
               	return length;
            }
    
    /**
     * 设置长度     *
     * 参数示例：<pre>10</pre>     
             * 此参数必填
          */
    public void setLength(double length) {
     	         	    this.length = length;
     	        }
    
    
  }
}