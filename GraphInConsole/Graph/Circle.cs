using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphInConsole.Graph;
internal class Circle : IGraph
{
    public Circle(int radius, int dx = 0, int dy = 0)
    {
        this.Radius = radius;
        this.DX = dx;
        this.DY = dy;
    }

    private int DX { get; }

    private int DY { get; }

    private int Radius { get; }

    public IEnumerable<(int X, int Y)> GetPoints()
    {
        int r = this.Radius;
        int dx = this.DX;
        int dy = this.DY;
        for (int i = 360; i >= 0; i--)
        {
            double rad = Angle.ToRadian(i);
            int x = (int)Math.Floor(2 * r * Math.Cos(rad)) + dx;
            int y = (int)Math.Floor(r * Math.Sin(rad)) + dy;
            yield return (x, y);
        }
    }
}
