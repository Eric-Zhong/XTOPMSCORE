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
public class AlibabaPhotobankPhotoDeleteBatchParam : GatewayAPIRequest {

    public AlibabaPhotobankPhotoDeleteBatchParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.photobank.photo.deleteBatch",1);
	}
	
       [DataMember(Order = 1)]
    private long[] imageIds;
    
        /**
       * @return 待操作图片ID列表，每次最多支持删除20张图片。
    */
        public long[] getImageIds() {
               	return imageIds;
            }
    
    /**
     * 设置待操作图片ID列表，每次最多支持删除20张图片。     *
     * 参数示例：<pre>[9268841037]</pre>     
             * 此参数必填
          */
    public void setImageIds(long[] imageIds) {
     	         	    this.imageIds = imageIds;
     	        }
    
        [DataMember(Order = 2)]
    private string webSite;
    
        /**
       * @return 1688或者alibaba
    */
        public string getWebSite() {
               	return webSite;
            }
    
    /**
     * 设置1688或者alibaba     *
     * 参数示例：<pre>1688</pre>     
             * 此参数必填
          */
    public void setWebSite(string webSite) {
     	         	    this.webSite = webSite;
     	        }
    
    
  }
}