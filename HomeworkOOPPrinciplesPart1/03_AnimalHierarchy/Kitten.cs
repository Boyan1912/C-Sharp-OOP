using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AnimalHierarchy
{
    public class Kitten : Cat
    {
        private const sex gendre = sex.female;

        public Kitten(string name, int age, sex gendre) : base(name, age, gendre)
        {

            if (gendre == sex.male)
            {
                throw new InvalidOperationException("Kittens are only females");
                
            }
       
        
        
        }

    }
}
