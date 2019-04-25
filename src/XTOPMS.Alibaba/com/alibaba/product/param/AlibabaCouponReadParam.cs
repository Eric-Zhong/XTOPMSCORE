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
public class AlibabaCouponReadParam : GatewayAPIRequest {

    public AlibabaCouponReadParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.coupon.read",1);
	}
	
       [DataMember(Order = 1)]
    private int? couponType;
    
        /**
       * @return 优惠券类型，现在只支持商品优惠券（1）、分销优惠券（60）
    */
        public int? getCouponType() {
               	return couponType;
            }
    
    /**
     * 设置优惠券类型，现在只支持商品优惠券（1）、分销优惠券（60）     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setCouponType(int couponType) {
     	         	    this.couponType = couponType;
     	        }
    
        [DataMember(Order = 2)]
    private string couponStartTimeS;
    
        /**
       * @return 优惠券有效期开始时间范围起始时间
    */
        public DateTime? getCouponStartTimeS() {
                 if (couponStartTimeS != null)
          {
              DateTime datetime = DateUtil.formatFromStr(couponStartTimeS);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置优惠券有效期开始时间范围起始时间     *
     * 参数示例：<pre>20180222000000000+0800</pre>     
             * 此参数必填
          */
    public void setCouponStartTimeS(DateTime couponStartTimeS) {
     	         	    this.couponStartTimeS = DateUtil.format(couponStartTimeS);
     	        }
    
        [DataMember(Order = 3)]
    private int? pageSize;
    
        /**
       * @return 每页大小
    */
        public int? getPageSize() {
               	return pageSize;
            }
    
    /**
     * 设置每页大小     *
     * 参数示例：<pre>20</pre>     
             * 此参数必填
          */
    public void setPageSize(int pageSize) {
     	         	    this.pageSize = pageSize;
     	        }
    
        [DataMember(Order = 4)]
    private int? pageIndex;
    
        /**
       * @return 请求的页码
    */
        public int? getPageIndex() {
               	return pageIndex;
            }
    
    /**
     * 设置请求的页码     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setPageIndex(int pageIndex) {
     	         	    this.pageIndex = pageIndex;
     	        }
    
        [DataMember(Order = 5)]
    private int? status;
    
        /**
       * @return 买家优惠券状态, 优惠券的状态有：未使用、使用中、已使用、已赠送
     * 未使用：1
     * 使用中：0
     * 已使用：-2
     * 已赠送：3
     * 全部状态：null
    */
        public int? getStatus() {
               	return status;
            }
    
    /**
     * 设置买家优惠券状态, 优惠券的状态有：未使用、使用中、已使用、已赠送
     * 未使用：1
     * 使用中：0
     * 已使用：-2
     * 已赠送：3
     * 全部状态：null     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setStatus(int status) {
     	         	    this.status = status;
     	        }
    
        [DataMember(Order = 6)]
    private string couponEndTimeS;
    
        /**
       * @return 优惠券有效期开始时间的截止范围时间
    */
        public DateTime? getCouponEndTimeS() {
                 if (couponEndTimeS != null)
          {
              DateTime datetime = DateUtil.formatFromStr(couponEndTimeS);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置优惠券有效期开始时间的截止范围时间     *
     * 参数示例：<pre>20180222000000000+0800</pre>     
             * 此参数必填
          */
    public void setCouponEndTimeS(DateTime couponEndTimeS) {
     	         	    this.couponEndTimeS = DateUtil.format(couponEndTimeS);
     	        }
    
        [DataMember(Order = 7)]
    private string couponStartTimeE;
    
        /**
       * @return 优惠券有效期结束时间范围的结束时间
    */
        public DateTime? getCouponStartTimeE() {
                 if (couponStartTimeE != null)
          {
              DateTime datetime = DateUtil.formatFromStr(couponStartTimeE);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置优惠券有效期结束时间范围的结束时间     *
     * 参数示例：<pre>20180222000000000+0800</pre>     
             * 此参数必填
          */
    public void setCouponStartTimeE(DateTime couponStartTimeE) {
     	         	    this.couponStartTimeE = DateUtil.format(couponStartTimeE);
     	        }
    
        [DataMember(Order = 8)]
    private string couponEndTimeE;
    
        /**
       * @return 优惠券有效期结束时间的截止范围时间
    */
        public DateTime? getCouponEndTimeE() {
                 if (couponEndTimeE != null)
          {
              DateTime datetime = DateUtil.formatFromStr(couponEndTimeE);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置优惠券有效期结束时间的截止范围时间     *
     * 参数示例：<pre>20180222000000000+0800</pre>     
             * 此参数必填
          */
    public void setCouponEndTimeE(DateTime couponEndTimeE) {
     	         	    this.couponEndTimeE = DateUtil.format(couponEndTimeE);
     	        }
    
    
  }
}