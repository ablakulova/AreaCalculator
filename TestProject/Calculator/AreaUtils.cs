using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public static class AreaUtils
    {
        public static double CalculTriangleArea(double AB, double AC, double BC)
        {
            return new Triangle(AB, BC, AC).GetArea();
        }

        public static double CalculCircleArea(double rad)
        {
            return new Circle(rad).GetArea();
        }
    }
}
