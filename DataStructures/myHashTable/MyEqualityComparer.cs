using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.myHashTable
{
    public class MyEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode(string key)
        {
            int keyLength = key.Length;

            //int[] asciiArr = new int[keyLength];
            int asciiChar;
            int result = 0;

            for (int i = 0; i < keyLength; i++)
            {
                //asciiArr[i] = (int)key[i];
                asciiChar = (int)key[i];
                result += (int)Math.Pow(asciiChar, (keyLength - i));
            }
            return result * 613;
        }
    }
}
