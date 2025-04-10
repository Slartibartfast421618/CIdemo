using CIdemo1;
namespace TestProject1
{
    public class UnitTest1
    {
        private readonly ICalculator _calculator;

        public UnitTest1()
        {
            _calculator = new Calculator1();
        }

        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;
            int expected = 8;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference()
        {
            // Arrange
            int a = 10;
            int b = 4;
            int expected = 6;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Multiply_ReturnsCorrectProduct()
        {
            // Arrange
            int a = 7;
            int b = 6;
            int expected = 42;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_ReturnsCorrectQuotient()
        {
            // Arrange
            int a = 20;
            int b = 5;
            int expected = 4;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_ThrowsException_WhenDivisorIsZero()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }

        [Fact]
        public void Divide_HandlesNegativeNumbers()
        {
            // Arrange
            int a = -20;
            int b = 5;
            int expected = -4;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_HandlesNegativeDivisor()
        {
            // Arrange
            int a = 20;
            int b = -5;
            int expected = -4;

            // Act
            double result = _calculator.Divide(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_HandlesNegativeNumbers()
        {
            // Arrange
            int a = -5;
            int b = -3;
            int expected = -8;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Subtract_HandlesNegativeNumbers()
        {
            // Arrange
            int a = -10;
            int b = -4;
            int expected = -6;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Multiply_HandlesNegativeNumbers()
        {
            // Arrange
            int a = -7;
            int b = 6;
            int expected = -42;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}