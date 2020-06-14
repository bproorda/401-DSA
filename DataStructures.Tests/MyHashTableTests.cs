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
            int testHash = testHT.myEqualityComparer.GetHashCode("Brennan", testHT.bucketCount);

            //assert
            Assert.Equal(992, testHash);
        }

        [Fact]
        public void Equal_Key_Equal_Hash_Code_Test()
        {
            //arrange
            MyHashTable<int> testHT = new MyHashTable<int>(1024);

            //act
            int A = testHT.myEqualityComparer.GetHashCode("Brennan", testHT.bucketCount);
            int B = testHT.myEqualityComparer.GetHashCode("Brennan", testHT.bucketCount);

            //assert
            Assert.Equal(A, B);

        }

        [Fact]
        public void Add_Works_Test()
        {
            //arrange
            MyHashTable<int> testHT = new MyHashTable<int>(1024);
            int thisIndex = testHT.myEqualityComparer.GetHashCode("Diana", testHT.bucketCount);

            //act
            testHT.Add("Diana", 678);

            //assert
            Assert.NotNull(testHT.buckets[thisIndex]);
        }

        [Fact]
        public void No_Collision_Test()
        {
            //arrange
            MyHashTable<int> testHT = new MyHashTable<int>(1024);
            int thisIndex = testHT.myEqualityComparer.GetHashCode("Diana", testHT.bucketCount);

            //act
            testHT.Add("Diana", 678);
            testHT.Add("Diana", 978);

            //assert
            Assert.NotNull(testHT.buckets[thisIndex].Next);
            //Assert.Equal(978, testHT.buckets[thisIndex].Next.Value);

        }
        [Fact]
        public void Get_Works_Test()
        {
            //arrange
            MyHashTable<int> testHT = new MyHashTable<int>(1024);
            testHT.Add("Diana", 678);

            //act
            int actual = testHT.Get("Diana");

            //assert
            Assert.Equal(678, actual);
        }
        [Fact]
        public void Contains_Returns_True_Test()
        {
            //arrange
            MyHashTable<int> testHT = new MyHashTable<int>(1024);
            testHT.Add("Diana", 678);

            //act
            bool actual = testHT.Contains("Diana");

            //assert
            Assert.True(actual);
        }
        [Fact]
        public void Contains_Returns_False_Test()
        {
            //arrange
            MyHashTable<int> testHT = new MyHashTable<int>(1024);
            testHT.Add("Diana", 678);

            //act
            bool actual = testHT.Contains("Skip");

            //assert
            Assert.False(actual);
        }
    }
}
