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
public class AlibabaLogisticsMyFreightTemplateListGetParam : GatewayAPIRequest {

    public AlibabaLogisticsMyFreightTemplateListGetParam() {
        this.ApiId = new APIId("com.alibaba.logistics", "alibaba.logistics.myFreightTemplate.list.get",1);
	}
	
       [DataMember(Order = 1)]
    private long? templateId;
    
        /**
       * @return 模版id，用于单条查询的场景
    */
        public long? getTemplateId() {
               	return templateId;
            }
    
    /**
     * 设置模版id，用于单条查询的场景     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTemplateId(long templateId) {
     	         	    this.templateId = templateId;
     	        }
    
        [DataMember(Order = 2)]
    private bool? querySubTemplate;
    
        /**
       * @return 是否查询子模板
    */
        public bool? getQuerySubTemplate() {
               	return querySubTemplate;
            }
    
    /**
     * 设置是否查询子模板     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setQuerySubTemplate(bool querySubTemplate) {
     	         	    this.querySubTemplate = querySubTemplate;
     	        }
    
        [DataMember(Order = 3)]
    private bool? queryRate;
    
        /**
       * @return 是否查询子模板费率
    */
        public bool? getQueryRate() {
               	return queryRate;
            }
    
    /**
     * 设置是否查询子模板费率     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setQueryRate(bool queryRate) {
     	         	    this.queryRate = queryRate;
     	        }
    
    
  }
}