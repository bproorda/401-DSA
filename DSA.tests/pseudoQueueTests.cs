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

    }
}
