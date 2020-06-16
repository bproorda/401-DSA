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
    }
}
