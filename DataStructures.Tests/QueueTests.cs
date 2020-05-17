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

        [Fact]
        public void Can_deQueue_Test()
        {
            //arrange
            myQueue<string> testQueue = new myQueue<string>();
            testQueue.enQueue("First");
            testQueue.enQueue("Second");
            testQueue.enQueue("Third");

            //act
            string actual = testQueue.deQueue();

            //Assert
            Assert.Equal("First", actual);
            Assert.Equal("Second", testQueue.Front.Value);
        }

        [Fact]
        public void Can_deQueue_Queue_To_Empty()
        {
            //arrange
            myQueue<int> testQueue = new myQueue<int>();
            testQueue.enQueue(10);
            testQueue.enQueue(11);
            testQueue.enQueue(12);
            testQueue.enQueue(13);
            testQueue.enQueue(14);

            //act
            testQueue.deQueue();
            testQueue.deQueue();
            testQueue.deQueue();
            testQueue.deQueue();
            testQueue.deQueue();
            bool result = testQueue.isEmpty();

            //Assert
            Assert.True(result);
        }
    }
}
