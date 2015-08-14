using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolClasses
{
   public class Person
    {
        public string name;

        public Person(string name)
        {
            this.name = name;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
                
            set
            {
                this.name = value;
            }
                    
        }

       
    }
}
