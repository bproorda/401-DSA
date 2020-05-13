using DataStructures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DSA.tests
{
    
    public class LLmergeTests
    {

        [Fact]
        public void Can_Merge_Test()
        {   
            //arrange
            DataStructures.LinkedLists listOne = new LinkedLists();
            listOne.Insert(5);
            listOne.Insert(10);
            listOne.Insert(15);
            DataStructures.LinkedLists listTwo = new LinkedLists();
            listOne.Insert(6);
            listOne.Insert(12);
            listOne.Insert(18);
            string expected = "{5} => {6} => {10} => {12} => {15} => {18} => NULL";

            //act
            DataStructures.LinkedLists actualList = LLchallenges.mergeLists(listOne, listTwo);
            string actual = actualList.ToString();

            //Assert
            Assert(expected, actual);
        }
    }
}
