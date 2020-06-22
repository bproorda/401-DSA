# Graph Data Structures

## Summary: A data structure that is used for a wide number of problems is the Graph. There is a entire field of 
mathematics devoted to dealing with graphs. In computer science, a graph is collection of Vertices or Nodes with 
a number of edges or connections between them. Each vertex contains a list of its neighbors The edges may have a value attached to them called weight. The current 
version in the project is an undirected graph, being that each edge works in both directions

## Methods
- AddVertex(value): creates and returns a vertex with the given value;
- AddEdge(vertex1, vertex2, ?weight): Creates an edge between the two given vertices. This method has an optional 
parameter for weight.
- Size(): returns the number of vertices in the graph
- GetVertices(): returns a list containing all of the vertices associated with that graph.
- GetNeighbors(vertex): returns a list of neighbors of a given vertex.
