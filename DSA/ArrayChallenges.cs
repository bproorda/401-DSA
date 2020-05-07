using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class ArrayChallenges
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
        public static int[] InsertShiftArray(int[] array, int number)
        {
            int middleIndex = 0;
            int[] newArray = new int[array.Length + 1];
            if (array.Length % 2 == 0)
            {
                middleIndex = array.Length / 2;
            }
            else
            {
                middleIndex = (array.Length / 2) + 1;
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < middleIndex)
                {
                    newArray[i] = array[i];
                }
                else if (i == middleIndex)
                {
                    newArray[i] = number;
                }
                else if (i > middleIndex)
                {
                    newArray[i] = array[i - 1];
                }
            }
            return newArray;
        }
        public static int BinarySearch(int[] sortedArray, int searchKey)
        {
            int startPoint = 0;
            int endPoint = sortedArray.Length - 1;
            int middleIndex = 13;
            bool foundAnswer = false;
            while(startPoint < endPoint)
            {
                middleIndex = (startPoint + endPoint) / 2;
                
                if (sortedArray[middleIndex] == searchKey)
                {
                    foundAnswer = true;
                    break;
                } else if (sortedArray[middleIndex] < searchKey)
                {
                    startPoint = middleIndex + 1;
                } else if (sortedArray[middleIndex] > searchKey)
                {
                    endPoint = middleIndex - 1;
                }
            }

            if (foundAnswer == true)
            {
                return middleIndex;
            } else
            {
                return -1;
            }
            
          
           

        }
    }
}
