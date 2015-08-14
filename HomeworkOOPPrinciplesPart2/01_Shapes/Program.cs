using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {

            var shapes = new Shapes[] 
            {
                new Triangle(5.5, 6.4),
                new Rectangle(10.3, 4.99),
                new Square(8.9)
            };


           foreach (var shape in shapes)
           {
               Console.WriteLine("The surface of the {0} is {1}", shape.GetType().Name, shape.CalculateSurface());
           }
            
        }
    }
}
