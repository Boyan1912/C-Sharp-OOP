using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AnimalHierarchy
{
    public class Dog : Animal
    {

        public Dog(string name, int age, sex gendre) : base(name, age, gendre)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("barking...");
        }

    }
}
