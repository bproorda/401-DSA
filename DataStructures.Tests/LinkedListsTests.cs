using System;
using Xunit;

namespace DataStructures.Tests
{
    /*
    1. Can successfully instantiate an empty linked list DONE
    2. Can properly insert into the linked list
    3. The head property will properly point to the first node in the linked list
    4. Can properly insert multiple nodes into the linked list
    5. Will return true when finding a value within the linked list that exists
    6. Will return false when searching for a value in the linked list that does not exist
    7. Can properly return a collection of all the values that exist in the linked list
     */
    public class LinkedListsTests
    {
        [Fact]
        public void Can_Create_Empty_List()
        {   //Arrange, Act
            DataStructures.LinkedLists testList = new LinkedLists();

            //Assert
            Assert.NotNull(testList);
        }
    }
}
