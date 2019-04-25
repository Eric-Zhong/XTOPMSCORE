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
public class AlibabaAgentProductSimpleGetResult : GatewayAPIResponse {

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
    private AlibabaProductProductBizGroupInfo[] bizGroupInfos;
    
        /**
       * @return 产品业务的支持信息,support为false说明不支持.
    */
        public AlibabaProductProductBizGroupInfo[] getBizGroupInfos() {
               	return bizGroupInfos;
            }
    
    /**
     * 设置产品业务的支持信息,support为false说明不支持.     *
          
             * 此参数必填
          */
    public void setBizGroupInfos(AlibabaProductProductBizGroupInfo[] bizGroupInfos) {
     	         	    this.bizGroupInfos = bizGroupInfos;
     	        }
    
        [DataMember(Order = 3)]
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