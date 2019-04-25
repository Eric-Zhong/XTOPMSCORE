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
public class AlibabaOpenplatformLogisticsDeliverySysRateDTO {

       [DataMember(Order = 1)]
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
    
        [DataMember(Order = 2)]
    private long? firstUnit;
    
        /**
       * @return 首重（单位：克）或首件（单位：件）
    */
        public long? getFirstUnit() {
               	return firstUnit;
            }
    
    /**
     * 设置首重（单位：克）或首件（单位：件）     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFirstUnit(long firstUnit) {
     	         	    this.firstUnit = firstUnit;
     	        }
    
        [DataMember(Order = 3)]
    private long? firstUnitFee;
    
        /**
       * @return 首重或首件的价格
    */
        public long? getFirstUnitFee() {
               	return firstUnitFee;
            }
    
    /**
     * 设置首重或首件的价格     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFirstUnitFee(long firstUnitFee) {
     	         	    this.firstUnitFee = firstUnitFee;
     	        }
    
        [DataMember(Order = 4)]
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
    
        [DataMember(Order = 5)]
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
    
        [DataMember(Order = 6)]
    private long? id;
    
        /**
       * @return 主键id
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置主键id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setId(long id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 7)]
    private long? leastExpenses;
    
        /**
       * @return 最低一票
    */
        public long? getLeastExpenses() {
               	return leastExpenses;
            }
    
    /**
     * 设置最低一票     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLeastExpenses(long leastExpenses) {
     	         	    this.leastExpenses = leastExpenses;
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
    private long? nextUnit;
    
        /**
       * @return 续重（单位：克）或续件（单位：件）单位
    */
        public long? getNextUnit() {
               	return nextUnit;
            }
    
    /**
     * 设置续重（单位：克）或续件（单位：件）单位     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setNextUnit(long nextUnit) {
     	         	    this.nextUnit = nextUnit;
     	        }
    
        [DataMember(Order = 10)]
    private long? nextUnitFee;
    
        /**
       * @return 续重件价格
    */
        public long? getNextUnitFee() {
               	return nextUnitFee;
            }
    
    /**
     * 设置续重件价格     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setNextUnitFee(long nextUnitFee) {
     	         	    this.nextUnitFee = nextUnitFee;
     	        }
    
        [DataMember(Order = 11)]
    private long? sysTemplateId;
    
        /**
       * @return 系统运费模板id
    */
        public long? getSysTemplateId() {
               	return sysTemplateId;
            }
    
    /**
     * 设置系统运费模板id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSysTemplateId(long sysTemplateId) {
     	         	    this.sysTemplateId = sysTemplateId;
     	        }
    
        [DataMember(Order = 12)]
    private string[] toAreaCodeList;
    
        /**
       * @return 到达地区编码（使用行政区编码）
    */
        public string[] getToAreaCodeList() {
               	return toAreaCodeList;
            }
    
    /**
     * 设置到达地区编码（使用行政区编码）     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToAreaCodeList(string[] toAreaCodeList) {
     	         	    this.toAreaCodeList = toAreaCodeList;
     	        }
    
    
  }
}