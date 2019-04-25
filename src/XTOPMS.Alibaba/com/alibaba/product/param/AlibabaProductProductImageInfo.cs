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
public class AlibabaProductProductImageInfo {

       [DataMember(Order = 1)]
    private string[] images;
    
        /**
       * @return 主图列表，使用相对路径，需要增加域名：https://cbu01.alicdn.com/
    */
        public string[] getImages() {
               	return images;
            }
    
    /**
     * 设置主图列表，使用相对路径，需要增加域名：https://cbu01.alicdn.com/     *
     * 参数示例：<pre>["img/ibank/2014/766/624/1652426667_642119312.jpg","img/ibank/2014/656/624/1652426656_642119312.jpg","img/ibank/2014/236/624/1652426632_642119312.jpg"]</pre>     
             * 此参数必填
          */
    public void setImages(string[] images) {
     	         	    this.images = images;
     	        }
    
    
  }
}