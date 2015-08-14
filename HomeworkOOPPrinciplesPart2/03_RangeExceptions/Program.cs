using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_RangeExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 101;

            if (number > 100 || number < 1)
            {
                Console.WriteLine(new InvalidRangeException<int>(1, 100).CustomMessage);
            }


            DateTime wrongDate = new DateTime(2015, 5, 12);
            DateTime minDate = new DateTime(1980, 1, 1);
            DateTime maxDate = new DateTime(2013, 12, 31);
    
            if (wrongDate < minDate || wrongDate > maxDate)
            {

                InvalidRangeException<DateTime> ex = new InvalidRangeException<DateTime>(minDate, maxDate);
                Console.WriteLine(ex.CustomMessage);
            }

        }


        
    
    
    }
}
