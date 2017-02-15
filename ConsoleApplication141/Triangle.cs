using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication141
{
    class Triangle
    {
        double p;

        double x1, x2, x3, y1, y2, y3; 


        ~Triangle();

        public double Perimeter
        {
            get
            {
                return Edge.a + Edge.b + Edge.c;
            }
        }

        public double Area
        {
            get
            {
                p = Edge.a + Edge.b + Edge.c;
                return Math.Sqrt(p * (p - Edge.a) * (p - Edge.b) * (p - Edge.c));
            }
        }

        public bool Right
        {
            get
            {
                if (
                    (Edge.a > Edge.b && Edge.a > Edge.c && (Edge.b * Edge.b + Edge.c * Edge.c) == Edge.a * Edge.a) || 
                    (Edge.b > Edge.a && Edge.b > Edge.c && (Edge.a * Edge.a + Edge.c * Edge.c) == Edge.b * Edge.b) || 
                    (Edge.c > Edge.a && Edge.c > Edge.b && (Edge.b * Edge.b + Edge.a * Edge.a) == Edge.c * Edge.c)
                    )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool Isosceles
        {
            get
            {
                if (Edge.a == Edge.b || Edge.a == Edge.c || Edge.b == Edge.c)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}