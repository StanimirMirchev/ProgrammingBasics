using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputAndOutput
{
    class SumOfThreeIntegers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = a + b + c;

            Console.Write("The sum is: ");
            Console.WriteLine(sum);
        }
    }
}
