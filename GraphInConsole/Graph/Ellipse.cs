using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphInConsole.Graphs;
internal class Ellipse : GraphBase
{
    public Ellipse(int a, int b, int interceptX = 0, int interceptY = 0) : base(interceptX, interceptY)
    {
        this.A = a;
        this.B = b;
    }

    private int A;

    private int B;

    public override IEnumerable<(int X, int Y)> GetPoints()
    {
        int a = this.A;
        int b = this.B;
        int interceptX = this.InterceptX;
        int interceptY = this.InterceptY;
        for (int i = 360; i >= 0; i--)
        {
            double rad = Angle.ToRadian(i);
            int x = (int)Math.Floor(2 * a * Math.Cos(rad)) + interceptX;
            int y = (int)Math.Floor(b * Math.Sin(rad)) - interceptY;
            yield return (x, y);
        }
    }
}
