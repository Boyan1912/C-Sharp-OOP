using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeNamespace
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]


    public class VersionAttribute : Attribute
    {
        
        public string Version { get; set; }

        public VersionAttribute(string version)
        {
        
            this.Version = version;

        }

    }

        

}
