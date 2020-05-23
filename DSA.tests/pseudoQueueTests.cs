using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DSA.tests
{
   public class pseudoQueueTests
    {
        [Fact]

        public void Can_Create_Empty_PseudoQueue()
        {
            //act
            pseudoQueue<int> testPQ = new DSA.pseudoQueue<int>();

            //assert
            Assert.NotNull(testPQ);
        }

        [Fact]
        public void Enqueue_Works_Test()
        {
            //arrange
            pseudoQueue<int> testPQ = new DSA.pseudoQueue<int>();

            //act
            testPQ.enqueue(563);

            //Assert
            Assert.Equal(563, testPQ.peekRear());
        }


        [Fact]
        public void Multi_Enqueue_Works_Test()
        {
            //arrange
            pseudoQueue<int> testPQ = new DSA.pseudoQueue<int>();

            //act
            testPQ.enqueue(563);
            testPQ.enqueue(564);
            testPQ.enqueue(565);
            testPQ.enqueue(566);

            //Assert
            Assert.Equal(566, testPQ.peekRear());
        }

        [Fact]
        public void Dequeue_Works_Test()
        {
            //arrange
            pseudoQueue<int> testPQ = new DSA.pseudoQueue<int>();

            //act
            testPQ.enqueue(563);

            //Assert
            Assert.Equal(563, testPQ.dequeue());
        }
    }
}
