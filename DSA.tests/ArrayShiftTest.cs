using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DSA.tests
{
   public class ArrayShiftTest
    {
        [Fact]
        public void ShiftArrayTest()
        {
            // Arrange
            int[] inputArray = new int[4] { 1, 2, 3, 4 };
            int inputNumber = 5;
            int[] expected = new int[5] { 1, 2, 5, 3, 4 };

            // Act
            int[] result = ArrayChallenges.InsertShiftArray(inputArray, inputNumber);

            // Assert
            Assert.Equal(expected, result);

        }

    }
}
