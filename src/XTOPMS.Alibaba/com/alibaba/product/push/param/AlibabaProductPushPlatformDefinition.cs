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
public class AlibabaProductPushPlatformDefinition {

       [DataMember(Order = 1)]
    private string definitionId;
    
        /**
       * @return 平台ID，由alibaba定义。比如淘宝为www.taobao.com。枚举值：亚马逊Amazon:AMAZON,速卖通:AE,Wish:WISH,Ebay易贝:EBAY,Lazada来赞达:LAZADA,淘宝Taobao:TAOBAO
    */
        public string getDefinitionId() {
               	return definitionId;
            }
    
    /**
     * 设置平台ID，由alibaba定义。比如淘宝为www.taobao.com。枚举值：亚马逊Amazon:AMAZON,速卖通:AE,Wish:WISH,Ebay易贝:EBAY,Lazada来赞达:LAZADA,淘宝Taobao:TAOBAO     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDefinitionId(string definitionId) {
     	         	    this.definitionId = definitionId;
     	        }
    
    
  }
}