using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_64BitArray
{
    class Program
    {
        static void Main(string[] args)
        {

            // Testing...

            var number = new BitArray64(567);
            
            Console.WriteLine(number[9]);

            var number2 = new BitArray64(567);

            Console.WriteLine(number == number2);

            foreach (var bit in number)
            {
                Console.Write(bit);
            }

            Console.WriteLine();

            number[3] = 1;

            foreach (var bit in number)
            {
                Console.Write(bit);
            }

            Console.WriteLine();
            number[4] = 0;

            foreach (var bit in number)
            {
                Console.Write(bit);
            }

            Console.WriteLine();

            Console.WriteLine(number == number2);
           

        }
    }
}
