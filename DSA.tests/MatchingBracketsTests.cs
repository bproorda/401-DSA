using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DSA.tests
{
    public class MatchingBracketsTests
    {
        [Fact]

        public void Matching_Returns_True()
        {
            //arrange
            string testString = "({[]})";

            //act
            bool actual = MatchingBrackets.MultiBracketValidation(testString);

            //Assert
            Assert.True(actual);
        }

        [Fact(Skip = "method needs to be refactored")]

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
