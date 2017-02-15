using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication141
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Edge(5, 4, 5);
            double perimeter = triangle.Perimeter;
            double area = triangle.Area;


            List<Point> objArray = new List<Point>();
            objArray.Add(new Point(3, 4, 5, 1, 4, 6));
            objArray.Add(new Point(7, 4, 5, 3, 4, 5));
            objArray.Add(new Point(3, 4, 5, 6, 9, 2));
            objArray.Add(new Point(3, 4, 7, 5, 6, 6));

            double MiddlePerimeter = 0;
            foreach (Triangle i in objArray)
            {
                MiddlePerimeter += i.Perimeter;
            }
            MiddlePerimeter /= objArray.Count;
            Console.WriteLine("Middle Perimeter = ", MiddlePerimeter);

            double MiddleArea = 0, it = 0;
            foreach (Triangle i in objArray)
            {
                if (i.Isosceles)
                {
                   MiddleArea += i.Area;
                   it++;
                }
            }
            MiddleArea /= it;
            Console.WriteLine("Middle Area = ", MiddleArea);
        }
    }
}
