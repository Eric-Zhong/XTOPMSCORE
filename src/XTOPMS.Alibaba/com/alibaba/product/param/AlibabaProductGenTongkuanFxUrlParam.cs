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
public class AlibabaProductGenTongkuanFxUrlParam : GatewayAPIRequest {

    public AlibabaProductGenTongkuanFxUrlParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.genTongkuanFxUrl",1);
	}
	
       [DataMember(Order = 1)]
    private string isvId;
    
        /**
       * @return ISV标识，联系小二提供
    */
        public string getIsvId() {
               	return isvId;
            }
    
    /**
     * 设置ISV标识，联系小二提供     *
     * 参数示例：<pre>fooerp</pre>     
             * 此参数必填
          */
    public void setIsvId(string isvId) {
     	         	    this.isvId = isvId;
     	        }
    
        [DataMember(Order = 2)]
    private string pid;
    
        /**
       * @return 分销客推广位PID
    */
        public string getPid() {
               	return pid;
            }
    
    /**
     * 设置分销客推广位PID     *
     * 参数示例：<pre>mm_2248544159</pre>     
             * 此参数必填
          */
    public void setPid(string pid) {
     	         	    this.pid = pid;
     	        }
    
        [DataMember(Order = 3)]
    private string productUrl;
    
        /**
       * @return 下游产品URL
    */
        public string getProductUrl() {
               	return productUrl;
            }
    
    /**
     * 设置下游产品URL     *
     * 参数示例：<pre>https://www.wish.com/c/546f3e9390</pre>     
             * 此参数必填
          */
    public void setProductUrl(string productUrl) {
     	         	    this.productUrl = productUrl;
     	        }
    
        [DataMember(Order = 4)]
    private string imgUrl;
    
        /**
       * @return 下游产品图片URL
    */
        public string getImgUrl() {
               	return imgUrl;
            }
    
    /**
     * 设置下游产品图片URL     *
     * 参数示例：<pre>https://contestimg.wish.com/api/webimage/foo-contest.jpg</pre>     
             * 此参数必填
          */
    public void setImgUrl(string imgUrl) {
     	         	    this.imgUrl = imgUrl;
     	        }
    
    
  }
}