using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.trade.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaPreOrderCreateParam : GatewayAPIRequest {

    public AlibabaPreOrderCreateParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.preOrder.create",1);
	}
	
       [DataMember(Order = 1)]
    private string marketName;
    
        /**
       * @return 专业市场与业务场景名称，dxc：大象城，hqb：华强北，cloudMfr：云制造
    */
        public string getMarketName() {
               	return marketName;
            }
    
    /**
     * 设置专业市场与业务场景名称，dxc：大象城，hqb：华强北，cloudMfr：云制造     *
     * 参数示例：<pre>dxc</pre>     
             * 此参数必填
          */
    public void setMarketName(string marketName) {
     	         	    this.marketName = marketName;
     	        }
    
        [DataMember(Order = 2)]
    private long? postFee;
    
        /**
       * @return 运费，单位分
    */
        public long? getPostFee() {
               	return postFee;
            }
    
    /**
     * 设置运费，单位分     *
     * 参数示例：<pre>100</pre>     
             * 此参数必填
          */
    public void setPostFee(long postFee) {
     	         	    this.postFee = postFee;
     	        }
    
        [DataMember(Order = 3)]
    private string remark;
    
        /**
       * @return 开单备注信息
    */
        public string getRemark() {
               	return remark;
            }
    
    /**
     * 设置开单备注信息     *
     * 参数示例：<pre>备注</pre>     
             * 此参数必填
          */
    public void setRemark(string remark) {
     	         	    this.remark = remark;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaPreOrderItemCreateParam[] itemList;
    
        /**
       * @return 详情列表
    */
        public AlibabaPreOrderItemCreateParam[] getItemList() {
               	return itemList;
            }
    
    /**
     * 设置详情列表     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setItemList(AlibabaPreOrderItemCreateParam[] itemList) {
     	         	    this.itemList = itemList;
     	        }
    
        [DataMember(Order = 5)]
    private long? totalFee;
    
        /**
       * @return 货品总金额。货品总额+运费=应付总额，货品总额不传时使用货品单价计算
    */
        public long? getTotalFee() {
               	return totalFee;
            }
    
    /**
     * 设置货品总金额。货品总额+运费=应付总额，货品总额不传时使用货品单价计算     *
     * 参数示例：<pre>100</pre>     
             * 此参数必填
          */
    public void setTotalFee(long totalFee) {
     	         	    this.totalFee = totalFee;
     	        }
    
        [DataMember(Order = 6)]
    private long? logisticsType;
    
        /**
       * @return 物流方式。1:自提；2:快递
    */
        public long? getLogisticsType() {
               	return logisticsType;
            }
    
    /**
     * 设置物流方式。1:自提；2:快递     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setLogisticsType(long logisticsType) {
     	         	    this.logisticsType = logisticsType;
     	        }
    
    
  }
}