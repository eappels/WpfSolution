using Xunit;

namespace WpfApp.Tests
{
    public class CalculatorTests
    {
        // Add two numbers
        [Fact]
        public void Add_SimpleValuesShouldCalculate()
        {

            // Arrange
            int expected = 5;

            // Act
            int actual = Calculator.Add(3, 2);

            // Assert
            Assert.Equal(expected, actual);
        }
        // Substract two numbers
        [Fact]
        public void Substract_SimpleValuesShouldCalculate()
        {

            // Arrange
            int expected = 5;

            // Act
            int actual = Calculator.Substract(8, 3);

            // Assert
            Assert.Equal(expected, actual);
        }
        // Multiply two numbers
        [Fact]
        public void Multiply_SimpleValuesShouldCalculate()
        {

            // Arrange
            int expected = 15;

            // Act
            int actual = Calculator.Multiply(3, 5);

            // Assert
            Assert.Equal(expected, actual);
        }
        // Divide two numbers
        [Fact]
        public void Divide_SimpleValuesShouldCalculate()
        {

            // Arrange
            double expected = 3;

            // Act
            double actual = Calculator.Divide(9, 3);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}