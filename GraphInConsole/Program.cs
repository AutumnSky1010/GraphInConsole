using GraphInConsole.Graph;

namespace GraphInConsole;
public class Program
{
    private static void Main()
    {
        var graphDrawer = new GraphDrawer();
        graphDrawer.DrawCoordinateAxis();
        graphDrawer.Draw(new Circle(11), '*', ConsoleColor.DarkGreen);
        graphDrawer.Draw(new Circle(9, 5, 5), 'x', ConsoleColor.Yellow);
        graphDrawer.Draw(new Circle(30), '+', ConsoleColor.Blue);
    }   
}