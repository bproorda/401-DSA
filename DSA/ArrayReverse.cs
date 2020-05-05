using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class ArrayReverse
    {
        public static int[] ReverseArray(int[] array)
        {
            int length = array.Length;
            int[] answerArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                answerArray[i] = array[(length - (1 + i))];
            }
            return answerArray;
        }
    }
}
