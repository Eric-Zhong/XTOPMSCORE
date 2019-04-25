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
public class AlibabaUserCategoryListGetResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaOceanOpenplatformBizCategoryCommonModelUserCategoryInfo[] cateList;
    
        /**
       * @return 自定义分类列表
    */
        public AlibabaOceanOpenplatformBizCategoryCommonModelUserCategoryInfo[] getCateList() {
               	return cateList;
            }
    
    /**
     * 设置自定义分类列表     *
          
             * 此参数必填
          */
    public void setCateList(AlibabaOceanOpenplatformBizCategoryCommonModelUserCategoryInfo[] cateList) {
     	         	    this.cateList = cateList;
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
    
    
  }
}