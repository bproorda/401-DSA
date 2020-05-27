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

        [Fact]

        public void Can_Add_Multiple_To_BST_Test()
        {
            //arrange
            BinarySearchTree myTree = new BinarySearchTree();

            //act
            myTree.add(10);
            myTree.add(5);

            //Assert
            Assert.Equal(5, myTree.Root.Left.Value);
        }

        [Fact]

        public void PreOrder_Test()
        {
            //arrange
            BinarySearchTree myTree = new BinarySearchTree();
            myTree.add(10);
            myTree.add(5);
            myTree.add(4);
            myTree.add(13);
            int[] expected = new int[] { 10, 5, 4, 13 };

            //act
            int[] actual = myTree.DepthHandler("preorder");

            //Assert
            Assert.Equal(expected, actual);

        }
        [Fact]

        public void InOrder_Test()
        {
            //arrange
            BinarySearchTree myTree = new BinarySearchTree();
            myTree.add(10);
            myTree.add(5);
            myTree.add(4);
            myTree.add(13);
            int[] expected = new int[] { 4, 5, 13, 10  };

            //act
            int[] actual = myTree.DepthHandler("postorder");

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]

        public void PostOrder_Test()
        {
            //arrange
            BinarySearchTree myTree = new BinarySearchTree();
            myTree.add(10);
            myTree.add(5);
            myTree.add(4);
            myTree.add(13);
            int[] expected = new int[] { 4, 5, 13, 10 };

            //act
            int[] actual = myTree.DepthHandler("postorder");

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]

        public void Breadth_Travesal_Test()
        {
            //arrange
            BinarySearchTree myTree = new BinarySearchTree();
            myTree.add(10);
            myTree.add(5);
            myTree.add(4);
            myTree.add(13);
            int[] expected = new int[] { 10, 5, 13, 4 };

            //act
            List<int> actual = myTree.Breadth();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Contains_Test()
        {
            //arrange
            BinarySearchTree myTree = new BinarySearchTree();
            myTree.add(10);
            myTree.add(5);
            myTree.add(4);
            myTree.add(13);

            //act
            bool actual = myTree.Contains(13);

            //Assert
            Assert.True(actual);

        }
    }
}
