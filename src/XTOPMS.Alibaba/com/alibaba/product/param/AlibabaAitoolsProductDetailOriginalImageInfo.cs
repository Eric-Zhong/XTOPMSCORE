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
public class AlibabaAitoolsProductDetailOriginalImageInfo {

       [DataMember(Order = 1)]
    private string url;
    
        /**
       * @return 原图上传到图片相册后的地址
    */
        public string getUrl() {
               	return url;
            }
    
    /**
     * 设置原图上传到图片相册后的地址     *
     * 参数示例：<pre>http://foo.bar/baz.jpg</pre>     
             * 此参数必填
          */
    public void setUrl(string url) {
     	         	    this.url = url;
     	        }
    
        [DataMember(Order = 2)]
    private int? width;
    
        /**
       * @return 原图宽度，单位：像素。注意，这里的图片尺寸并不是上传到图片相册后的尺寸，图片相册可能会对图片进行压缩。
    */
        public int? getWidth() {
               	return width;
            }
    
    /**
     * 设置原图宽度，单位：像素。注意，这里的图片尺寸并不是上传到图片相册后的尺寸，图片相册可能会对图片进行压缩。     *
     * 参数示例：<pre>1024</pre>     
             * 此参数必填
          */
    public void setWidth(int width) {
     	         	    this.width = width;
     	        }
    
        [DataMember(Order = 3)]
    private int? height;
    
        /**
       * @return 原图高度，单位：像素。注意，这里的图片尺寸并不是上传到图片相册后的尺寸，图片相册可能会对图片进行压缩。
    */
        public int? getHeight() {
               	return height;
            }
    
    /**
     * 设置原图高度，单位：像素。注意，这里的图片尺寸并不是上传到图片相册后的尺寸，图片相册可能会对图片进行压缩。     *
     * 参数示例：<pre>768</pre>     
             * 此参数必填
          */
    public void setHeight(int height) {
     	         	    this.height = height;
     	        }
    
        [DataMember(Order = 4)]
    private double? detailXRate;
    
        /**
       * @return 细节切图所在原图中的 x 坐标比例，取值为 0.0 ~ 1.0，由 width * x 可得出 x 坐标的像素值
    */
        public double? getDetailXRate() {
               	return detailXRate;
            }
    
    /**
     * 设置细节切图所在原图中的 x 坐标比例，取值为 0.0 ~ 1.0，由 width * x 可得出 x 坐标的像素值     *
     * 参数示例：<pre>0.5</pre>     
             * 此参数必填
          */
    public void setDetailXRate(double detailXRate) {
     	         	    this.detailXRate = detailXRate;
     	        }
    
        [DataMember(Order = 5)]
    private double? detailYRate;
    
        /**
       * @return 细节切图所在原图中的 y 坐标比例，取值为 0.0 ~ 1.0，由 height * y 可得出 y 坐标的像素值
    */
        public double? getDetailYRate() {
               	return detailYRate;
            }
    
    /**
     * 设置细节切图所在原图中的 y 坐标比例，取值为 0.0 ~ 1.0，由 height * y 可得出 y 坐标的像素值     *
     * 参数示例：<pre>0.5</pre>     
             * 此参数必填
          */
    public void setDetailYRate(double detailYRate) {
     	         	    this.detailYRate = detailYRate;
     	        }
    
        [DataMember(Order = 6)]
    private double? detailWidthRate;
    
        /**
       * @return 细节切图占原图的宽度比例，取值为 0.0 ~ 1.0，由 width * w 可得出实际像素宽度
    */
        public double? getDetailWidthRate() {
               	return detailWidthRate;
            }
    
    /**
     * 设置细节切图占原图的宽度比例，取值为 0.0 ~ 1.0，由 width * w 可得出实际像素宽度     *
     * 参数示例：<pre>0.5</pre>     
             * 此参数必填
          */
    public void setDetailWidthRate(double detailWidthRate) {
     	         	    this.detailWidthRate = detailWidthRate;
     	        }
    
        [DataMember(Order = 7)]
    private double? detailHeightRate;
    
        /**
       * @return 细节切图占原图的高度比例，取值为 0.0 ~ 1.0，由 height * h 可得出实际像素高度
    */
        public double? getDetailHeightRate() {
               	return detailHeightRate;
            }
    
    /**
     * 设置细节切图占原图的高度比例，取值为 0.0 ~ 1.0，由 height * h 可得出实际像素高度     *
     * 参数示例：<pre>0.5</pre>     
             * 此参数必填
          */
    public void setDetailHeightRate(double detailHeightRate) {
     	         	    this.detailHeightRate = detailHeightRate;
     	        }
    
    
  }
}