using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.trade.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaTradeAddressCode {

       [DataMember(Order = 1)]
    private string code;
    
        /**
       * @return 地区编码
    */
        public string getCode() {
               	return code;
            }
    
    /**
     * 设置地区编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCode(string code) {
     	         	    this.code = code;
     	        }
    
        [DataMember(Order = 2)]
    private string name;
    
        /**
       * @return 地区名称
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置地区名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
        [DataMember(Order = 3)]
    private string parentCode;
    
        /**
       * @return 父节点编码，可能为空
    */
        public string getParentCode() {
               	return parentCode;
            }
    
    /**
     * 设置父节点编码，可能为空     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setParentCode(string parentCode) {
     	         	    this.parentCode = parentCode;
     	        }
    
        [DataMember(Order = 4)]
    private string post;
    
        /**
       * @return 邮编
    */
        public string getPost() {
               	return post;
            }
    
    /**
     * 设置邮编     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPost(string post) {
     	         	    this.post = post;
     	        }
    
        [DataMember(Order = 5)]
    private string[] children;
    
        /**
       * @return 下一级编码列表，可能为空
    */
        public string[] getChildren() {
               	return children;
            }
    
    /**
     * 设置下一级编码列表，可能为空     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setChildren(string[] children) {
     	         	    this.children = children;
     	        }
    
    
  }
}