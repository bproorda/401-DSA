using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.myGraph
{
   public class myGraph<T>
    {

        public List<Vertex<T>> Vertices { get; set; }

        public int CountV { get; set; }

        public int CountE { get; set; }

        public Vertex<T> AddVertex(T Value)
        {
            return default;
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
