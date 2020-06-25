using DataStructures.myHashTable;
using DataStructures.StackAndQueue;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;


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

  

        public Vertex<T> FindVertex(string value)
        {
            foreach (var vertex in Vertices)
            {
                if (vertex.Value.ToString() == value)
                {
                    return vertex;
                }
            }
            throw new VertexNotFoundException();
        }

        public List<Vertex<T>> GetVertices()
        {
            return Vertices;
        }

        public List<Vertex<T>> GetNeighbors(Vertex<T> vertex)
        {
            var result = new List<Vertex<T>>();
            var neighborEdges = vertex.Neighbors;

            foreach (var neighbor in neighborEdges)
            {
                result.Add(neighbor.Neighbor);
            }

            return result;
        }


        public int Size()
        {
            return CountV;
        }

        public IEnumerable<Vertex<T>> BreadthFirst(Vertex<T> start)
        {
            foreach (var vertex in Vertices)
            {
                vertex.Visited = false;
            }

            myQueue<Vertex<T>> graphQ = new myQueue<Vertex<T>>();
            graphQ.enQueue(start);

            while (graphQ.Front != null)
            {
                var current = graphQ.deQueue();
                current.Visited = true;
                foreach (var neighbor in current.Neighbors)
                {
                    if (!neighbor.Neighbor.Visited)
                    {
                        graphQ.enQueue(neighbor.Neighbor); 
                    }
                }
                yield return current;
            }
            
        }

        public IEnumerable<Vertex<T>> DepthFirst()
        {
            MyStack<Vertex<T>> graphStack = new MyStack<Vertex<T>>();
            MyHashTable<string> visited = new MyHashTable<string>(1024);
            List<Vertex<T>> results = new List<Vertex<T>>();
            graphStack.push(Vertices[0]);
            while (!graphStack.isEmpty())
            {
                var current = graphStack.pop();
                visited.Add(current.Value.ToString(), "visited");
                foreach (var edge in current.Neighbors)
                {

                    if (!visited.Contains(edge.Neighbor.Value.ToString()))
                    {
                        graphStack.push(edge.Neighbor);
                  
                    }
                   
                    //results.Add(current);
                }
                yield return current;
            }
            //return results;
        }

        public string BreadthFirstHandler(Vertex<T> start)
        {
            var collection = BreadthFirst(start);
            string result = IEtoString(collection);

            return result;
        }

        public string IEtoString(IEnumerable<Vertex<T>> vertices)
        {
            string result = "";
            foreach (var vertex in vertices)
            {
                result = result + $"{vertex.Value}, ";
            }
            Regex rgx = new Regex(",\\s$");

            result = rgx.Replace(result, "");
            return result;
        }

    }
    public class Vertex<T>
    {
        public T Value { get; set; }

        public List<Edge<T>> Neighbors { get; set; }
        public bool Visited { get; set; }

        public Vertex(T value)
        {
            this.Value = value;
            this.Neighbors = new List<Edge<T>>();
            this.Visited = false;
        }

        public bool HasNeighbor(string value)
        {
            for (int i = 0; i < Neighbors.Count; i++)
            {
                if (Neighbors[i].Neighbor.Value.ToString() == value)
                {
                    return true;
                }
            }
            return false;
        }

        public Edge<T> FindEdge(string value)
        {
            for (int i = 0; i < Neighbors.Count; i++)
            {
                if (Neighbors[i].Neighbor.Value.ToString() == value)
                {
                    return Neighbors[i];
                }
            }
            return null;
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

    public class VertexNotFoundException : Exception
    {

    }
}
