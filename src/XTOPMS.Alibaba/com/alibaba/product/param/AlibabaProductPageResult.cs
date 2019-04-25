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
public class AlibabaProductPageResult {

       [DataMember(Order = 1)]
    private int? sizePerPage;
    
        /**
       * @return 每页数量
    */
        public int? getSizePerPage() {
               	return sizePerPage;
            }
    
    /**
     * 设置每页数量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSizePerPage(int sizePerPage) {
     	         	    this.sizePerPage = sizePerPage;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaProductProductInfo[] resultList;
    
        /**
       * @return 商品列表
    */
        public AlibabaProductProductInfo[] getResultList() {
               	return resultList;
            }
    
    /**
     * 设置商品列表     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setResultList(AlibabaProductProductInfo[] resultList) {
     	         	    this.resultList = resultList;
     	        }
    
        [DataMember(Order = 3)]
    private int? totalRecords;
    
        /**
       * @return 商品总数量
    */
        public int? getTotalRecords() {
               	return totalRecords;
            }
    
    /**
     * 设置商品总数量     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTotalRecords(int totalRecords) {
     	         	    this.totalRecords = totalRecords;
     	        }
    
        [DataMember(Order = 4)]
    private int? pageIndex;
    
        /**
       * @return 当前页码
    */
        public int? getPageIndex() {
               	return pageIndex;
            }
    
    /**
     * 设置当前页码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPageIndex(int pageIndex) {
     	         	    this.pageIndex = pageIndex;
     	        }
    
    
  }
}