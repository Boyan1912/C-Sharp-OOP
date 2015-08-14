using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeNamespace
{
    class SampleClass
    {
        [Version("2.10")]
         static void Main(string[] args)
        {

            Type type = typeof(SampleClass);

            object[] attributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attributes)
            {
                Console.WriteLine(item.Version);
            }

        }

    }
}
