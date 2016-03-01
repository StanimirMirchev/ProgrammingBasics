using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;

            Console.WriteLine("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * PI * radius;
            double area = PI * radius * radius;

            Console.WriteLine("Perimeter is {0} and area is {1} !", perimeter, area);


        }
    }
}
