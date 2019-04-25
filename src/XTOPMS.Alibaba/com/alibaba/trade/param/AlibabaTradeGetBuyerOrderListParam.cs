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
public class AlibabaTradeGetBuyerOrderListParam : GatewayAPIRequest {

    public AlibabaTradeGetBuyerOrderListParam() {
        this.ApiId = new APIId("com.alibaba.trade", "alibaba.trade.getBuyerOrderList",1);
	}
	
       [DataMember(Order = 1)]
    private string[] bizTypes;
    
        /**
       * @return 业务类型，支持： "cn"(普通订单类型), "ws"(大额批发订单类型), "yp"(普通拿样订单类型), "yf"(一分钱拿样订单类型), "fs"(倒批(限时折扣)订单类型), "cz"(加工定制订单类型), "ag"(协议采购订单类型), "hp"(伙拼订单类型), "gc"(国采订单类型), "supply"(供销订单类型), "nyg"(nyg订单类型), "factory"(淘工厂订单类型), "quick"(快订下单), "xiangpin"(享拼订单), "nest"(采购商城-鸟巢), "f2f"(当面付), "cyfw"(存样服务), "sp"(代销订单标记), "wg"(微供订单), "factorysamp"(淘工厂打样订单), "factorybig"(淘工厂大货订单)
    */
        public string[] getBizTypes() {
               	return bizTypes;
            }
    
    /**
     * 设置业务类型，支持： "cn"(普通订单类型), "ws"(大额批发订单类型), "yp"(普通拿样订单类型), "yf"(一分钱拿样订单类型), "fs"(倒批(限时折扣)订单类型), "cz"(加工定制订单类型), "ag"(协议采购订单类型), "hp"(伙拼订单类型), "gc"(国采订单类型), "supply"(供销订单类型), "nyg"(nyg订单类型), "factory"(淘工厂订单类型), "quick"(快订下单), "xiangpin"(享拼订单), "nest"(采购商城-鸟巢), "f2f"(当面付), "cyfw"(存样服务), "sp"(代销订单标记), "wg"(微供订单), "factorysamp"(淘工厂打样订单), "factorybig"(淘工厂大货订单)     *
     * 参数示例：<pre>["cn","ws"]</pre>     
             * 此参数必填
          */
    public void setBizTypes(string[] bizTypes) {
     	         	    this.bizTypes = bizTypes;
     	        }
    
        [DataMember(Order = 2)]
    private string createEndTime;
    
        /**
       * @return 下单结束时间
    */
        public DateTime? getCreateEndTime() {
                 if (createEndTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(createEndTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置下单结束时间     *
     * 参数示例：<pre>20180802211113000+0800</pre>     
             * 此参数必填
          */
    public void setCreateEndTime(DateTime createEndTime) {
     	         	    this.createEndTime = DateUtil.format(createEndTime);
     	        }
    
        [DataMember(Order = 3)]
    private string createStartTime;
    
        /**
       * @return 下单开始时间
    */
        public DateTime? getCreateStartTime() {
                 if (createStartTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(createStartTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置下单开始时间     *
     * 参数示例：<pre>20180102211113000+0800</pre>     
             * 此参数必填
          */
    public void setCreateStartTime(DateTime createStartTime) {
     	         	    this.createStartTime = DateUtil.format(createStartTime);
     	        }
    
        [DataMember(Order = 4)]
    private bool? isHis;
    
        /**
       * @return 是否查询历史订单表,默认查询当前表，即默认值为false
    */
        public bool? getIsHis() {
               	return isHis;
            }
    
    /**
     * 设置是否查询历史订单表,默认查询当前表，即默认值为false     *
     * 参数示例：<pre>false</pre>     
             * 此参数必填
          */
    public void setIsHis(bool isHis) {
     	         	    this.isHis = isHis;
     	        }
    
        [DataMember(Order = 5)]
    private string modifyEndTime;
    
        /**
       * @return 查询修改时间结束
    */
        public DateTime? getModifyEndTime() {
                 if (modifyEndTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(modifyEndTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置查询修改时间结束     *
     * 参数示例：<pre>20180802211113000+0800</pre>     
             * 此参数必填
          */
    public void setModifyEndTime(DateTime modifyEndTime) {
     	         	    this.modifyEndTime = DateUtil.format(modifyEndTime);
     	        }
    
        [DataMember(Order = 6)]
    private string modifyStartTime;
    
        /**
       * @return 查询修改时间开始
    */
        public DateTime? getModifyStartTime() {
                 if (modifyStartTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(modifyStartTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置查询修改时间开始     *
     * 参数示例：<pre>20180102211113000+0800</pre>     
             * 此参数必填
          */
    public void setModifyStartTime(DateTime modifyStartTime) {
     	         	    this.modifyStartTime = DateUtil.format(modifyStartTime);
     	        }
    
        [DataMember(Order = 7)]
    private string orderStatus;
    
        /**
       * @return 订单状态，值有 success, cancel(交易取消，违约金等交割完毕), waitbuyerpay(等待卖家付款)， waitsellersend(等待卖家发货), waitbuyerreceive(等待买家收货 )
    */
        public string getOrderStatus() {
               	return orderStatus;
            }
    
    /**
     * 设置订单状态，值有 success, cancel(交易取消，违约金等交割完毕), waitbuyerpay(等待卖家付款)， waitsellersend(等待卖家发货), waitbuyerreceive(等待买家收货 )     *
     * 参数示例：<pre>success</pre>     
             * 此参数必填
          */
    public void setOrderStatus(string orderStatus) {
     	         	    this.orderStatus = orderStatus;
     	        }
    
        [DataMember(Order = 8)]
    private int? page;
    
        /**
       * @return 查询分页页码，从1开始
    */
        public int? getPage() {
               	return page;
            }
    
    /**
     * 设置查询分页页码，从1开始     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setPage(int page) {
     	         	    this.page = page;
     	        }
    
        [DataMember(Order = 9)]
    private int? pageSize;
    
        /**
       * @return 查询的每页的数量
    */
        public int? getPageSize() {
               	return pageSize;
            }
    
    /**
     * 设置查询的每页的数量     *
     * 参数示例：<pre>20</pre>     
             * 此参数必填
          */
    public void setPageSize(int pageSize) {
     	         	    this.pageSize = pageSize;
     	        }
    
        [DataMember(Order = 10)]
    private string refundStatus;
    
        /**
       * @return 退款状态，支持： "waitselleragree"(等待卖家同意), "refundsuccess"(退款成功), "refundclose"(退款关闭), "waitbuyermodify"(待买家修改), "waitbuyersend"(等待买家退货), "waitsellerreceive"(等待卖家确认收货)
    */
        public string getRefundStatus() {
               	return refundStatus;
            }
    
    /**
     * 设置退款状态，支持： "waitselleragree"(等待卖家同意), "refundsuccess"(退款成功), "refundclose"(退款关闭), "waitbuyermodify"(待买家修改), "waitbuyersend"(等待买家退货), "waitsellerreceive"(等待卖家确认收货)     *
     * 参数示例：<pre>refundsuccess</pre>     
             * 此参数必填
          */
    public void setRefundStatus(string refundStatus) {
     	         	    this.refundStatus = refundStatus;
     	        }
    
        [DataMember(Order = 11)]
    private string sellerMemberId;
    
        /**
       * @return 卖家memberId
    */
        public string getSellerMemberId() {
               	return sellerMemberId;
            }
    
    /**
     * 设置卖家memberId     *
     * 参数示例：<pre>b2b-1624961198</pre>     
             * 此参数必填
          */
    public void setSellerMemberId(string sellerMemberId) {
     	         	    this.sellerMemberId = sellerMemberId;
     	        }
    
        [DataMember(Order = 12)]
    private int? sellerRateStatus;
    
        /**
       * @return 卖家评价状态 (4:已评价,5:未评价,6;不需要评价)
    */
        public int? getSellerRateStatus() {
               	return sellerRateStatus;
            }
    
    /**
     * 设置卖家评价状态 (4:已评价,5:未评价,6;不需要评价)     *
     * 参数示例：<pre>6</pre>     
             * 此参数必填
          */
    public void setSellerRateStatus(int sellerRateStatus) {
     	         	    this.sellerRateStatus = sellerRateStatus;
     	        }
    
        [DataMember(Order = 13)]
    private string tradeType;
    
        /**
       * @return 交易类型:
担保交易(1),
预存款交易(2),
ETC境外收单交易(3),
即时到帐交易(4),
保障金安全交易(5),
统一交易流程(6),
分阶段交易(7),
货到付款交易(8),
信用凭证支付交易(9),
账期支付交易(10),
1688交易4.0，新分阶段交易(50060),
当面付的交易流程(50070),
服务类的交易流程(50080)
    */
        public string getTradeType() {
               	return tradeType;
            }
    
    /**
     * 设置交易类型:
担保交易(1),
预存款交易(2),
ETC境外收单交易(3),
即时到帐交易(4),
保障金安全交易(5),
统一交易流程(6),
分阶段交易(7),
货到付款交易(8),
信用凭证支付交易(9),
账期支付交易(10),
1688交易4.0，新分阶段交易(50060),
当面付的交易流程(50070),
服务类的交易流程(50080)     *
     * 参数示例：<pre>50060</pre>     
             * 此参数必填
          */
    public void setTradeType(string tradeType) {
     	         	    this.tradeType = tradeType;
     	        }
    
        [DataMember(Order = 14)]
    private string productName;
    
        /**
       * @return 商品名称
    */
        public string getProductName() {
               	return productName;
            }
    
    /**
     * 设置商品名称     *
     * 参数示例：<pre>测试商品</pre>     
             * 此参数必填
          */
    public void setProductName(string productName) {
     	         	    this.productName = productName;
     	        }
    
        [DataMember(Order = 15)]
    private bool? needBuyerAddressAndPhone;
    
        /**
       * @return 是否需要查询买家的详细地址信息和电话
    */
        public bool? getNeedBuyerAddressAndPhone() {
               	return needBuyerAddressAndPhone;
            }
    
    /**
     * 设置是否需要查询买家的详细地址信息和电话     *
     * 参数示例：<pre>false</pre>     
             * 此参数必填
          */
    public void setNeedBuyerAddressAndPhone(bool needBuyerAddressAndPhone) {
     	         	    this.needBuyerAddressAndPhone = needBuyerAddressAndPhone;
     	        }
    
        [DataMember(Order = 16)]
    private bool? needMemoInfo;
    
        /**
       * @return 是否需要查询备注信息
    */
        public bool? getNeedMemoInfo() {
               	return needMemoInfo;
            }
    
    /**
     * 设置是否需要查询备注信息     *
     * 参数示例：<pre>false</pre>     
             * 此参数必填
          */
    public void setNeedMemoInfo(bool needMemoInfo) {
     	         	    this.needMemoInfo = needMemoInfo;
     	        }
    
    
  }
}