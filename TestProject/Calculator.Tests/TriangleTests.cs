using System;
using Xunit;

namespace Calculator.Tests
{
    public class TriangleTests
    {

        [Theory]
        [InlineData(-3, 4, 5)]
        [InlineData(3, 4, -5)]
        [InlineData(3, 0, 5)]
        [InlineData(1, 1, 3)]
        public void Is_Triangle_Has_Valid_Sides(double AB, double AC, double BC)
        {
            Assert.Throws<ArgumentException>(() => AreaUtils.CalculTriangleArea(AB, AC, BC));
        }

        [Theory]
        [InlineData(96, 12, 20, 16)]
        [InlineData(20.33316256758894, 8, 7, 6)]
        [InlineData(6, 3, 4, 5)]
        public void Checking_Triangle_Area(double area, double AB, double BC, double AC)
        {
            Assert.Equal(area, AreaUtils.CalculTriangleArea(AB, BC, AC));
        }

        [Fact]
        public void Checking_If_Triangle_Right()
        {
            Assert.True(new Triangle(3, 4, 5).checkIfRectangle);
            Assert.True(new Triangle(12, 20, 16).checkIfRectangle);
            Assert.False(new Triangle(13, 21, 17).checkIfRectangle);
            Assert.False(new Triangle(6, 7, 8).checkIfRectangle);
        }

    }
}
