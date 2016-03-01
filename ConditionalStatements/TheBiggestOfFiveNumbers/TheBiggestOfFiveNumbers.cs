using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());
            double number4 = double.Parse(Console.ReadLine());
            double number5 = double.Parse(Console.ReadLine());

            if (number1 > number2 && number1 > number3 && number1 > number4 && number1 > number5)
            {
                Console.WriteLine(number1);
            }
            else if (number2 > number3 && number2 > number4 && number2 > number5)
            {
                Console.WriteLine(number2);
            }
            else if (number3 > number4 && number3 > number5)
            {
                Console.WriteLine(number3);
            }
            else if (number4 > number5)
            {
                Console.WriteLine(number4);
            }
            else
            {
                Console.WriteLine(number5);
            }
        }
    }
}
