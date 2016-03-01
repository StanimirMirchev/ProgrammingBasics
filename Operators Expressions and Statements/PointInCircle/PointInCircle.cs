using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            double centerX = 0;
            double centerY = 0;
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double radius = 2;
            if ((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY) <= radius * radius)
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
