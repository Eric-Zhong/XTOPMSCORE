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
public class AlibabaProductTokenlessGetResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaProductProductInfo productInfo;
    
        /**
       * @return 商品详细信息
    */
        public AlibabaProductProductInfo getProductInfo() {
               	return productInfo;
            }
    
    /**
     * 设置商品详细信息     *
          
             * 此参数必填
          */
    public void setProductInfo(AlibabaProductProductInfo productInfo) {
     	         	    this.productInfo = productInfo;
     	        }
    
        [DataMember(Order = 2)]
    private string createTime;
    
        /**
       * @return 创建时间
    */
        public DateTime? getCreateTime() {
                 if (createTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(createTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置创建时间     *
          
             * 此参数必填
          */
    public void setCreateTime(DateTime createTime) {
     	         	    this.createTime = DateUtil.format(createTime);
     	        }
    
        [DataMember(Order = 3)]
    private string lastUpdateTime;
    
        /**
       * @return 最后修改时间
    */
        public DateTime? getLastUpdateTime() {
                 if (lastUpdateTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(lastUpdateTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置最后修改时间     *
          
             * 此参数必填
          */
    public void setLastUpdateTime(DateTime lastUpdateTime) {
     	         	    this.lastUpdateTime = DateUtil.format(lastUpdateTime);
     	        }
    
        [DataMember(Order = 4)]
    private string lastRepostTime;
    
        /**
       * @return 最近重发时间，国际站无此信息
    */
        public DateTime? getLastRepostTime() {
                 if (lastRepostTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(lastRepostTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置最近重发时间，国际站无此信息     *
          
             * 此参数必填
          */
    public void setLastRepostTime(DateTime lastRepostTime) {
     	         	    this.lastRepostTime = DateUtil.format(lastRepostTime);
     	        }
    
        [DataMember(Order = 5)]
    private string approvedTime;
    
        /**
       * @return 审核通过时间，国际站无此信息
    */
        public DateTime? getApprovedTime() {
                 if (approvedTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(approvedTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置审核通过时间，国际站无此信息     *
          
             * 此参数必填
          */
    public void setApprovedTime(DateTime approvedTime) {
     	         	    this.approvedTime = DateUtil.format(approvedTime);
     	        }
    
        [DataMember(Order = 6)]
    private string expireTime;
    
        /**
       * @return 过期时间，国际站无此信息
    */
        public DateTime? getExpireTime() {
                 if (expireTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(expireTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置过期时间，国际站无此信息     *
          
             * 此参数必填
          */
    public void setExpireTime(DateTime expireTime) {
     	         	    this.expireTime = DateUtil.format(expireTime);
     	        }
    
        [DataMember(Order = 7)]
    private string errMsg;
    
        /**
       * @return 返回错误信息
    */
        public string getErrMsg() {
               	return errMsg;
            }
    
    /**
     * 设置返回错误信息     *
          
             * 此参数必填
          */
    public void setErrMsg(string errMsg) {
     	         	    this.errMsg = errMsg;
     	        }
    
    
  }
}