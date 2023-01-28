using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphInConsole.Graphs;
internal abstract class GraphBase : IGraph
{
    public GraphBase(int interceptX = 0, int interceptY = 0)
    {
        this.InterceptX = interceptX;
        this.InterceptY= interceptY;
    }

    protected int InterceptX { get; }

    protected int InterceptY { get; }

    public abstract IEnumerable<(int X, int Y)> GetPoints();
}
