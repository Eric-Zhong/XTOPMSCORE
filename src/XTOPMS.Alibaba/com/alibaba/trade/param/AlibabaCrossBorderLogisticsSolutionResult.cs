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
public class AlibabaCrossBorderLogisticsSolutionResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private string success;
    
        /**
       * @return 是否成功
    */
        public string getSuccess() {
               	return success;
            }
    
    /**
     * 设置是否成功     *
          
             * 此参数必填
          */
    public void setSuccess(string success) {
     	         	    this.success = success;
     	        }
    
        [DataMember(Order = 2)]
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
    
        [DataMember(Order = 3)]
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
    
        [DataMember(Order = 4)]
    private ComAlibabaOceanOpenplatformBizLogisticsResultCainiaoSolutionInfoModel[] solutionList;
    
        /**
       * @return 可使用的路线列表
    */
        public ComAlibabaOceanOpenplatformBizLogisticsResultCainiaoSolutionInfoModel[] getSolutionList() {
               	return solutionList;
            }
    
    /**
     * 设置可使用的路线列表     *
          
             * 此参数必填
          */
    public void setSolutionList(ComAlibabaOceanOpenplatformBizLogisticsResultCainiaoSolutionInfoModel[] solutionList) {
     	         	    this.solutionList = solutionList;
     	        }
    
    
  }
}