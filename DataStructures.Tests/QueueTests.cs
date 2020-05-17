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

        [Fact]
        public void Can_enQueue_Multiple_Test()
        {
            //arrange
            myQueue<string> testQueue = new myQueue<string>();

            //act
            testQueue.enQueue("Front");
            testQueue.enQueue("Middle");
            testQueue.enQueue("Rear");

            //Assert
            Assert.Equal("Front", testQueue.Front.Value);
            Assert.Equal("Rear", testQueue.Rear.Value);

        }

        [Fact]
        public void Peek_Empty_Queue_Throws_Exception_Test()
        {
            //arrange
            myQueue<int> testQueue = new myQueue<int>();

            //Assert
            Assert.Throws<QueueEmptyException>(() =>
            {
                //act
                testQueue.peek();
            });
        }

        [Fact]
        public void Does_Peek_Work_Test()
        {
            //arrange
            myQueue<int> testQueue = new myQueue<int>();
            testQueue.enQueue(13);

            //act
            int actual = testQueue.peek();

            //Assert
            Assert.Equal(13, actual);

        }
    }
}
