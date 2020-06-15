﻿using System;
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



        public void Add(string key, T value)
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

        public string FindRepeatedWord(string input)
        {
            MyHashTable<string> wordSearch = new MyHashTable<string>(1024);
            var words = input.Split(' ');
            foreach (var word in words)
            {
                bool toggle = wordSearch.Contains(word);
                if (toggle)
                {
                    return word;
                }
                else
                {
                    wordSearch.Add(word, word);
                }
            }
            return null;
        }
    }
}
