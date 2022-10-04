using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(4, 5, 6, 15)]
        [InlineData(5, 6, 7, 18)]
        [InlineData(7, 3, 6, 16)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var c = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = c.Add(num1, num2, num3);

            //Assert
            
            Assert.Equal(expected, actual);
        
        }


        [InlineData(10, 3, 7)]
        [InlineData(14, 5, 9)]
        [InlineData(15, 5, 10)]
        [InlineData(7, 3, 4)]
        //Add test data <-------
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var c = new Calculator();
            //Act
            var actual = c.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [InlineData(3, 5, 15)]
        [InlineData(3, 3, 9)]
        [InlineData(5, 5, 25)]
        [InlineData(7, 3, 21)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var c = new Calculator();
            //Act
            var actual = c.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [InlineData(9, 3, 3)]
        [InlineData(15, 5, 3)]
        [InlineData(12, 6, 2)]
        [InlineData(24, 8, 4)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var c = new Calculator();
            //Act
            var actual = c.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
