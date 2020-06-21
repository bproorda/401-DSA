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
            var inital = testGraph.Vertices;

            //act
            var actual = testGraph.AddVertex("Bob");
            var final = testGraph.Vertices;


            //Assert
            Assert.NotEqual(final, inital);
        }

    }
}
