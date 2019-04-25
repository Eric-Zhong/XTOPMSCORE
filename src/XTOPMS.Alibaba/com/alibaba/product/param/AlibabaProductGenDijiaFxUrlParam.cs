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
public class AlibabaProductGenDijiaFxUrlParam : GatewayAPIRequest {

    public AlibabaProductGenDijiaFxUrlParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.genDijiaFxUrl",1);
	}
	
       [DataMember(Order = 1)]
    private string isvId;
    
        /**
       * @return ISV唯一标识，联系小二提供
    */
        public string getIsvId() {
               	return isvId;
            }
    
    /**
     * 设置ISV唯一标识，联系小二提供     *
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
    private string detailUrl;
    
        /**
       * @return 1688商品URL
    */
        public string getDetailUrl() {
               	return detailUrl;
            }
    
    /**
     * 设置1688商品URL     *
     * 参数示例：<pre>https://detail.1688.com/offer/560137.html</pre>     
             * 此参数必填
          */
    public void setDetailUrl(string detailUrl) {
     	         	    this.detailUrl = detailUrl;
     	        }
    
        [DataMember(Order = 4)]
    private string offerId;
    
        /**
       * @return 1688商品ID
    */
        public string getOfferId() {
               	return offerId;
            }
    
    /**
     * 设置1688商品ID     *
     * 参数示例：<pre>560137</pre>     
             * 此参数必填
          */
    public void setOfferId(string offerId) {
     	         	    this.offerId = offerId;
     	        }
    
    
  }
}