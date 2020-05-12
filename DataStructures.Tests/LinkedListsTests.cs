using System;
using Xunit;

namespace DataStructures.Tests
{
    /*
    1. Can successfully instantiate an empty linked list DONE
    2. Can properly insert into the linked list DONE
    3. The head property will properly point to the first node in the linked list DONE
    4. Can properly insert multiple nodes into the linked list DONE
    5. Will return true when finding a value within the linked list that exists DONE
    6. Will return false when searching for a value in the linked list that does not exist DONE
    7. Can properly return a collection of all the values that exist in the linked list DONE
     */
    public class LinkedListsTests
    {
        [Fact]
        public void Can_Create_Empty_List()
        {   //Act
            DataStructures.LinkedLists testList = new LinkedLists();

            //Assert
            Assert.Equal("NULL", testList.ToString());
        }

        [Fact]
        public void Can_Insert_Node()
        {
            //Arrange
            DataStructures.LinkedLists testList = new LinkedLists();

            //Act
            testList.Insert(13);

            //Assert
            Assert.Equal("{13} => NULL", testList.ToString());
        }

        [Fact]
        public void Head_Points_To_Next()
        {
            //Arrange
            DataStructures.LinkedLists testList = new LinkedLists();
            testList.Insert(13);
            string expected = "{12} => {13} => NULL";

            //Act
            testList.Insert(12);
            string result = testList.ToString();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Includes_Returns_True()
        {
            //Arrange
            DataStructures.LinkedLists testList = new LinkedLists();
            testList.Insert(13);
            testList.Insert(12);

            //Act
            bool result = testList.Includes(13);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Includes_Returns_False()
        {
            //Arrange
            DataStructures.LinkedLists testList = new LinkedLists();
            testList.Insert(13);
            testList.Insert(12);

            //Act
            bool result = testList.Includes(11);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Append_To_End_Test()
        {
            //Arrange
            DataStructures.LinkedLists testList = new LinkedLists();
            testList.Insert(3);
            testList.Insert(1);
            string expected = "{1} => {3} => {13} => NULL";

            //Act
            testList.AppendToEnd(13);
            string actual = testList.ToString();

            //Assert
            Assert.Equal(expected, actual);
            

        }

        [Fact]
        public void Insert_Before_Given_Value_Test()
        {
            //Arrange
            DataStructures.LinkedLists testList = new LinkedLists();
            testList.Insert(24);
            testList.Insert(13);
            testList.Insert(86);
            string expected = "{86} => {5} => {13} => {24} => NULL";

            //Act
            testList.InsertBefore(13, 5);
            string actual = testList.ToString();

            //Assert
            Assert.Equal(expected, actual);

        }


    }
}