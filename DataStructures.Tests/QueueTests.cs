using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.Tests
{
    public class QueueTests
    {
        [Fact]
        public void Can_Create_Empty_Queue_Test()
        {
            //act
            myQueue<int> testQueue = new myQueue<int>();

            //Assert
            Assert.NotNull(testQueue);
            Assert.Null(testQueue.Front);
            Assert.Null(testQueue.Rear);
        }

        [Fact]
        public void Can_enQueue_Test()
        {
            //arrange
            myQueue<string> testQueue = new myQueue<string>();

            //act
            testQueue.enQueue("It worked!");

            //Assert
            Assert.Equal("It worked!", testQueue.Front.Value);
        }
    }
}
