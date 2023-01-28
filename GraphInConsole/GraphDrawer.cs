using GraphInConsole.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphInConsole;
internal class GraphDrawer
{
    private static int DifferenceX { get; } = 5;

    private static int DifferenceY { get; } = 7;

    private static int MarginOfCoordinateAxis { get; } = 8;

    public void Draw(IGraph graph, char c)
    {
        this.DrawCoordinateAxis();
        foreach (var point in graph.GetPoints())
        {
            var origin = GetOriginPoint();
            var x = point.X + origin.X;
            var y = point.Y + origin.Y;
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.Write(c);
        }
    }

    public void DrawCoordinateAxis()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        
        var origin = GetOriginPoint();
        Console.SetCursorPosition(origin.X, DifferenceY);

        int last = Console.BufferHeight - DifferenceY - 1;
        for (int i = 0; i < last; i++, Console.CursorTop++, Console.CursorLeft--)
        {
            char WriteCharacter = i == 0 ? '↑' : '│';
            Console.Write(WriteCharacter);
            Task.Delay(20).Wait();
        }

        Console.SetCursorPosition(0, origin.Y);
        last = Console.BufferWidth - 1;
        for (int i = 1; i <= last; i++)
        {
            char WriteCharacter = i == last ? '＞' : '─';
            Console.Write(WriteCharacter);
            Task.Delay(20).Wait();
        }

        Console.SetCursorPosition(origin.X, origin.Y);
        Console.Write("●");
        Console.ResetColor();
        Console.CursorTop = Console.BufferHeight - 1;

    }

    private (int X, int Y) GetOriginPoint()
    {
        int x = Console.BufferWidth / 2;
        int y = DifferenceY + (Console.BufferHeight - DifferenceY) / 2;
        return (x, y);
    }
}
