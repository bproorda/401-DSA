using DSA.Sorting_Week6;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace DSA.tests
{
   public class InsertSortTests
    {
        [Fact]
        public void Testing_Insertion_Sort()
        {
            //arrange
            int[] input = new int[] { 5, 2, 9, 4 };
            int[] expected = new int[] { 2, 4, 5, 9 };

            //act
            int[] actual = InsertSort.InsertionSort(input);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
