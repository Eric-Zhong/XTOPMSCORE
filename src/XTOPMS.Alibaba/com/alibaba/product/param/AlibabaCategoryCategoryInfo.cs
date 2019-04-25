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
public class AlibabaCategoryCategoryInfo {

       [DataMember(Order = 1)]
    private long? categoryID;
    
        /**
       * @return 类目ID
    */
        public long? getCategoryID() {
               	return categoryID;
            }
    
    /**
     * 设置类目ID     *
     * 参数示例：<pre>123456</pre>     
             * 此参数必填
          */
    public void setCategoryID(long categoryID) {
     	         	    this.categoryID = categoryID;
     	        }
    
        [DataMember(Order = 2)]
    private string name;
    
        /**
       * @return 类目名称
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置类目名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
        [DataMember(Order = 3)]
    private int? level;
    
        /**
       * @return 类目层级，1688无此内容
    */
        public int? getLevel() {
               	return level;
            }
    
    /**
     * 设置类目层级，1688无此内容     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLevel(int level) {
     	         	    this.level = level;
     	        }
    
        [DataMember(Order = 4)]
    private bool? isLeaf;
    
        /**
       * @return 是否叶子类目（只有叶子类目才能发布商品）
    */
        public bool? getIsLeaf() {
               	return isLeaf;
            }
    
    /**
     * 设置是否叶子类目（只有叶子类目才能发布商品）     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsLeaf(bool isLeaf) {
     	         	    this.isLeaf = isLeaf;
     	        }
    
        [DataMember(Order = 5)]
    private long[] parentIDs;
    
        /**
       * @return 父类目ID数组,1688只返回一个父id
    */
        public long[] getParentIDs() {
               	return parentIDs;
            }
    
    /**
     * 设置父类目ID数组,1688只返回一个父id     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setParentIDs(long[] parentIDs) {
     	         	    this.parentIDs = parentIDs;
     	        }
    
        [DataMember(Order = 6)]
    private long[] childIDs;
    
        /**
       * @return 子类目ID数组，1688无此内容
    */
        public long[] getChildIDs() {
               	return childIDs;
            }
    
    /**
     * 设置子类目ID数组，1688无此内容     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setChildIDs(long[] childIDs) {
     	         	    this.childIDs = childIDs;
     	        }
    
        [DataMember(Order = 7)]
    private AlibabaChildCategoryInfo[] childCategorys;
    
        /**
       * @return 子类目信息
    */
        public AlibabaChildCategoryInfo[] getChildCategorys() {
               	return childCategorys;
            }
    
    /**
     * 设置子类目信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setChildCategorys(AlibabaChildCategoryInfo[] childCategorys) {
     	         	    this.childCategorys = childCategorys;
     	        }
    
    
  }
}