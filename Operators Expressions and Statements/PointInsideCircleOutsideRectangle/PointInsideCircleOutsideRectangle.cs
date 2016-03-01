using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInsideCircleOutsideRectangle
{
    class PointInsideAndOutside
    {
        static void Main(string[] args)
        {
            double radius = 1.5;
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool rectangle = (x <= 5 && x >= -1 && y >= -1 && y <= 1);
            if ((((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= radius * radius) && rectangle != true)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
