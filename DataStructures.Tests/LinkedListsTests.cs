using System;
using Xunit;

namespace DataStructures.Tests
{
    /*
    1. Can successfully instantiate an empty linked list DONE
    2. Can properly insert into the linked list DONE
    3. The head property will properly point to the first node in the linked list DONE
    4. Can properly insert multiple nodes into the linked list
    5. Will return true when finding a value within the linked list that exists
    6. Will return false when searching for a value in the linked list that does not exist
    7. Can properly return a collection of all the values that exist in the linked list
     */
    public class LinkedListsTests
    {
        [Fact]
        public void Can_Create_Empty_List()
        {   //Act
            DataStructures.LinkedLists testList = new LinkedLists();

            //Assert
            Assert.Equal("", testList.ToString());
        }

        [Fact]
        public void Can_Insert_Node()
        {
            //Arrange
            DataStructures.LinkedLists testList = new LinkedLists();

            //Act
            testList.Insert(13);

            //Assert
            Assert.Equal("13", testList.ToString());
        }

        [Fact]
        public void Head_Points_To_Next()
        {
            //Arrange
            DataStructures.LinkedLists testList = new LinkedLists();
            int expected = 13;
            testList.Insert(expected);

            //Act
            testList.Insert(12);
            int result = testList.Head.Next.Value;

            //Assert
            Assert.Equal(expected, result);
        }

    }
}
