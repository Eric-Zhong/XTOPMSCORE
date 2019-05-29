using System.Runtime.Serialization;
using com.alibaba.openapi.client;


namespace cn.alibaba.open.param
{
    [DataContract(Namespace = "com.alibaba.openapi.client")]
    public class PushQueryMessageListResult : GatewayAPIResponse
    {
        [DataMember(Order = 1)]
        //private PushMessagePage pushMessagePage = null;
        //public PushMessagePage getPushMessagePage() { return this.pushMessagePage; }
        //public void setPushMessagePage(PushMessagePage value) { this.pushMessagePage = value; }
        public PushMessagePage pushMessagePage { get; set; }
    }
}