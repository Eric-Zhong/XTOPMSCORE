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
public class AlibabaAitoolsProductSmartTextResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private string subject;
    
        /**
       * @return 自动生成的商品标题
    */
        public string getSubject() {
               	return subject;
            }
    
    /**
     * 设置自动生成的商品标题     *
          
             * 此参数必填
          */
    public void setSubject(string subject) {
     	         	    this.subject = subject;
     	        }
    
        [DataMember(Order = 2)]
    private string descriptionText;
    
        /**
       * @return 自动生成的商品详情描述文案，包含若干短句，几十字左右
    */
        public string getDescriptionText() {
               	return descriptionText;
            }
    
    /**
     * 设置自动生成的商品详情描述文案，包含若干短句，几十字左右     *
          
             * 此参数必填
          */
    public void setDescriptionText(string descriptionText) {
     	         	    this.descriptionText = descriptionText;
     	        }
    
    
  }
}