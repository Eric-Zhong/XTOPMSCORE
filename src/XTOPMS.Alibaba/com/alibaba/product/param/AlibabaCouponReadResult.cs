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
public class AlibabaCouponReadResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaCouponOpenProductCoupon[] couponResource;
    
        /**
       * @return 优惠券信息
    */
        public AlibabaCouponOpenProductCoupon[] getCouponResource() {
               	return couponResource;
            }
    
    /**
     * 设置优惠券信息     *
          
             * 此参数必填
          */
    public void setCouponResource(AlibabaCouponOpenProductCoupon[] couponResource) {
     	         	    this.couponResource = couponResource;
     	        }
    
        [DataMember(Order = 2)]
    private int? sizePerPage;
    
        /**
       * @return 每页大小
    */
        public int? getSizePerPage() {
               	return sizePerPage;
            }
    
    /**
     * 设置每页大小     *
          
             * 此参数必填
          */
    public void setSizePerPage(int sizePerPage) {
     	         	    this.sizePerPage = sizePerPage;
     	        }
    
        [DataMember(Order = 3)]
    private int? pageIndex;
    
        /**
       * @return 当前页从0开始
    */
        public int? getPageIndex() {
               	return pageIndex;
            }
    
    /**
     * 设置当前页从0开始     *
          
             * 此参数必填
          */
    public void setPageIndex(int pageIndex) {
     	         	    this.pageIndex = pageIndex;
     	        }
    
        [DataMember(Order = 4)]
    private int? totalRecords;
    
        /**
       * @return 记录总数
    */
        public int? getTotalRecords() {
               	return totalRecords;
            }
    
    /**
     * 设置记录总数     *
          
             * 此参数必填
          */
    public void setTotalRecords(int totalRecords) {
     	         	    this.totalRecords = totalRecords;
     	        }
    
        [DataMember(Order = 5)]
    private bool? success;
    
        /**
       * @return 是否查询成功
    */
        public bool? getSuccess() {
               	return success;
            }
    
    /**
     * 设置是否查询成功     *
          
             * 此参数必填
          */
    public void setSuccess(bool success) {
     	         	    this.success = success;
     	        }
    
        [DataMember(Order = 6)]
    private string errorCode;
    
        /**
       * @return 错误码
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置错误码     *
          
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 7)]
    private string errorInfo;
    
        /**
       * @return 错误信息
    */
        public string getErrorInfo() {
               	return errorInfo;
            }
    
    /**
     * 设置错误信息     *
          
             * 此参数必填
          */
    public void setErrorInfo(string errorInfo) {
     	         	    this.errorInfo = errorInfo;
     	        }
    
    
  }
}