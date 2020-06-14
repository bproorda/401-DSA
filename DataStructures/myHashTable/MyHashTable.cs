using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.myHashTable
{
    public class MyHashTable<T>
    {
        //public MyEqualityComparer myEqualityComparer;

        public Node[] buckets { get; set; }

        public MyHashTable(int bucketCount)
        {
            //myEqualityComparer = MyEqualityComparer;
            this.buckets = new Node[bucketCount];
        }


        public class Node
        {
            public string Key { get; set; }

            public T Value { get; set; }

            public Node Next { get; set; }

            public Node(string key, T value)
            {
                this.Key = key;
                this.Value = value;
            }
        }

        public static int GetHashCode(string key)
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
                result  = result * -1;
            }
            return result * 613;
        }
    }
}
