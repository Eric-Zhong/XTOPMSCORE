using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.multimedia.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaOceanOpenplatformCommonPageResult {

       [DataMember(Order = 1)]
    private string errorCode;
    
        /**
       * @return 错误码
    */
        public string getErrorCode() {
               	return errorCode;
            }
    
    /**
     * 设置错误码     *
     * 参数示例：<pre>null</pre>     
             * 此参数必填
          */
    public void setErrorCode(string errorCode) {
     	         	    this.errorCode = errorCode;
     	        }
    
        [DataMember(Order = 2)]
    private string errorInfo;
    
        /**
       * @return 错误描述
    */
        public string getErrorInfo() {
               	return errorInfo;
            }
    
    /**
     * 设置错误描述     *
     * 参数示例：<pre>null</pre>     
             * 此参数必填
          */
    public void setErrorInfo(string errorInfo) {
     	         	    this.errorInfo = errorInfo;
     	        }
    
        [DataMember(Order = 3)]
    private int? pageIndex;
    
        /**
       * @return 页码
    */
        public int? getPageIndex() {
               	return pageIndex;
            }
    
    /**
     * 设置页码     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setPageIndex(int pageIndex) {
     	         	    this.pageIndex = pageIndex;
     	        }
    
    
  }
}