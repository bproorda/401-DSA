using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.myGraph
{
   public class myGraph<T>
    {
        public myGraph()
        {
            this.Vertices = new List<Vertex<T>>();
        }
        public List<Vertex<T>> Vertices { get; set; }

        public int CountV { get; set; }

        public int CountE { get; set; }

        public Vertex<T> AddVertex(T Value)
        {
            Vertex<T> newVertex = new Vertex<T>(Value);
            Vertices.Add(newVertex);

            return newVertex;
        }

    }
    public class Vertex<T>
    {
        public T Value { get; set; }

        public List<Vertex<T>> Neighbors { get; set; }

        public Vertex(T value)
        {
            this.Value = value;
            this.Neighbors = new List<Vertex<T>>();
        }

    }
}
