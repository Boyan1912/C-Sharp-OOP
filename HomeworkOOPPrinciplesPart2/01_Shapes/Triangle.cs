﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    public class Triangle : Shapes
    {

        public Triangle(double height, double width)
        {
            this.height = height;
            this.width = width;

        }


        public override double CalculateSurface()
        {

            return this.height * this.width / 2;

        }
    }
}
