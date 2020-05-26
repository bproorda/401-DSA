using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.Tests
{
    public class BinaryTreeTests
    {
        [Fact]

        public void Can_Create_Empty_Tree()
        {
            //act
            BinarySearchTree myTree = new BinarySearchTree();

            //assert
            Assert.NotNull(myTree);
        }


        [Fact]

        public void Can_Add_To_BST_Test()
        {
            //arrange
            BinarySearchTree myTree = new BinarySearchTree();

            //act
            myTree.add(4);

            //Assert
            Assert.Equal(4, myTree.Root.Value);
        }
    }
}
