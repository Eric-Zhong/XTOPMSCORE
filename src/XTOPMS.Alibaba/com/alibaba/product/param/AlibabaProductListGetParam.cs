using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.product.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductListGetParam : GatewayAPIRequest {

    public AlibabaProductListGetParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.list.get",1);
	}
	
       [DataMember(Order = 1)]
    private string[] signs;
    
        /**
       * @return 业务标
    */
        public string[] getSigns() {
               	return signs;
            }
    
    /**
     * 设置业务标     *
     * 参数示例：<pre>['isMicroSupply']</pre>     
             * 此参数必填
          */
    public void setSigns(string[] signs) {
     	         	    this.signs = signs;
     	        }
    
        [DataMember(Order = 2)]
    private string[] productSupportedBizGroups;
    
        /**
       * @return 业务名
    */
        public string[] getProductSupportedBizGroups() {
               	return productSupportedBizGroups;
            }
    
    /**
     * 设置业务名     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setProductSupportedBizGroups(string[] productSupportedBizGroups) {
     	         	    this.productSupportedBizGroups = productSupportedBizGroups;
     	        }
    
        [DataMember(Order = 3)]
    private int? pageNo;
    
        /**
       * @return 分页参数，起始为1
    */
        public int? getPageNo() {
               	return pageNo;
            }
    
    /**
     * 设置分页参数，起始为1     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setPageNo(int pageNo) {
     	         	    this.pageNo = pageNo;
     	        }
    
        [DataMember(Order = 4)]
    private int? pageSize;
    
        /**
       * @return 分页参数，每页大小，目前最大值为20，超过20时以20为准
    */
        public int? getPageSize() {
               	return pageSize;
            }
    
    /**
     * 设置分页参数，每页大小，目前最大值为20，超过20时以20为准     *
     * 参数示例：<pre>20</pre>     
             * 此参数必填
          */
    public void setPageSize(int pageSize) {
     	         	    this.pageSize = pageSize;
     	        }
    
        [DataMember(Order = 5)]
    private string[] statusList;
    
        /**
       * @return 商品状态，published:上架状态，expired：过期(包含手动过期与自动过期)，TBD：to be delete，deleted：删除，new：新发，modified：修改，member expired：会员撤销
    */
        public string[] getStatusList() {
               	return statusList;
            }
    
    /**
     * 设置商品状态，published:上架状态，expired：过期(包含手动过期与自动过期)，TBD：to be delete，deleted：删除，new：新发，modified：修改，member expired：会员撤销     *
     * 参数示例：<pre>['published']</pre>     
             * 此参数必填
          */
    public void setStatusList(string[] statusList) {
     	         	    this.statusList = statusList;
     	        }
    
        [DataMember(Order = 6)]
    private long? categoryId;
    
        /**
       * @return 类目ID
    */
        public long? getCategoryId() {
               	return categoryId;
            }
    
    /**
     * 设置类目ID     *
     * 参数示例：<pre>1031728</pre>     
             * 此参数必填
          */
    public void setCategoryId(long categoryId) {
     	         	    this.categoryId = categoryId;
     	        }
    
        [DataMember(Order = 7)]
    private string startModifyTime;
    
        /**
       * @return 产品修改开始时间
    */
        public DateTime? getStartModifyTime() {
                 if (startModifyTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(startModifyTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置产品修改开始时间     *
     * 参数示例：<pre>20180717174002000+0800</pre>     
             * 此参数必填
          */
    public void setStartModifyTime(DateTime startModifyTime) {
     	         	    this.startModifyTime = DateUtil.format(startModifyTime);
     	        }
    
        [DataMember(Order = 8)]
    private string endModifyTime;
    
        /**
       * @return 产品修改结束时间
    */
        public DateTime? getEndModifyTime() {
                 if (endModifyTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(endModifyTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置产品修改结束时间     *
     * 参数示例：<pre>20180717174002000+0800</pre>     
             * 此参数必填
          */
    public void setEndModifyTime(DateTime endModifyTime) {
     	         	    this.endModifyTime = DateUtil.format(endModifyTime);
     	        }
    
        [DataMember(Order = 9)]
    private string subjectKey;
    
        /**
       * @return 关键词
    */
        public string getSubjectKey() {
               	return subjectKey;
            }
    
    /**
     * 设置关键词     *
     * 参数示例：<pre>北极</pre>     
             * 此参数必填
          */
    public void setSubjectKey(string subjectKey) {
     	         	    this.subjectKey = subjectKey;
     	        }
    
        [DataMember(Order = 10)]
    private string cargoNumber;
    
        /**
       * @return 货号
    */
        public string getCargoNumber() {
               	return cargoNumber;
            }
    
    /**
     * 设置货号     *
     * 参数示例：<pre>LYQ-8816</pre>     
             * 此参数必填
          */
    public void setCargoNumber(string cargoNumber) {
     	         	    this.cargoNumber = cargoNumber;
     	        }
    
        [DataMember(Order = 11)]
    private long[] productIds;
    
        /**
       * @return 产品ID列表
    */
        public long[] getProductIds() {
               	return productIds;
            }
    
    /**
     * 设置产品ID列表     *
     * 参数示例：<pre>[12323213,12312323]</pre>     
             * 此参数必填
          */
    public void setProductIds(long[] productIds) {
     	         	    this.productIds = productIds;
     	        }
    
        [DataMember(Order = 12)]
    private int? beginStar;
    
        /**
       * @return 星级范围起始值0-5，不能高于endStar
    */
        public int? getBeginStar() {
               	return beginStar;
            }
    
    /**
     * 设置星级范围起始值0-5，不能高于endStar     *
     * 参数示例：<pre>0</pre>     
             * 此参数必填
          */
    public void setBeginStar(int beginStar) {
     	         	    this.beginStar = beginStar;
     	        }
    
        [DataMember(Order = 13)]
    private int? endStar;
    
        /**
       * @return 星级范围起始值0-5，不能低于beginStar
    */
        public int? getEndStar() {
               	return endStar;
            }
    
    /**
     * 设置星级范围起始值0-5，不能低于beginStar     *
     * 参数示例：<pre>5</pre>     
             * 此参数必填
          */
    public void setEndStar(int endStar) {
     	         	    this.endStar = endStar;
     	        }
    
        [DataMember(Order = 14)]
    private string groupIds;
    
        /**
       * @return 查询自定义分组ID，目前只支持查询一个
    */
        public string getGroupIds() {
               	return groupIds;
            }
    
    /**
     * 设置查询自定义分组ID，目前只支持查询一个     *
     * 参数示例：<pre>100416219</pre>     
             * 此参数必填
          */
    public void setGroupIds(string groupIds) {
     	         	    this.groupIds = groupIds;
     	        }
    
        [DataMember(Order = 15)]
    private string startPublishTime;
    
        /**
       * @return 发布时间起始值
    */
        public DateTime? getStartPublishTime() {
                 if (startPublishTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(startPublishTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置发布时间起始值     *
     * 参数示例：<pre>20180717174002000+0800</pre>     
             * 此参数必填
          */
    public void setStartPublishTime(DateTime startPublishTime) {
     	         	    this.startPublishTime = DateUtil.format(startPublishTime);
     	        }
    
        [DataMember(Order = 16)]
    private string endPublishTime;
    
        /**
       * @return 发布时间结束值
    */
        public DateTime? getEndPublishTime() {
                 if (endPublishTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(endPublishTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置发布时间结束值     *
     * 参数示例：<pre>20180717174002000+0800</pre>     
             * 此参数必填
          */
    public void setEndPublishTime(DateTime endPublishTime) {
     	         	    this.endPublishTime = DateUtil.format(endPublishTime);
     	        }
    
        [DataMember(Order = 17)]
    private string startExpiredTime;
    
        /**
       * @return 过期时间起始值
    */
        public DateTime? getStartExpiredTime() {
                 if (startExpiredTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(startExpiredTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置过期时间起始值     *
     * 参数示例：<pre>20180717174002000+0800</pre>     
             * 此参数必填
          */
    public void setStartExpiredTime(DateTime startExpiredTime) {
     	         	    this.startExpiredTime = DateUtil.format(startExpiredTime);
     	        }
    
        [DataMember(Order = 18)]
    private string endExpiredTime;
    
        /**
       * @return 过期时间结束值
    */
        public DateTime? getEndExpiredTime() {
                 if (endExpiredTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(endExpiredTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置过期时间结束值     *
     * 参数示例：<pre>20180717174002000+0800</pre>     
             * 此参数必填
          */
    public void setEndExpiredTime(DateTime endExpiredTime) {
     	         	    this.endExpiredTime = DateUtil.format(endExpiredTime);
     	        }
    
        [DataMember(Order = 19)]
    private double? priceStart;
    
        /**
       * @return 价格范围起始值
    */
        public double? getPriceStart() {
               	return priceStart;
            }
    
    /**
     * 设置价格范围起始值     *
     * 参数示例：<pre>1.0</pre>     
             * 此参数必填
          */
    public void setPriceStart(double priceStart) {
     	         	    this.priceStart = priceStart;
     	        }
    
        [DataMember(Order = 20)]
    private double? priceEnd;
    
        /**
       * @return 价格范围结束值
    */
        public double? getPriceEnd() {
               	return priceEnd;
            }
    
    /**
     * 设置价格范围结束值     *
     * 参数示例：<pre>1000.0</pre>     
             * 此参数必填
          */
    public void setPriceEnd(double priceEnd) {
     	         	    this.priceEnd = priceEnd;
     	        }
    
        [DataMember(Order = 21)]
    private string orderByCondition;
    
        /**
       * @return 排序条件：CREATE_DATE,POST_DATE,MODIFY_DATE,APPROVED_DATE,EXPIRE_DATE,STATUS,ID,GROUP_ID,PRICE,SALE_QUANTITY
    */
        public string getOrderByCondition() {
               	return orderByCondition;
            }
    
    /**
     * 设置排序条件：CREATE_DATE,POST_DATE,MODIFY_DATE,APPROVED_DATE,EXPIRE_DATE,STATUS,ID,GROUP_ID,PRICE,SALE_QUANTITY     *
     * 参数示例：<pre>PRICE</pre>     
             * 此参数必填
          */
    public void setOrderByCondition(string orderByCondition) {
     	         	    this.orderByCondition = orderByCondition;
     	        }
    
        [DataMember(Order = 22)]
    private string orderByType;
    
        /**
       * @return 升序 ASC 还是降序 DESC
    */
        public string getOrderByType() {
               	return orderByType;
            }
    
    /**
     * 设置升序 ASC 还是降序 DESC     *
     * 参数示例：<pre>DESC</pre>     
             * 此参数必填
          */
    public void setOrderByType(string orderByType) {
     	         	    this.orderByType = orderByType;
     	        }
    
        [DataMember(Order = 23)]
    private bool? supportOnlineTrade;
    
        /**
       * @return 支持在线交易
    */
        public bool? getSupportOnlineTrade() {
               	return supportOnlineTrade;
            }
    
    /**
     * 设置支持在线交易     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setSupportOnlineTrade(bool supportOnlineTrade) {
     	         	    this.supportOnlineTrade = supportOnlineTrade;
     	        }
    
        [DataMember(Order = 24)]
    private bool? privateOffer;
    
        /**
       * @return 私密商品
    */
        public bool? getPrivateOffer() {
               	return privateOffer;
            }
    
    /**
     * 设置私密商品     *
     * 参数示例：<pre>false</pre>     
             * 此参数必填
          */
    public void setPrivateOffer(bool privateOffer) {
     	         	    this.privateOffer = privateOffer;
     	        }
    
        [DataMember(Order = 25)]
    private bool? needDetail;
    
        /**
       * @return 是否需要详情
    */
        public bool? getNeedDetail() {
               	return needDetail;
            }
    
    /**
     * 设置是否需要详情     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setNeedDetail(bool needDetail) {
     	         	    this.needDetail = needDetail;
     	        }
    
        [DataMember(Order = 26)]
    private bool? needFreight;
    
        /**
       * @return 是否需要运费
    */
        public bool? getNeedFreight() {
               	return needFreight;
            }
    
    /**
     * 设置是否需要运费     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setNeedFreight(bool needFreight) {
     	         	    this.needFreight = needFreight;
     	        }
    
        [DataMember(Order = 27)]
    private bool? needUserCategoryInfo;
    
        /**
       * @return 是否需要自定义类目
    */
        public bool? getNeedUserCategoryInfo() {
               	return needUserCategoryInfo;
            }
    
    /**
     * 设置是否需要自定义类目     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setNeedUserCategoryInfo(bool needUserCategoryInfo) {
     	         	    this.needUserCategoryInfo = needUserCategoryInfo;
     	        }
    
    
  }
}