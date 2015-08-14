using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AnimalHierarchy
{
   public class Cat : Animal
    {


        public Cat(string name, int age, sex gendre) : base(name, age, gendre)
        {
        }
        public Cat(string name, int age)
        {
        }

       public override void MakeSound()
        {
            Console.WriteLine("meowing...");
        }
    }
}
