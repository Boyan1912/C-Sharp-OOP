using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AnimalHierarchy
{
    class Tomcat : Cat
    {

        private const sex gendre = sex.male;

        public Tomcat(string name, int age, sex gendre) : base(name, age, gendre)
        {

            if (gendre == sex.female)
            {
                throw new InvalidOperationException("Tomcats are only males");
            }
        }



    }
}
