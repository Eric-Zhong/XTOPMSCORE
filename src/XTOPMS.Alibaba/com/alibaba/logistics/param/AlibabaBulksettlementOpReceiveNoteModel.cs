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
public class AlibabaBulksettlementOpReceiveNoteModel {

       [DataMember(Order = 1)]
    private long? id;
    
        /**
       * @return 收货主单id
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置收货主单id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setId(long id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 2)]
    private string statusInfo;
    
        /**
       * @return 收货主单状态状态
    */
        public string getStatusInfo() {
               	return statusInfo;
            }
    
    /**
     * 设置收货主单状态状态     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStatusInfo(string statusInfo) {
     	         	    this.statusInfo = statusInfo;
     	        }
    
        [DataMember(Order = 3)]
    private long? actualPayFee;
    
        /**
       * @return 1 待发起结算 2 已发起结算
    */
        public long? getActualPayFee() {
               	return actualPayFee;
            }
    
    /**
     * 设置1 待发起结算 2 已发起结算     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setActualPayFee(long actualPayFee) {
     	         	    this.actualPayFee = actualPayFee;
     	        }
    
        [DataMember(Order = 4)]
    private string attributes;
    
        /**
       * @return 扩展属性
    */
        public string getAttributes() {
               	return attributes;
            }
    
    /**
     * 设置扩展属性     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAttributes(string attributes) {
     	         	    this.attributes = attributes;
     	        }
    
        [DataMember(Order = 5)]
    private int? isSuccess;
    
        /**
       * @return 是否正常创建
    */
        public int? getIsSuccess() {
               	return isSuccess;
            }
    
    /**
     * 设置是否正常创建     *
     * 参数示例：<pre>1 正常创建；0 非正常创建</pre>     
             * 此参数必填
          */
    public void setIsSuccess(int isSuccess) {
     	         	    this.isSuccess = isSuccess;
     	        }
    
        [DataMember(Order = 6)]
    private long? orderId;
    
        /**
       * @return 主订单ID
    */
        public long? getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置主订单ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderId(long orderId) {
     	         	    this.orderId = orderId;
     	        }
    
        [DataMember(Order = 7)]
    private string gmtReceive;
    
        /**
       * @return 收货时间
    */
        public DateTime? getGmtReceive() {
                 if (gmtReceive != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtReceive);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置收货时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGmtReceive(DateTime gmtReceive) {
     	         	    this.gmtReceive = DateUtil.format(gmtReceive);
     	        }
    
        [DataMember(Order = 8)]
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
    
        [DataMember(Order = 9)]
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
    
        [DataMember(Order = 10)]
    private long? sellerUserId;
    
        /**
       * @return 卖家主账号userId
    */
        public long? getSellerUserId() {
               	return sellerUserId;
            }
    
    /**
     * 设置卖家主账号userId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerUserId(long sellerUserId) {
     	         	    this.sellerUserId = sellerUserId;
     	        }
    
        [DataMember(Order = 11)]
    private string sellerCompanyName;
    
        /**
       * @return 卖家公司名称
    */
        public string getSellerCompanyName() {
               	return sellerCompanyName;
            }
    
    /**
     * 设置卖家公司名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerCompanyName(string sellerCompanyName) {
     	         	    this.sellerCompanyName = sellerCompanyName;
     	        }
    
        [DataMember(Order = 12)]
    private string operatorUsername;
    
        /**
       * @return 收货操作者姓名
    */
        public string getOperatorUsername() {
               	return operatorUsername;
            }
    
    /**
     * 设置收货操作者姓名     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOperatorUsername(string operatorUsername) {
     	         	    this.operatorUsername = operatorUsername;
     	        }
    
        [DataMember(Order = 13)]
    private string buyerUserId;
    
        /**
       * @return 买家主账号
    */
        public string getBuyerUserId() {
               	return buyerUserId;
            }
    
    /**
     * 设置买家主账号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerUserId(string buyerUserId) {
     	         	    this.buyerUserId = buyerUserId;
     	        }
    
        [DataMember(Order = 14)]
    private long? operatorUserId;
    
        /**
       * @return 收货操作者userId
    */
        public long? getOperatorUserId() {
               	return operatorUserId;
            }
    
    /**
     * 设置收货操作者userId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOperatorUserId(long operatorUserId) {
     	         	    this.operatorUserId = operatorUserId;
     	        }
    
        [DataMember(Order = 15)]
    private string pcorpName;
    
        /**
       * @return 名义下单 下单公司主体
    */
        public string getPcorpName() {
               	return pcorpName;
            }
    
    /**
     * 设置名义下单 下单公司主体     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPcorpName(string pcorpName) {
     	         	    this.pcorpName = pcorpName;
     	        }
    
        [DataMember(Order = 16)]
    private string buyerName;
    
        /**
       * @return 名义下单 下单账号
    */
        public string getBuyerName() {
               	return buyerName;
            }
    
    /**
     * 设置名义下单 下单账号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerName(string buyerName) {
     	         	    this.buyerName = buyerName;
     	        }
    
        [DataMember(Order = 17)]
    private AlibabaBulksettlementOpReceiveNoteEntryModel[] receiveEntrylist;
    
        /**
       * @return 
    */
        public AlibabaBulksettlementOpReceiveNoteEntryModel[] getReceiveEntrylist() {
               	return receiveEntrylist;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiveEntrylist(AlibabaBulksettlementOpReceiveNoteEntryModel[] receiveEntrylist) {
     	         	    this.receiveEntrylist = receiveEntrylist;
     	        }
    
    
  }
}