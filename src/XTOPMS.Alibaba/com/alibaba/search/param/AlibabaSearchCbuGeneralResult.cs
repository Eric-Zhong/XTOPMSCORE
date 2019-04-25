using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.search.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaSearchCbuGeneralResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaSearchProductSearchResultInfo[] resultList;
    
        /**
       * @return 搜索的返回结果
    */
        public AlibabaSearchProductSearchResultInfo[] getResultList() {
               	return resultList;
            }
    
    /**
     * 设置搜索的返回结果     *
          
             * 此参数必填
          */
    public void setResultList(AlibabaSearchProductSearchResultInfo[] resultList) {
     	         	    this.resultList = resultList;
     	        }
    
        [DataMember(Order = 2)]
    private int? totalRecords;
    
        /**
       * @return 总记录数
    */
        public int? getTotalRecords() {
               	return totalRecords;
            }
    
    /**
     * 设置总记录数     *
          
             * 此参数必填
          */
    public void setTotalRecords(int totalRecords) {
     	         	    this.totalRecords = totalRecords;
     	        }
    
        [DataMember(Order = 3)]
    private int? pageIndex;
    
        /**
       * @return 当前页数
    */
        public int? getPageIndex() {
               	return pageIndex;
            }
    
    /**
     * 设置当前页数     *
          
             * 此参数必填
          */
    public void setPageIndex(int pageIndex) {
     	         	    this.pageIndex = pageIndex;
     	        }
    
        [DataMember(Order = 4)]
    private int? sizePerPage;
    
        /**
       * @return 每页的记录数
    */
        public int? getSizePerPage() {
               	return sizePerPage;
            }
    
    /**
     * 设置每页的记录数     *
          
             * 此参数必填
          */
    public void setSizePerPage(int sizePerPage) {
     	         	    this.sizePerPage = sizePerPage;
     	        }
    
    
  }
}