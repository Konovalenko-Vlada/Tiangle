using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication141
{
    class Point
    {
        public static double x1, x2, x3, y1, y2, y3; 
        ~Point();
        public Point(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            this.x1 = x1;
            this.y1 = y1;

            this.x2 = x2;
            this.y2 = y2;

            this.x3 = x3;
            this.y3 = y3;
        }
 
    }
}
