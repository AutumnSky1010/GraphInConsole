namespace GraphInConsole.Graphs;
internal class Asteroid : GraphBase
{
    public Asteroid(int a, int interceptX = 0, int interceptY = 0) : base(interceptX, interceptY)
    {
        this.A = a;
    }

    private int A { get; }

    public override IEnumerable<(int X, int Y)> GetPoints()
    {
        int width = this.A;
        for (int i = 360; i >= 0; i--)
        {
            double rad = Angle.ToRadian(i);
            int x = (int)Math.Floor(2 * width * Math.Pow(Math.Cos(rad), 3)) + this.InterceptX;
            int y = (int)Math.Floor(width * Math.Pow(Math.Sin(rad), 3)) - this.InterceptY;
            yield return (x, y);
        }
    }
}
