using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.myHashTable
{
    public class MyHashTable<T>
    {
        public MyEqualityComparer myEqualityComparer;

        public Node[] buckets { get; set; }
        public int bucketCount { get; set; }

        public MyHashTable(int bucketCount)
        {
            myEqualityComparer = new MyEqualityComparer();
            this.bucketCount = ((bucketCount > 1024) ? bucketCount : 1024);
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



        public virtual int Add(string key, T value)
        {
            int hashIndex = myEqualityComparer.GetHashCode(key) % bucketCount;

            if (buckets[hashIndex] == null)
            {
                Node newNode = new Node(key, value);
                buckets[hashIndex] = newNode;
            } else
            {
                Node newNode = new Node(key, value);
                buckets[hashIndex].Next = newNode;
            }
            return 0;
        }

        public T Get(string key)
        {
            int index = myEqualityComparer.GetHashCode(key) % bucketCount;
            Node bucket = buckets[index];
            if (bucket == null)
            {
                throw new KeyNotFoundException();
            } else
            {
                while(bucket != null)
                {
                    if (bucket.Key == key)
                    {
                        return bucket.Value;
                    } else
                    {
                        bucket = bucket.Next;
                    }
                }
            }

            throw new KeyNotFoundException();
        }

        public bool Contains(string key)
        {
            int index = myEqualityComparer.GetHashCode(key) % bucketCount;
            Node bucket = buckets[index];
            if (bucket == null)
            {
                return false;
            } else
            {
                while (bucket != null)
                {
                    if (bucket.Key == key)
                    {
                        return true;
                    }
                    else
                    {
                        bucket = bucket.Next;
                    }
                }
            }
            return false;
        }

        public static HashSet<int> TreeComparer(BinaryTree treeA, BinaryTree treeB)
        {
            HashSet<int> treeAHash = treeA.HTTraversal();

            HashSet<int> TreeBHash = treeB.HTTraversal2(treeAHash);
            return TreeBHash;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < bucketCount; i++)
            {
                while(buckets[i] != null)
                {
                    result = result + $"{buckets[i].Key} : {buckets[i].Value},";
                    buckets[i] = buckets[i].Next;

                }
            }

            return result;
        }


    }
}
