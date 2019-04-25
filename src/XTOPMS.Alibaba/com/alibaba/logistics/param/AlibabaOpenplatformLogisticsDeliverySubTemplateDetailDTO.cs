using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.logistics.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaOpenplatformLogisticsDeliverySubTemplateDetailDTO {

       [DataMember(Order = 1)]
    private string operateType;
    
        /**
       * @return 操作类型
    */
        public string getOperateType() {
               	return operateType;
            }
    
    /**
     * 设置操作类型     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOperateType(string operateType) {
     	         	    this.operateType = operateType;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaOpenplatformLogisticsDeliverySubTemplateDTO subTemplateDTO;
    
        /**
       * @return 子模板
    */
        public AlibabaOpenplatformLogisticsDeliverySubTemplateDTO getSubTemplateDTO() {
               	return subTemplateDTO;
            }
    
    /**
     * 设置子模板     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubTemplateDTO(AlibabaOpenplatformLogisticsDeliverySubTemplateDTO subTemplateDTO) {
     	         	    this.subTemplateDTO = subTemplateDTO;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaOpenplatformLogisticsDeliveryRateDetailDTO[] rateList;
    
        /**
       * @return 费率
    */
        public AlibabaOpenplatformLogisticsDeliveryRateDetailDTO[] getRateList() {
               	return rateList;
            }
    
    /**
     * 设置费率     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRateList(AlibabaOpenplatformLogisticsDeliveryRateDetailDTO[] rateList) {
     	         	    this.rateList = rateList;
     	        }
    
    
  }
}