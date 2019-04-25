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
public class AlibabaProductPushTaTradeBillModel {

       [DataMember(Order = 1)]
    private string gmtCreate;
    
        /**
       * @return 账单时间
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
     * 设置账单时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGmtCreate(DateTime gmtCreate) {
     	         	    this.gmtCreate = DateUtil.format(gmtCreate);
     	        }
    
        [DataMember(Order = 2)]
    private long? payFee;
    
        /**
       * @return 收支金额,（分为单位）--实付款
    */
        public long? getPayFee() {
               	return payFee;
            }
    
    /**
     * 设置收支金额,（分为单位）--实付款     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPayFee(long payFee) {
     	         	    this.payFee = payFee;
     	        }
    
        [DataMember(Order = 3)]
    private string gmtReceived;
    
        /**
       * @return 到账时间
    */
        public DateTime? getGmtReceived() {
                 if (gmtReceived != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtReceived);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置到账时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGmtReceived(DateTime gmtReceived) {
     	         	    this.gmtReceived = DateUtil.format(gmtReceived);
     	        }
    
        [DataMember(Order = 4)]
    private string serialId;
    
        /**
       * @return 账务流水号
    */
        public string getSerialId() {
               	return serialId;
            }
    
    /**
     * 设置账务流水号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSerialId(string serialId) {
     	         	    this.serialId = serialId;
     	        }
    
        [DataMember(Order = 5)]
    private string queryStr;
    
        /**
       * @return 查询账单明细字符串,作为查询账单明细接口的入参
    */
        public string getQueryStr() {
               	return queryStr;
            }
    
    /**
     * 设置查询账单明细字符串,作为查询账单明细接口的入参     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setQueryStr(string queryStr) {
     	         	    this.queryStr = queryStr;
     	        }
    
        [DataMember(Order = 6)]
    private string bizTypeName;
    
        /**
       * @return 财务类型名称
    */
        public string getBizTypeName() {
               	return bizTypeName;
            }
    
    /**
     * 设置财务类型名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBizTypeName(string bizTypeName) {
     	         	    this.bizTypeName = bizTypeName;
     	        }
    
    
  }
}