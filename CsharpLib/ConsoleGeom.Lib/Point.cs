using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGeom.Lib
{
    public struct Point
    {

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; init; }
        public int Y { get; init; }

        public void Print(char symbol = '*')
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(symbol);
        }
    }

}
