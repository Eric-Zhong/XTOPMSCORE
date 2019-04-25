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
public class AlibabaOceanOpenplatformBizTradeCommonModelAccountPeriodInfo {

       [DataMember(Order = 1)]
    private long? buyerId;
    
        /**
       * @return 买家userId
    */
        public long? getBuyerId() {
               	return buyerId;
            }
    
    /**
     * 设置买家userId     *
     * 参数示例：<pre>112312331</pre>     
             * 此参数必填
          */
    public void setBuyerId(long buyerId) {
     	         	    this.buyerId = buyerId;
     	        }
    
        [DataMember(Order = 2)]
    private string buyerLoginId;
    
        /**
       * @return 买家loginId
    */
        public string getBuyerLoginId() {
               	return buyerLoginId;
            }
    
    /**
     * 设置买家loginId     *
     * 参数示例：<pre>alitestforisv01</pre>     
             * 此参数必填
          */
    public void setBuyerLoginId(string buyerLoginId) {
     	         	    this.buyerLoginId = buyerLoginId;
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
     * 参数示例：<pre>20170913231727000+0800</pre>     
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
     * 参数示例：<pre>20170913231727000+0800</pre>     
             * 此参数必填
          */
    public void setGmtModified(DateTime gmtModified) {
     	         	    this.gmtModified = DateUtil.format(gmtModified);
     	        }
    
        [DataMember(Order = 5)]
    private string gmtQuota;
    
        /**
       * @return 授信日期
    */
        public DateTime? getGmtQuota() {
                 if (gmtQuota != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtQuota);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置授信日期     *
     * 参数示例：<pre>20170913231727000+0800</pre>     
             * 此参数必填
          */
    public void setGmtQuota(DateTime gmtQuota) {
     	         	    this.gmtQuota = DateUtil.format(gmtQuota);
     	        }
    
        [DataMember(Order = 6)]
    private long? quota;
    
        /**
       * @return 授信额度值,单位为分
    */
        public long? getQuota() {
               	return quota;
            }
    
    /**
     * 设置授信额度值,单位为分     *
     * 参数示例：<pre>10000</pre>     
             * 此参数必填
          */
    public void setQuota(long quota) {
     	         	    this.quota = quota;
     	        }
    
        [DataMember(Order = 7)]
    private long? surplusQuota;
    
        /**
       * @return 可用授信额度值,单位为分
    */
        public long? getSurplusQuota() {
               	return surplusQuota;
            }
    
    /**
     * 设置可用授信额度值,单位为分     *
     * 参数示例：<pre>10000</pre>     
             * 此参数必填
          */
    public void setSurplusQuota(long surplusQuota) {
     	         	    this.surplusQuota = surplusQuota;
     	        }
    
        [DataMember(Order = 8)]
    private long? sellerId;
    
        /**
       * @return 卖家userId
    */
        public long? getSellerId() {
               	return sellerId;
            }
    
    /**
     * 设置卖家userId     *
     * 参数示例：<pre>121312441</pre>     
             * 此参数必填
          */
    public void setSellerId(long sellerId) {
     	         	    this.sellerId = sellerId;
     	        }
    
        [DataMember(Order = 9)]
    private string sellerLoginId;
    
        /**
       * @return 卖家loginId
    */
        public string getSellerLoginId() {
               	return sellerLoginId;
            }
    
    /**
     * 设置卖家loginId     *
     * 参数示例：<pre>alitestforisv02</pre>     
             * 此参数必填
          */
    public void setSellerLoginId(string sellerLoginId) {
     	         	    this.sellerLoginId = sellerLoginId;
     	        }
    
        [DataMember(Order = 10)]
    private int? status;
    
        /**
       * @return 状态
    */
        public int? getStatus() {
               	return status;
            }
    
    /**
     * 设置状态     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setStatus(int status) {
     	         	    this.status = status;
     	        }
    
        [DataMember(Order = 11)]
    private string statusStr;
    
        /**
       * @return 状态描述
    */
        public string getStatusStr() {
               	return statusStr;
            }
    
    /**
     * 设置状态描述     *
     * 参数示例：<pre>有效</pre>     
             * 此参数必填
          */
    public void setStatusStr(string statusStr) {
     	         	    this.statusStr = statusStr;
     	        }
    
        [DataMember(Order = 12)]
    private int? tapDate;
    
        /**
       * @return 账期日期
    */
        public int? getTapDate() {
               	return tapDate;
            }
    
    /**
     * 设置账期日期     *
     * 参数示例：<pre>如每月28日记做：28</pre>     
             * 此参数必填
          */
    public void setTapDate(int tapDate) {
     	         	    this.tapDate = tapDate;
     	        }
    
        [DataMember(Order = 13)]
    private string tapDateStr;
    
        /**
       * @return 账期日期描述
    */
        public string getTapDateStr() {
               	return tapDateStr;
            }
    
    /**
     * 设置账期日期描述     *
     * 参数示例：<pre>两个月一结，20号</pre>     
             * 此参数必填
          */
    public void setTapDateStr(string tapDateStr) {
     	         	    this.tapDateStr = tapDateStr;
     	        }
    
        [DataMember(Order = 14)]
    private int? tapOverdue;
    
        /**
       * @return 逾期次数
    */
        public int? getTapOverdue() {
               	return tapOverdue;
            }
    
    /**
     * 设置逾期次数     *
     * 参数示例：<pre>0</pre>     
             * 此参数必填
          */
    public void setTapOverdue(int tapOverdue) {
     	         	    this.tapOverdue = tapOverdue;
     	        }
    
        [DataMember(Order = 15)]
    private int? tapType;
    
        /**
       * @return 账期类型
    */
        public int? getTapType() {
               	return tapType;
            }
    
    /**
     * 设置账期类型     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setTapType(int tapType) {
     	         	    this.tapType = tapType;
     	        }
    
    
  }
}