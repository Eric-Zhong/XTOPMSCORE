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
public class AlibabaProductDescrTmplListParam : GatewayAPIRequest {

    public AlibabaProductDescrTmplListParam() {
        this.ApiId = new APIId("com.alibaba.product", "alibaba.product.descr.tmpl.list",1);
	}
	
       [DataMember(Order = 1)]
    private string vendor;
    
        /**
       * @return 过滤提供者，为空时返回所有提供者模板
    */
        public string getVendor() {
               	return vendor;
            }
    
    /**
     * 设置过滤提供者，为空时返回所有提供者模板     *
     * 参数示例：<pre>""</pre>     
             * 此参数必填
          */
    public void setVendor(string vendor) {
     	         	    this.vendor = vendor;
     	        }
    
        [DataMember(Order = 2)]
    private string title;
    
        /**
       * @return 过滤模板名，为空时不过滤
    */
        public string getTitle() {
               	return title;
            }
    
    /**
     * 设置过滤模板名，为空时不过滤     *
     * 参数示例：<pre>清新模板</pre>     
             * 此参数必填
          */
    public void setTitle(string title) {
     	         	    this.title = title;
     	        }
    
        [DataMember(Order = 3)]
    private int? page;
    
        /**
       * @return 页码，从 1 开始，默认为 1
    */
        public int? getPage() {
               	return page;
            }
    
    /**
     * 设置页码，从 1 开始，默认为 1     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setPage(int page) {
     	         	    this.page = page;
     	        }
    
        [DataMember(Order = 4)]
    private int? pageSize;
    
        /**
       * @return 页大小，默认为 20，最大不超过 200
    */
        public int? getPageSize() {
               	return pageSize;
            }
    
    /**
     * 设置页大小，默认为 20，最大不超过 200     *
     * 参数示例：<pre>20</pre>     
             * 此参数必填
          */
    public void setPageSize(int pageSize) {
     	         	    this.pageSize = pageSize;
     	        }
    
    
  }
}