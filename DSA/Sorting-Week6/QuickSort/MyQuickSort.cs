using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace DSA.Sorting_Week6.QuickSort
{
    public class MyQuickSort
    {
        public static int[] QuickSort(int[] arr)
        {
            
            arr = QuickSort(arr, 0, arr.Length - 1);
            return arr;
        }

        private static int[] QuickSort(int[] arr, int low, int high)
        {
            int nextPivot = Partitioner(arr, low, high);
            if (low < high)
            {
               arr = QuickSort(arr, low, nextPivot - 1);
                arr = QuickSort(arr, nextPivot + 1, high);
            }
            return arr;
        }

        private static int Partitioner(int[] arr, int low, int high)
        {
            int i = low - 1;
            int pivot = arr[high];

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                int temp2 = arr[i + 1];
                arr[i + 1] = arr[high];
                arr[high] = temp2;
            }

            return i +1;
        }
    }
}
