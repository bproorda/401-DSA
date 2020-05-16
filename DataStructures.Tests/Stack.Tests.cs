using DataStructures.StackAndQueue;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.Tests
{
    public class StackTests
    {

        [Fact]
        public void Empty_Stack_Throws_Exception()
        {
            //Arrange
            MyStack<int[]> testStack = new MyStack<int[]>();

            //Assert
            Assert.Throws<StackEmptyException>(() =>
            {
                //Act
                testStack.peek();
            });
        }


        [Fact(Skip ="Not ready yet")]
        public void Can_Add_And_Peek_Test()
        {
            //arrange
            MyStack<string> testStack = new MyStack<string>();
            string expected = "Hello";

            //Act
            testStack.push("Hello");
            string actual = testStack.peek();

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
