using CIdemo1;

namespace TestProject1
{
        public class CalculatorTests
        {
            private readonly ICalculator _calculator;

            public CalculatorTests()
            {
                _calculator = new CalculatorImplementation();
            }

            [Fact]
            public void Add_ReturnsCorrectSum_PositiveNumbers()
            {
                int a = 5;
                int b = 3;
                int expected = 8;
                int result = _calculator.Add(a, b);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void Add_ReturnsCorrectSum_NegativeNumbers()
            {
                int a = -5;
                int b = -3;
                int expected = -8;
                int result = _calculator.Add(a, b);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void Subtract_ReturnsCorrectDifference_PositiveNumbers()
            {
                int a = 10;
                int b = 4;
                int expected = 6;
                int result = _calculator.Subtract(a, b);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void Subtract_ReturnsCorrectDifference_NegativeNumbers()
            {
                int a = -10;
                int b = -4;
                int expected = -6;
                int result = _calculator.Subtract(a, b);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void Multiply_ReturnsCorrectProduct_PositiveNumbers()
            {
                int a = 7;
                int b = 6;
                int expected = 42;
                int result = _calculator.Multiply(a, b);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void Multiply_ReturnsCorrectProduct_NegativeNumbers()
            {
                int a = -7;
                int b = 6;
                int expected = -42;
                int result = _calculator.Multiply(a, b);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void Divide_ReturnsCorrectQuotient_PositiveNumbers()
            {
                int a = 20;
                int b = 5;
                int expected = 4;
                int result = _calculator.Divide(a, b);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void Divide_ReturnsCorrectQuotient_NegativeNumbers()
            {
                int a = -20;
                int b = 5;
                int expected = -4;
                int result = _calculator.Divide(a, b);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void Divide_ThrowsException_WhenDivisorIsZero()
            {
                int a = 10;
                int b = 0;
                Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
            }

            [Fact]
            public void Power_ReturnsCorrectResult_PositiveNumbers()
            {
                double a = 2;
                double b = 3;
                double expected = 8;
                double result = _calculator.Power(a, b);
                Assert.Equal(expected, result, 5); // Using precision of 5 decimal places
            }

            [Fact]
            public void Power_ReturnsCorrectResult_NegativeExponent()
            {
                double a = 2;
                double b = -3;
                double expected = 0.125;
                double result = _calculator.Power(a, b);
                Assert.Equal(expected, result, 5); // Using precision of 5 decimal places
            }

            [Fact]
            public void SquareRoot_ReturnsCorrectResult_PositiveNumbers()
            {
                double a = 16;
                double expected = 4;
                double result = _calculator.SquareRoot(a);
                Assert.Equal(expected, result, 5); // Using precision of 5 decimal places
            }


        }
    }
