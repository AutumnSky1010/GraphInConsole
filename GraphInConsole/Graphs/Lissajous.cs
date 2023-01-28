using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphInConsole.Graphs;
internal class Lissajous : GraphBase
{
    public Lissajous(int width, int a, int b, int interceptX = 0, int interceptY = 0) : base(interceptX, interceptY)
    {
        this.Width= width;
        this.A = a;
        this.B = b;
    }

    private int A { get; }

    private int B { get; }

    private int Width { get; }

    public override IEnumerable<(int X, int Y)> GetPoints()
    {
        int a = this.A, b = this.B;
        for (int i = 360; i >= 0; i--)
        {
            double rad = Angle.ToRadian(i);
            int x = (int)Math.Floor(this.Width * 2 * Math.Sin(a * rad)) + this.InterceptX;
            int y = (int)Math.Floor(this.Width * Math.Sin(b * rad)) - this.InterceptY;
            yield return (x, y);
        }
    }
}
