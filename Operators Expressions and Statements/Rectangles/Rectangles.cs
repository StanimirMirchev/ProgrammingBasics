using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = weight * height;
            double perimeter = 2 * weight + 2 * height;
            Console.WriteLine(area);
            Console.WriteLine(perimeter);


        }
    }
}
