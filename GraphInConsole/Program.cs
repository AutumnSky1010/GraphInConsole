using GraphInConsole.Graphs;

namespace GraphInConsole;
public class Program
{
    private static void Main()
    {
        var graphDrawer = new GraphDrawer();
        Console.Write("コンソールの画面を最大化してエンターキーを押してください。");
        Console.Read();
        //graphDrawer.DrawCoordinateAxis();
        
        graphDrawer.Draw(new Lissajous(11, 2, 3), 'L', ConsoleColor.Cyan);
        //graphDrawer.Draw(new Circle(11, 50, 0), 'C', ConsoleColor.DarkGreen);
        graphDrawer.Draw(new Asteroid(9), 'A', ConsoleColor.Yellow);
        //graphDrawer.Draw(new Ellipse(13, 9, 20, 20), 'E', ConsoleColor.Blue);
        graphDrawer.Draw(new Rose(21, 6), 'R', ConsoleColor.Magenta);

        Console.CursorTop = Console.BufferHeight - 1;
        Console.Write("\n\n");
    }   
}