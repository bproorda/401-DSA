using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DSA.tests
{
    public class MatchingBracketsTests
    {
        [Theory]
        [InlineData( "({[]})") ]
        [InlineData("(){}[]")]
        [InlineData("[(hello){world}]")]
        [InlineData("[(){{}}]")]
        public void Matching_Returns_True(string input)
        {
            //arrange
            //string testString = "({[]})";

            //act
            bool actual = MatchingBrackets.MultiBracketValidation(input);

            //Assert
            Assert.True(actual);
        }

        [Fact]

        public void Matching_Returns_False()
        {
            //arrange
            string testString = "({[})";

            //act
            bool actual = MatchingBrackets.MultiBracketValidation(testString);

            //Assert
            Assert.False(actual);
        }
    }
}
