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
            Assert.Equal(33760, testHash);
        }

        [Fact]
        public void Equal_Key_Equal_Hash_Code_Test()
        {
            //act
            int A = MyHashTable<int>.GetHashCode("Brennan");
            int B = MyHashTable<int>.GetHashCode("Brennan");

            //assert
            Assert.Equal(A, B);

        }

        [Fact]
        public void Add_Works_Test()
        {
            //arrange
            MyHashTable<int> testHT = new MyHashTable<int>(1024);
            int thisIndex = MyHashTable<int>.GetHashCode("Diana") % 1024;

            //act
            testHT.Add("Diana", 678);

            //assert
            Assert.NotNull(testHT.buckets[thisIndex]);

        }
    }
}
