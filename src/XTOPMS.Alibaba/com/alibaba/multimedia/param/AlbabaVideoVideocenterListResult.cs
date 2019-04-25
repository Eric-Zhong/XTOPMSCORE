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
public class AlbabaVideoVideocenterListResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaOceanOpenplatformCommonPageResult result;
    
        /**
       * @return 返回视频结果
    */
        public AlibabaOceanOpenplatformCommonPageResult getResult() {
               	return result;
            }
    
    /**
     * 设置返回视频结果     *
          
             * 此参数必填
          */
    public void setResult(AlibabaOceanOpenplatformCommonPageResult result) {
     	         	    this.result = result;
     	        }
    
    
  }
}