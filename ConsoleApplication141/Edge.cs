using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication141
{
    class Edge
    {
        public static double a, b, c;
        public Edge()
        {
            a = Math.Sqrt(Math.Pow(Point.x2 - Point.x1, 2) + Math.Pow(Point.y2 - Point.y1, 2));
            b = Math.Sqrt(Math.Pow(Point.x2 - Point.x3, 2) + Math.Pow(Point.y2 - Point.y3, 2));
            c = Math.Sqrt(Math.Pow(Point.x3 - Point.x1, 2) + Math.Pow(Point.y3 - Point.y1, 2));
        }
    }
}
