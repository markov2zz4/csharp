using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGeom.Lib.Shapes.Lines
{
    public class VerticalLine : Line
    {
         public VerticalLine(Point start, int length)
        {
            Points = new Point[length];

            for (int i = 0; i < length; ++i)
            {
                Points[i] = new Point(start.X, start.Y + i);
            }
        }
    }
}
