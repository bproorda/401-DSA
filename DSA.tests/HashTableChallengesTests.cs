using DataStructures;
using DataStructures.myHashTable;
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
        public void Tree_Comparer_Test()
        {
            //arrange
            BinaryTree mytreeA = new BinaryTree();
            BinaryTree mytreeB = new BinaryTree();
            BinaryTree.Node firstANode = new BinaryTree.Node();
            BinaryTree.Node firstBNode = new BinaryTree.Node();
            BinaryTree.Node secondBNode = new BinaryTree.Node();
            firstANode.Value = 13;
            firstBNode.Value = 13;
            secondBNode.Value = 11;

            mytreeA.Root = firstANode;
            mytreeB.Root = firstBNode;
            mytreeB.Root.Left = secondBNode;

            //act
            var actual = MyHashTable<int>.TreeComparer(mytreeA, mytreeB);

            HashSet<int> expected = new HashSet<int>();
            expected.Add(13);

            //assert
            Assert.Equal(expected, actual);


        }
    }
}
