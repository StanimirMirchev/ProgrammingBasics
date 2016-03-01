using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOfThreeNumbers
{
    class TheBiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());


            if ((number1 > number2) && (number1 > number3))
            {
                Console.WriteLine(number1);
            }
            else if (number2 > number3)
            {
                Console.WriteLine(number2);
            }
            else
            {
                Console.WriteLine(number3);
            }
        }
    }
}
