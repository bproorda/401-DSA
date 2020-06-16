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
    }
}
