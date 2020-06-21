using DataStructures.myGraph;
using System;
using System.Collections.Generic;
using Xunit;

namespace DataStructures.Tests
{
    public class myGraphTests
    {
        [Fact]
        public void Add_Vertex_Works()
        {
            //arrange
            myGraph<string> testGraph = new myGraph<string>();
            

            //act
            var actual = testGraph.AddVertex("Bob");
            var expected = testGraph.Vertices[0];
           


            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Size_Method_Works()
        {
            //arrange
            myGraph<string> testGraph = new myGraph<string>();
            testGraph.AddVertex("Bob");

            //act
            var actual = testGraph.Size();

            //Assert
            Assert.Equal(1, actual);

        }

    }
}
