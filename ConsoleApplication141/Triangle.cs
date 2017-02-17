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
        public Point P1, P2, P3;

        public Triangle(Point p1, Point p2, Point p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;

            a = new Edge(p1, p2);
            b = new Edge(p2, p3);
            c = new Edge(p3, p1);

            if (a.Length >= b.Length + c.Length && b.Length >= a.Length + c.Length && c.Length >= a.Length + b.Length)
            {
                throw new ArgumentException("Error Edge");
            }
        }

        public double Perimeter
        {
            get
            {
                return a.Length + b.Length + c.Length;
            }
        }

        public double Area
        {
            get
            {
                p = a.Length + b.Length + c.Length;
                return Math.Sqrt(p * (p - a.Length) * (p - b.Length) * (p - c.Length)) / 2;
            }
        }

        public bool Right
        {
            get
            {
                return (
                        (a.Length > b.Length && a.Length > c.Length && (b.Length * b.Length + c.Length * c.Length) == a.Length * a.Length) ||
                        (b.Length > a.Length && b.Length > c.Length && (a.Length * a.Length + c.Length * c.Length) == b.Length * b.Length) ||
                        (c.Length > a.Length && c.Length > b.Length && (b.Length * b.Length + a.Length * a.Length) == c.Length * c.Length)
                        );                
            }
        }

        public bool Isosceles
        {
            get
            {
                return (a == b || a == c || b == c);
            }
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