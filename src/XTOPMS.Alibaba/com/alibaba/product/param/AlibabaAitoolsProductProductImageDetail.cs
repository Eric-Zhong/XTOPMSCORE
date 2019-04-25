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
public class AlibabaAitoolsProductProductImageDetail {

       [DataMember(Order = 1)]
    private string title;
    
        /**
       * @return 细节部位名称
    */
        public string getTitle() {
               	return title;
            }
    
    /**
     * 设置细节部位名称     *
     * 参数示例：<pre>领型</pre>     
             * 此参数必填
          */
    public void setTitle(string title) {
     	         	    this.title = title;
     	        }
    
        [DataMember(Order = 2)]
    private string description;
    
        /**
       * @return 细节部位智能描述文案
    */
        public string getDescription() {
               	return description;
            }
    
    /**
     * 设置细节部位智能描述文案     *
     * 参数示例：<pre>性感V领，魅力四射</pre>     
             * 此参数必填
          */
    public void setDescription(string description) {
     	         	    this.description = description;
     	        }
    
        [DataMember(Order = 3)]
    private double? widthRate;
    
        /**
       * @return 0~1 之间的浮点数，细节部位图片宽度占原图的比例
    */
        public double? getWidthRate() {
               	return widthRate;
            }
    
    /**
     * 设置0~1 之间的浮点数，细节部位图片宽度占原图的比例     *
     * 参数示例：<pre>0.5</pre>     
             * 此参数必填
          */
    public void setWidthRate(double widthRate) {
     	         	    this.widthRate = widthRate;
     	        }
    
        [DataMember(Order = 4)]
    private double? heightRate;
    
        /**
       * @return 0~1 之间的浮点数，细节部位图片高度占原图的比例
    */
        public double? getHeightRate() {
               	return heightRate;
            }
    
    /**
     * 设置0~1 之间的浮点数，细节部位图片高度占原图的比例     *
     * 参数示例：<pre>0.5</pre>     
             * 此参数必填
          */
    public void setHeightRate(double heightRate) {
     	         	    this.heightRate = heightRate;
     	        }
    
        [DataMember(Order = 5)]
    private double? xRate;
    
        /**
       * @return 0~1 之间的浮点数，细节部位图片左上角 x 坐标在原图中的位置比例
    */
        public double? getXRate() {
               	return xRate;
            }
    
    /**
     * 设置0~1 之间的浮点数，细节部位图片左上角 x 坐标在原图中的位置比例     *
     * 参数示例：<pre>0.5</pre>     
             * 此参数必填
          */
    public void setXRate(double xRate) {
     	         	    this.xRate = xRate;
     	        }
    
        [DataMember(Order = 6)]
    private double? yRate;
    
        /**
       * @return 0~1 之间的浮点数，细节部位图片左上角 y 坐标在原图中的位置比例
    */
        public double? getYRate() {
               	return yRate;
            }
    
    /**
     * 设置0~1 之间的浮点数，细节部位图片左上角 y 坐标在原图中的位置比例     *
     * 参数示例：<pre>0.5</pre>     
             * 此参数必填
          */
    public void setYRate(double yRate) {
     	         	    this.yRate = yRate;
     	        }
    
    
  }
}