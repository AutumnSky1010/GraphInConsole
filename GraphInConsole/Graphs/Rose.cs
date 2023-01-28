using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphInConsole.Graphs;
internal class Rose : GraphBase
{
    public Rose(int width, int a, int interceptX = 0, int interceptY = 0) : base(interceptX, interceptY)
    {
        this.A = a;
        this.Width = width;
    }

    private int A { get; }

    private int Width { get; }

    public override IEnumerable<(int X, int Y)> GetPoints()
    {
        var a = this.A;
        int interceptX = this.InterceptX;
        int interceptY = this.InterceptY;
        for (int i = 360; i >= 0; i--)
        {
            double rad = Angle.ToRadian(i);
            int x = (int)Math.Floor(2 * this.Width * Math.Sin(a * rad) * Math.Cos(rad)) + interceptX;
            int y = (int)Math.Floor(this.Width * Math.Sin(a * rad)* Math.Sin(rad)) - interceptY;
            yield return (x, y);
        }
    }
}
