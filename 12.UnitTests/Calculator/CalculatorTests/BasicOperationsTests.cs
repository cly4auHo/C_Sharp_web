using Calculator;
using System;
using Xunit;

namespace CalculatorTests
{
    public class BasicOperationsTests
    {
        [Theory]
        [InlineData(4, 5, 9)]
        [InlineData(1, 3, 4)]
        [InlineData(-1, 53, 52)]
        public void Add_AddTwoIntegers_ResultIsCorrect(int firstNumber, int secondNumber, int expected)
        {
            //Arrange
            BasicOperations basicOperations = new BasicOperations();

            //Act
            var result = basicOperations.Add(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
