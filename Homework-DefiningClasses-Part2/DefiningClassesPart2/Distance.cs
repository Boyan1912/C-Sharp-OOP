using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    static class Distance
    {

        public static double CalculateDistance(Point3D x, Point3D y)
        {
            return Math.Sqrt(Math.Pow(x.X - y.X, 2) + Math.Pow(x.Y - y.Y, 2) + Math.Pow(x.Z - y.Z, 2));

        }


    }
}
