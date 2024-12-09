namespace dsa.structures.graph
{
    internal class UndirectedEdge
    {

        public Vertex One { get; }
        public Vertex Other { get; }
        public int Weight { get; set; }

        public UndirectedEdge(Vertex one, Vertex other, int weight)
        {
            One = one;
            Other = other;
            Weight = weight;
        }
    }
}
