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
public class AlibabaPhotobankPhotoAddParam : GatewayAPIRequest {

    public AlibabaPhotobankPhotoAddParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.photobank.photo.add",1);
	}
	
       [DataMember(Order = 1)]
    private long? albumID;
    
        /**
       * @return 相册ID，1688必须传此参数，国际站可不传
    */
        public long? getAlbumID() {
               	return albumID;
            }
    
    /**
     * 设置相册ID，1688必须传此参数，国际站可不传     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAlbumID(long albumID) {
     	         	    this.albumID = albumID;
     	        }
    
        [DataMember(Order = 2)]
    private string name;
    
        /**
       * @return 图片名称。最长30个中文字符
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置图片名称。最长30个中文字符     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
        [DataMember(Order = 3)]
    private string description;
    
        /**
       * @return 图片描述。最长2000个中文字符
    */
        public string getDescription() {
               	return description;
            }
    
    /**
     * 设置图片描述。最长2000个中文字符     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDescription(string description) {
     	         	    this.description = description;
     	        }
    
        [DataMember(Order = 4)]
    private bool? drawTxt;
    
        /**
       * @return 是否打上默认水印，国际站无需处理此字段
    */
        public bool? getDrawTxt() {
               	return drawTxt;
            }
    
    /**
     * 设置是否打上默认水印，国际站无需处理此字段     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDrawTxt(bool drawTxt) {
     	         	    this.drawTxt = drawTxt;
     	        }
    
        [DataMember(Order = 5)]
    private byte[] imageBytes;
    
        /**
       * @return 图片的二进制数据，向服务端提交文件即可 (二进制文件数组 PHP 的话，用 base64_encode 转换 ，JAVA 是 通过 IOUtils.toByteArray 转换)
    */
        public byte[] getImageBytes() {
               	return imageBytes;
            }
    
    /**
     * 设置图片的二进制数据，向服务端提交文件即可 (二进制文件数组 PHP 的话，用 base64_encode 转换 ，JAVA 是 通过 IOUtils.toByteArray 转换)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setImageBytes(byte[] imageBytes) {
     	         	    this.imageBytes = imageBytes;
     	        }
    
        [DataMember(Order = 6)]
    private string webSite;
    
        /**
       * @return 站点信息，指定调用的API是属于国际站（alibaba）还是1688网站（1688）
    */
        public string getWebSite() {
               	return webSite;
            }
    
    /**
     * 设置站点信息，指定调用的API是属于国际站（alibaba）还是1688网站（1688）     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setWebSite(string webSite) {
     	         	    this.webSite = webSite;
     	        }
    
    
  }
}