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
public class AlibabaCategorySearchByKeywordParam : GatewayAPIRequest {

    public AlibabaCategorySearchByKeywordParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.category.searchByKeyword",1);
	}
	
       [DataMember(Order = 1)]
    private string keyword;
    
        /**
       * @return 叶子类目关键字
    */
        public string getKeyword() {
               	return keyword;
            }
    
    /**
     * 设置叶子类目关键字     *
     * 参数示例：<pre>帽子</pre>     
             * 此参数必填
          */
    public void setKeyword(string keyword) {
     	         	    this.keyword = keyword;
     	        }
    
    
  }
}