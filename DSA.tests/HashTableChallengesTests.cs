﻿using DataStructures.myHashTable;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DSA.tests
{
    public class HashTableChallengesTests
    {
        [Theory]
        [InlineData("One Two One", "One")]
        [InlineData("Fear is the mindkiller, Fear is the little death that brings total obliteration", "Fear")]
        [InlineData("To be or not to be, that is the Question", "to")]

        public void Find_Repeated_Word_Test(string input, string expected)
        {
            //act
            var actual = HashTableChallenges.FindRepeatedWord(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void No_Repeated_Word_Returns_Null()
        {
            //act
            var actual = HashTableChallenges.FindRepeatedWord("One Two Three");

            //Assert
            Assert.Null(actual);
        }

        [Fact]
        public void Counts_Of_Each_Word_Test()
        {
            //arrange 
            string input = "Penultimate is the penultimate word in this penultimate sentence. See?";
            string[] expected = new string[] { "in : 1", "this : 1", "the : 1", "penultimate : 3", "word : 1", "see? : 1", "sentence. : 1", "" };

            //act
            string[] actual = HashTableChallenges.CountsOfEachWord(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Left_Join_Test()
        {
            //arrange
            MyHashTable<string> leftHT = new MyHashTable<string>(1024);
            leftHT.Add("Thunderous", "Loud");
            leftHT.Add("Icy", "Cold");
            leftHT.Add("Quick", "Fast");
            MyHashTable<string> rightHT = new MyHashTable<string>(1024);
            rightHT.Add("Thunderous", "quiet");
            rightHT.Add("Icy", "warm");

            //act
            HashSet<string[]> actual = HashTableChallenges.LeftJoin(leftHT, rightHT);
            HashSet<string[]> expected = new HashSet<string[]>();
            expected.Add(new string[] {"Icy", "Cold", "warm"});
            expected.Add(new string[] {"Quick", "Fast", "NULL"});
            expected.Add(new string[] {"Thunderous", "Loud", "quiet"});

            //assert
            Assert.Equal(expected.ToString(), actual.ToString());
        }
    }
}
