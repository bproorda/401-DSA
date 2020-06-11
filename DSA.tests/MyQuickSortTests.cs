using DSA.Sorting_Week6.QuickSort;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DSA.tests
{
    public class MyQuickSortTests
    {
        [Fact]
        public void Does_Quick_Sort_Work()
        {
            //arrange 
            int[] test = new int[] { 8, 5, 43, 78, 29};
            int[] expected = new int[] { 5, 8, 29, 43, 78};

            //act
            int[] actual = MyQuickSort.QuickSort(test);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
