using GraphInConsole.Graphs;

namespace GraphInConsole;
public class Program
{
    private static void Main()
    {
        var graphDrawer = new GraphDrawer();
        graphDrawer.DrawCoordinateAxis();
        graphDrawer.Draw(new Circle(11), '*', ConsoleColor.DarkGreen);
        graphDrawer.Draw(new Asteroid(9, 5, 5), 'x', ConsoleColor.Yellow);
        graphDrawer.Draw(new Ellipse(13, 9, 2, 2), '&', ConsoleColor.Blue);
    }   
}