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
        public void Can_Create_Empty_Stack()
        {
            //act
            MyStack<decimal> testStack = new MyStack<decimal>();

            //Assert
            Assert.NotNull(testStack);
            Assert.Null(testStack.Top);
        }
        [Fact]
        public void Peeking_An_Empty_Stack_Throws_Exception()
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


        [Fact]
        public void Can_Push_And_Peek_Test()
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

        [Fact]

        public void Can_Push_Multiple_Test()
        {
            //arrange
            MyStack<int> testStack = new MyStack<int>();
            int expected = 3;

            //Act
            testStack.push(0);
            testStack.push(1);
            testStack.push(2);
            testStack.push(3);
            int actual = testStack.peek();

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
