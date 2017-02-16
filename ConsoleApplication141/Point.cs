using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication141
{
    class Point
    {
        public double x,y; 
        ~Point();
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
