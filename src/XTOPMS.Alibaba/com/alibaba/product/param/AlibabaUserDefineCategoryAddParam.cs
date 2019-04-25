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
public class AlibabaUserDefineCategoryAddParam : GatewayAPIRequest {

    public AlibabaUserDefineCategoryAddParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.userDefine.category.add",1);
	}
	
       [DataMember(Order = 1)]
    private string groupName;
    
        /**
       * @return 要新增的类目的名称
    */
        public string getGroupName() {
               	return groupName;
            }
    
    /**
     * 设置要新增的类目的名称     *
     * 参数示例：<pre>女装</pre>     
             * 此参数必填
          */
    public void setGroupName(string groupName) {
     	         	    this.groupName = groupName;
     	        }
    
        [DataMember(Order = 2)]
    private long? parentID;
    
        /**
       * @return 上一级类目的id。如果要创建的是一级类目，此处值填0
    */
        public long? getParentID() {
               	return parentID;
            }
    
    /**
     * 设置上一级类目的id。如果要创建的是一级类目，此处值填0     *
     * 参数示例：<pre>0</pre>     
             * 此参数必填
          */
    public void setParentID(long parentID) {
     	         	    this.parentID = parentID;
     	        }
    
    
  }
}