using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.p4p.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaCpsListGroupInfoResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaCpsOpenUnionGroupDTO[] result;
    
        /**
       * @return  
    */
        public AlibabaCpsOpenUnionGroupDTO[] getResult() {
               	return result;
            }
    
    /**
     * 设置      *
          
             * 此参数必填
          */
    public void setResult(AlibabaCpsOpenUnionGroupDTO[] result) {
     	         	    this.result = result;
     	        }
    
    
  }
}