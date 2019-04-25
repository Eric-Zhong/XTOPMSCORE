using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.logistics.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaDistributorGetSupplierFreightTemplatesParam : GatewayAPIRequest {

    public AlibabaDistributorGetSupplierFreightTemplatesParam() {
        this.ApiId = new APIId("com.alibaba.logistics", "alibaba.distributor.getSupplierFreightTemplates",1);
	}
	
       [DataMember(Order = 1)]
    private string supplierLoginId;
    
        /**
       * @return 供应商的LoginId
    */
        public string getSupplierLoginId() {
               	return supplierLoginId;
            }
    
    /**
     * 设置供应商的LoginId     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setSupplierLoginId(string supplierLoginId) {
     	         	    this.supplierLoginId = supplierLoginId;
     	        }
    
        [DataMember(Order = 2)]
    private long? templateId;
    
        /**
       * @return 运费模版id，用于单条查询的场景，如果不传的话，则是查所有模版
    */
        public long? getTemplateId() {
               	return templateId;
            }
    
    /**
     * 设置运费模版id，用于单条查询的场景，如果不传的话，则是查所有模版     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setTemplateId(long templateId) {
     	         	    this.templateId = templateId;
     	        }
    
        [DataMember(Order = 3)]
    private bool? querySubTemplate;
    
        /**
       * @return 是否查询子模板
    */
        public bool? getQuerySubTemplate() {
               	return querySubTemplate;
            }
    
    /**
     * 设置是否查询子模板     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setQuerySubTemplate(bool querySubTemplate) {
     	         	    this.querySubTemplate = querySubTemplate;
     	        }
    
        [DataMember(Order = 4)]
    private bool? queryRate;
    
        /**
       * @return 是否查询子模板费率
    */
        public bool? getQueryRate() {
               	return queryRate;
            }
    
    /**
     * 设置是否查询子模板费率     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setQueryRate(bool queryRate) {
     	         	    this.queryRate = queryRate;
     	        }
    
    
  }
}