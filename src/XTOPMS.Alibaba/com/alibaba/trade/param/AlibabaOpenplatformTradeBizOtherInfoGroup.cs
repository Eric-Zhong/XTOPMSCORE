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
public class AlibabaOpenplatformTradeBizOtherInfoGroup {

       [DataMember(Order = 1)]
    private double? additionalFee;
    
        /**
       * @return 附加费,单位，元
    */
        public double? getAdditionalFee() {
               	return additionalFee;
            }
    
    /**
     * 设置附加费,单位，元     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAdditionalFee(double additionalFee) {
     	         	    this.additionalFee = additionalFee;
     	        }
    
        [DataMember(Order = 2)]
    private long? appointedArrivalDate;
    
        /**
       * @return 约定到货日期. 需要把到货日期转换为毫秒传过来.
    */
        public long? getAppointedArrivalDate() {
               	return appointedArrivalDate;
            }
    
    /**
     * 设置约定到货日期. 需要把到货日期转换为毫秒传过来.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAppointedArrivalDate(long appointedArrivalDate) {
     	         	    this.appointedArrivalDate = appointedArrivalDate;
     	        }
    
        [DataMember(Order = 3)]
    private long? autoConfirmReceipt;
    
        /**
       * @return 自动确认收货时间，单位为s
    */
        public long? getAutoConfirmReceipt() {
               	return autoConfirmReceipt;
            }
    
    /**
     * 设置自动确认收货时间，单位为s     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAutoConfirmReceipt(long autoConfirmReceipt) {
     	         	    this.autoConfirmReceipt = autoConfirmReceipt;
     	        }
    
        [DataMember(Order = 4)]
    private string buyerBizPhone;
    
        /**
       * @return 买家业务联系电话
    */
        public string getBuyerBizPhone() {
               	return buyerBizPhone;
            }
    
    /**
     * 设置买家业务联系电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerBizPhone(string buyerBizPhone) {
     	         	    this.buyerBizPhone = buyerBizPhone;
     	        }
    
        [DataMember(Order = 5)]
    private string buyerCommpanyName;
    
        /**
       * @return 买家公司名称
    */
        public string getBuyerCommpanyName() {
               	return buyerCommpanyName;
            }
    
    /**
     * 设置买家公司名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setBuyerCommpanyName(string buyerCommpanyName) {
     	         	    this.buyerCommpanyName = buyerCommpanyName;
     	        }
    
        [DataMember(Order = 6)]
    private long? calCarriage;
    
        /**
       * @return 页面运费模板计算出的运费 单位:分
    */
        public long? getCalCarriage() {
               	return calCarriage;
            }
    
    /**
     * 设置页面运费模板计算出的运费 单位:分     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCalCarriage(long calCarriage) {
     	         	    this.calCarriage = calCarriage;
     	        }
    
        [DataMember(Order = 7)]
    private string channel;
    
        /**
       * @return 下单来源渠道
    */
        public string getChannel() {
               	return channel;
            }
    
    /**
     * 设置下单来源渠道     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setChannel(string channel) {
     	         	    this.channel = channel;
     	        }
    
        [DataMember(Order = 8)]
    private string checkCode;
    
        /**
       * @return 验证码
    */
        public string getCheckCode() {
               	return checkCode;
            }
    
    /**
     * 设置验证码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCheckCode(string checkCode) {
     	         	    this.checkCode = checkCode;
     	        }
    
        [DataMember(Order = 9)]
    private string chooseFreeFreight;
    
        /**
       * @return 用户是否选择店铺免运费 。 "0"：用户没有选择免用费 "1":用户选择免运费.
    */
        public string getChooseFreeFreight() {
               	return chooseFreeFreight;
            }
    
    /**
     * 设置用户是否选择店铺免运费 。 "0"：用户没有选择免用费 "1":用户选择免运费.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setChooseFreeFreight(string chooseFreeFreight) {
     	         	    this.chooseFreeFreight = chooseFreeFreight;
     	        }
    
        [DataMember(Order = 10)]
    private string codServiceType;
    
        /**
       * @return 分档id
    */
        public string getCodServiceType() {
               	return codServiceType;
            }
    
    /**
     * 设置分档id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCodServiceType(string codServiceType) {
     	         	    this.codServiceType = codServiceType;
     	        }
    
        [DataMember(Order = 11)]
    private string[] crossPromotionIds;
    
        /**
       * @return 跨订单优惠
    */
        public string[] getCrossPromotionIds() {
               	return crossPromotionIds;
            }
    
    /**
     * 设置跨订单优惠     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCrossPromotionIds(string[] crossPromotionIds) {
     	         	    this.crossPromotionIds = crossPromotionIds;
     	        }
    
        [DataMember(Order = 12)]
    private string[] crossShopPromotions;
    
        /**
       * @return 跨店店铺优惠内容,不包含优惠券
    */
        public string[] getCrossShopPromotions() {
               	return crossShopPromotions;
            }
    
    /**
     * 设置跨店店铺优惠内容,不包含优惠券     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCrossShopPromotions(string[] crossShopPromotions) {
     	         	    this.crossShopPromotions = crossShopPromotions;
     	        }
    
        [DataMember(Order = 13)]
    private double? discountFee;
    
        /**
       * @return 计算完货品金额后再次进行的减免金额. 单位: 元
    */
        public double? getDiscountFee() {
               	return discountFee;
            }
    
    /**
     * 设置计算完货品金额后再次进行的减免金额. 单位: 元     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDiscountFee(double discountFee) {
     	         	    this.discountFee = discountFee;
     	        }
    
        [DataMember(Order = 14)]
    private string engine;
    
        /**
       * @return 交易流程引擎标识
    */
        public string getEngine() {
               	return engine;
            }
    
    /**
     * 设置交易流程引擎标识     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setEngine(string engine) {
     	         	    this.engine = engine;
     	        }
    
        [DataMember(Order = 15)]
    private string extId;
    
        /**
       * @return 订单级别扩展数据由业务方自行解析, 框架不做任何处理。
    */
        public string getExtId() {
               	return extId;
            }
    
    /**
     * 设置订单级别扩展数据由业务方自行解析, 框架不做任何处理。     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setExtId(string extId) {
     	         	    this.extId = extId;
     	        }
    
        [DataMember(Order = 16)]
    private double? filledCarriage;
    
        /**
       * @return 用户填写的运费 单位:元
    */
        public double? getFilledCarriage() {
               	return filledCarriage;
            }
    
    /**
     * 设置用户填写的运费 单位:元     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFilledCarriage(double filledCarriage) {
     	         	    this.filledCarriage = filledCarriage;
     	        }
    
        [DataMember(Order = 17)]
    private string group;
    
        /**
       * @return 信息所属分组。多订单提交时用来分组。
    */
        public string getGroup() {
               	return group;
            }
    
    /**
     * 设置信息所属分组。多订单提交时用来分组。     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGroup(string group) {
     	         	    this.group = group;
     	        }
    
        [DataMember(Order = 18)]
    private double? guaranteeFee;
    
        /**
       * @return 页面传过来的阿里信用凭证担保费. 单位：元
    */
        public double? getGuaranteeFee() {
               	return guaranteeFee;
            }
    
    /**
     * 设置页面传过来的阿里信用凭证担保费. 单位：元     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setGuaranteeFee(double guaranteeFee) {
     	         	    this.guaranteeFee = guaranteeFee;
     	        }
    
        [DataMember(Order = 19)]
    private string lgArguments;
    
        /**
       * @return 物流二级key value
    */
        public string getLgArguments() {
               	return lgArguments;
            }
    
    /**
     * 设置物流二级key value     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLgArguments(string lgArguments) {
     	         	    this.lgArguments = lgArguments;
     	        }
    
        [DataMember(Order = 20)]
    private string mergedJsonVar;
    
        /**
       * @return json格式的所有数据.
    */
        public string getMergedJsonVar() {
               	return mergedJsonVar;
            }
    
    /**
     * 设置json格式的所有数据.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMergedJsonVar(string mergedJsonVar) {
     	         	    this.mergedJsonVar = mergedJsonVar;
     	        }
    
        [DataMember(Order = 21)]
    private string message;
    
        /**
       * @return 买家留言
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置买家留言     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
        [DataMember(Order = 22)]
    private string mixAmount;
    
        /**
       * @return 混批金额, 单位:元。必填
    */
        public string getMixAmount() {
               	return mixAmount;
            }
    
    /**
     * 设置混批金额, 单位:元。必填     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMixAmount(string mixAmount) {
     	         	    this.mixAmount = mixAmount;
     	        }
    
        [DataMember(Order = 23)]
    private string mixNumber;
    
        /**
       * @return 混批数量。除非为0，否则必填
    */
        public string getMixNumber() {
               	return mixNumber;
            }
    
    /**
     * 设置混批数量。除非为0，否则必填     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMixNumber(string mixNumber) {
     	         	    this.mixNumber = mixNumber;
     	        }
    
        [DataMember(Order = 24)]
    private bool? needCheckCode;
    
        /**
       * @return 是否需要验证码
    */
        public bool? getNeedCheckCode() {
               	return needCheckCode;
            }
    
    /**
     * 设置是否需要验证码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setNeedCheckCode(bool needCheckCode) {
     	         	    this.needCheckCode = needCheckCode;
     	        }
    
        [DataMember(Order = 25)]
    private int? needCheckInstant;
    
        /**
       * @return 是否使用协议提额极速到账，用来接收checkbox的状态 。
     * -1：页面上未出现checkbox，走老的极速到账逻辑
     * 0：页面上出现了checkbox，但未被买家选中，表示不走极速到账交易，走支付宝担保交易
     * 1：页面上出现了checkbox，且被买家选中，表示走提额极速到账
    */
        public int? getNeedCheckInstant() {
               	return needCheckInstant;
            }
    
    /**
     * 设置是否使用协议提额极速到账，用来接收checkbox的状态 。
     * -1：页面上未出现checkbox，走老的极速到账逻辑
     * 0：页面上出现了checkbox，但未被买家选中，表示不走极速到账交易，走支付宝担保交易
     * 1：页面上出现了checkbox，且被买家选中，表示走提额极速到账     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setNeedCheckInstant(int needCheckInstant) {
     	         	    this.needCheckInstant = needCheckInstant;
     	        }
    
        [DataMember(Order = 26)]
    private bool? needInstallment;
    
        /**
       * @return 是否需要分期付款
    */
        public bool? getNeedInstallment() {
               	return needInstallment;
            }
    
    /**
     * 设置是否需要分期付款     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setNeedInstallment(bool needInstallment) {
     	         	    this.needInstallment = needInstallment;
     	        }
    
        [DataMember(Order = 27)]
    private bool? needRegist;
    
        /**
       * @return 判断前台是否需要登录注册
    */
        public bool? getNeedRegist() {
               	return needRegist;
            }
    
    /**
     * 设置判断前台是否需要登录注册     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setNeedRegist(bool needRegist) {
     	         	    this.needRegist = needRegist;
     	        }
    
        [DataMember(Order = 28)]
    private double? orderCodFee;
    
        /**
       * @return cod服务费
    */
        public double? getOrderCodFee() {
               	return orderCodFee;
            }
    
    /**
     * 设置cod服务费     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderCodFee(double orderCodFee) {
     	         	    this.orderCodFee = orderCodFee;
     	        }
    
        [DataMember(Order = 29)]
    private string orderContractContent;
    
        /**
       * @return 交易合约内容
    */
        public string getOrderContractContent() {
               	return orderContractContent;
            }
    
    /**
     * 设置交易合约内容     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOrderContractContent(string orderContractContent) {
     	         	    this.orderContractContent = orderContractContent;
     	        }
    
        [DataMember(Order = 30)]
    private string payChannel;
    
        /**
       * @return 支付渠道
    */
        public string getPayChannel() {
               	return payChannel;
            }
    
    /**
     * 设置支付渠道     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPayChannel(string payChannel) {
     	         	    this.payChannel = payChannel;
     	        }
    
        [DataMember(Order = 31)]
    private string payEntry;
    
        /**
       * @return 选择的支付入口
    */
        public string getPayEntry() {
               	return payEntry;
            }
    
    /**
     * 设置选择的支付入口     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPayEntry(string payEntry) {
     	         	    this.payEntry = payEntry;
     	        }
    
        [DataMember(Order = 32)]
    private long? payTimeout;
    
        /**
       * @return 定点付款超时时间，单位为ms。 需要把付款超时的日期Date类型转换为毫秒传过来.
    */
        public long? getPayTimeout() {
               	return payTimeout;
            }
    
    /**
     * 设置定点付款超时时间，单位为ms。 需要把付款超时的日期Date类型转换为毫秒传过来.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPayTimeout(long payTimeout) {
     	         	    this.payTimeout = payTimeout;
     	        }
    
        [DataMember(Order = 33)]
    private string payWay;
    
        /**
       * @return 支付方式。 "6"：全额付款，"7"：分阶段付
    */
        public string getPayWay() {
               	return payWay;
            }
    
    /**
     * 设置支付方式。 "6"：全额付款，"7"：分阶段付     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPayWay(string payWay) {
     	         	    this.payWay = payWay;
     	        }
    
        [DataMember(Order = 34)]
    private string promotionId;
    
        /**
       * @return 店铺优惠id
    */
        public string getPromotionId() {
               	return promotionId;
            }
    
    /**
     * 设置店铺优惠id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPromotionId(string promotionId) {
     	         	    this.promotionId = promotionId;
     	        }
    
        [DataMember(Order = 35)]
    private string selectedLogistics;
    
        /**
       * @return 选择的物流方案标识
    */
        public string getSelectedLogistics() {
               	return selectedLogistics;
            }
    
    /**
     * 设置选择的物流方案标识     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSelectedLogistics(string selectedLogistics) {
     	         	    this.selectedLogistics = selectedLogistics;
     	        }
    
        [DataMember(Order = 36)]
    private string sellerBizPhone;
    
        /**
       * @return 卖家业务联系电话
    */
        public string getSellerBizPhone() {
               	return sellerBizPhone;
            }
    
    /**
     * 设置卖家业务联系电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerBizPhone(string sellerBizPhone) {
     	         	    this.sellerBizPhone = sellerBizPhone;
     	        }
    
        [DataMember(Order = 37)]
    private string sellerCompanyname;
    
        /**
       * @return 卖家公司名称
    */
        public string getSellerCompanyname() {
               	return sellerCompanyname;
            }
    
    /**
     * 设置卖家公司名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSellerCompanyname(string sellerCompanyname) {
     	         	    this.sellerCompanyname = sellerCompanyname;
     	        }
    
        [DataMember(Order = 38)]
    private string site;
    
        /**
       * @return 站点标识
    */
        public string getSite() {
               	return site;
            }
    
    /**
     * 设置站点标识     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSite(string site) {
     	         	    this.site = site;
     	        }
    
        [DataMember(Order = 39)]
    private double? sumCarriage;
    
        /**
       * @return 总运费。除非为0，否则必填
    */
        public double? getSumCarriage() {
               	return sumCarriage;
            }
    
    /**
     * 设置总运费。除非为0，否则必填     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSumCarriage(double sumCarriage) {
     	         	    this.sumCarriage = sumCarriage;
     	        }
    
        [DataMember(Order = 40)]
    private bool? supportInvoice;
    
        /**
       * @return 是否支持发票标识.
    */
        public bool? getSupportInvoice() {
               	return supportInvoice;
            }
    
    /**
     * 设置是否支持发票标识.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSupportInvoice(bool supportInvoice) {
     	         	    this.supportInvoice = supportInvoice;
     	        }
    
        [DataMember(Order = 41)]
    private string toleranceFreight;
    
        /**
       * @return 用来标记运费是否被容错。便于提交订单时跳过运费相关逻辑校验。 1：运费被容错。 0:正常运费.
    */
        public string getToleranceFreight() {
               	return toleranceFreight;
            }
    
    /**
     * 设置用来标记运费是否被容错。便于提交订单时跳过运费相关逻辑校验。 1：运费被容错。 0:正常运费.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToleranceFreight(string toleranceFreight) {
     	         	    this.toleranceFreight = toleranceFreight;
     	        }
    
        [DataMember(Order = 42)]
    private double? totalAmount;
    
        /**
       * @return 货品总金额:， 货品总金额 + 运费，单位: 元。必填
    */
        public double? getTotalAmount() {
               	return totalAmount;
            }
    
    /**
     * 设置货品总金额:， 货品总金额 + 运费，单位: 元。必填     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTotalAmount(double totalAmount) {
     	         	    this.totalAmount = totalAmount;
     	        }
    
        [DataMember(Order = 43)]
    private double? totalProductAmount;
    
        /**
       * @return 商品总金额，确认订购时，页面显示的总金额，用来进行校验。 商品总金额 - 店铺级优惠.
    */
        public double? getTotalProductAmount() {
               	return totalProductAmount;
            }
    
    /**
     * 设置商品总金额，确认订购时，页面显示的总金额，用来进行校验。 商品总金额 - 店铺级优惠.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTotalProductAmount(double totalProductAmount) {
     	         	    this.totalProductAmount = totalProductAmount;
     	        }
    
        [DataMember(Order = 44)]
    private string umpSysAvailble;
    
        /**
       * @return 用来标记ump系统是否可用，这个变量会在前台页面埋点，供ump联动使用. 1：ump 系统可用 0:ump系统不可用.
    */
        public string getUmpSysAvailble() {
               	return umpSysAvailble;
            }
    
    /**
     * 设置用来标记ump系统是否可用，这个变量会在前台页面埋点，供ump联动使用. 1：ump 系统可用 0:ump系统不可用.     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUmpSysAvailble(string umpSysAvailble) {
     	         	    this.umpSysAvailble = umpSysAvailble;
     	        }
    
    
  }
}