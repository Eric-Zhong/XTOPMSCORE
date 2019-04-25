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
public class AlibabaTradeSimpleBuyer {

       [DataMember(Order = 1)]
    private string memberId;
    
        /**
       * @return 会员memberId
    */
        public string getMemberId() {
               	return memberId;
            }
    
    /**
     * 设置会员memberId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMemberId(string memberId) {
     	         	    this.memberId = memberId;
     	        }
    
        [DataMember(Order = 2)]
    private string name;
    
        /**
       * @return 会员名字
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置会员名字     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
        [DataMember(Order = 3)]
    private long? userId;
    
        /**
       * @return userId
    */
        public long? getUserId() {
               	return userId;
            }
    
    /**
     * 设置userId     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setUserId(long userId) {
     	         	    this.userId = userId;
     	        }
    
    
  }
}