using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.product.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductProductThreeDimModel {

       [DataMember(Order = 1)]
    private string id;
    
        /**
       * @return 模型ID
    */
        public string getId() {
               	return id;
            }
    
    /**
     * 设置模型ID     *
     * 参数示例：<pre>xxx-xx</pre>     
             * 此参数必填
          */
    public void setId(string id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 2)]
    private string url;
    
        /**
       * @return 模型预览图URL
    */
        public string getUrl() {
               	return url;
            }
    
    /**
     * 设置模型预览图URL     *
     * 参数示例：<pre>https://hello.com/hello.jpg</pre>     
             * 此参数必填
          */
    public void setUrl(string url) {
     	         	    this.url = url;
     	        }
    
        [DataMember(Order = 3)]
    private string createTime;
    
        /**
       * @return 模型上传时间
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
     * 设置模型上传时间     *
     * 参数示例：<pre>20180901000000000+0800</pre>     
             * 此参数必填
          */
    public void setCreateTime(DateTime createTime) {
     	         	    this.createTime = DateUtil.format(createTime);
     	        }
    
    
  }
}