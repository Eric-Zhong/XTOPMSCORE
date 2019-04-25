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
public class AlibabaProductItemIDDefinition {

       [DataMember(Order = 1)]
    private string skuId;
    
        /**
       * @return skuId对应平台的skuID
    */
        public string getSkuId() {
               	return skuId;
            }
    
    /**
     * 设置skuId对应平台的skuID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkuId(string skuId) {
     	         	    this.skuId = skuId;
     	        }
    
        [DataMember(Order = 2)]
    private string spuId;
    
        /**
       * @return spuID, 对应平台的offerId或者productId
    */
        public string getSpuId() {
               	return spuId;
            }
    
    /**
     * 设置spuID, 对应平台的offerId或者productId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSpuId(string spuId) {
     	         	    this.spuId = spuId;
     	        }
    
        [DataMember(Order = 3)]
    private string skuName;
    
        /**
       * @return skuId对应平台的名称
    */
        public string getSkuName() {
               	return skuName;
            }
    
    /**
     * 设置skuId对应平台的名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkuName(string skuName) {
     	         	    this.skuName = skuName;
     	        }
    
    
  }
}