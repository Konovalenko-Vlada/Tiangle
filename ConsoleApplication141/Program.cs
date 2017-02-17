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
            List<Triangle> objArray = new List<Triangle>();
            objArray.Add(new Triangle(new Point(1,2), new Point(3,4), new Point(5,6)));
            objArray.Add(new Triangle(new Point(2, 2), new Point(3, 1), new Point(7, 6)));
            objArray.Add(new Triangle(new Point(3, 2), new Point(3, 2), new Point(4, 6)));
            objArray.Add(new Triangle(new Point(4, 2), new Point(3, 9), new Point(2, 6)));



            double MiddlePerimeter = 0;
            foreach (Triangle i in objArray)
            {
                if(i.Right)
                {
                    MiddlePerimeter += i.Perimeter;
                }
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
