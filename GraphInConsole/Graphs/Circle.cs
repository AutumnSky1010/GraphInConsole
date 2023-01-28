using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphInConsole.Graphs;
internal class Circle : GraphBase
{
    public Circle(double radius, int interceptX = 0, int interceptY = 0) : base(interceptX,interceptY)
    {
        this.Radius = radius;
    }

    private double Radius { get; }

    public override IEnumerable<(int X, int Y)> GetPoints()
    {
        double r = this.Radius;
        int interceptX = this.InterceptX;
        int interceptY = this.InterceptY;
        for (int i = 360; i >= 0; i--)
        {
            double rad = Angle.ToRadian(i);
            int x = (int)Math.Floor(2 * r * Math.Cos(rad)) + interceptX;
            int y = (int)Math.Floor(r * Math.Sin(rad)) - interceptY;
            yield return (x, y);
        }
    }
}
