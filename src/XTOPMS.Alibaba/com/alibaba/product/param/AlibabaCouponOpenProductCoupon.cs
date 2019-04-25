using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.product.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaCouponOpenProductCoupon {

       [DataMember(Order = 1)]
    private long? buyerId;
    
        /**
       * @return 买家的userId
    */
        public long? getBuyerId() {
               	return buyerId;
            }
    
    /**
     * 设置买家的userId     *
     * 参数示例：<pre>4234234</pre>     
             * 此参数必填
          */
    public void setBuyerId(long buyerId) {
     	         	    this.buyerId = buyerId;
     	        }
    
        [DataMember(Order = 2)]
    private long? couponId;
    
        /**
       * @return 优惠券id
    */
        public long? getCouponId() {
               	return couponId;
            }
    
    /**
     * 设置优惠券id     *
     * 参数示例：<pre>435</pre>     
             * 此参数必填
          */
    public void setCouponId(long couponId) {
     	         	    this.couponId = couponId;
     	        }
    
        [DataMember(Order = 3)]
    private string couponName;
    
        /**
       * @return 优惠券名称
    */
        public string getCouponName() {
               	return couponName;
            }
    
    /**
     * 设置优惠券名称     *
     * 参数示例：<pre>慢100减50券</pre>     
             * 此参数必填
          */
    public void setCouponName(string couponName) {
     	         	    this.couponName = couponName;
     	        }
    
        [DataMember(Order = 4)]
    private long? startFee;
    
        /**
       * @return 优惠券使用条件,满多少钱,单位为分
    */
        public long? getStartFee() {
               	return startFee;
            }
    
    /**
     * 设置优惠券使用条件,满多少钱,单位为分     *
     * 参数示例：<pre>1214</pre>     
             * 此参数必填
          */
    public void setStartFee(long startFee) {
     	         	    this.startFee = startFee;
     	        }
    
        [DataMember(Order = 5)]
    private long? discountFee;
    
        /**
       * @return 优惠券面额,单位为分
    */
        public long? getDiscountFee() {
               	return discountFee;
            }
    
    /**
     * 设置优惠券面额,单位为分     *
     * 参数示例：<pre>1000</pre>     
             * 此参数必填
          */
    public void setDiscountFee(long discountFee) {
     	         	    this.discountFee = discountFee;
     	        }
    
        [DataMember(Order = 6)]
    private int? status;
    
        /**
       * @return 买家拥有的优惠券状态，1正常，0是过期，-1删除
    */
        public int? getStatus() {
               	return status;
            }
    
    /**
     * 设置买家拥有的优惠券状态，1正常，0是过期，-1删除     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setStatus(int status) {
     	         	    this.status = status;
     	        }
    
        [DataMember(Order = 7)]
    private int? source;
    
        /**
       * @return 优惠券来源,如果该优惠券是买家自己领取的，则source=3;如果是别人转赠给他的，则source=14;如果是卖家定向发放的，则source=2
    */
        public int? getSource() {
               	return source;
            }
    
    /**
     * 设置优惠券来源,如果该优惠券是买家自己领取的，则source=3;如果是别人转赠给他的，则source=14;如果是卖家定向发放的，则source=2     *
     * 参数示例：<pre>3</pre>     
             * 此参数必填
          */
    public void setSource(int source) {
     	         	    this.source = source;
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
     * 参数示例：<pre>2018-01-10</pre>     
             * 此参数必填
          */
    public void setGmtCreate(DateTime gmtCreate) {
     	         	    this.gmtCreate = DateUtil.format(gmtCreate);
     	        }
    
        [DataMember(Order = 9)]
    private int? couponType;
    
        /**
       * @return 优惠券类型
    */
        public int? getCouponType() {
               	return couponType;
            }
    
    /**
     * 设置优惠券类型     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCouponType(int couponType) {
     	         	    this.couponType = couponType;
     	        }
    
    
  }
}