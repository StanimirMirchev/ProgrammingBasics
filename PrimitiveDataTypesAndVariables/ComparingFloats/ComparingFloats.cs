using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;

            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double differ = firstNumber - secondNumber;
            if (differ < eps)
            {
                Console.WriteLine("Numbers are equal!");
            }
            else
            {
                Console.WriteLine("Numbers are NOT equal!");
            }
        }
    }
}
