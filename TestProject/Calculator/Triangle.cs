using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Triangle : ICalcArea
    {
        public double[] lengths;

        public Triangle(double AB, double BC, double AC)
        {
            if(AB + BC < AC || BC + AC < AB || AB + AC < BC)
            {
                throw new ArgumentException("This shape cannot be a triangle");
            }

            if(AB <= 0 || BC <= 0 || AC <= 0)
            {
                throw new ArgumentException("The side lengths cannot be null.");
            }

            lengths = new double[3] {AB, BC, AC};
        }

        public double GetArea()
        {
            //S = p/2 x (p/2-a) x (p/2-b) x (p/2-c)
            double semiPer = lengths.Sum() / 2;

            return Math.Sqrt(semiPer * (semiPer - lengths[0]) * (semiPer - lengths[1]) * (semiPer - lengths[2]));
        }

        public bool checkIfRectangle
        {
            get
            {
                 Array.Sort(lengths);

                 //a^2 + b^2 = c^2
                 return Math.Pow(lengths[0], 2) + Math.Pow(lengths[1], 2) == Math.Pow(lengths[2], 2);
                
            }
        }
    }
}
