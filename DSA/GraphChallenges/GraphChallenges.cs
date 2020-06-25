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


            while (current != null)
            {
                int i = 1;
                for (int j = 0; j < current.Neighbors.Count; j++)
                {
                    //if (current.Neighbors[j].Neighbor.Value == stops[i])
                    //{
                    //sum += current.Neighbors[j].Weight;
                    //current = current.Neighbors[j].Neighbor;
                    //  break;
                    //}
                    if (current.HasNeighbor(stops[i])){
                        var neighbor = current.FindEdge(stops[i]);
                        sum += neighbor.Weight;
                    }
                    else
                    {
                        var resultFalse = new TripResult(false, null);
                        return resultFalse;
                    }
                }

                if (current.Value == stops[length-1])
                {
                    var resultTrue = new TripResult(true, sum);
                    return resultTrue;
                }
                i++;
            }

            var result = new TripResult(false, null);
            return result;
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
