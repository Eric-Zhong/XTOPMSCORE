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
public class AlibabaOpenplatformTradeModelGuaranteeTermsInfo {

       [DataMember(Order = 1)]
    private string assuranceInfo;
    
        /**
       * @return 保障条款
    */
        public string getAssuranceInfo() {
               	return assuranceInfo;
            }
    
    /**
     * 设置保障条款     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAssuranceInfo(string assuranceInfo) {
     	         	    this.assuranceInfo = assuranceInfo;
     	        }
    
        [DataMember(Order = 2)]
    private string assuranceType;
    
        /**
       * @return 保障方式。国际站：TA(信保)
    */
        public string getAssuranceType() {
               	return assuranceType;
            }
    
    /**
     * 设置保障方式。国际站：TA(信保)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAssuranceType(string assuranceType) {
     	         	    this.assuranceType = assuranceType;
     	        }
    
        [DataMember(Order = 3)]
    private string qualityAssuranceType;
    
        /**
       * @return 质量保证类型。国际站：pre_shipment(发货前),post_delivery(发货后)
    */
        public string getQualityAssuranceType() {
               	return qualityAssuranceType;
            }
    
    /**
     * 设置质量保证类型。国际站：pre_shipment(发货前),post_delivery(发货后)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setQualityAssuranceType(string qualityAssuranceType) {
     	         	    this.qualityAssuranceType = qualityAssuranceType;
     	        }
    
    
  }
}