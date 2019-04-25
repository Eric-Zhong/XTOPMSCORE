using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.search.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaSearchCbuGeneralParam : GatewayAPIRequest {

    public AlibabaSearchCbuGeneralParam() {
        this.ApiId = new APIId("com.alibaba.search", "alibaba.search.cbu.general",1);
	}
	
       [DataMember(Order = 1)]
    private int? bizType;
    
        /**
       * @return 商品卖家的业务类型：
5 企业单位,6 个体经营,7 事业单位或社会团体,8 未人经工商注册
    */
        public int? getBizType() {
               	return bizType;
            }
    
    /**
     * 设置商品卖家的业务类型：
5 企业单位,6 个体经营,7 事业单位或社会团体,8 未人经工商注册     *
     * 参数示例：<pre>5</pre>     
             * 此参数必填
          */
    public void setBizType(int bizType) {
     	         	    this.bizType = bizType;
     	        }
    
        [DataMember(Order = 2)]
    private long? category;
    
        /**
       * @return 商品的类目ID
    */
        public long? getCategory() {
               	return category;
            }
    
    /**
     * 设置商品的类目ID     *
     * 参数示例：<pre>13579</pre>     
             * 此参数必填
          */
    public void setCategory(long category) {
     	         	    this.category = category;
     	        }
    
        [DataMember(Order = 3)]
    private string city;
    
        /**
       * @return 商品的发货城市
    */
        public string getCity() {
               	return city;
            }
    
    /**
     * 设置商品的发货城市     *
     * 参数示例：<pre>杭州市</pre>     
             * 此参数必填
          */
    public void setCity(string city) {
     	         	    this.city = city;
     	        }
    
        [DataMember(Order = 4)]
    private string descendOrder;
    
        /**
       * @return 排序值
    */
        public string getDescendOrder() {
               	return descendOrder;
            }
    
    /**
     * 设置排序值     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setDescendOrder(string descendOrder) {
     	         	    this.descendOrder = descendOrder;
     	        }
    
        [DataMember(Order = 5)]
    private string gmtModifiedBegin;
    
        /**
       * @return 商品的修改开始时间
    */
        public DateTime? getGmtModifiedBegin() {
                 if (gmtModifiedBegin != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtModifiedBegin);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置商品的修改开始时间     *
     * 参数示例：<pre>123213</pre>     
             * 此参数必填
          */
    public void setGmtModifiedBegin(DateTime gmtModifiedBegin) {
     	         	    this.gmtModifiedBegin = DateUtil.format(gmtModifiedBegin);
     	        }
    
        [DataMember(Order = 6)]
    private string gmtModifiedEnd;
    
        /**
       * @return 商品的修改结束时间
    */
        public DateTime? getGmtModifiedEnd() {
                 if (gmtModifiedEnd != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtModifiedEnd);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置商品的修改结束时间     *
     * 参数示例：<pre>12312</pre>     
             * 此参数必填
          */
    public void setGmtModifiedEnd(DateTime gmtModifiedEnd) {
     	         	    this.gmtModifiedEnd = DateUtil.format(gmtModifiedEnd);
     	        }
    
        [DataMember(Order = 7)]
    private int? pageNo;
    
        /**
       * @return 分页的开始页数，1代表第一页
    */
        public int? getPageNo() {
               	return pageNo;
            }
    
    /**
     * 设置分页的开始页数，1代表第一页     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setPageNo(int pageNo) {
     	         	    this.pageNo = pageNo;
     	        }
    
        [DataMember(Order = 8)]
    private double? priceStart;
    
        /**
       * @return 搜索价格最小值
    */
        public double? getPriceStart() {
               	return priceStart;
            }
    
    /**
     * 设置搜索价格最小值     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setPriceStart(double priceStart) {
     	         	    this.priceStart = priceStart;
     	        }
    
        [DataMember(Order = 9)]
    private double? priceEnd;
    
        /**
       * @return 搜索价格最大值
    */
        public double? getPriceEnd() {
               	return priceEnd;
            }
    
    /**
     * 设置搜索价格最大值     *
     * 参数示例：<pre>10</pre>     
             * 此参数必填
          */
    public void setPriceEnd(double priceEnd) {
     	         	    this.priceEnd = priceEnd;
     	        }
    
        [DataMember(Order = 10)]
    private string province;
    
        /**
       * @return 商品的发货省
    */
        public string getProvince() {
               	return province;
            }
    
    /**
     * 设置商品的发货省     *
     * 参数示例：<pre>浙江省</pre>     
             * 此参数必填
          */
    public void setProvince(string province) {
     	         	    this.province = province;
     	        }
    
        [DataMember(Order = 11)]
    private string q;
    
        /**
       * @return 商品的搜索关键字，通常是商品的标题
    */
        public string getQ() {
               	return q;
            }
    
    /**
     * 设置商品的搜索关键字，通常是商品的标题     *
     * 参数示例：<pre>test</pre>     
             * 此参数必填
          */
    public void setQ(string q) {
     	         	    this.q = q;
     	        }
    
        [DataMember(Order = 12)]
    private int? quantityMin;
    
        /**
       * @return 商品的最小起批量
    */
        public int? getQuantityMin() {
               	return quantityMin;
            }
    
    /**
     * 设置商品的最小起批量     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setQuantityMin(int quantityMin) {
     	         	    this.quantityMin = quantityMin;
     	        }
    
        [DataMember(Order = 13)]
    private string replaceEnsure;
    
        /**
       * @return 包换保障，目前支持7天包换(qtbh)和15天包换(swtbh)
    */
        public string getReplaceEnsure() {
               	return replaceEnsure;
            }
    
    /**
     * 设置包换保障，目前支持7天包换(qtbh)和15天包换(swtbh)     *
     * 参数示例：<pre>swtbh</pre>     
             * 此参数必填
          */
    public void setReplaceEnsure(string replaceEnsure) {
     	         	    this.replaceEnsure = replaceEnsure;
     	        }
    
        [DataMember(Order = 14)]
    private string sellerOnline;
    
        /**
       * @return 卖家是否在线
    */
        public string getSellerOnline() {
               	return sellerOnline;
            }
    
    /**
     * 设置卖家是否在线     *
     * 参数示例：<pre>true</pre>     
             * 此参数必填
          */
    public void setSellerOnline(string sellerOnline) {
     	         	    this.sellerOnline = sellerOnline;
     	        }
    
        [DataMember(Order = 15)]
    private string sendGoodsEnsure;
    
        /**
       * @return 发货保障，目前仅支持48小时发货条件查询
    */
        public string getSendGoodsEnsure() {
               	return sendGoodsEnsure;
            }
    
    /**
     * 设置发货保障，目前仅支持48小时发货条件查询     *
     * 参数示例：<pre>48</pre>     
             * 此参数必填
          */
    public void setSendGoodsEnsure(string sendGoodsEnsure) {
     	         	    this.sendGoodsEnsure = sendGoodsEnsure;
     	        }
    
        [DataMember(Order = 16)]
    private string sortType;
    
        /**
       * @return 排序类型，以价格排序price，成交量排序booked
    */
        public string getSortType() {
               	return sortType;
            }
    
    /**
     * 设置排序类型，以价格排序price，成交量排序booked     *
     * 参数示例：<pre>price</pre>     
             * 此参数必填
          */
    public void setSortType(string sortType) {
     	         	    this.sortType = sortType;
     	        }
    
        [DataMember(Order = 17)]
    private long? productId;
    
        /**
       * @return 商品ID
    */
        public long? getProductId() {
               	return productId;
            }
    
    /**
     * 设置商品ID     *
     * 参数示例：<pre>123123123</pre>     
             * 此参数必填
          */
    public void setProductId(long productId) {
     	         	    this.productId = productId;
     	        }
    
        [DataMember(Order = 18)]
    private long[] productIds;
    
        /**
       * @return 商品ID列表
    */
        public long[] getProductIds() {
               	return productIds;
            }
    
    /**
     * 设置商品ID列表     *
     * 参数示例：<pre>[123123,123123,1234334]</pre>     
             * 此参数必填
          */
    public void setProductIds(long[] productIds) {
     	         	    this.productIds = productIds;
     	        }
    
    
  }
}