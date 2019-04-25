using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.search.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaSearchRelationAccountInfo {

       [DataMember(Order = 1)]
    private long? userId;
    
        /**
       * @return 关联人ID
    */
        public long? getUserId() {
               	return userId;
            }
    
    /**
     * 设置关联人ID     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUserId(long userId) {
     	         	    this.userId = userId;
     	        }
    
        [DataMember(Order = 2)]
    private string companyName;
    
        /**
       * @return 关联人所在公司名
    */
        public string getCompanyName() {
               	return companyName;
            }
    
    /**
     * 设置关联人所在公司名     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCompanyName(string companyName) {
     	         	    this.companyName = companyName;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaSearchRelationGroupInfo[] relationDesc;
    
        /**
       * @return 关联的信息描述
    */
        public AlibabaSearchRelationGroupInfo[] getRelationDesc() {
               	return relationDesc;
            }
    
    /**
     * 设置关联的信息描述     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRelationDesc(AlibabaSearchRelationGroupInfo[] relationDesc) {
     	         	    this.relationDesc = relationDesc;
     	        }
    
        [DataMember(Order = 4)]
    private string[] domainInPlatforms;
    
        /**
       * @return 卖家在平台上的旺铺域名
    */
        public string[] getDomainInPlatforms() {
               	return domainInPlatforms;
            }
    
    /**
     * 设置卖家在平台上的旺铺域名     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDomainInPlatforms(string[] domainInPlatforms) {
     	         	    this.domainInPlatforms = domainInPlatforms;
     	        }
    
        [DataMember(Order = 5)]
    private string loginId;
    
        /**
       * @return 关联人昵称信息
    */
        public string getLoginId() {
               	return loginId;
            }
    
    /**
     * 设置关联人昵称信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLoginId(string loginId) {
     	         	    this.loginId = loginId;
     	        }
    
    
  }
}