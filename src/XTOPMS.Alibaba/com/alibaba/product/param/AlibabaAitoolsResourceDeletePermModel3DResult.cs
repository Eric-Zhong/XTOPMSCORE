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
public class AlibabaAitoolsResourceDeletePermModel3DResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private int? numSuccess;
    
        /**
       * @return 成功删除数量
    */
        public int? getNumSuccess() {
               	return numSuccess;
            }
    
    /**
     * 设置成功删除数量     *
          
             * 此参数必填
          */
    public void setNumSuccess(int numSuccess) {
     	         	    this.numSuccess = numSuccess;
     	        }
    
        [DataMember(Order = 2)]
    private int? numFailure;
    
        /**
       * @return 删除失败数量
    */
        public int? getNumFailure() {
               	return numFailure;
            }
    
    /**
     * 设置删除失败数量     *
          
             * 此参数必填
          */
    public void setNumFailure(int numFailure) {
     	         	    this.numFailure = numFailure;
     	        }
    
        [DataMember(Order = 3)]
    private string[] failedIDList;
    
        /**
       * @return 如果有删除失败的模型，则此字段包含删除失败的模型识别号列表
    */
        public string[] getFailedIDList() {
               	return failedIDList;
            }
    
    /**
     * 设置如果有删除失败的模型，则此字段包含删除失败的模型识别号列表     *
          
             * 此参数必填
          */
    public void setFailedIDList(string[] failedIDList) {
     	         	    this.failedIDList = failedIDList;
     	        }
    
        [DataMember(Order = 4)]
    private string[] failedReasons;
    
        /**
       * @return 如果有删除失败的模型，则此字段包含删除失败的原因列表，该字段顺序、大小和 failedIDList 相同，一一对应
    */
        public string[] getFailedReasons() {
               	return failedReasons;
            }
    
    /**
     * 设置如果有删除失败的模型，则此字段包含删除失败的原因列表，该字段顺序、大小和 failedIDList 相同，一一对应     *
          
             * 此参数必填
          */
    public void setFailedReasons(string[] failedReasons) {
     	         	    this.failedReasons = failedReasons;
     	        }
    
    
  }
}