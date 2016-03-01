using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNnumbers
{
    class SumOfNnumbers
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sumOfNumbers = 0;

            for (int i = 1; i <= numbers; i++)
            {
                sumOfNumbers += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}
