using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.product.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductProductInfoListResult {

       [DataMember(Order = 1)]
    private AlibabaProductPageResult pageResult;
    
        /**
       * @return 查询结果
    */
        public AlibabaProductPageResult getPageResult() {
               	return pageResult;
            }
    
    /**
     * 设置查询结果     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPageResult(AlibabaProductPageResult pageResult) {
     	         	    this.pageResult = pageResult;
     	        }
    
    
  }
}