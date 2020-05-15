﻿using DataStructures;
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
            listOne.Insert(15);
            listOne.Insert(10);
            listOne.Insert(5);
            DataStructures.LinkedLists listTwo = new LinkedLists();
            listTwo.Insert(18);
            listTwo.Insert(12);
            listTwo.Insert(6);
            string expected = "{5} => {6} => {10} => {12} => {15} => {18} => NULL";

            //act
            DataStructures.LinkedLists actualList = LLchallenges.mergeLists(listOne, listTwo);
            string actual = actualList.ToString();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact(Skip = "need to written this method anyway")]
        public void Can_Merge_Lists_Of_Different_Lengths_Test()
        {
            //arrange
            DataStructures.LinkedLists listOne = new LinkedLists();
            listOne.Insert(15);
            listOne.Insert(10);
            listOne.Insert(5);
            DataStructures.LinkedLists listTwo = new LinkedLists();
            listTwo.Insert(12);
            listTwo.Insert(6);
            string expected = "{5} => {6} => {10} => {12} => {15} => NULL";

            //act
            DataStructures.LinkedLists actualList = LLchallenges.mergeLists(listOne, listTwo);
            string actual = actualList.ToString();

            //Assert
            Assert.Equal(expected, actual);

           //act
            DataStructures.LinkedLists actualList2 = LLchallenges.mergeLists(listTwo, listOne);
            string actual2 = actualList.ToString();

            //Assert
            Assert.Equal(expected, actual2);
        }
    }
}
