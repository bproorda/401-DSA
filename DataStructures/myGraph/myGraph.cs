using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.myGraph
{
   public class myGraph<T>
    {


        public List<Vertex<T>> Vertices { get; set; }
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
