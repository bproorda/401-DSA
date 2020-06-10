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

            for (int i = 0; i < input.Length; i++)
            {
                int j = i - 1;
                int temp = input[i];

                while (j>=0 && temp < input[j])
                {
                    input[j + 1] = input[j];
                    j = j - 1;
                }
                input[j + 1] = temp;

            }

            return input;
        }
    }

    public class EmptyArrayException : Exception
    {

    }
}
