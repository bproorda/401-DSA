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
    }
}
