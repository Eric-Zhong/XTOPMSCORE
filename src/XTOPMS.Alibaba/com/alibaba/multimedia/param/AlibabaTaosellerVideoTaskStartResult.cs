using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.multimedia.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaTaosellerVideoTaskStartResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private ComAlibabaOceanOpenplatformCommonResultModel result;
    
        /**
       * @return 调用返回结果
    */
        public ComAlibabaOceanOpenplatformCommonResultModel getResult() {
               	return result;
            }
    
    /**
     * 设置调用返回结果     *
          
             * 此参数必填
          */
    public void setResult(ComAlibabaOceanOpenplatformCommonResultModel result) {
     	         	    this.result = result;
     	        }
    
    
  }
}