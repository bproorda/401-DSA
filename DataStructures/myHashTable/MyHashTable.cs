using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.myHashTable
{
    public class MyHashTable<T>
    {
        public MyEqualityComparer myEqualityComparer;

        public MyHashTable(MyEqualityComparer myEqualityComparer)
        {
            this.myEqualityComparer = myEqualityComparer;
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
    }
}
