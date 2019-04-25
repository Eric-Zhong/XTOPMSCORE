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
public class AlibabaMemberGetUserInfoResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private string userId;
    
        /**
       * @return 用户userId
    */
        public string getUserId() {
               	return userId;
            }
    
    /**
     * 设置用户userId     *
          
             * 此参数必填
          */
    public void setUserId(string userId) {
     	         	    this.userId = userId;
     	        }
    
        [DataMember(Order = 2)]
    private string companyName;
    
        /**
       * @return 公司名称
    */
        public string getCompanyName() {
               	return companyName;
            }
    
    /**
     * 设置公司名称     *
          
             * 此参数必填
          */
    public void setCompanyName(string companyName) {
     	         	    this.companyName = companyName;
     	        }
    
        [DataMember(Order = 3)]
    private string memberId;
    
        /**
       * @return 会员ID
    */
        public string getMemberId() {
               	return memberId;
            }
    
    /**
     * 设置会员ID     *
          
             * 此参数必填
          */
    public void setMemberId(string memberId) {
     	         	    this.memberId = memberId;
     	        }
    
        [DataMember(Order = 4)]
    private string loginId;
    
        /**
       * @return loginId
    */
        public string getLoginId() {
               	return loginId;
            }
    
    /**
     * 设置loginId     *
          
             * 此参数必填
          */
    public void setLoginId(string loginId) {
     	         	    this.loginId = loginId;
     	        }
    
        [DataMember(Order = 5)]
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
    
    
  }
}