using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphInConsole.Graph;
internal class Circle : GraphBase
{
    public Circle(int radius, int interceptX = 0, int interceptY = 0) : base(interceptX,interceptY)
    {
        this.Radius = radius;
    }

    private int Radius { get; }

    public override IEnumerable<(int X, int Y)> GetPoints()
    {
        int r = this.Radius;
        int dx = this.InterceptX;
        int dy = this.InterceptY;
        for (int i = 360; i >= 0; i--)
        {
            double rad = Angle.ToRadian(i);
            int x = (int)Math.Floor(2 * r * Math.Cos(rad)) + dx;
            int y = (int)Math.Floor(r * Math.Sin(rad)) + dy;
            yield return (x, y);
        }
    }
}
