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
public class AlibabaProcureSearchParam : GatewayAPIRequest {

    public AlibabaProcureSearchParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.procure.search",1);
	}
	
       [DataMember(Order = 1)]
    private string obUid;
    
        /**
       * @return 海外小b用户账号
    */
        public string getObUid() {
               	return obUid;
            }
    
    /**
     * 设置海外小b用户账号     *
     * 参数示例：<pre>th123456789</pre>     
             * 此参数必填
          */
    public void setObUid(string obUid) {
     	         	    this.obUid = obUid;
     	        }
    
        [DataMember(Order = 2)]
    private string keywords;
    
        /**
       * @return 搜索关键字，多个关键字用空格分隔
    */
        public string getKeywords() {
               	return keywords;
            }
    
    /**
     * 设置搜索关键字，多个关键字用空格分隔     *
     * 参数示例：<pre>女装 连衣裙</pre>     
             * 此参数必填
          */
    public void setKeywords(string keywords) {
     	         	    this.keywords = keywords;
     	        }
    
    
  }
}