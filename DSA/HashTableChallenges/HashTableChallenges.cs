using DataStructures.myHashTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class HashTableChallenges
    {
        public static string FindRepeatedWord(string input)
        {
            MyHashTable<string> wordSearch = new MyHashTable<string>(1024);
            var words = input.Split(' ');
            foreach (var word in words)
            {
                bool toggle = wordSearch.Contains(word.ToLower());
                if (toggle)
                {
                    return word;
                }
                else
                {
                    wordSearch.Add(word.ToLower(), word);
                }
            }
            return null;
        }

        public static string[] CountsOfEachWord(string input)
        {
            MyCountingHashTable wordCounts = new MyCountingHashTable(1024);
            var words = input.Split(' ');
            foreach (var word in words)
            {
              wordCounts.Add(word.ToLower(), 1);
            }
            string wordCountsString = wordCounts.ToString();
            string[] result = wordCountsString.Split(",");

            return result;
        } 
        
        public static HashSet<string[]> LeftJoin(MyHashTable<string> left, MyHashTable<string> right)
        {
            HashSet<string[]> leftHash = new HashSet<string[]>();
            HashSet<string[]> result = new HashSet<string[]>();
            foreach (var word in left)
            {
                leftHash.Add(word.Split(','));
            }
            foreach (var entry in leftHash)
            {
                if (right.Contains(entry[0]))
                {
                    result.Add(new string[] { entry[0], entry[1], right.Get(entry[0]) });
                }
                else
                {
                    result.Add(new string[] { entry[0], entry[1], "NULL" });
                }
            }
            return result;
        }
    }
}
