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
public class AlibabaOpenplatformLogisticsDeliveryRateDetailDTO {

       [DataMember(Order = 1)]
    private string operateType;
    
        /**
       * @return 费率操作类型：INSERT,UPDATE,DELETE
    */
        public string getOperateType() {
               	return operateType;
            }
    
    /**
     * 设置费率操作类型：INSERT,UPDATE,DELETE     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOperateType(string operateType) {
     	         	    this.operateType = operateType;
     	        }
    
        [DataMember(Order = 2)]
    private bool? isSysRate;
    
        /**
       * @return 是否系统模板
    */
        public bool? getIsSysRate() {
               	return isSysRate;
            }
    
    /**
     * 设置是否系统模板     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsSysRate(bool isSysRate) {
     	         	    this.isSysRate = isSysRate;
     	        }
    
        [DataMember(Order = 3)]
    private string toAreaCodeText;
    
        /**
       * @return 地址编码文本，用顿号隔开。例如：上海、福建省、广东省
    */
        public string getToAreaCodeText() {
               	return toAreaCodeText;
            }
    
    /**
     * 设置地址编码文本，用顿号隔开。例如：上海、福建省、广东省     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToAreaCodeText(string toAreaCodeText) {
     	         	    this.toAreaCodeText = toAreaCodeText;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaOpenplatformLogisticsDeliveryRateDTO rateDTO;
    
        /**
       * @return 普通子模板费率
    */
        public AlibabaOpenplatformLogisticsDeliveryRateDTO getRateDTO() {
               	return rateDTO;
            }
    
    /**
     * 设置普通子模板费率     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRateDTO(AlibabaOpenplatformLogisticsDeliveryRateDTO rateDTO) {
     	         	    this.rateDTO = rateDTO;
     	        }
    
        [DataMember(Order = 5)]
    private AlibabaOpenplatformLogisticsDeliverySysRateDTO sysRateDTO;
    
        /**
       * @return 系统子模板费率
    */
        public AlibabaOpenplatformLogisticsDeliverySysRateDTO getSysRateDTO() {
               	return sysRateDTO;
            }
    
    /**
     * 设置系统子模板费率     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSysRateDTO(AlibabaOpenplatformLogisticsDeliverySysRateDTO sysRateDTO) {
     	         	    this.sysRateDTO = sysRateDTO;
     	        }
    
    
  }
}