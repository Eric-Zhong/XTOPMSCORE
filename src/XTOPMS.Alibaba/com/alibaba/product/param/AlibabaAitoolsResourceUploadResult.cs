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
public class AlibabaAitoolsResourceUploadResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private string recogniseID;
    
        /**
       * @return 全局唯一的识别号，自动生成，作为后续各种 AI 能力的入参使用
    */
        public string getRecogniseID() {
               	return recogniseID;
            }
    
    /**
     * 设置全局唯一的识别号，自动生成，作为后续各种 AI 能力的入参使用     *
          
             * 此参数必填
          */
    public void setRecogniseID(string recogniseID) {
     	         	    this.recogniseID = recogniseID;
     	        }
    
    
  }
}