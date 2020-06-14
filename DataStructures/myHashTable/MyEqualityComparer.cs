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

            int[] asciiArr = new int[keyLength]; 

            for (int i = 0; i < keyLength; i++)
            {
                asciiArr[i] = (int)key[i];
            }
            return 1;
        }
    }
}
