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
public class AlibabaUploadfileListParam : GatewayAPIRequest {

    public AlibabaUploadfileListParam() {
        this.ApiId = new APIId("com.alibaba.multimedia", "alibaba.uploadfile.list",1);
	}
	
   
  }
}