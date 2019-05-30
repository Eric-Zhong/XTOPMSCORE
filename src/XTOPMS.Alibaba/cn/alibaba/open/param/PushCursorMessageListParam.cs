using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace cn.alibaba.open.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class PushCursorMessageListParam : GatewayAPIRequest {

    public PushCursorMessageListParam() {
        this.ApiId = new APIId("cn.alibaba.open", "push.cursor.messageList",1);
	}
	
   
  }
}