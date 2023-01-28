using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphInConsole.Graphs;
internal interface IGraph
{
    IEnumerable<(int X, int Y)> GetPoints();
}
