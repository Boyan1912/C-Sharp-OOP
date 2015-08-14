using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {

            var someone = new Person("Pesho", null);
            Console.WriteLine(someone);

            var someoneElse = new Person("Pesho", 20);
            Console.WriteLine(someoneElse);
        }
    }
}
