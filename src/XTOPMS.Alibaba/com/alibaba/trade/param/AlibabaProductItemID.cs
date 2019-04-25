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
public class AlibabaProductItemID {

       [DataMember(Order = 1)]
    private AlibabaProductItemIDDefinition idOfSupplier;
    
        /**
       * @return 供应商端的ID详情
    */
        public AlibabaProductItemIDDefinition getIdOfSupplier() {
               	return idOfSupplier;
            }
    
    /**
     * 设置供应商端的ID详情     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIdOfSupplier(AlibabaProductItemIDDefinition idOfSupplier) {
     	         	    this.idOfSupplier = idOfSupplier;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaProductItemIDDefinition idOfPlatform;
    
        /**
       * @return 平台端的ID详情
    */
        public AlibabaProductItemIDDefinition getIdOfPlatform() {
               	return idOfPlatform;
            }
    
    /**
     * 设置平台端的ID详情     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIdOfPlatform(AlibabaProductItemIDDefinition idOfPlatform) {
     	         	    this.idOfPlatform = idOfPlatform;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaProductItemIDDefinition idOfBuyer;
    
        /**
       * @return 买家端的ID详情
    */
        public AlibabaProductItemIDDefinition getIdOfBuyer() {
               	return idOfBuyer;
            }
    
    /**
     * 设置买家端的ID详情     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIdOfBuyer(AlibabaProductItemIDDefinition idOfBuyer) {
     	         	    this.idOfBuyer = idOfBuyer;
     	        }
    
    
  }
}