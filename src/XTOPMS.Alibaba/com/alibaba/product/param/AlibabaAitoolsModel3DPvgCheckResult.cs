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
public class AlibabaAitoolsModel3DPvgCheckResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private bool? hasPrivilege;
    
        /**
       * @return 用户是否可以使用 1688 3D 服务，为 true 表示可以使用。
    */
        public bool? getHasPrivilege() {
               	return hasPrivilege;
            }
    
    /**
     * 设置用户是否可以使用 1688 3D 服务，为 true 表示可以使用。     *
          
             * 此参数必填
          */
    public void setHasPrivilege(bool hasPrivilege) {
     	         	    this.hasPrivilege = hasPrivilege;
     	        }
    
        [DataMember(Order = 2)]
    private string userGuideAddress;
    
        /**
       * @return 1688 3D 服务官方指引文档地址
    */
        public string getUserGuideAddress() {
               	return userGuideAddress;
            }
    
    /**
     * 设置1688 3D 服务官方指引文档地址     *
          
             * 此参数必填
          */
    public void setUserGuideAddress(string userGuideAddress) {
     	         	    this.userGuideAddress = userGuideAddress;
     	        }
    
    
  }
}