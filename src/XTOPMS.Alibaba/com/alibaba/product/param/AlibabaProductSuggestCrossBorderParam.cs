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
public class AlibabaProductSuggestCrossBorderParam : GatewayAPIRequest {

    public AlibabaProductSuggestCrossBorderParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.suggest.crossBorder",1);
	}
	
       [DataMember(Order = 1)]
    private string keyWord;
    
        /**
       * @return 商品的搜索关键字，通常是商品的标题
    */
        public string getKeyWord() {
               	return keyWord;
            }
    
    /**
     * 设置商品的搜索关键字，通常是商品的标题     *
     * 参数示例：<pre>商品标题</pre>     
             * 此参数必填
          */
    public void setKeyWord(string keyWord) {
     	         	    this.keyWord = keyWord;
     	        }
    
        [DataMember(Order = 2)]
    private string loginId;
    
        /**
       * @return 卖家loginId
    */
        public string getLoginId() {
               	return loginId;
            }
    
    /**
     * 设置卖家loginId     *
     * 参数示例：<pre>alitestforisv01</pre>     
             * 此参数必填
          */
    public void setLoginId(string loginId) {
     	         	    this.loginId = loginId;
     	        }
    
    
  }
}