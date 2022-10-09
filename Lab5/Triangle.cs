using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Triangle                                // Setting up a new class
    {
        int Base;                                 // Setting the base on the triangle
        int Height;                               // Setting the height on the triangle
        public Triangle(int Base, int Height)     // Creating a constructor
        {
            this.Base = Base;
            this.Height = Height;
        }
        public float TriangleArea()               // Method
        {
            float TriArea = Base * Height / 2;    // Setting up the calculation for the area on the triangle
            return TriArea;                       // The calculation of the area on the triangle
        }
    }
}
