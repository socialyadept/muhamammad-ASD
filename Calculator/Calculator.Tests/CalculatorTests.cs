using System.Numerics;
using NuGet.Frameworks;
using Xunit.Sdk;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        //Addition
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1, -1, 0)]
        [InlineData(-13, -2, -15)]
        [InlineData(0, 0, 0)]
        [InlineData(2, 3, 5)]
        public void Add_BaseCase(int a, int b, int sum)
        {
            int s = Calculator.Core.Calculator.Add(a, b);
            Assert.Equal(sum, s);
        }

        [Fact]
        public void Add_Negatives()
        {
            int sum = Calculator.Core.Calculator.Add(-1, -2);
            Assert.Equal(-3, sum);
        }

        [Fact]
        public void Add_PositiveAndNegative()
        {
            int sum = Calculator.Core.Calculator.Add(-1, 4);
            Assert.Equal(3, sum);
        }

        [Fact]
        public void Add_ShouldThrowException()
        {
            Assert.Throws<System.OverflowException>(() => Calculator.Core.Calculator.Add(int.MaxValue, 3));
        }


        // Division
        [Theory]
        [InlineData(1, 2, 0.5)]
        [InlineData(1000, 2, 500)]
        [InlineData(-22, 7, -3.14)]
        [InlineData(3, -2, -1.5)]

        public void Divide_BaseCase(int a, int b, double expectedResult)
        {
            double actualResult = Calculator.Core.Calculator.Divide(a, b);
            Assert.Equal(expectedResult, actualResult, 2);
        }

        [Fact]
        public void Divide_ShouldThrowZeroException()
        {
            Assert.Throws<System.ArgumentException>(() => Calculator.Core.Calculator.Divide(2, 0));
        }

        // Multiplication

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(1000, 2, 2000)]
        [InlineData(-22, 7, -154)]
        [InlineData(3, -2, -6)]
        [InlineData(0, -10000, 0)]

        public void Multiply_BaseCase(int a, int b, double expectedResult)
        {
            double actualResult = Calculator.Core.Calculator.Multiply(a, b);
            Assert.Equal(expectedResult, actualResult, 2);
        }

        [Fact]
        public void Multiply_ShouldThrowException()
        {
            Assert.Throws<System.OverflowException>(() => Calculator.Core.Calculator.Multiply(int.MaxValue, 10));
        }

        [Fact]
        public void Multiply_ShouldAlwaysAnswerZero()
        {
            double actualResult = Calculator.Core.Calculator.Multiply(-2200, 0);
            Assert.Equal(0, actualResult, 2);
        }

        // Subtraction
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(1, -1, 2)]
        [InlineData(-13, -2, -11)]
        [InlineData(0, 0, 0)]
        [InlineData(0, -2, 2)]
        [InlineData(1000, -2, 1002)]
        public void Subtract_BaseCase(int a, int b, int sum)
        {
            int s = Calculator.Core.Calculator.Subtract(a, b);
            Assert.Equal(sum, s);
        }

        [Fact]
        public void Subtract_Negatives()
        {
            int sum = Calculator.Core.Calculator.Subtract(-1, -2);
            Assert.Equal(1, sum);
        }

        [Fact]
        public void Subtract_PositiveAndNegative()
        {
            int sum = Calculator.Core.Calculator.Subtract(-1, 4);
            Assert.Equal(-5, sum);
        }

        [Fact]
        public void Subtract_ShouldThrowException()
        {
            Assert.Throws<System.OverflowException>(() => Calculator.Core.Calculator.Subtract(int.MinValue, 1));
        }

    }
}
