using com.alibaba.openapi.client.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace com.alibaba.openapi.client
{
    public class GatewayAPIRequest
    {
        [DataMember(Order = 0)]
        private APIId apiId;

        public APIId ApiId
        {
            get { return apiId; }
            set { apiId = value; }
        }
        
    }
}
