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
public class AlibabaLogisticsFreightTemplate {

       [DataMember(Order = 1)]
    private string addressCodeText;
    
        /**
       * @return 地址信息
    */
        public string getAddressCodeText() {
               	return addressCodeText;
            }
    
    /**
     * 设置地址信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAddressCodeText(string addressCodeText) {
     	         	    this.addressCodeText = addressCodeText;
     	        }
    
        [DataMember(Order = 2)]
    private string fromAreaCode;
    
        /**
       * @return 发货地址地区码
    */
        public string getFromAreaCode() {
               	return fromAreaCode;
            }
    
    /**
     * 设置发货地址地区码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFromAreaCode(string fromAreaCode) {
     	         	    this.fromAreaCode = fromAreaCode;
     	        }
    
        [DataMember(Order = 3)]
    private long? id;
    
        /**
       * @return 模版ID
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置模版ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setId(long id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 4)]
    private string memberId;
    
        /**
       * @return 会员ID
    */
        public string getMemberId() {
               	return memberId;
            }
    
    /**
     * 设置会员ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMemberId(string memberId) {
     	         	    this.memberId = memberId;
     	        }
    
        [DataMember(Order = 5)]
    private string name;
    
        /**
       * @return 名称
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
        [DataMember(Order = 6)]
    private string remark;
    
        /**
       * @return 备注
    */
        public string getRemark() {
               	return remark;
            }
    
    /**
     * 设置备注     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRemark(string remark) {
     	         	    this.remark = remark;
     	        }
    
        [DataMember(Order = 7)]
    private int? status;
    
        /**
       * @return 状态
    */
        public int? getStatus() {
               	return status;
            }
    
    /**
     * 设置状态     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStatus(int status) {
     	         	    this.status = status;
     	        }
    
        [DataMember(Order = 8)]
    private AlibabaOpenplatformLogisticsDeliverySubTemplateDetailDTO expressSubTemplate;
    
        /**
       * @return 快递子模版
    */
        public AlibabaOpenplatformLogisticsDeliverySubTemplateDetailDTO getExpressSubTemplate() {
               	return expressSubTemplate;
            }
    
    /**
     * 设置快递子模版     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setExpressSubTemplate(AlibabaOpenplatformLogisticsDeliverySubTemplateDetailDTO expressSubTemplate) {
     	         	    this.expressSubTemplate = expressSubTemplate;
     	        }
    
        [DataMember(Order = 9)]
    private AlibabaOpenplatformLogisticsDeliverySubTemplateDetailDTO logisticsSubTemplate;
    
        /**
       * @return 货运子模版
    */
        public AlibabaOpenplatformLogisticsDeliverySubTemplateDetailDTO getLogisticsSubTemplate() {
               	return logisticsSubTemplate;
            }
    
    /**
     * 设置货运子模版     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsSubTemplate(AlibabaOpenplatformLogisticsDeliverySubTemplateDetailDTO logisticsSubTemplate) {
     	         	    this.logisticsSubTemplate = logisticsSubTemplate;
     	        }
    
        [DataMember(Order = 10)]
    private AlibabaOpenplatformLogisticsDeliverySubTemplateDetailDTO codSubTemplate;
    
        /**
       * @return 货到付款子模版
    */
        public AlibabaOpenplatformLogisticsDeliverySubTemplateDetailDTO getCodSubTemplate() {
               	return codSubTemplate;
            }
    
    /**
     * 设置货到付款子模版     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCodSubTemplate(AlibabaOpenplatformLogisticsDeliverySubTemplateDetailDTO codSubTemplate) {
     	         	    this.codSubTemplate = codSubTemplate;
     	        }
    
    
  }
}