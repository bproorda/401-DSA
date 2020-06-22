using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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

        private int CountV { get; set; }

        private int CountE { get; set; }

        public Vertex<T> AddVertex(T Value)
        {
            Vertex<T> newVertex = new Vertex<T>(Value);
            Vertices.Add(newVertex);
            CountV++;
            return newVertex;
        }

        public void AddEdge(Vertex<T> v1, Vertex<T> v2, int? weight= null)
        {

            if (weight == null)
            {
                var edge2 = new Edge<T>(v1);
                var edge1 = new Edge<T>(v2);
                v1.Neighbors.Add(edge1);
                v2.Neighbors.Add(edge2);
            } else
            {
                var edge2 = new Edge<T>(v1, weight);
                var edge1 = new Edge<T>(v2, weight);
                v1.Neighbors.Add(edge1);
                v2.Neighbors.Add(edge2);
            }

            

        }

        public List<Vertex<T>> GetVertices()
        {
            return Vertices;
        }

        public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
        {
            return vertex.Neighbors;
        }


        public int Size()
        {
            return CountV;
        }

    }
    public class Vertex<T>
    {
        public T Value { get; set; }

        public List<Edge<T>> Neighbors { get; set; }

        public Vertex(T value)
        {
            this.Value = value;
            this.Neighbors = new List<Edge<T>>();
        }

    }

    public class Edge<T>
    {
        public Vertex<T> Neighbor { get; set; }

        public int? Weight { get; set; }

        public Edge(Vertex<T> neighbor)
        {
            this.Neighbor = neighbor;
            this.Weight = 0;
        }

        public Edge(Vertex<T> neighbor,int? weight)
        {
            this.Neighbor = neighbor;
            this.Weight = weight;
        }
    }
}
