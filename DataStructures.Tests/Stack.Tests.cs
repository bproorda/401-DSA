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
