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
public class AlibabaPreOrderInfo {

       [DataMember(Order = 1)]
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
    
        [DataMember(Order = 2)]
    private long? postFee;
    
        /**
       * @return 运费（分）
    */
        public long? getPostFee() {
               	return postFee;
            }
    
    /**
     * 设置运费（分）     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPostFee(long postFee) {
     	         	    this.postFee = postFee;
     	        }
    
        [DataMember(Order = 3)]
    private long? buyerSubId;
    
        /**
       * @return 买家子账号ID
    */
        public long? getBuyerSubId() {
               	return buyerSubId;
            }
    
    /**
     * 设置买家子账号ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerSubId(long buyerSubId) {
     	         	    this.buyerSubId = buyerSubId;
     	        }
    
        [DataMember(Order = 4)]
    private long? operatorId;
    
        /**
       * @return 操作人
    */
        public long? getOperatorId() {
               	return operatorId;
            }
    
    /**
     * 设置操作人     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOperatorId(long operatorId) {
     	         	    this.operatorId = operatorId;
     	        }
    
        [DataMember(Order = 5)]
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
    
        [DataMember(Order = 6)]
    private int? status;
    
        /**
       * @return 状态，0:待支付；1:已创建订单，待支付；2：已支付
    */
        public int? getStatus() {
               	return status;
            }
    
    /**
     * 设置状态，0:待支付；1:已创建订单，待支付；2：已支付     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStatus(int status) {
     	         	    this.status = status;
     	        }
    
        [DataMember(Order = 7)]
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
    
        [DataMember(Order = 8)]
    private long? id;
    
        /**
       * @return 预订单ID
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置预订单ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setId(long id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 9)]
    private int? logisticsType;
    
        /**
       * @return 物流方式：1：自提 2：快递
    */
        public int? getLogisticsType() {
               	return logisticsType;
            }
    
    /**
     * 设置物流方式：1：自提 2：快递     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsType(int logisticsType) {
     	         	    this.logisticsType = logisticsType;
     	        }
    
        [DataMember(Order = 10)]
    private string gmtConfirm;
    
        /**
       * @return 开单时间
    */
        public DateTime? getGmtConfirm() {
                 if (gmtConfirm != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtConfirm);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置开单时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGmtConfirm(DateTime gmtConfirm) {
     	         	    this.gmtConfirm = DateUtil.format(gmtConfirm);
     	        }
    
        [DataMember(Order = 11)]
    private long? totalFee;
    
        /**
       * @return 货品总金额(分)
    */
        public long? getTotalFee() {
               	return totalFee;
            }
    
    /**
     * 设置货品总金额(分)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTotalFee(long totalFee) {
     	         	    this.totalFee = totalFee;
     	        }
    
        [DataMember(Order = 12)]
    private int? payType;
    
        /**
       * @return 支付方式 1：线下 2：线上
    */
        public int? getPayType() {
               	return payType;
            }
    
    /**
     * 设置支付方式 1：线下 2：线上     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPayType(int payType) {
     	         	    this.payType = payType;
     	        }
    
        [DataMember(Order = 13)]
    private AlibabaPreOrderItemInfo[] itemList;
    
        /**
       * @return 详情
    */
        public AlibabaPreOrderItemInfo[] getItemList() {
               	return itemList;
            }
    
    /**
     * 设置详情     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setItemList(AlibabaPreOrderItemInfo[] itemList) {
     	         	    this.itemList = itemList;
     	        }
    
        [DataMember(Order = 14)]
    private string detailUrl;
    
        /**
       * @return 预订单详情链接，ISV根据该地址生成二维码
    */
        public string getDetailUrl() {
               	return detailUrl;
            }
    
    /**
     * 设置预订单详情链接，ISV根据该地址生成二维码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDetailUrl(string detailUrl) {
     	         	    this.detailUrl = detailUrl;
     	        }
    
        [DataMember(Order = 15)]
    private long? bizOrderId;
    
        /**
       * @return 通过预订单生成的正式订单ID
    */
        public long? getBizOrderId() {
               	return bizOrderId;
            }
    
    /**
     * 设置通过预订单生成的正式订单ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBizOrderId(long bizOrderId) {
     	         	    this.bizOrderId = bizOrderId;
     	        }
    
        [DataMember(Order = 16)]
    private long? actualTotalFee;
    
        /**
       * @return 应付总金额(分)，应付总金额=调整金额+货品总金额+运费
    */
        public long? getActualTotalFee() {
               	return actualTotalFee;
            }
    
    /**
     * 设置应付总金额(分)，应付总金额=调整金额+货品总金额+运费     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setActualTotalFee(long actualTotalFee) {
     	         	    this.actualTotalFee = actualTotalFee;
     	        }
    
        [DataMember(Order = 17)]
    private long? adjustFee;
    
        /**
       * @return 调整金额(分)，可为负。
    */
        public long? getAdjustFee() {
               	return adjustFee;
            }
    
    /**
     * 设置调整金额(分)，可为负。     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAdjustFee(long adjustFee) {
     	         	    this.adjustFee = adjustFee;
     	        }
    
    
  }
}