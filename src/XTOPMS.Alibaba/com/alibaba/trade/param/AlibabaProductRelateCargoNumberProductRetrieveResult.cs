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
public class AlibabaProductRelateCargoNumberProductRetrieveResult {

       [DataMember(Order = 1)]
    private AlibabaProductItemRelationLine[] relatedProductItemLines;
    
        /**
       * @return 
    */
        public AlibabaProductItemRelationLine[] getRelatedProductItemLines() {
               	return relatedProductItemLines;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRelatedProductItemLines(AlibabaProductItemRelationLine[] relatedProductItemLines) {
     	         	    this.relatedProductItemLines = relatedProductItemLines;
     	        }
    
    
  }
}