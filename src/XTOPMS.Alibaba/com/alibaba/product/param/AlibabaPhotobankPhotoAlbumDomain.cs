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
public class AlibabaPhotobankPhotoAlbumDomain {

       [DataMember(Order = 1)]
    private long? albumID;
    
        /**
       * @return 相册ID
    */
        public long? getAlbumID() {
               	return albumID;
            }
    
    /**
     * 设置相册ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAlbumID(long albumID) {
     	         	    this.albumID = albumID;
     	        }
    
        [DataMember(Order = 2)]
    private string name;
    
        /**
       * @return 相册名称
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置相册名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
        [DataMember(Order = 3)]
    private string description;
    
        /**
       * @return 相册描述，国际站无此信息
    */
        public string getDescription() {
               	return description;
            }
    
    /**
     * 设置相册描述，国际站无此信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDescription(string description) {
     	         	    this.description = description;
     	        }
    
        [DataMember(Order = 4)]
    private int? authority;
    
        /**
       * @return 相册访问权限。取值范围:0-不公开；1-公开；2-密码访问。只有开通旺铺的会员可以设置相册访问权限为“1-公开”和“2-密码访问”，未开通旺铺的会员相册访问权限限制为“0-不公开”。国际站无此信息
    */
        public int? getAuthority() {
               	return authority;
            }
    
    /**
     * 设置相册访问权限。取值范围:0-不公开；1-公开；2-密码访问。只有开通旺铺的会员可以设置相册访问权限为“1-公开”和“2-密码访问”，未开通旺铺的会员相册访问权限限制为“0-不公开”。国际站无此信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAuthority(int authority) {
     	         	    this.authority = authority;
     	        }
    
        [DataMember(Order = 5)]
    private int? imageCount;
    
        /**
       * @return 图片数量
    */
        public int? getImageCount() {
               	return imageCount;
            }
    
    /**
     * 设置图片数量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setImageCount(int imageCount) {
     	         	    this.imageCount = imageCount;
     	        }
    
    
  }
}