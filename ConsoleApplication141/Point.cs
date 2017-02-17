using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication141
{
    class Point
    {
        public double X,Y; 
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Boolean operator ==(Point r1, Point r2)
        {
            if (r1.X == r2.X && r1.Y == r2.Y) 
                return true;
            else
                return false;
        }

        public static Boolean operator !=(Point r1, Point r2)
        {
            if (r1.X != r2.X || r1.Y != r2.Y) 
                return true;
            else
                return false;
        }
    }
}
