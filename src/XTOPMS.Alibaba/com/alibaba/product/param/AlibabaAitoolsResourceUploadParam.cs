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
public class AlibabaAitoolsResourceUploadParam : GatewayAPIRequest {

    public AlibabaAitoolsResourceUploadParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.aitools.resource.upload",1);
	}
	
       [DataMember(Order = 1)]
    private byte[] imageBytes;
    
        /**
       * @return 商品图片，最大2MB，建议使用500*500像素以上，支持jpg/jpeg/png格式，纯色背景图片，推荐白色；图片比例为正方形，商品居中，识别主体的在图片中占比大于80%； 调用方注意图片的方向，该 API 只能比较准确地识别正向的图片（比如，由于手持设备引起的图片旋转 90 度后，会造成识别结果的不准确，甚至出错）；另外调用方上传图片前可自由美化图片； 请求向服务端提交文件即可 (商品图片二进制文件数组 PHP 的话，用 base64_encode 转换 ，JAVA 是 通过 IOUtils.toByteArray 转换)
    */
        public byte[] getImageBytes() {
               	return imageBytes;
            }
    
    /**
     * 设置商品图片，最大2MB，建议使用500*500像素以上，支持jpg/jpeg/png格式，纯色背景图片，推荐白色；图片比例为正方形，商品居中，识别主体的在图片中占比大于80%； 调用方注意图片的方向，该 API 只能比较准确地识别正向的图片（比如，由于手持设备引起的图片旋转 90 度后，会造成识别结果的不准确，甚至出错）；另外调用方上传图片前可自由美化图片； 请求向服务端提交文件即可 (商品图片二进制文件数组 PHP 的话，用 base64_encode 转换 ，JAVA 是 通过 IOUtils.toByteArray 转换)     *
     * 参数示例：<pre>[1,2,3,4]</pre>     
             * 此参数必填
          */
    public void setImageBytes(byte[] imageBytes) {
     	         	    this.imageBytes = imageBytes;
     	        }
    
        [DataMember(Order = 2)]
    private byte[] tagBytes;
    
        /**
       * @return 非必填，商品吊牌图片，用于辅助生成更加准确的商品属性，最大2MB，建议使用500*500像素以上，支持jpg/jpeg/png格式；调用方注意图片的方向，该 API 只能比较准确地识别正向的图片（比如，由于手持设备引起的图片旋转 90 度后，会造成识别结果的不准确，甚至出错）；请求向服务端提交文件即可 (图片二进制文件数组 PHP 的话，用 base64_encode 转换 ，JAVA 是 通过 IOUtils.toByteArray 转换)
    */
        public byte[] getTagBytes() {
               	return tagBytes;
            }
    
    /**
     * 设置非必填，商品吊牌图片，用于辅助生成更加准确的商品属性，最大2MB，建议使用500*500像素以上，支持jpg/jpeg/png格式；调用方注意图片的方向，该 API 只能比较准确地识别正向的图片（比如，由于手持设备引起的图片旋转 90 度后，会造成识别结果的不准确，甚至出错）；请求向服务端提交文件即可 (图片二进制文件数组 PHP 的话，用 base64_encode 转换 ，JAVA 是 通过 IOUtils.toByteArray 转换)     *
     * 参数示例：<pre>[1,2,3]</pre>     
             * 此参数必填
          */
    public void setTagBytes(byte[] tagBytes) {
     	         	    this.tagBytes = tagBytes;
     	        }
    
    
  }
}