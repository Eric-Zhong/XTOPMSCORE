using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.product.push.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductPushMicroSupplyProductSetupParam : GatewayAPIRequest {

    public AlibabaProductPushMicroSupplyProductSetupParam() {
        this.ApiId = new APIId("com.alibaba.product.push", "alibaba.product.push.microSupply.productSetup",1);
	}
	
       [DataMember(Order = 1)]
    private string appKey;
    
        /**
       * @return 铺货目标的ISV的appkey，并不是调用者的appKey
    */
        public string getAppKey() {
               	return appKey;
            }
    
    /**
     * 设置铺货目标的ISV的appkey，并不是调用者的appKey     *
     * 参数示例：<pre>2663495</pre>     
             * 此参数必填
          */
    public void setAppKey(string appKey) {
     	         	    this.appKey = appKey;
     	        }
    
        [DataMember(Order = 2)]
    private string userIdInMicroPlatform;
    
        /**
       * @return 发起铺货的用户在1688上的标志。该标志在用户授权给ISV时已经传递给ISV。所以ISV可以根据该标志去定位下游平台的用户标志。
    */
        public string getUserIdInMicroPlatform() {
               	return userIdInMicroPlatform;
            }
    
    /**
     * 设置发起铺货的用户在1688上的标志。该标志在用户授权给ISV时已经传递给ISV。所以ISV可以根据该标志去定位下游平台的用户标志。     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setUserIdInMicroPlatform(string userIdInMicroPlatform) {
     	         	    this.userIdInMicroPlatform = userIdInMicroPlatform;
     	        }
    
        [DataMember(Order = 3)]
    private string targetShopName;
    
        /**
       * @return 目标小店标志，该字段是用户在目标平台(ISV)上所开小店的标志。可能一个用户在ISV上会有多个小店，如果该字段不传递，则ISV负责引导用户铺货到目标小店。如果该字段传递，ISV需要负责默认选中该小店进行铺货。
    */
        public string getTargetShopName() {
               	return targetShopName;
            }
    
    /**
     * 设置目标小店标志，该字段是用户在目标平台(ISV)上所开小店的标志。可能一个用户在ISV上会有多个小店，如果该字段不传递，则ISV负责引导用户铺货到目标小店。如果该字段传递，ISV需要负责默认选中该小店进行铺货。     *
     * 参数示例：<pre>   </pre>     
             * 此参数必填
          */
    public void setTargetShopName(string targetShopName) {
     	         	    this.targetShopName = targetShopName;
     	        }
    
        [DataMember(Order = 4)]
    private string pushProductIds;
    
        /**
       * @return 产品ID列表，如果是多个产品，则以”,”分隔。1688只传递商品ID，ID需要根据商品再获取一次商品详情。如何获取见详情API。
    */
        public string getPushProductIds() {
               	return pushProductIds;
            }
    
    /**
     * 设置产品ID列表，如果是多个产品，则以”,”分隔。1688只传递商品ID，ID需要根据商品再获取一次商品详情。如何获取见详情API。     *
     * 参数示例：<pre>  </pre>     
             * 此参数必填
          */
    public void setPushProductIds(string pushProductIds) {
     	         	    this.pushProductIds = pushProductIds;
     	        }
    
        [DataMember(Order = 5)]
    private string errorPage;
    
        /**
       * @return 多渠道铺货的解决方案中，网站会通过开放平台访问ISV的铺货页面，并且嵌入到1688的页面中。在这个过程中可能会出错（比如参数传递的不对，访问权限问题，ISV的APP设置不正确等原因），此时开放平台需要把请求跳转到一个错误页面上，提示稍微友好点的错误提示。该参数为可选字段，如果调用者不传递该字段，则采用API配置的默认错误页面。如果传递了该字段，则把用户重定向到该错误页面。
    */
        public string getErrorPage() {
               	return errorPage;
            }
    
    /**
     * 设置多渠道铺货的解决方案中，网站会通过开放平台访问ISV的铺货页面，并且嵌入到1688的页面中。在这个过程中可能会出错（比如参数传递的不对，访问权限问题，ISV的APP设置不正确等原因），此时开放平台需要把请求跳转到一个错误页面上，提示稍微友好点的错误提示。该参数为可选字段，如果调用者不传递该字段，则采用API配置的默认错误页面。如果传递了该字段，则把用户重定向到该错误页面。     *
     * 参数示例：<pre>  </pre>     
             * 此参数必填
          */
    public void setErrorPage(string errorPage) {
     	         	    this.errorPage = errorPage;
     	        }
    
    
  }
}