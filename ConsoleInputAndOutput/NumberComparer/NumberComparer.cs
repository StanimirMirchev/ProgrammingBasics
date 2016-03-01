using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int c = firstNumber - secondNumber;
            int k = (c >> 31) & 0x1;
            int max = firstNumber - k * c;

            Console.WriteLine(max);
        }
    }
}
