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
public class AlibabaAitoolsGet3DModelMetaResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private string model;
    
        /**
       * @return 模型文件
    */
        public string getModel() {
               	return model;
            }
    
    /**
     * 设置模型文件     *
          
             * 此参数必填
          */
    public void setModel(string model) {
     	         	    this.model = model;
     	        }
    
        [DataMember(Order = 2)]
    private string[] textures;
    
        /**
       * @return 模型纹理
    */
        public string[] getTextures() {
               	return textures;
            }
    
    /**
     * 设置模型纹理     *
          
             * 此参数必填
          */
    public void setTextures(string[] textures) {
     	         	    this.textures = textures;
     	        }
    
    
  }
}