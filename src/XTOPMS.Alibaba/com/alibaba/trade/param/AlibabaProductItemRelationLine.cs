using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.trade.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductItemRelationLine {

       [DataMember(Order = 1)]
    private AlibabaProductProductItemInfo[] productItemInfos;
    
        /**
       * @return 
    */
        public AlibabaProductProductItemInfo[] getProductItemInfos() {
               	return productItemInfos;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductItemInfos(AlibabaProductProductItemInfo[] productItemInfos) {
     	         	    this.productItemInfos = productItemInfos;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaProductItemIDDefinition idOfSupplier;
    
        /**
       * @return 
    */
        public AlibabaProductItemIDDefinition getIdOfSupplier() {
               	return idOfSupplier;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIdOfSupplier(AlibabaProductItemIDDefinition idOfSupplier) {
     	         	    this.idOfSupplier = idOfSupplier;
     	        }
    
    
  }
}