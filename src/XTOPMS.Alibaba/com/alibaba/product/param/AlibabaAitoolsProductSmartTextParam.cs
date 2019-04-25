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
public class AlibabaAitoolsProductSmartTextParam : GatewayAPIRequest {

    public AlibabaAitoolsProductSmartTextParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.aitools.product.smart.text",1);
	}
	
       [DataMember(Order = 1)]
    private string recogniseID;
    
        /**
       * @return 识别号，使用慧眼识货资源上传 API 上传资源后，自动生成
    */
        public string getRecogniseID() {
               	return recogniseID;
            }
    
    /**
     * 设置识别号，使用慧眼识货资源上传 API 上传资源后，自动生成     *
     * 参数示例：<pre>xxxxxxxxxxx-xxx</pre>     
             * 此参数必填
          */
    public void setRecogniseID(string recogniseID) {
     	         	    this.recogniseID = recogniseID;
     	        }
    
        [DataMember(Order = 2)]
    private string rootCategoryID;
    
        /**
       * @return 一级类目ID
    */
        public string getRootCategoryID() {
               	return rootCategoryID;
            }
    
    /**
     * 设置一级类目ID     *
     * 参数示例：<pre>10166</pre>     
             * 此参数必填
          */
    public void setRootCategoryID(string rootCategoryID) {
     	         	    this.rootCategoryID = rootCategoryID;
     	        }
    
        [DataMember(Order = 3)]
    private string categoryID;
    
        /**
       * @return 商品所属末级类目ID，比如连衣裙、T恤等
    */
        public string getCategoryID() {
               	return categoryID;
            }
    
    /**
     * 设置商品所属末级类目ID，比如连衣裙、T恤等     *
     * 参数示例：<pre>12345</pre>     
             * 此参数必填
          */
    public void setCategoryID(string categoryID) {
     	         	    this.categoryID = categoryID;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaAitoolsProductProductAttribute[] attributes;
    
        /**
       * @return 商品属性列表
    */
        public AlibabaAitoolsProductProductAttribute[] getAttributes() {
               	return attributes;
            }
    
    /**
     * 设置商品属性列表     *
     * 参数示例：<pre>[]</pre>     
             * 此参数必填
          */
    public void setAttributes(AlibabaAitoolsProductProductAttribute[] attributes) {
     	         	    this.attributes = attributes;
     	        }
    
    
  }
}