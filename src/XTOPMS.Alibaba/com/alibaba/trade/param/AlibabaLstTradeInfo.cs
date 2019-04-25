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
public class AlibabaLstTradeInfo {

       [DataMember(Order = 1)]
    private string lstWarehouseType;
    
        /**
       * @return 零售通仓库类型。customer：虚仓；cainiao：实仓
    */
        public string getLstWarehouseType() {
               	return lstWarehouseType;
            }
    
    /**
     * 设置零售通仓库类型。customer：虚仓；cainiao：实仓     *
     * 参数示例：<pre>cainiao</pre>     
             * 此参数必填
          */
    public void setLstWarehouseType(string lstWarehouseType) {
     	         	    this.lstWarehouseType = lstWarehouseType;
     	        }
    
    
  }
}