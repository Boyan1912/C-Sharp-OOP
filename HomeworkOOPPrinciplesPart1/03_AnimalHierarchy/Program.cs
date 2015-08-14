using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AnimalHierarchy
{
    class Program
    {
        static void Main()
        {

            IEnumerable<Animal> animals = new List<Animal>()
            {
                new Dog (name: "Tom", age: 2, gendre: Animal.sex.male),
                new Cat (name: "Suzi", age: 5, gendre: Animal.sex.female),
                new Kitten (name: "Boni", age: 1, gendre: Animal.sex.female),
                new Frog (name: "Jaba", age: 4, gendre: Animal.sex.male),
                new Dog (name: "Jerri", age: 9, gendre: Animal.sex.male),
                new Cat (name: "Tom", age: 3, gendre: Animal.sex.male),
                new Kitten (name: "Mimi", age: 3, gendre: Animal.sex.female),
                new Tomcat (name: "Bubu", age: 5, gendre: Animal.sex.male),
                new Frog (name: "Name", age: 3, gendre: Animal.sex.male),
                new Frog (name: "Name", age: 4, gendre: Animal.sex.male),
                new Frog (name: "Name", age: 2, gendre: Animal.sex.male),
                new Frog (name: "Name", age: 0, gendre: Animal.sex.male),
                new Dog (name: "Name", age: 8, gendre: Animal.sex.male),
                new Dog (name: "Name", age: 7, gendre: Animal.sex.male),
                new Dog (name: "Name", age: 2, gendre: Animal.sex.male),
                new Tomcat (name: "Boom", age: 12, gendre: Animal.sex.male),
                new Tomcat (name: "M", age: 35, gendre: Animal.sex.male),
                new Tomcat (name: "A", age: 72, gendre: Animal.sex.male),
                new Tomcat (name: "B", age: 5, gendre: Animal.sex.male),
            };

            var averageAge = animals.Average(x => x.Age);
            Console.WriteLine("Average age of all animals: {0}", averageAge);

            var dogs = from animal in animals
                                 where animal is Dog
                                 select animal;
            Console.WriteLine("Average age of dogs: {0}", Animal.GetAverageAge(dogs));

            var cats = from animal in animals
                          where animal is Cat
                          select animal;
            Console.WriteLine("Average age of cats: {0}", Animal.GetAverageAge(cats));

            var frogs = from animal in animals
                        where animal is Frog
                        select animal;
            Console.WriteLine("Average age of frogs: {0}", Animal.GetAverageAge(frogs));

            // Lambda:
            var averageKitten = animals.Where(x => x is Kitten).Average(x => x.Age);
            Console.WriteLine("Average age of kitten: {0}", averageKitten);

            var averageAgeTomcats = animals.Where(x => x is Tomcat).Average(x => x.Age);
            Console.WriteLine("Average age of tomcats: {0}", averageAgeTomcats);
        }
    }
}
