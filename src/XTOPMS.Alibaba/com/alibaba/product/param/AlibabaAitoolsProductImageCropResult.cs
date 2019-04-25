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
public class AlibabaAitoolsProductImageCropResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaAitoolsProductProductImageDetail[] productDetails;
    
        /**
       * @return 慧眼识货商品图片细节列表。其中细节部位的图片区域大小和位置按照 0~1 之间的比例进行描述，比如原图为 800 x 600 像素大小的图片，widthRate = 0.5 / heightRate = 0.5 / xRate = 0.5 / yRate = 0.5，则细节图为原图的右下角 1/4 的部分。
    */
        public AlibabaAitoolsProductProductImageDetail[] getProductDetails() {
               	return productDetails;
            }
    
    /**
     * 设置慧眼识货商品图片细节列表。其中细节部位的图片区域大小和位置按照 0~1 之间的比例进行描述，比如原图为 800 x 600 像素大小的图片，widthRate = 0.5 / heightRate = 0.5 / xRate = 0.5 / yRate = 0.5，则细节图为原图的右下角 1/4 的部分。     *
          
             * 此参数必填
          */
    public void setProductDetails(AlibabaAitoolsProductProductImageDetail[] productDetails) {
     	         	    this.productDetails = productDetails;
     	        }
    
        [DataMember(Order = 2)]
    private int? imageWidth;
    
        /**
       * @return 原图宽度，像素为单位
    */
        public int? getImageWidth() {
               	return imageWidth;
            }
    
    /**
     * 设置原图宽度，像素为单位     *
          
             * 此参数必填
          */
    public void setImageWidth(int imageWidth) {
     	         	    this.imageWidth = imageWidth;
     	        }
    
        [DataMember(Order = 3)]
    private int? imageHeight;
    
        /**
       * @return 原图高度，像素为单位
    */
        public int? getImageHeight() {
               	return imageHeight;
            }
    
    /**
     * 设置原图高度，像素为单位     *
          
             * 此参数必填
          */
    public void setImageHeight(int imageHeight) {
     	         	    this.imageHeight = imageHeight;
     	        }
    
    
  }
}