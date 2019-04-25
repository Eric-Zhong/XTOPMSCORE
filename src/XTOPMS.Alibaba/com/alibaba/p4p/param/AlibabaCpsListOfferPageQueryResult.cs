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
public class AlibabaCpsListOfferPageQueryResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaCpsOpenOfferDTO[] result;
    
        /**
       * @return 列表
    */
        public AlibabaCpsOpenOfferDTO[] getResult() {
               	return result;
            }
    
    /**
     * 设置列表     *
          
             * 此参数必填
          */
    public void setResult(AlibabaCpsOpenOfferDTO[] result) {
     	         	    this.result = result;
     	        }
    
        [DataMember(Order = 2)]
    private int? totalRow;
    
        /**
       * @return 总记录数
    */
        public int? getTotalRow() {
               	return totalRow;
            }
    
    /**
     * 设置总记录数     *
          
             * 此参数必填
          */
    public void setTotalRow(int totalRow) {
     	         	    this.totalRow = totalRow;
     	        }
    
    
  }
}