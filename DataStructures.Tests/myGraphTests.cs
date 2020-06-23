using DataStructures.myGraph;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [Fact]
        public void Get_Neighbors_Test()
        {
            //arrange
            myGraph<string> testGraph = new myGraph<string>();
            var bob = testGraph.AddVertex("Bob");
            var carol = testGraph.AddVertex("Carol");
            var diana = testGraph.AddVertex("Diana");
            testGraph.AddEdge(bob, carol, 13);
            testGraph.AddEdge(bob, diana, 9);

            //act
            var actual = testGraph.GetNeighbors(bob);

            //Assert
            Assert.Equal(diana, actual[1]);
        }

        [Fact]
        public void Breadth_First_Test_A()
        {
            //arrange
            myGraph<string> testGraph = new myGraph<string>();
            var bob = testGraph.AddVertex("Bob");
            var carol = testGraph.AddVertex("Carol");
            var diana = testGraph.AddVertex("Diana");
            testGraph.AddEdge(bob, carol, 13);
            testGraph.AddEdge(bob, diana, 9);

            //act
            var actual = testGraph.BreadthFirst(bob);

            //Assert
            Assert.Equal(testGraph.Size(), actual.Count());
        }

        [Fact]
        public void Breadth_First_Test_B()
        {
            //arrange
            myGraph<string> testGraph = new myGraph<string>();
            var bob = testGraph.AddVertex("Bob");
            var carol = testGraph.AddVertex("Carol");
            var diana = testGraph.AddVertex("Diana");
            var bill = testGraph.AddVertex("Bill");
            testGraph.AddEdge(bob, carol, 13);
            testGraph.AddEdge(bob, diana, 9);
            testGraph.AddEdge(diana, bill, 23);
            string expected = "Bob, Carol, Diana, Bill";


            //act
            var IE = testGraph.BreadthFirst(bob);
            var actual = testGraph.IEtoString(IE);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
