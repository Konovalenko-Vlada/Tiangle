using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication141
{
    class Edge
    {
        public readonly Point P1, P2;
        public readonly double Length;
        public Edge(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;

            Length = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

        public static Boolean operator ==(Edge r1, Edge r2)
        {
            if (r1.Length == r2.Length)
                return true;
            else
                return false;
        }

        public static Boolean operator !=(Edge r1, Edge r2)
        {
            if (r1.Length != r2.Length)
                return true;
            else
                return false;
        }
    }
}
