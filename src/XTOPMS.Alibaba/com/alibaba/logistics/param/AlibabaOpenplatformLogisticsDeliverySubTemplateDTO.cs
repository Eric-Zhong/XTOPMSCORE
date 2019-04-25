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
public class AlibabaOpenplatformLogisticsDeliverySubTemplateDTO {

       [DataMember(Order = 1)]
    private int? chargeType;
    
        /**
       * @return 计件类型。0:重量 1:件数 2:体积
    */
        public int? getChargeType() {
               	return chargeType;
            }
    
    /**
     * 设置计件类型。0:重量 1:件数 2:体积     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setChargeType(int chargeType) {
     	         	    this.chargeType = chargeType;
     	        }
    
        [DataMember(Order = 2)]
    private string creator;
    
        /**
       * @return 创建人
    */
        public string getCreator() {
               	return creator;
            }
    
    /**
     * 设置创建人     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCreator(string creator) {
     	         	    this.creator = creator;
     	        }
    
        [DataMember(Order = 3)]
    private string gmtCreate;
    
        /**
       * @return 创建时间
    */
        public DateTime? getGmtCreate() {
                 if (gmtCreate != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtCreate);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置创建时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGmtCreate(DateTime gmtCreate) {
     	         	    this.gmtCreate = DateUtil.format(gmtCreate);
     	        }
    
        [DataMember(Order = 4)]
    private string gmtModified;
    
        /**
       * @return 修改时间
    */
        public DateTime? getGmtModified() {
                 if (gmtModified != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtModified);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置修改时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGmtModified(DateTime gmtModified) {
     	         	    this.gmtModified = DateUtil.format(gmtModified);
     	        }
    
        [DataMember(Order = 5)]
    private long? id;
    
        /**
       * @return 主键id，也就是子模板id
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置主键id，也就是子模板id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setId(long id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 6)]
    private bool? isSysTemplate;
    
        /**
       * @return 是否系统模板
    */
        public bool? getIsSysTemplate() {
               	return isSysTemplate;
            }
    
    /**
     * 设置是否系统模板     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsSysTemplate(bool isSysTemplate) {
     	         	    this.isSysTemplate = isSysTemplate;
     	        }
    
        [DataMember(Order = 7)]
    private string memberId;
    
        /**
       * @return 会员memberId
    */
        public string getMemberId() {
               	return memberId;
            }
    
    /**
     * 设置会员memberId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMemberId(string memberId) {
     	         	    this.memberId = memberId;
     	        }
    
        [DataMember(Order = 8)]
    private string modifier;
    
        /**
       * @return 修改人
    */
        public string getModifier() {
               	return modifier;
            }
    
    /**
     * 设置修改人     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setModifier(string modifier) {
     	         	    this.modifier = modifier;
     	        }
    
        [DataMember(Order = 9)]
    private int? serviceChargeType;
    
        /**
       * @return 运费承担类型 卖家承担：0；买家承担：1。
    */
        public int? getServiceChargeType() {
               	return serviceChargeType;
            }
    
    /**
     * 设置运费承担类型 卖家承担：0；买家承担：1。     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setServiceChargeType(int serviceChargeType) {
     	         	    this.serviceChargeType = serviceChargeType;
     	        }
    
        [DataMember(Order = 10)]
    private int? serviceType;
    
        /**
       * @return 服务类型。0:快递 1:货运 2:货到付款
    */
        public int? getServiceType() {
               	return serviceType;
            }
    
    /**
     * 设置服务类型。0:快递 1:货运 2:货到付款     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setServiceType(int serviceType) {
     	         	    this.serviceType = serviceType;
     	        }
    
        [DataMember(Order = 11)]
    private long? templateId;
    
        /**
       * @return 主模板id
    */
        public long? getTemplateId() {
               	return templateId;
            }
    
    /**
     * 设置主模板id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTemplateId(long templateId) {
     	         	    this.templateId = templateId;
     	        }
    
        [DataMember(Order = 12)]
    private int? type;
    
        /**
       * @return 子模板类型 0基准 1增值。默认0。
    */
        public int? getType() {
               	return type;
            }
    
    /**
     * 设置子模板类型 0基准 1增值。默认0。     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setType(int type) {
     	         	    this.type = type;
     	        }
    
        [DataMember(Order = 13)]
    private string operateType;
    
        /**
       * @return 操作类型：INSERT，UPDATE，DELETE
    */
        public string getOperateType() {
               	return operateType;
            }
    
    /**
     * 设置操作类型：INSERT，UPDATE，DELETE     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOperateType(string operateType) {
     	         	    this.operateType = operateType;
     	        }
    
    
  }
}