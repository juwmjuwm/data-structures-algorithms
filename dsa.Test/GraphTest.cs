using dsa.structures.graph;

namespace dsa.Test
{
    public class GraphTest
    {
        [Fact]
        public void ShouldAddEdges()
        {
            // when
            Graph g = new Graph(5);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(0, 3);
            g.AddEdge(2, 4);
            g.AddEdge(4, 3);
            g.AddEdge(2, 3);

            // then
            Assert.Equal(6, g.E());
            Assert.Equal(5, g.V());
            Assert.Equal(3, g.Degree(0));
            Assert.Equal(3, g.Degree(2));
            Assert.Contains(0, g.Adj(2));
            Assert.Contains(4, g.Adj(2));
            Assert.Contains(3, g.Adj(2));
        }
    }
}