using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Sorting_Week6
{
    public class InsertSort
    {

        public static int[] InsertionSort(int[] input)
        {
            if (input.Length == 0)
            {
                throw new EmptyArrayException();
            }

            return default;
        }
    }

    public class EmptyArrayException : Exception
    {

    }
}
