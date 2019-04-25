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
public class AlibabaOceanOpenplatformBizCategoryCommonModelUserCategoryInfo {

       [DataMember(Order = 1)]
    private AlibabaOceanOpenplatformBizCategoryCommonModelUserCategoryInfo[] children;
    
        /**
       * @return 子自定义类目信息列表
    */
        public AlibabaOceanOpenplatformBizCategoryCommonModelUserCategoryInfo[] getChildren() {
               	return children;
            }
    
    /**
     * 设置子自定义类目信息列表     *
     * 参数示例：<pre>[]</pre>     
             * 此参数必填
          */
    public void setChildren(AlibabaOceanOpenplatformBizCategoryCommonModelUserCategoryInfo[] children) {
     	         	    this.children = children;
     	        }
    
        [DataMember(Order = 2)]
    private string iconUrl;
    
        /**
       * @return 图标
    */
        public string getIconUrl() {
               	return iconUrl;
            }
    
    /**
     * 设置图标     *
     * 参数示例：<pre>http://</pre>     
             * 此参数必填
          */
    public void setIconUrl(string iconUrl) {
     	         	    this.iconUrl = iconUrl;
     	        }
    
        [DataMember(Order = 3)]
    private long? id;
    
        /**
       * @return Id
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置Id     *
     * 参数示例：<pre>100</pre>     
             * 此参数必填
          */
    public void setId(long id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 4)]
    private string name;
    
        /**
       * @return 名称
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置名称     *
     * 参数示例：<pre>自定义类目</pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
        [DataMember(Order = 5)]
    private int? ordering;
    
        /**
       * @return 排序Id
    */
        public int? getOrdering() {
               	return ordering;
            }
    
    /**
     * 设置排序Id     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setOrdering(int ordering) {
     	         	    this.ordering = ordering;
     	        }
    
        [DataMember(Order = 6)]
    private long? pid;
    
        /**
       * @return 父自定义类目ID
    */
        public long? getPid() {
               	return pid;
            }
    
    /**
     * 设置父自定义类目ID     *
     * 参数示例：<pre>123</pre>     
             * 此参数必填
          */
    public void setPid(long pid) {
     	         	    this.pid = pid;
     	        }
    
    
  }
}