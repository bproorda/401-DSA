using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Sorting_Week6.MergeSort
{
   public class MyMergeSort
    {
        public static int[] MergeSort(int[] arr)
        {
            int n = arr.Length;

            if (n > 1)
            {
                int mid = n / 2;
                int[] left = new int[mid];
                int[] right = new int[n - mid];
                for (int i = 0; i < left.Length; i++)
                {
                    left[i] = arr[i];
                }
                for (int j = 0; j < right.Length; j++)
                {
                    right[j] = arr[j + mid];
                }
                MergeSort(left);
                MergeSort(right);
                return  Merge(left, right, arr);
            }
            return default;
            
        }

        public static int[] Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    arr[k] = left[i];
                    i++;
                } else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;

                if (i == left.Length)
                {
                    while (j < right.Length)
                    {
                        arr[k] = right[j];
                        j++;
                        k++;
                    }
                }
                if (j == right.Length)
                {
                    while (i < left.Length)
                    {
                        arr[k] = left[i];
                        i++;
                        k++;
                    }
                }

            }
            return arr;
        }
    }
}
