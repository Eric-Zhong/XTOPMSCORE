using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.p4p.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaCpsListOfferPageQueryParam : GatewayAPIRequest {

    public AlibabaCpsListOfferPageQueryParam() {
        this.ApiId = new APIId("com.alibaba.p4p", "alibaba.cps.listOfferPageQuery",1);
	}
	
       [DataMember(Order = 1)]
    private long? categoryId;
    
        /**
       * @return 类目id
类目id和feedInfo至少输入一项
    */
        public long? getCategoryId() {
               	return categoryId;
            }
    
    /**
     * 设置类目id
类目id和feedInfo至少输入一项     *
     * 参数示例：<pre>1	农业
2	食品、饮料
4	纺织、皮革
5	电工电气
6	家用电器
7	数码、电脑
8	化工
9	冶金矿产
10	能源
12	交通运输
13	家装、建材
15	日用百货
17	工艺品、礼品
18	运动装备
51	代理
52	纸业
53	传媒、广电
54	服饰配件、饰品
55	橡塑
56	精细化学品
57	电子元器件
58	照明工业
59	五金、工具
64	环保
65	机械及行业设备
66	医药、保养
67	办公、文教
68	包装
69	商务服务
70	安全、防护
71	汽摩及配件
72	印刷
73	项目合作
96	家纺家饰
97	美容护肤/彩妆
311	童装
312	内衣
509	通信产品
1426	机床
1501	母婴用品
1813	玩具
2805	加工
2829	二手设备转让
3007	个人防护
10165	男装
10166	女装
10208	仪器仪表
1038378	鞋
1042954	箱包皮具
122916001	宠物及园艺
122916002	汽车用品
123614001	钢铁
127380009	运动服饰
130822002	餐饮生鲜
130822220	个护/家清
130823000	性保健品</pre>     
             * 此参数必填
          */
    public void setCategoryId(long categoryId) {
     	         	    this.categoryId = categoryId;
     	        }
    
        [DataMember(Order = 2)]
    private string feedInfo;
    
        /**
       * @return 关键词或offerId
类目id和feedInfo至少输入一项
    */
        public string getFeedInfo() {
               	return feedInfo;
            }
    
    /**
     * 设置关键词或offerId
类目id和feedInfo至少输入一项     *
     * 参数示例：<pre>Mp3
537357997672</pre>     
             * 此参数必填
          */
    public void setFeedInfo(string feedInfo) {
     	         	    this.feedInfo = feedInfo;
     	        }
    
        [DataMember(Order = 3)]
    private string defineTags;
    
        /**
       * @return 属性标签，属性间以逗号分隔
    */
        public string getDefineTags() {
               	return defineTags;
            }
    
    /**
     * 设置属性标签，属性间以逗号分隔     *
     * 参数示例：<pre>含实力商家、深度认证、一件代发、进口货源、是否包含优惠券等标志eg:slsj_flag=true,sdrd_flag=true,yjdf_flag=true,jkhy_flag=true,yhq_flag=true</pre>     
             * 此参数必填
          */
    public void setDefineTags(string defineTags) {
     	         	    this.defineTags = defineTags;
     	        }
    
        [DataMember(Order = 4)]
    private double? filterMinPrice;
    
        /**
       * @return 售价下限
    */
        public double? getFilterMinPrice() {
               	return filterMinPrice;
            }
    
    /**
     * 设置售价下限     *
     * 参数示例：<pre>售价下限</pre>     
             * 此参数必填
          */
    public void setFilterMinPrice(double filterMinPrice) {
     	         	    this.filterMinPrice = filterMinPrice;
     	        }
    
        [DataMember(Order = 5)]
    private double? filterMaxPrice;
    
        /**
       * @return 售价上限
    */
        public double? getFilterMaxPrice() {
               	return filterMaxPrice;
            }
    
    /**
     * 设置售价上限     *
     * 参数示例：<pre>售价上限</pre>     
             * 此参数必填
          */
    public void setFilterMaxPrice(double filterMaxPrice) {
     	         	    this.filterMaxPrice = filterMaxPrice;
     	        }
    
        [DataMember(Order = 6)]
    private int? filterQuantityBeginMin;
    
        /**
       * @return 起批量下限
    */
        public int? getFilterQuantityBeginMin() {
               	return filterQuantityBeginMin;
            }
    
    /**
     * 设置起批量下限     *
     * 参数示例：<pre>起批量下限</pre>     
             * 此参数必填
          */
    public void setFilterQuantityBeginMin(int filterQuantityBeginMin) {
     	         	    this.filterQuantityBeginMin = filterQuantityBeginMin;
     	        }
    
        [DataMember(Order = 7)]
    private int? filterQuantityBeginMax;
    
        /**
       * @return 起批量上限
    */
        public int? getFilterQuantityBeginMax() {
               	return filterQuantityBeginMax;
            }
    
    /**
     * 设置起批量上限     *
     * 参数示例：<pre>起批量上限</pre>     
             * 此参数必填
          */
    public void setFilterQuantityBeginMax(int filterQuantityBeginMax) {
     	         	    this.filterQuantityBeginMax = filterQuantityBeginMax;
     	        }
    
        [DataMember(Order = 8)]
    private int? filterSaleQuantityMin;
    
        /**
       * @return 销量下限
    */
        public int? getFilterSaleQuantityMin() {
               	return filterSaleQuantityMin;
            }
    
    /**
     * 设置销量下限     *
     * 参数示例：<pre>销量下限</pre>     
             * 此参数必填
          */
    public void setFilterSaleQuantityMin(int filterSaleQuantityMin) {
     	         	    this.filterSaleQuantityMin = filterSaleQuantityMin;
     	        }
    
        [DataMember(Order = 9)]
    private int? filterSaleQuantityMax;
    
        /**
       * @return 销量上限
    */
        public int? getFilterSaleQuantityMax() {
               	return filterSaleQuantityMax;
            }
    
    /**
     * 设置销量上限     *
     * 参数示例：<pre>销量上限</pre>     
             * 此参数必填
          */
    public void setFilterSaleQuantityMax(int filterSaleQuantityMax) {
     	         	    this.filterSaleQuantityMax = filterSaleQuantityMax;
     	        }
    
        [DataMember(Order = 10)]
    private double? filterRatioMin;
    
        /**
       * @return 佣金比例下限
    */
        public double? getFilterRatioMin() {
               	return filterRatioMin;
            }
    
    /**
     * 设置佣金比例下限     *
     * 参数示例：<pre>佣金比例下限</pre>     
             * 此参数必填
          */
    public void setFilterRatioMin(double filterRatioMin) {
     	         	    this.filterRatioMin = filterRatioMin;
     	        }
    
        [DataMember(Order = 11)]
    private double? filterRatioMax;
    
        /**
       * @return 佣金比例上限
    */
        public double? getFilterRatioMax() {
               	return filterRatioMax;
            }
    
    /**
     * 设置佣金比例上限     *
     * 参数示例：<pre>佣金比例上限</pre>     
             * 此参数必填
          */
    public void setFilterRatioMax(double filterRatioMax) {
     	         	    this.filterRatioMax = filterRatioMax;
     	        }
    
        [DataMember(Order = 12)]
    private string sortField;
    
        /**
       * @return 排序字段(desc降序，asc升序)
    */
        public string getSortField() {
               	return sortField;
            }
    
    /**
     * 设置排序字段(desc降序，asc升序)     *
     * 参数示例：<pre>销量：saleQuantity^asc;
价格：price^desc;
推广量：tkCnt^desc;
分佣比例：ratio^desc;
月支出佣金：tkCommission^desc;
优惠券面值：yhqDiscountFee^desc;</pre>     
             * 此参数必填
          */
    public void setSortField(string sortField) {
     	         	    this.sortField = sortField;
     	        }
    
        [DataMember(Order = 13)]
    private int? pageNo;
    
        /**
       * @return 页号
    */
        public int? getPageNo() {
               	return pageNo;
            }
    
    /**
     * 设置页号     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setPageNo(int pageNo) {
     	         	    this.pageNo = pageNo;
     	        }
    
        [DataMember(Order = 14)]
    private int? pageSize;
    
        /**
       * @return 页大小
    */
        public int? getPageSize() {
               	return pageSize;
            }
    
    /**
     * 设置页大小     *
     * 参数示例：<pre>100</pre>     
             * 此参数必填
          */
    public void setPageSize(int pageSize) {
     	         	    this.pageSize = pageSize;
     	        }
    
    
  }
}