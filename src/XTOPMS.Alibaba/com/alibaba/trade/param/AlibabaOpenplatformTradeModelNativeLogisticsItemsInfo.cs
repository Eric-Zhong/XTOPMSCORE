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
public class AlibabaOpenplatformTradeModelNativeLogisticsItemsInfo {

       [DataMember(Order = 1)]
    private string deliveredTime;
    
        /**
       * @return 发货时间
    */
        public DateTime? getDeliveredTime() {
                 if (deliveredTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(deliveredTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置发货时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDeliveredTime(DateTime deliveredTime) {
     	         	    this.deliveredTime = DateUtil.format(deliveredTime);
     	        }
    
        [DataMember(Order = 2)]
    private string logisticsCode;
    
        /**
       * @return 物流编号
    */
        public string getLogisticsCode() {
               	return logisticsCode;
            }
    
    /**
     * 设置物流编号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsCode(string logisticsCode) {
     	         	    this.logisticsCode = logisticsCode;
     	        }
    
        [DataMember(Order = 3)]
    private string type;
    
        /**
       * @return SELF_SEND_GOODS("0")自行发货，在线发货ONLINE_SEND_GOODS("1"，不需要物流的发货 NO_LOGISTICS_SEND_GOODS("2")
    */
        public string getType() {
               	return type;
            }
    
    /**
     * 设置SELF_SEND_GOODS("0")自行发货，在线发货ONLINE_SEND_GOODS("1"，不需要物流的发货 NO_LOGISTICS_SEND_GOODS("2")     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setType(string type) {
     	         	    this.type = type;
     	        }
    
        [DataMember(Order = 4)]
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
    
        [DataMember(Order = 5)]
    private string status;
    
        /**
       * @return 状态
    */
        public string getStatus() {
               	return status;
            }
    
    /**
     * 设置状态     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStatus(string status) {
     	         	    this.status = status;
     	        }
    
        [DataMember(Order = 6)]
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
    
        [DataMember(Order = 7)]
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
    
        [DataMember(Order = 8)]
    private decimal? carriage;
    
        /**
       * @return 运费(单位为元)
    */
        public decimal? getCarriage() {
               	return carriage;
            }
    
    /**
     * 设置运费(单位为元)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCarriage(decimal carriage) {
     	         	    this.carriage = carriage;
     	        }
    
        [DataMember(Order = 9)]
    private string fromProvince;
    
        /**
       * @return 发货省
    */
        public string getFromProvince() {
               	return fromProvince;
            }
    
    /**
     * 设置发货省     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFromProvince(string fromProvince) {
     	         	    this.fromProvince = fromProvince;
     	        }
    
        [DataMember(Order = 10)]
    private string fromCity;
    
        /**
       * @return 发货市
    */
        public string getFromCity() {
               	return fromCity;
            }
    
    /**
     * 设置发货市     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFromCity(string fromCity) {
     	         	    this.fromCity = fromCity;
     	        }
    
        [DataMember(Order = 11)]
    private string fromArea;
    
        /**
       * @return 发货区
    */
        public string getFromArea() {
               	return fromArea;
            }
    
    /**
     * 设置发货区     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFromArea(string fromArea) {
     	         	    this.fromArea = fromArea;
     	        }
    
        [DataMember(Order = 12)]
    private string fromAddress;
    
        /**
       * @return 发货街道地址
    */
        public string getFromAddress() {
               	return fromAddress;
            }
    
    /**
     * 设置发货街道地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFromAddress(string fromAddress) {
     	         	    this.fromAddress = fromAddress;
     	        }
    
        [DataMember(Order = 13)]
    private string fromPhone;
    
        /**
       * @return 发货联系电话
    */
        public string getFromPhone() {
               	return fromPhone;
            }
    
    /**
     * 设置发货联系电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFromPhone(string fromPhone) {
     	         	    this.fromPhone = fromPhone;
     	        }
    
        [DataMember(Order = 14)]
    private string fromMobile;
    
        /**
       * @return 发货联系手机
    */
        public string getFromMobile() {
               	return fromMobile;
            }
    
    /**
     * 设置发货联系手机     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFromMobile(string fromMobile) {
     	         	    this.fromMobile = fromMobile;
     	        }
    
        [DataMember(Order = 15)]
    private string fromPost;
    
        /**
       * @return 发货地址邮编
    */
        public string getFromPost() {
               	return fromPost;
            }
    
    /**
     * 设置发货地址邮编     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFromPost(string fromPost) {
     	         	    this.fromPost = fromPost;
     	        }
    
        [DataMember(Order = 16)]
    private long? logisticsCompanyId;
    
        /**
       * @return 物流公司Id
    */
        public long? getLogisticsCompanyId() {
               	return logisticsCompanyId;
            }
    
    /**
     * 设置物流公司Id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsCompanyId(long logisticsCompanyId) {
     	         	    this.logisticsCompanyId = logisticsCompanyId;
     	        }
    
        [DataMember(Order = 17)]
    private string logisticsCompanyNo;
    
        /**
       * @return 物流公司编号
    */
        public string getLogisticsCompanyNo() {
               	return logisticsCompanyNo;
            }
    
    /**
     * 设置物流公司编号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsCompanyNo(string logisticsCompanyNo) {
     	         	    this.logisticsCompanyNo = logisticsCompanyNo;
     	        }
    
        [DataMember(Order = 18)]
    private string logisticsCompanyName;
    
        /**
       * @return 物流公司名称
    */
        public string getLogisticsCompanyName() {
               	return logisticsCompanyName;
            }
    
    /**
     * 设置物流公司名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsCompanyName(string logisticsCompanyName) {
     	         	    this.logisticsCompanyName = logisticsCompanyName;
     	        }
    
        [DataMember(Order = 19)]
    private string logisticsBillNo;
    
        /**
       * @return 物流公司运单号
    */
        public string getLogisticsBillNo() {
               	return logisticsBillNo;
            }
    
    /**
     * 设置物流公司运单号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsBillNo(string logisticsBillNo) {
     	         	    this.logisticsBillNo = logisticsBillNo;
     	        }
    
        [DataMember(Order = 20)]
    private string subItemIds;
    
        /**
       * @return 商品明细条目id，如有多个以,分隔
    */
        public string getSubItemIds() {
               	return subItemIds;
            }
    
    /**
     * 设置商品明细条目id，如有多个以,分隔     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubItemIds(string subItemIds) {
     	         	    this.subItemIds = subItemIds;
     	        }
    
        [DataMember(Order = 21)]
    private string toProvince;
    
        /**
       * @return 收货省
    */
        public string getToProvince() {
               	return toProvince;
            }
    
    /**
     * 设置收货省     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToProvince(string toProvince) {
     	         	    this.toProvince = toProvince;
     	        }
    
        [DataMember(Order = 22)]
    private string toCity;
    
        /**
       * @return 收货市
    */
        public string getToCity() {
               	return toCity;
            }
    
    /**
     * 设置收货市     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToCity(string toCity) {
     	         	    this.toCity = toCity;
     	        }
    
        [DataMember(Order = 23)]
    private string toArea;
    
        /**
       * @return 收货区
    */
        public string getToArea() {
               	return toArea;
            }
    
    /**
     * 设置收货区     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToArea(string toArea) {
     	         	    this.toArea = toArea;
     	        }
    
        [DataMember(Order = 24)]
    private string toAddress;
    
        /**
       * @return 收货街道地址
    */
        public string getToAddress() {
               	return toAddress;
            }
    
    /**
     * 设置收货街道地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToAddress(string toAddress) {
     	         	    this.toAddress = toAddress;
     	        }
    
        [DataMember(Order = 25)]
    private string toPhone;
    
        /**
       * @return 收货联系电话
    */
        public string getToPhone() {
               	return toPhone;
            }
    
    /**
     * 设置收货联系电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToPhone(string toPhone) {
     	         	    this.toPhone = toPhone;
     	        }
    
        [DataMember(Order = 26)]
    private string toMobile;
    
        /**
       * @return 收货联系手机
    */
        public string getToMobile() {
               	return toMobile;
            }
    
    /**
     * 设置收货联系手机     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToMobile(string toMobile) {
     	         	    this.toMobile = toMobile;
     	        }
    
        [DataMember(Order = 27)]
    private string toPost;
    
        /**
       * @return 收货地址邮编
    */
        public string getToPost() {
               	return toPost;
            }
    
    /**
     * 设置收货地址邮编     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToPost(string toPost) {
     	         	    this.toPost = toPost;
     	        }
    
        [DataMember(Order = 28)]
    private string noLogisticsCondition;
    
        /**
       * @return 无需物流类别
    */
        public string getNoLogisticsCondition() {
               	return noLogisticsCondition;
            }
    
    /**
     * 设置无需物流类别     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setNoLogisticsCondition(string noLogisticsCondition) {
     	         	    this.noLogisticsCondition = noLogisticsCondition;
     	        }
    
        [DataMember(Order = 29)]
    private string noLogisticsName;
    
        /**
       * @return 物流姓名
    */
        public string getNoLogisticsName() {
               	return noLogisticsName;
            }
    
    /**
     * 设置物流姓名     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setNoLogisticsName(string noLogisticsName) {
     	         	    this.noLogisticsName = noLogisticsName;
     	        }
    
        [DataMember(Order = 30)]
    private string noLogisticsTel;
    
        /**
       * @return 联系方式
    */
        public string getNoLogisticsTel() {
               	return noLogisticsTel;
            }
    
    /**
     * 设置联系方式     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setNoLogisticsTel(string noLogisticsTel) {
     	         	    this.noLogisticsTel = noLogisticsTel;
     	        }
    
        [DataMember(Order = 31)]
    private string noLogisticsBillNo;
    
        /**
       * @return 无需物流业务单号
    */
        public string getNoLogisticsBillNo() {
               	return noLogisticsBillNo;
            }
    
    /**
     * 设置无需物流业务单号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setNoLogisticsBillNo(string noLogisticsBillNo) {
     	         	    this.noLogisticsBillNo = noLogisticsBillNo;
     	        }
    
        [DataMember(Order = 32)]
    private bool? isTimePromise;
    
        /**
       * @return 是否使用限时达物流
    */
        public bool? getIsTimePromise() {
               	return isTimePromise;
            }
    
    /**
     * 设置是否使用限时达物流     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsTimePromise(bool isTimePromise) {
     	         	    this.isTimePromise = isTimePromise;
     	        }
    
        [DataMember(Order = 33)]
    private string arriveTime;
    
        /**
       * @return 限时达物流，预计到达时间
    */
        public DateTime? getArriveTime() {
                 if (arriveTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(arriveTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置限时达物流，预计到达时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setArriveTime(DateTime arriveTime) {
     	         	    this.arriveTime = DateUtil.format(arriveTime);
     	        }
    
    
  }
}