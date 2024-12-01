namespace dsa.structures
{
    internal class Graph
    {

        private List<GraphNode> _nodes;
        private List<GraphEdge> _edges;

        public Graph()
        {
            _nodes = new List<GraphNode>();
            _edges = new List<GraphEdge>();
        }

        public Graph(GraphEdge edge) : this()
        {
            Add(edge);
        }

        public void Add(GraphEdge edge)
        {
            if (!_edges.Contains(edge))
            {
                _edges.Add(edge);
            }
            if (!_nodes.Contains(edge.Start))
            {
                _nodes.Add(edge.Start);
            }
            if (!_nodes.Contains(edge.End))
            {
                _nodes.Add(edge.End);
            }
        }

        public int countNewNodes(GraphEdge edge)
        {
            int counter = 0;
            if (!_nodes.Contains(edge.Start))
            {
                counter++;
            }
            if (!_nodes.Contains(edge.End))
            {
                counter++;
            }
            return counter;
        }

        public void Join(Graph graph)
        {

        }
    }
}
