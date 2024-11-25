namespace dsa.structures
{
    internal class GraphEdge
    {

        public GraphNode Start { get; set; }
        public GraphNode End { get; set; }
        public int Weight { get; set; }

        public GraphEdge(GraphNode start, GraphNode end, int weight)
        {
            Start = start;
            End = end;
            Weight = weight;
        }
    }
}
