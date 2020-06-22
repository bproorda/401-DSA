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

        //Test both adding edge and added weighted edges
        [Fact]
        public void Add_Edge_Works()
        {
            //arrange
            myGraph<string> testGraph = new myGraph<string>();
            var bob = testGraph.AddVertex("Bob");
            var carol = testGraph.AddVertex("Carol");

            //Arrange
            testGraph.AddEdge(bob, carol, 13);
            var actual = bob.Neighbors[0].Weight;

            //Assert
            Assert.Equal(13, actual);
        }

        [Fact]
        public void Get_Vertices_Test()
        {
            //arrange
            myGraph<string> testGraph = new myGraph<string>();
            var bob = testGraph.AddVertex("Bob");
            var carol = testGraph.AddVertex("Carol");

            //Arrange
            var actual = testGraph.GetVertices();

            //Assert
            Assert.Equal(bob, actual[0]);
        }

    }
}
