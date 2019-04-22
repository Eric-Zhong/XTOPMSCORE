using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace com.alibaba.openapi.client
{
    public class APIId
    {
        public APIId()
        {

        }

        public APIId(String namespaceValue,String name, int version)
        {
            this.NamespaceValue = namespaceValue;
            this.Name = name;
            this.version = version;
        }

        private String namespaceValue;

        public String NamespaceValue
        {
            get { return namespaceValue; }
            set { namespaceValue = value; }
        }
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private int version;

        public int Version
        {
            get { return version; }
            set { version = value; }
        }

       
    }
}
