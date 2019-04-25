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
public class AlibabaCpsTradeBillListResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaCpsOpenTradeBillDTO[] tradeBillList;
    
        /**
       * @return cps交易列表
    */
        public AlibabaCpsOpenTradeBillDTO[] getTradeBillList() {
               	return tradeBillList;
            }
    
    /**
     * 设置cps交易列表     *
          
             * 此参数必填
          */
    public void setTradeBillList(AlibabaCpsOpenTradeBillDTO[] tradeBillList) {
     	         	    this.tradeBillList = tradeBillList;
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