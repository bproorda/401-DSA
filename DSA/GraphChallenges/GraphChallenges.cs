using DataStructures.myGraph;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.GraphChallenges
{
    public class GraphChallenges
    {
        public static TripResult PlaneTrip(myGraph<string> graph, string[] stops )
        {
            int length = stops.Length;
            var current = graph.FindVertex(stops[0]);
            int? sum = 0;



            for (int i = 1; i < length; i++)
            {

                if (current.HasNeighbor(stops[i]))
                {
                    var neighbor = current.FindEdge(stops[i]);
                    current = neighbor.Neighbor;
                    sum += neighbor.Weight;
                }
                else
                {
                    var resultFalse = new TripResult(false, null);
                    return resultFalse;
                }

            }
            var resultTrue = new TripResult(true, sum);
            return resultTrue;


        }
        
    }
    public class TripResult
    {
        public bool pathFound { get; set; }

        public int? cost { get; set; }

        public TripResult(bool pathfound, int? cost)
        {
            this.pathFound = pathfound;
            this.cost = cost;
        }
    }
}
