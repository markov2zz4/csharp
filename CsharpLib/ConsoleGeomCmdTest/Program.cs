using ConsoleGeom.Lib.Shapes.Lines;
using System;

namespace ConsoleGeomCmdTest
{
    class Program
    {
        static void Main(string[] args)
        {
            VerticalLine line = new VerticalLine(new ConsoleGeom.Lib.Point {X = 2, Y = 0 });
            line.Print();
        }
    }
}
