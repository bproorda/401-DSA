using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DSA.tests
{
    public class BinarySearchTests
    {
        [Theory]
        [InlineData(new int[] {1, 2, 3, 4}, 2, 1)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, 2)]
        public void FindCorrectIndexTest(int[] sortedArray, int searchKey, int expected)
        {
            //Given
            //When
            int result = ArrayChallenges.BinarySearch(sortedArray, searchKey);

            //Then
            Assert.Equal(expected, result);
            
        }

        [Fact]

        public void NoMatchTest()
        {
            //Given 
            int[] sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 8, 9 };
            int searchKey = 7;

            //When
            int result = ArrayChallenges.BinarySearch(sortedArray, searchKey);

            //Then
            int expected = -1;
            Assert.Equal(expected, result);
        }
    }
}
