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
public class AlibabaAitoolsDescrTemplateItem {

       [DataMember(Order = 1)]
    private string id;
    
        /**
       * @return 模板ID
    */
        public string getId() {
               	return id;
            }
    
    /**
     * 设置模板ID     *
     * 参数示例：<pre>001</pre>     
             * 此参数必填
          */
    public void setId(string id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 2)]
    private string title;
    
        /**
       * @return 模板名称
    */
        public string getTitle() {
               	return title;
            }
    
    /**
     * 设置模板名称     *
     * 参数示例：<pre>清新风格模板</pre>     
             * 此参数必填
          */
    public void setTitle(string title) {
     	         	    this.title = title;
     	        }
    
        [DataMember(Order = 3)]
    private string previewImageUrl;
    
        /**
       * @return 预览图地址
    */
        public string getPreviewImageUrl() {
               	return previewImageUrl;
            }
    
    /**
     * 设置预览图地址     *
     * 参数示例：<pre>http://foo.bar/baz.jpg</pre>     
             * 此参数必填
          */
    public void setPreviewImageUrl(string previewImageUrl) {
     	         	    this.previewImageUrl = previewImageUrl;
     	        }
    
        [DataMember(Order = 4)]
    private string vendor;
    
        /**
       * @return 提供者
    */
        public string getVendor() {
               	return vendor;
            }
    
    /**
     * 设置提供者     *
     * 参数示例：<pre>阿里巴巴官方模板</pre>     
             * 此参数必填
          */
    public void setVendor(string vendor) {
     	         	    this.vendor = vendor;
     	        }
    
        [DataMember(Order = 5)]
    private string editTime;
    
        /**
       * @return 更新时间
    */
        public DateTime? getEditTime() {
                 if (editTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(editTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置更新时间     *
     * 参数示例：<pre>201811130800000+0800</pre>     
             * 此参数必填
          */
    public void setEditTime(DateTime editTime) {
     	         	    this.editTime = DateUtil.format(editTime);
     	        }
    
    
  }
}