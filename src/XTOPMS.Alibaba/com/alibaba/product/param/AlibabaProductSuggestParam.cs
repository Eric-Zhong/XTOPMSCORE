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
public class AlibabaProductSuggestParam : GatewayAPIRequest {

    public AlibabaProductSuggestParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.suggest",1);
	}
	
       [DataMember(Order = 1)]
    private long? categoryId;
    
        /**
       * @return 一级类目ID
    */
        public long? getCategoryId() {
               	return categoryId;
            }
    
    /**
     * 设置一级类目ID     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setCategoryId(long categoryId) {
     	         	    this.categoryId = categoryId;
     	        }
    
        [DataMember(Order = 2)]
    private string loginId;
    
        /**
       * @return 1688的登录名
    */
        public string getLoginId() {
               	return loginId;
            }
    
    /**
     * 设置1688的登录名     *
     * 参数示例：<pre>alitestforisv01</pre>     
             * 此参数必填
          */
    public void setLoginId(string loginId) {
     	         	    this.loginId = loginId;
     	        }
    
        [DataMember(Order = 3)]
    private string taobaoNick;
    
        /**
       * @return 淘宝昵称
    */
        public string getTaobaoNick() {
               	return taobaoNick;
            }
    
    /**
     * 设置淘宝昵称     *
     * 参数示例：<pre>alitestforisv01</pre>     
             * 此参数必填
          */
    public void setTaobaoNick(string taobaoNick) {
     	         	    this.taobaoNick = taobaoNick;
     	        }
    
    
  }
}