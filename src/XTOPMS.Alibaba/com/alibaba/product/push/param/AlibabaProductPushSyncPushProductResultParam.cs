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
public class AlibabaProductPushSyncPushProductResultParam : GatewayAPIRequest {

    public AlibabaProductPushSyncPushProductResultParam() {
        this.ApiId = new APIId("com.alibaba.product.push", "alibaba.product.push.syncPushProductResult",1);
	}
	
       [DataMember(Order = 1)]
    private AlibabaProductPushPlatformDefinition platformDefinition;
    
        /**
       * @return 目标平台的定义
    */
        public AlibabaProductPushPlatformDefinition getPlatformDefinition() {
               	return platformDefinition;
            }
    
    /**
     * 设置目标平台的定义     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setPlatformDefinition(AlibabaProductPushPlatformDefinition platformDefinition) {
     	         	    this.platformDefinition = platformDefinition;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaProductPushIdentity pushRecordIdentity;
    
        /**
       * @return 在批量铺货时，源平台可能会为每次铺货产生一个批次传递给ISV，ISV可以在同步通知时返回该字段。该字段由平台传递给ISV，该字段不是必须。
    */
        public AlibabaProductPushIdentity getPushRecordIdentity() {
               	return pushRecordIdentity;
            }
    
    /**
     * 设置在批量铺货时，源平台可能会为每次铺货产生一个批次传递给ISV，ISV可以在同步通知时返回该字段。该字段由平台传递给ISV，该字段不是必须。     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setPushRecordIdentity(AlibabaProductPushIdentity pushRecordIdentity) {
     	         	    this.pushRecordIdentity = pushRecordIdentity;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaProductPushPushProductResult pushProductResults;
    
        /**
       * @return 商品级别的铺货结果
    */
        public AlibabaProductPushPushProductResult getPushProductResults() {
               	return pushProductResults;
            }
    
    /**
     * 设置商品级别的铺货结果     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setPushProductResults(AlibabaProductPushPushProductResult pushProductResults) {
     	         	    this.pushProductResults = pushProductResults;
     	        }
    
    
  }
}