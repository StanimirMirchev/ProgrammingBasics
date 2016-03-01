using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("No real roots!");
            }
            else
            {
                double x1 = (-b - Math.Sqrt(discriminant)) / 2;
                double x2 = (-b + Math.Sqrt(discriminant)) / 2;
                Console.WriteLine("X1 is {0},X2 is {1}", x1, x2);
            }
        }
    }
}
