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
public class AlibabaCpsListShopPageQueryParam : GatewayAPIRequest {

    public AlibabaCpsListShopPageQueryParam() {
        this.ApiId = new APIId("com.alibaba.p4p", "alibaba.cps.listShopPageQuery",1);
	}
	
       [DataMember(Order = 1)]
    private long? sellerId;
    
        /**
       * @return 卖家id
    */
        public long? getSellerId() {
               	return sellerId;
            }
    
    /**
     * 设置卖家id     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setSellerId(long sellerId) {
     	         	    this.sellerId = sellerId;
     	        }
    
        [DataMember(Order = 2)]
    private string companyName;
    
        /**
       * @return 公司名称
    */
        public string getCompanyName() {
               	return companyName;
            }
    
    /**
     * 设置公司名称     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setCompanyName(string companyName) {
     	         	    this.companyName = companyName;
     	        }
    
        [DataMember(Order = 3)]
    private long? categoryId;
    
        /**
       * @return 类目id
    */
        public long? getCategoryId() {
               	return categoryId;
            }
    
    /**
     * 设置类目id     *
     * 参数示例：<pre>0	全部1	农业2	食品、饮料4	纺织、皮革5	电工电气6	家用电器7	数码、电脑8	化工9	冶金矿产10	能源12	交通运输13	家装、建材15	日用百货17	工艺品、礼品18	运动装备51	代理52	纸业53	传媒、广电54	服饰配件、饰品55	橡塑56	精细化学品57	电子元器件58	照明工业59	五金、工具64	环保65	机械及行业设备66	医药、保养67	办公、文教68	包装69	商务服务70	安全、防护71	汽摩及配件72	印刷73	项目合作96	家纺家饰97	美容护肤/彩妆311	童装312	内衣509	通信产品1426	机床1501	母婴用品1813	玩具2805	加工2829	二手设备转让3007	个人防护10165	男装10166	女装10208	仪器仪表1038378	鞋1042954	箱包皮具122916001	宠物及园艺122916002	汽车用品123614001	钢铁127380009	运动服饰130822002	餐饮生鲜130822220	个护/家清130823000	性保健品</pre>     
             * 此参数必填
          */
    public void setCategoryId(long categoryId) {
     	         	    this.categoryId = categoryId;
     	        }
    
        [DataMember(Order = 4)]
    private string defineTags;
    
        /**
       * @return 属性标签
    */
        public string getDefineTags() {
               	return defineTags;
            }
    
    /**
     * 设置属性标签     *
     * 参数示例：<pre>含实力商家、深度认证、标志
eg:slsj_flag=true,sdrd_flag=true</pre>     
             * 此参数必填
          */
    public void setDefineTags(string defineTags) {
     	         	    this.defineTags = defineTags;
     	        }
    
        [DataMember(Order = 5)]
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
    
        [DataMember(Order = 6)]
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
    
        [DataMember(Order = 7)]
    private string sortField;
    
        /**
       * @return 排序字段(desc降序，asc升序)
    */
        public string getSortField() {
               	return sortField;
            }
    
    /**
     * 设置排序字段(desc降序，asc升序)     *
     * 参数示例：<pre>佣金比例：ratio^asc;
商品数量:productCnt^asc;
30天推广量：tkCnt^asc;</pre>     
             * 此参数必填
          */
    public void setSortField(string sortField) {
     	         	    this.sortField = sortField;
     	        }
    
        [DataMember(Order = 8)]
    private int? pageNo;
    
        /**
       * @return 页偏移量
    */
        public int? getPageNo() {
               	return pageNo;
            }
    
    /**
     * 设置页偏移量     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setPageNo(int pageNo) {
     	         	    this.pageNo = pageNo;
     	        }
    
        [DataMember(Order = 9)]
    private int? pageSize;
    
        /**
       * @return 分页大小
    */
        public int? getPageSize() {
               	return pageSize;
            }
    
    /**
     * 设置分页大小     *
     * 参数示例：<pre>100</pre>     
             * 此参数必填
          */
    public void setPageSize(int pageSize) {
     	         	    this.pageSize = pageSize;
     	        }
    
    
  }
}