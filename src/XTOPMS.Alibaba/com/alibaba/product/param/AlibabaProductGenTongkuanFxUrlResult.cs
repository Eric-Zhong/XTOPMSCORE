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
public class AlibabaProductGenTongkuanFxUrlResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private bool? success;
    
        /**
       * @return 是否成功
    */
        public bool? getSuccess() {
               	return success;
            }
    
    /**
     * 设置是否成功     *
          
             * 此参数必填
          */
    public void setSuccess(bool success) {
     	         	    this.success = success;
     	        }
    
        [DataMember(Order = 2)]
    private string url;
    
        /**
       * @return 生成的URL
    */
        public string getUrl() {
               	return url;
            }
    
    /**
     * 设置生成的URL     *
          
             * 此参数必填
          */
    public void setUrl(string url) {
     	         	    this.url = url;
     	        }
    
        [DataMember(Order = 3)]
    private string error;
    
        /**
       * @return 错误信息
    */
        public string getError() {
               	return error;
            }
    
    /**
     * 设置错误信息     *
          
             * 此参数必填
          */
    public void setError(string error) {
     	         	    this.error = error;
     	        }
    
        [DataMember(Order = 4)]
    private string msg;
    
        /**
       * @return 描述信息
    */
        public string getMsg() {
               	return msg;
            }
    
    /**
     * 设置描述信息     *
          
             * 此参数必填
          */
    public void setMsg(string msg) {
     	         	    this.msg = msg;
     	        }
    
    
  }
}