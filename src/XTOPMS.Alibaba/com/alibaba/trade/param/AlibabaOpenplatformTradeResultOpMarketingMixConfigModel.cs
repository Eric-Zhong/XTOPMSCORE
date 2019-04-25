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
public class AlibabaOpenplatformTradeResultOpMarketingMixConfigModel {

       [DataMember(Order = 1)]
    private bool? generalHunpi;
    
        /**
       * @return 是否普通混批
    */
        public bool? getGeneralHunpi() {
               	return generalHunpi;
            }
    
    /**
     * 设置是否普通混批     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setGeneralHunpi(bool generalHunpi) {
     	         	    this.generalHunpi = generalHunpi;
     	        }
    
        [DataMember(Order = 2)]
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
    
        [DataMember(Order = 3)]
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
    
        [DataMember(Order = 4)]
    private string memberId;
    
        /**
       * @return 卖家memberID
    */
        public string getMemberId() {
               	return memberId;
            }
    
    /**
     * 设置卖家memberID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMemberId(string memberId) {
     	         	    this.memberId = memberId;
     	        }
    
        [DataMember(Order = 5)]
    private int? mixAmount;
    
        /**
       * @return 混批金额
    */
        public int? getMixAmount() {
               	return mixAmount;
            }
    
    /**
     * 设置混批金额     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMixAmount(int mixAmount) {
     	         	    this.mixAmount = mixAmount;
     	        }
    
        [DataMember(Order = 6)]
    private int? mixNumber;
    
        /**
       * @return 混批数量
    */
        public int? getMixNumber() {
               	return mixNumber;
            }
    
    /**
     * 设置混批数量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMixNumber(int mixNumber) {
     	         	    this.mixNumber = mixNumber;
     	        }
    
    
  }
}