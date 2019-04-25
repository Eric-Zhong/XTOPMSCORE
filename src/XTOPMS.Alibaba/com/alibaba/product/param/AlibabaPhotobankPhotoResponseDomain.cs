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
public class AlibabaPhotobankPhotoResponseDomain {

       [DataMember(Order = 1)]
    private long? id;
    
        /**
       * @return 图片ID
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置图片ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setId(long id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 2)]
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
    
        [DataMember(Order = 3)]
    private string name;
    
        /**
       * @return 图片名称
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置图片名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
        [DataMember(Order = 4)]
    private string url;
    
        /**
       * @return 图片url
    */
        public string getUrl() {
               	return url;
            }
    
    /**
     * 设置图片url     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUrl(string url) {
     	         	    this.url = url;
     	        }
    
    
  }
}