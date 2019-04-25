using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.multimedia.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlbabaVideoVideocenterListParam : GatewayAPIRequest {

    public AlbabaVideoVideocenterListParam() {
        this.ApiId = new APIId("com.alibaba.multimedia", "albaba.video.videocenter.list",1);
	}
	
       [DataMember(Order = 1)]
    private int? page;
    
        /**
       * @return 查询页码，默认返回第一页
    */
        public int? getPage() {
               	return page;
            }
    
    /**
     * 设置查询页码，默认返回第一页     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setPage(int page) {
     	         	    this.page = page;
     	        }
    
        [DataMember(Order = 2)]
    private int? pageSize;
    
        /**
       * @return 每页返回的记录条数，默认返回10条记录
    */
        public int? getPageSize() {
               	return pageSize;
            }
    
    /**
     * 设置每页返回的记录条数，默认返回10条记录     *
     * 参数示例：<pre>10</pre>     
             * 此参数必填
          */
    public void setPageSize(int pageSize) {
     	         	    this.pageSize = pageSize;
     	        }
    
    
  }
}