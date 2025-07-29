using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationsLibrary.Test
{
    public class MathOperationsTests
    {
        [Fact]
        public void MathOperationAddShouldReturnSum()
        {
            //Arrange
            MathOperations operations = new MathOperations();
            double expected = 13;

            //Act
            double actual = operations.Addition(6,7);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MathOperationAddShouldReturnDifference()
        {
            //Arrange
            MathOperations operations = new MathOperations();
            double expected = 150;

            //Act
            double actual = operations.Subtraction(200, 50);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MathOperationAddShouldReturnProduct()
        {
            //Arrange
            MathOperations operations = new MathOperations();
            double expected = 368;

            //Act
            double actual = operations.Multiplication(23, 16);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MathOperationAddShouldReturnQuotient()
        {
            //Arrange
            MathOperations operations = new MathOperations();
            decimal expected = 2;

            //Act
            decimal actual = operations.Division(20, 10);

            //Assert
            Assert.Equal(expected, actual);
        }






    }
}
