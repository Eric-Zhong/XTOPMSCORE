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
public class AlibabaProductDescrTmplListResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private string total;
    
        /**
       * @return 检索到的模板总数
    */
        public string getTotal() {
               	return total;
            }
    
    /**
     * 设置检索到的模板总数     *
          
             * 此参数必填
          */
    public void setTotal(string total) {
     	         	    this.total = total;
     	        }
    
        [DataMember(Order = 2)]
    private string page;
    
        /**
       * @return 页码，从 1 开始
    */
        public string getPage() {
               	return page;
            }
    
    /**
     * 设置页码，从 1 开始     *
          
             * 此参数必填
          */
    public void setPage(string page) {
     	         	    this.page = page;
     	        }
    
        [DataMember(Order = 3)]
    private string pageSize;
    
        /**
       * @return 页大小
    */
        public string getPageSize() {
               	return pageSize;
            }
    
    /**
     * 设置页大小     *
          
             * 此参数必填
          */
    public void setPageSize(string pageSize) {
     	         	    this.pageSize = pageSize;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaAitoolsDescrTemplateItem[] resultList;
    
        /**
       * @return 结果模板列表
    */
        public AlibabaAitoolsDescrTemplateItem[] getResultList() {
               	return resultList;
            }
    
    /**
     * 设置结果模板列表     *
          
             * 此参数必填
          */
    public void setResultList(AlibabaAitoolsDescrTemplateItem[] resultList) {
     	         	    this.resultList = resultList;
     	        }
    
    
  }
}