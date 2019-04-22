using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace com.alibaba.openapi.client.entity
{
    [DataContract(Namespace = "com.alibaba.openapi.client")]
    public class ErrorExceptionDesc
    {
        [DataMember(Order = 0)]
        private string error_code;
        [DataMember(Order = 1)]
        private string error_message;
        [DataMember(Order = 2)]
        private string exception;
        [DataMember(Order = 3)]
        private string error;
        [DataMember(Order = 4)]
        private string error_description;

        public string getError_code()
        {
            return this.error_code;
        }

        public string getError_message()
        {
            return this.error_message;
        }

        public string getException()
        {
            return this.exception;
        }


        public string getError()
        {
            return this.error;
        }

        public string getErrorDescription()
        {
            return this.error_description;
        }

    }
}
