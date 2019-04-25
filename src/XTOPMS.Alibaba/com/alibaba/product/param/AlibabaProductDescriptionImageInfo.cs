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
public class AlibabaProductDescriptionImageInfo {

       [DataMember(Order = 1)]
    private string url;
    
        /**
       * @return URL 地址
    */
        public string getUrl() {
               	return url;
            }
    
    /**
     * 设置URL 地址     *
     * 参数示例：<pre>http://foo/bar.jpg</pre>     
             * 此参数必填
          */
    public void setUrl(string url) {
     	         	    this.url = url;
     	        }
    
        [DataMember(Order = 2)]
    private int? width;
    
        /**
       * @return 图片宽度，像素单位
    */
        public int? getWidth() {
               	return width;
            }
    
    /**
     * 设置图片宽度，像素单位     *
     * 参数示例：<pre>123</pre>     
             * 此参数必填
          */
    public void setWidth(int width) {
     	         	    this.width = width;
     	        }
    
        [DataMember(Order = 3)]
    private int? height;
    
        /**
       * @return 图片高度，像素单位
    */
        public int? getHeight() {
               	return height;
            }
    
    /**
     * 设置图片高度，像素单位     *
     * 参数示例：<pre>234</pre>     
             * 此参数必填
          */
    public void setHeight(int height) {
     	         	    this.height = height;
     	        }
    
    
  }
}