using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public struct Point3D 
    {

        private static readonly Point3D start = new Point3D(0, 0, 0);

        private static Point3D ReturnStart
        {
            get { return start; }
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D (double X, double Y, double Z) : this()
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public override string ToString()
        {
            return string.Format("X = {0}, Y = {1}, Z = {2}", this.X, this.Y, this.Z);
            
        }
        

        public Point3D Parse(string input)
        {

            string number = "";
            int n = 0;
            double[] pointsCoordinate = new double[3];
            bool parseNumber = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsNumber(input[i]) || input[i] == '.')
                {
                    number += input[i];
                    parseNumber = false;
                }

                else
                {
                    parseNumber = true;
                }

                if (parseNumber && number.Length > 0 || i == input.Length - 1)
                {
                    pointsCoordinate[n] = double.Parse(number);
                    number = "";
                    n++;
                    parseNumber = false;
                }



            }

            return new Point3D(pointsCoordinate[0], pointsCoordinate[1], pointsCoordinate[2]);
            
        }
       
       
    }
}
