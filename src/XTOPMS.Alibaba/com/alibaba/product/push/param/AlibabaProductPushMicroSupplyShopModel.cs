using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.product.push.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductPushMicroSupplyShopModel {

       [DataMember(Order = 1)]
    private string partnerId;
    
        /**
       * @return 合作伙伴id,比如APPKEY
    */
        public string getPartnerId() {
               	return partnerId;
            }
    
    /**
     * 设置合作伙伴id,比如APPKEY     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPartnerId(string partnerId) {
     	         	    this.partnerId = partnerId;
     	        }
    
        [DataMember(Order = 2)]
    private string shopName;
    
        /**
       * @return 小店名称
    */
        public string getShopName() {
               	return shopName;
            }
    
    /**
     * 设置小店名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setShopName(string shopName) {
     	         	    this.shopName = shopName;
     	        }
    
        [DataMember(Order = 3)]
    private string shopDesc;
    
        /**
       * @return 小店描述
    */
        public string getShopDesc() {
               	return shopDesc;
            }
    
    /**
     * 设置小店描述     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setShopDesc(string shopDesc) {
     	         	    this.shopDesc = shopDesc;
     	        }
    
        [DataMember(Order = 4)]
    private string authStart;
    
        /**
       * @return 授权开始时间
    */
        public DateTime? getAuthStart() {
                 if (authStart != null)
          {
              DateTime datetime = DateUtil.formatFromStr(authStart);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置授权开始时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAuthStart(DateTime authStart) {
     	         	    this.authStart = DateUtil.format(authStart);
     	        }
    
        [DataMember(Order = 5)]
    private string authEnd;
    
        /**
       * @return 授权结束时间
    */
        public DateTime? getAuthEnd() {
                 if (authEnd != null)
          {
              DateTime datetime = DateUtil.formatFromStr(authEnd);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置授权结束时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAuthEnd(DateTime authEnd) {
     	         	    this.authEnd = DateUtil.format(authEnd);
     	        }
    
        [DataMember(Order = 6)]
    private string authState;
    
        /**
       * @return 授权状态
    */
        public string getAuthState() {
               	return authState;
            }
    
    /**
     * 设置授权状态     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAuthState(string authState) {
     	         	    this.authState = authState;
     	        }
    
    
  }
}