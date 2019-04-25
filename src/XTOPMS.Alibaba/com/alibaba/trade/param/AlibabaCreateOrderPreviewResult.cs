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
public class AlibabaCreateOrderPreviewResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaCreateOrderPreviewResultModel[] orderPreviewResuslt;
    
        /**
       * @return 订单预览结果，过自动拆单会返回多个记录
    */
        public AlibabaCreateOrderPreviewResultModel[] getOrderPreviewResuslt() {
               	return orderPreviewResuslt;
            }
    
    /**
     * 设置订单预览结果，过自动拆单会返回多个记录     *
          
             * 此参数必填
          */
    public void setOrderPreviewResuslt(AlibabaCreateOrderPreviewResultModel[] orderPreviewResuslt) {
     	         	    this.orderPreviewResuslt = orderPreviewResuslt;
     	        }
    
        [DataMember(Order = 2)]
    private bool? success;
    
        /**
       * @return 是否成功
    */
        public bool? getSuccess() {
               	return success;
            }
    
    /**
     * 设置是否成功     *
          
             * 此参数必填
          */
    public void setSuccess(bool success) {
     	         	    this.success = success;
     	        }
    
        [DataMember(Order = 3)]
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
    
        [DataMember(Order = 4)]
    private string errorMsg;
    
        /**
       * @return 错误信息
    */
        public string getErrorMsg() {
               	return errorMsg;
            }
    
    /**
     * 设置错误信息     *
          
             * 此参数必填
          */
    public void setErrorMsg(string errorMsg) {
     	         	    this.errorMsg = errorMsg;
     	        }
    
        [DataMember(Order = 5)]
    private long[] postFeeByDescOfferList;
    
        /**
       * @return 运费说明的商品列表
    */
        public long[] getPostFeeByDescOfferList() {
               	return postFeeByDescOfferList;
            }
    
    /**
     * 设置运费说明的商品列表     *
          
             * 此参数必填
          */
    public void setPostFeeByDescOfferList(long[] postFeeByDescOfferList) {
     	         	    this.postFeeByDescOfferList = postFeeByDescOfferList;
     	        }
    
        [DataMember(Order = 6)]
    private long[] consignOfferList;
    
        /**
       * @return 代销商品列表
    */
        public long[] getConsignOfferList() {
               	return consignOfferList;
            }
    
    /**
     * 设置代销商品列表     *
          
             * 此参数必填
          */
    public void setConsignOfferList(long[] consignOfferList) {
     	         	    this.consignOfferList = consignOfferList;
     	        }
    
    
  }
}