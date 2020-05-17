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
    }
}
