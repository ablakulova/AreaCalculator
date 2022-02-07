using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(Math.PI * 16, 4)]
        [InlineData(Math.PI, 1)]
        [InlineData(Math.PI * 4, 2)]
        public void Checking_Circle_Area_Correct(double area, double radius)
        {
            Assert.Equal(area, AreaUtils.CalculCircleArea(radius));
        }

        [Theory]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(-12)]
        public void Checking_Circle_Area_Radius(double radius)
        {
            Assert.Throws<ArgumentException>(() => AreaUtils.CalculCircleArea(radius));
        }
    }
}
