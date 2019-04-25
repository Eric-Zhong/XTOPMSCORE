using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.account.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaSubAccountListResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private string mainUserId;
    
        /**
       * @return 主账号Userid
    */
        public string getMainUserId() {
               	return mainUserId;
            }
    
    /**
     * 设置主账号Userid     *
          
             * 此参数必填
          */
    public void setMainUserId(string mainUserId) {
     	         	    this.mainUserId = mainUserId;
     	        }
    
        [DataMember(Order = 2)]
    private string mainLoginId;
    
        /**
       * @return 主账号loginId
    */
        public string getMainLoginId() {
               	return mainLoginId;
            }
    
    /**
     * 设置主账号loginId     *
          
             * 此参数必填
          */
    public void setMainLoginId(string mainLoginId) {
     	         	    this.mainLoginId = mainLoginId;
     	        }
    
        [DataMember(Order = 3)]
    private string mainMemberId;
    
        /**
       * @return 主账号MemberId
    */
        public string getMainMemberId() {
               	return mainMemberId;
            }
    
    /**
     * 设置主账号MemberId     *
          
             * 此参数必填
          */
    public void setMainMemberId(string mainMemberId) {
     	         	    this.mainMemberId = mainMemberId;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaAccountSimpleAccountInfo[] subAccountList;
    
        /**
       * @return 子账号列表
    */
        public AlibabaAccountSimpleAccountInfo[] getSubAccountList() {
               	return subAccountList;
            }
    
    /**
     * 设置子账号列表     *
          
             * 此参数必填
          */
    public void setSubAccountList(AlibabaAccountSimpleAccountInfo[] subAccountList) {
     	         	    this.subAccountList = subAccountList;
     	        }
    
        [DataMember(Order = 5)]
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
    
    
  }
}