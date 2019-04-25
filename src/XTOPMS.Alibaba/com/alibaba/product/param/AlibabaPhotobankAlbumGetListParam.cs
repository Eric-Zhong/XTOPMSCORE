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
public class AlibabaPhotobankAlbumGetListParam : GatewayAPIRequest {

    public AlibabaPhotobankAlbumGetListParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.photobank.album.getList",1);
	}
	
       [DataMember(Order = 1)]
    private long? id;
    
        /**
       * @return 如传入相册ID，1688返回当前相册信息，国际站返回当前相册及下级信息。如不传此参数，1688返回所有相册信息列表，国际站返回所有一级相册列表
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置如传入相册ID，1688返回当前相册信息，国际站返回当前相册及下级信息。如不传此参数，1688返回所有相册信息列表，国际站返回所有一级相册列表     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setId(long id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 2)]
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
    
        [DataMember(Order = 3)]
    private string albumType;
    
        /**
       * @return 相册类型
    */
        public string getAlbumType() {
               	return albumType;
            }
    
    /**
     * 设置相册类型     *
     * 参数示例：<pre>MY:我的相册(系统相册); OFF:下架相册(系统相册); AUDTING:审核中(系统相册); NOPASS:审核不通过(系统相册); CUSTOM:自定义;</pre>     
             * 此参数必填
          */
    public void setAlbumType(string albumType) {
     	         	    this.albumType = albumType;
     	        }
    
    
  }
}