using System;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 1, 2, 3, 4, 5};
            int[] emptyArray = new int[0];
            Console.WriteLine("When the input is [{0}], the output is [{1}]", string.Join(", ", testArray), string.Join(", ", ArrayReverse(testArray)));
            Console.WriteLine("When the input is [{0}], the output is [{1}]", string.Join(", ", emptyArray), string.Join(", ", ArrayReverse(emptyArray)));
            Console.ReadLine();

        }
        public static int[] ArrayReverse(int[] array)
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
