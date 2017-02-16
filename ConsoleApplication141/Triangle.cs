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
        Edge a, b, c;

        public Triangle(Edge a, Edge b, Edge c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            if ((a.p2.x - a.p1.x) * (b.p2.y - c.p2.y) - (b.p2.y - a.p2.y) * (c.p2.x - a.p1.x) == 0)
            {
                Console.WriteLine("Error!!!");
                System.Environment.Exit(0);
            }

            if (a >= b + c && b >= a + c && c >= a + b)
            {
                Console.WriteLine("Error!!!");
                System.Environment.Exit(0);
            }
        }
        public Triangle(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            Point p3 = new Point(x3, y3);

            a = new Edge(p1, p2);
            b = new Edge(p2, p3);
            c = new Edge(p3, p1);
        }
        
        ~Triangle();

        public double Perimeter
        {
            get
            {
                return a + b + c;
            }
        }

        public double Area
        {
            get
            {
                p = a + b + c;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        public bool Right
        {
            get
            {
                if (
                    (a > b && a > c && (b * b + c * c) == a * a) || 
                    (b > a && b > c && (a * a + c * c) == b * b) || 
                    (c > a && c > b && (b * b + a * a) == c * c)
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
                if (a == b || a == c || b == c)
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