using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.product.push.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductPushPushProductSKUResult {

       [DataMember(Order = 1)]
    private string skuIdInSource;
    
        /**
       * @return 在源平台的SKU标志
    */
        public string getSkuIdInSource() {
               	return skuIdInSource;
            }
    
    /**
     * 设置在源平台的SKU标志     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkuIdInSource(string skuIdInSource) {
     	         	    this.skuIdInSource = skuIdInSource;
     	        }
    
        [DataMember(Order = 2)]
    private string skuIdInPartner;
    
        /**
       * @return 在第三方平台的SKU标志
    */
        public string getSkuIdInPartner() {
               	return skuIdInPartner;
            }
    
    /**
     * 设置在第三方平台的SKU标志     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkuIdInPartner(string skuIdInPartner) {
     	         	    this.skuIdInPartner = skuIdInPartner;
     	        }
    
        [DataMember(Order = 3)]
    private string skuPushStatus;
    
        /**
       * @return 铺货状态
    */
        public string getSkuPushStatus() {
               	return skuPushStatus;
            }
    
    /**
     * 设置铺货状态     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkuPushStatus(string skuPushStatus) {
     	         	    this.skuPushStatus = skuPushStatus;
     	        }
    
        [DataMember(Order = 4)]
    private string skuIdInTargetPlatform;
    
        /**
       * @return 在目标平台的SKU标志
    */
        public string getSkuIdInTargetPlatform() {
               	return skuIdInTargetPlatform;
            }
    
    /**
     * 设置在目标平台的SKU标志     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkuIdInTargetPlatform(string skuIdInTargetPlatform) {
     	         	    this.skuIdInTargetPlatform = skuIdInTargetPlatform;
     	        }
    
        [DataMember(Order = 5)]
    private AlibabaProductPushSimpleItemDesc skuInfoInTargetPlatform;
    
        /**
       * @return SKU铺货结果
    */
        public AlibabaProductPushSimpleItemDesc getSkuInfoInTargetPlatform() {
               	return skuInfoInTargetPlatform;
            }
    
    /**
     * 设置SKU铺货结果     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSkuInfoInTargetPlatform(AlibabaProductPushSimpleItemDesc skuInfoInTargetPlatform) {
     	         	    this.skuInfoInTargetPlatform = skuInfoInTargetPlatform;
     	        }
    
        [DataMember(Order = 6)]
    private AlibabaProductPushAttributeRelationMapping[] mappingInfo;
    
        /**
       * @return 属性映射关系
    */
        public AlibabaProductPushAttributeRelationMapping[] getMappingInfo() {
               	return mappingInfo;
            }
    
    /**
     * 设置属性映射关系     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMappingInfo(AlibabaProductPushAttributeRelationMapping[] mappingInfo) {
     	         	    this.mappingInfo = mappingInfo;
     	        }
    
    
  }
}