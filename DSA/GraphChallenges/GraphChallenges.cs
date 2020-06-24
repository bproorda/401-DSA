using DataStructures.myGraph;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.GraphChallenges
{
    public class GraphChallenges
    {
        public TripResult PlaneTrip(myGraph<string> graph, string[] stops )
        {
            int length = stops.Length;
            var current = graph.FindVertex(stops[0]);
            int? sum = 0;


            while (current != null)
            {
                int i = 1;
                for (int j = 0; j < current.Neighbors.Count; j++)
                {
                    if (current.Neighbors[j].Neighbor.Value == stops[i])
                    {
                        sum += current.Neighbors[j].Weight;
                        current = current.Neighbors[j].Neighbor;
                        break;
                    }
                }

                if (current.Value == stops[length-1])
                {
                    var result = new TripResult(true, sum);
                    return result;
                }
                i++;
            }

            var result = new TripResult(true, sum);
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
