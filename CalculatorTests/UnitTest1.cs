using Xunit;
using CalculatorApp;

namespace CalculatorTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, 3, "+", 8)]
        [InlineData(5, 3, "-", 2)]
        [InlineData(5, 3, "*", 15)]
        [InlineData(6, 3, "/", 2)]
        [InlineData(50, 10, "%", 5)]
        [InlineData(9, 3, "%", 0.27)]
        public void TestCalculator(double num1, double num2, string op, double expected)
        {
            Assert.Equal(expected, Program.Calculate(num1, num2, op));
        }

        [Fact]
        public void TestDivisionByZero()
        {
            var ex = Assert.Throws<DivideByZeroException>(() => Program.Calculate(0, 0, "/"));
            Assert.Equal("Cannot divide by zero", ex.Message);
        }
    }
}
