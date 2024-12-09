namespace dsa.structures.graph
{
    internal class UndirectedGraph
    {

        private readonly List<Vertex> _vertices;
        private readonly List<UndirectedEdge> _edges;

        public List<Vertex> Vertices
        {
            get { return _vertices; }
        }

        public List<UndirectedEdge> Edges
        {
            get { return _edges; }
        }

        public UndirectedGraph()
        {
            _vertices = new List<Vertex>();
            _edges = new List<UndirectedEdge>();
        }

        public UndirectedGraph(UndirectedEdge edge) : this()
        {
            AddEdge(edge);
        }

        public void AddVertex(Vertex vertex)
        {
            if (!Vertices.Contains(vertex))
            {
                Vertices.Add(vertex);
            }
        }

        public void AddEdge(UndirectedEdge edge)
        {
            AddVertex(edge.One);
            AddVertex(edge.Other);
            Edges.Add(edge);
        }
    }
}
