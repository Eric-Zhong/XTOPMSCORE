using System.Collections.Generic;
using System.Runtime.Serialization;


namespace cn.alibaba.open.param
{
    [DataContract(Namespace = "com.alibaba.openapi.client")]
    public class PushMessage
    {
        [DataMember(Order = 1)]
        public long msgId { get; set; }
        [DataMember(Order = 2)]
        public string appKey { get; set; }
        [DataMember(Order = 3)]
        public string type { get; set; }
        [DataMember(Order = 4)]
        public string userInfo { get; set; }
        [DataMember(Order = 5)]
        public long gmtBorn { get; set; }
        [DataMember(Order = 6)]
        public string topicGroup { get; set; }
        [DataMember(Order = 7)]
        public string topicName { get; set; }
        [DataMember(Order = 8)]
        public Dictionary<string, object> data { get; set; }
    }
}
