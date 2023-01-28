using GraphInConsole.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphInConsole;
internal class GraphDrawer
{
    private static int DifferenceY { get; } = 7;

    public void Draw(IGraph graph, char c, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        foreach (var point in graph.GetPoints())
        {
            var origin = GetOriginPoint();
            var x = point.X + origin.X;
            var y = point.Y + origin.Y;
            if (!CanDraw(x, y))
            {
                continue;
            }
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.Write(c);
            Task.Delay(10).Wait();
        }
        Console.ResetColor();
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
            Task.Delay(5).Wait();
        }

        Console.SetCursorPosition(0, origin.Y);
        last = Console.BufferWidth - 1;
        for (int i = 1; i <= last; i++)
        {
            char WriteCharacter = i == last ? '＞' : '─';
            Console.Write(WriteCharacter);
            Task.Delay(5).Wait();
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

    private bool CanDraw(int x, int y)
    {
        bool canWriteX = x < Console.BufferWidth && x > 0;
        bool canWriteY = y < Console.BufferHeight && y > DifferenceY;
        return canWriteX && canWriteY;
    }
}
