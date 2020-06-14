using DataStructures.myHashTable;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.Tests
{
    public class MyHashTableTests
    {
        [Fact]
        public void Get_Hash_Code_Works()
        {
            //arrange
            MyHashTable<int> testHT = new MyHashTable<int>(1024);
            //act
            int testHash = MyHashTable<int>.GetHashCode("Brennan");

            //assert
            Assert.Equal(1770728717, testHash);
        }
    }
}
