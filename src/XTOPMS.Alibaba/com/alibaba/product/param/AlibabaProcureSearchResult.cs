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
public class AlibabaProcureSearchResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaCbuOverseasModelsProcurementOverseasProcureOffer[] model;
    
        /**
       * @return 商品摘要列表
    */
        public AlibabaCbuOverseasModelsProcurementOverseasProcureOffer[] getModel() {
               	return model;
            }
    
    /**
     * 设置商品摘要列表     *
          
             * 此参数必填
          */
    public void setModel(AlibabaCbuOverseasModelsProcurementOverseasProcureOffer[] model) {
     	         	    this.model = model;
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
    private string errorMsg;
    
        /**
       * @return 错误描述
    */
        public string getErrorMsg() {
               	return errorMsg;
            }
    
    /**
     * 设置错误描述     *
          
             * 此参数必填
          */
    public void setErrorMsg(string errorMsg) {
     	         	    this.errorMsg = errorMsg;
     	        }
    
        [DataMember(Order = 4)]
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
    
    
  }
}