using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Circle : ICalcArea
    {
        public Circle(double Rad)
        {
            if(Rad <= 0)
            {
                throw new ArgumentException("Radius cannot be negative.");
            }

            rad = Rad;
        }

        public double rad { get; set; }

        public double GetArea()
        {
            return Math.PI * Math.Pow(rad, 2);
        }
    }
}
