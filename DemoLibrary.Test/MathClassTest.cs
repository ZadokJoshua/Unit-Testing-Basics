using CoreLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Test
{
    public class MathClassTest
    {
        [Fact]
        public void AdditionShouldReturnSum()
        {
            // Arrange
            MathClass mathClass = new MathClass();
            double expected = 4;

            // Act
            double Actual = mathClass.Addition(2, 2);

            // Assert
            Assert.Equal(expected, Actual);
        }

        [Theory]
        [InlineData(3, 3, 6)]
        [InlineData(7, 4, 11)]
        [InlineData(5, 3, 8)]
        [InlineData(32, 10, 42)]
        public void AdditionShouldReturnSumValue(double n1, double n2, double expected)
        {
            // Arrange
            MathClass mathClass = new MathClass();

            // Act
            double actual = mathClass.Addition(n1, n2);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
