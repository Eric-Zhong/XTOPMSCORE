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
public class AlibabaProductProductOperateResult {

       [DataMember(Order = 1)]
    private long? productId;
    
        /**
       * @return 商品ID
    */
        public long? getProductId() {
               	return productId;
            }
    
    /**
     * 设置商品ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProductId(long productId) {
     	         	    this.productId = productId;
     	        }
    
        [DataMember(Order = 2)]
    private bool? result;
    
        /**
       * @return 修改是否成功
    */
        public bool? getResult() {
               	return result;
            }
    
    /**
     * 设置修改是否成功     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setResult(bool result) {
     	         	    this.result = result;
     	        }
    
        [DataMember(Order = 3)]
    private string code;
    
        /**
       * @return 错误码
    */
        public string getCode() {
               	return code;
            }
    
    /**
     * 设置错误码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCode(string code) {
     	         	    this.code = code;
     	        }
    
        [DataMember(Order = 4)]
    private string desc;
    
        /**
       * @return 备注
    */
        public string getDesc() {
               	return desc;
            }
    
    /**
     * 设置备注     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDesc(string desc) {
     	         	    this.desc = desc;
     	        }
    
    
  }
}