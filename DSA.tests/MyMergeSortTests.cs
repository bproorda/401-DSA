using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DSA.Sorting_Week6;
using DSA.Sorting_Week6.MergeSort;

namespace DSA.tests
{
    public class MyMergeSortTests
    {
        [Fact]
        public void Merge_Sort_Test_One()
        { 
            //arrange
            int[] test = new int[] { 4, 7, 3, 2};
            int[] expected = new int[] { 2, 3, 4, 7 };

            //act
            int[] actual = MyMergeSort.MergeSort(test);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
