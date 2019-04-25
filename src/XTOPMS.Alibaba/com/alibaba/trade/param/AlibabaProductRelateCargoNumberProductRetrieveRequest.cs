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
public class AlibabaProductRelateCargoNumberProductRetrieveRequest {

       [DataMember(Order = 1)]
    private long? supplyUserId;
    
        /**
       * @return 卖家ID
    */
        public long? getSupplyUserId() {
               	return supplyUserId;
            }
    
    /**
     * 设置卖家ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSupplyUserId(long supplyUserId) {
     	         	    this.supplyUserId = supplyUserId;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaProductItemIDDefinition[] idListOfSupplier;
    
        /**
       * @return 卖家的货号列表
    */
        public AlibabaProductItemIDDefinition[] getIdListOfSupplier() {
               	return idListOfSupplier;
            }
    
    /**
     * 设置卖家的货号列表     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIdListOfSupplier(AlibabaProductItemIDDefinition[] idListOfSupplier) {
     	         	    this.idListOfSupplier = idListOfSupplier;
     	        }
    
    
  }
}