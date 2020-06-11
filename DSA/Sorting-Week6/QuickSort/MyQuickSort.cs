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
            
            QuickSort(arr, 0, arr.Length - 1);
            return arr;
        }

        private static void QuickSort(int[] arr, int low, int high)
        {
            
            if (low < high)
            {
                int pivotIndex = Partitioner(arr, low, high);
                QuickSort(arr, low, pivotIndex - 1);
                 QuickSort(arr, pivotIndex + 1, high);
            }
            
        }

        private static int Partitioner(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp1 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp1;
                }
            }
            // uses arr[i +1] to swap the pivot with first element greater than it
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;

            return i + 1;

        }
    }
}
