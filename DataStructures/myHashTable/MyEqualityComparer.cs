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

        public int GetHashCode(string key, int bucketCount)
        {
            int keyLength = key.Length;

            int asciiChar;
            int result = 0;

            for (int i = 0; i < keyLength; i++)
            {
                asciiChar = (int)key[i];
                result += (int)Math.Pow(asciiChar, (keyLength - i));
            }
            if (result < 0)
            {
                result = result * -1;
            }
            int divisor = 59233;
            result = result / divisor;
            result = result % bucketCount;
            return result;
        }

        public int GetHashCode(string obj)
        {
            throw new NotImplementedException();
        }
    }
}
