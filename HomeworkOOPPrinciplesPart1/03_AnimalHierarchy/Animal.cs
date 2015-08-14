using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AnimalHierarchy
{
    public class Animal : ISound
    {
        private string name;
        private int age;
        private sex gendre;

        public Animal(string name, int age, sex gendre) : this()
        {
            this.name = name;
            this.age = age;
            this.gendre = gendre;
        }

        public Animal()
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
        }
        public sex Gendre
        {
            get
            {
                return this.gendre;
            }

        }

        public enum sex
        {
            male,
            female
        }


        public virtual void MakeSound()
         {
             Console.WriteLine("...");
         }
 
        public static double GetAverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(x => x.Age);

        }
    
    
    
    }
}
