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
public class AlibabaAitoolsProductAttrResolveResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private string categoryID;
    
        /**
       * @return AI 识别出的二三级类目ID
    */
        public string getCategoryID() {
               	return categoryID;
            }
    
    /**
     * 设置AI 识别出的二三级类目ID     *
          
             * 此参数必填
          */
    public void setCategoryID(string categoryID) {
     	         	    this.categoryID = categoryID;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaProductProductAttribute[] attributes;
    
        /**
       * @return 属性列表。如果同一个属性包含多个识别出的属性值，那么属性值会按照识别评分从高到低排列（识别度越高的属性值排名越靠前）
    */
        public AlibabaProductProductAttribute[] getAttributes() {
               	return attributes;
            }
    
    /**
     * 设置属性列表。如果同一个属性包含多个识别出的属性值，那么属性值会按照识别评分从高到低排列（识别度越高的属性值排名越靠前）     *
          
             * 此参数必填
          */
    public void setAttributes(AlibabaProductProductAttribute[] attributes) {
     	         	    this.attributes = attributes;
     	        }
    
        [DataMember(Order = 3)]
    private string articleNumber;
    
        /**
       * @return 自动生成的货号
    */
        public string getArticleNumber() {
               	return articleNumber;
            }
    
    /**
     * 设置自动生成的货号     *
          
             * 此参数必填
          */
    public void setArticleNumber(string articleNumber) {
     	         	    this.articleNumber = articleNumber;
     	        }
    
    
  }
}