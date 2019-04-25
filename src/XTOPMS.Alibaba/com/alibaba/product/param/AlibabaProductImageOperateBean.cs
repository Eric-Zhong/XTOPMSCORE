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
public class AlibabaProductImageOperateBean {

       [DataMember(Order = 1)]
    private long? imageId;
    
        /**
       * @return 图片ID
    */
        public long? getImageId() {
               	return imageId;
            }
    
    /**
     * 设置图片ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setImageId(long imageId) {
     	         	    this.imageId = imageId;
     	        }
    
        [DataMember(Order = 2)]
    private bool? result;
    
        /**
       * @return 操作结果
    */
        public bool? getResult() {
               	return result;
            }
    
    /**
     * 设置操作结果     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setResult(bool result) {
     	         	    this.result = result;
     	        }
    
        [DataMember(Order = 3)]
    private string code;
    
        /**
       * @return 操作结果错误码
    */
        public string getCode() {
               	return code;
            }
    
    /**
     * 设置操作结果错误码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCode(string code) {
     	         	    this.code = code;
     	        }
    
        [DataMember(Order = 4)]
    private string desc;
    
        /**
       * @return 操作结果错误描述
    */
        public string getDesc() {
               	return desc;
            }
    
    /**
     * 设置操作结果错误描述     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDesc(string desc) {
     	         	    this.desc = desc;
     	        }
    
    
  }
}